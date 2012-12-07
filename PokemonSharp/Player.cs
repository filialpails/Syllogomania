using System;
using System.Collections.Generic;
using System.Drawing;

namespace PokemonSharp
{
	public sealed class Player
	{
		private const int MAX_PARTY_SIZE = 6;
		private const int NUM_BOXES_1 = 8;
		private const int NUM_BOXES_2 = 16;
		private const int NUM_BOXES_3 = 24;
		private const int NUM_BOX_SLOTS = 30;
		public readonly DateTime adevntureStartedDate = DateTime.Now;
		public readonly string name;
		public readonly ushort id = (ushort)new Random(DateTime.Now.Millisecond).Next(65536);
		public readonly ushort secretID = (ushort)new Random(DateTime.Now.Millisecond + 1).Next(65536);
		public uint money;
		public readonly Gender gender;
		public Badges badges;
		public TimeSpan playTime = TimeSpan.Zero;
		public readonly List<Pokemon> party = new List<Pokemon>(6);
		public readonly Dictionary<Item, int> ItemBag = new Dictionary<Item, int>(217);
		public readonly Dictionary<Item, int> KeyBag = new Dictionary<Item, int>(103);
		public readonly Dictionary<Item, int> TMBag = new Dictionary<Item, int>(184);
		public readonly Dictionary<Item, int> MailBag = new Dictionary<Item, int>(46);
		public readonly Dictionary<Item, int> MedicineBag = new Dictionary<Item, int>(39);
		public readonly Dictionary<Item, int> BerryBag = new Dictionary<Item, int>(64);
		public readonly Dictionary<Item, int> BallBag = new Dictionary<Item, int>(26);
		public readonly Dictionary<Item, int> BattleBag = new Dictionary<Item, int>(32);
		public Map currentMap;
		public readonly string rivalName;
		public Point location;
		public PointF[] signaturePoints;
		public byte[] signatureTypes;
		public int pokemonCaught;
		public readonly List<Pokemon> boxes = new List<Pokemon>(240);
		public TrainerType type;
		public Nature nature;
		public Direction dir;
		public readonly Sprite sprite;
		private static Player instance = null;
		public static Player Instance
		{
			get
			{
				return Player.instance;
			}
		}
		public static void CreatePlayer(string n, Gender g, string r)
		{
			if (Player.instance == null)
			{
				Player.instance = new Player(n, g, r);
			}
			//Player.instance.currentMap = Maps.PalletTown;
		}
		public static void CreatePlayer(Player p)
		{
			if (Player.instance == null)
			{
				Player.instance = p;
			}
		}
		private Player(string n, Gender g, string r)
		{
			this.name = n;
			this.gender = g;
			this.location = new Point(7, 8);
			switch (this.gender)
			{
			case Gender.Male:
				//this.sprite = Sprite.BoySprite;
				break;
			case Gender.Female:
				//this.sprite = Sprite.GirlSprite;
				break;
			}
			this.rivalName = r;
		}
		public bool givePokemon(Pokemon mon)
		{
			bool result;
			if (this.party.Count < 6)
			{
				mon.OTid = this.id;
				mon.OTsecretid = this.secretID;
				mon.OTname = this.name;
				this.party.Add(mon);
				if (new TextWindow(new[] { "Give a nickname to " + mon.baseStats.name + "?" }, new[] { "Yes", "No" }).Show() == 0)
				{
					//mon.nickname = new NameEntry(mon.FrontImage).enterName();
				}
				result = true;
			}
			else
			{
				if (this.depositPokemon(mon))
				{
					mon.OTid = this.id;
					mon.OTsecretid = this.secretID;
					mon.OTname = this.name;
					if (new TextWindow(new[] { "Give a nickname to " + mon.baseStats.name + "?" }, new[] { "Yes", "No" }).Show() == 0)
					{
						//mon.nickname = new NameEntry(mon.FrontImage).enterName();
					}
					new TextWindow(new[] { mon.nickname + " was sent to BILL'S PC." }).Show();
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		public bool depositPokemon(Pokemon p)
		{
			bool result;
			if (this.boxes.Count > 240)
			{
				result = false;
			}
			else
			{
				this.boxes.Add(p);
				result = true;
			}
			return result;
		}

		public bool withdrawPokemon(int box, int pos)
		{
			bool result;
			if (this.party.Count > 6)
			{
				result = false;
			}
			else
			{
				this.party.Add(this.boxes[box * pos]);
				this.boxes.RemoveAt(box * pos);
				result = true;
			}
			return result;
		}

		public void GetItem(Item i)
		{
			Dictionary<Item, int> dictionary = null;
			switch (i.pocket)
			{
			case Pocket.Items:
				dictionary = this.ItemBag;
				break;
			case Pocket.Medicine:
				dictionary = this.MedicineBag;
				break;
			case Pocket.Balls:
				dictionary = this.BallBag;
				break;
			case Pocket.TMs:
				dictionary = this.TMBag;
				break;
			case Pocket.Battle:
				dictionary = this.BattleBag;
				break;
			case Pocket.Key:
				dictionary = this.KeyBag;
				break;
			}
			if (dictionary.ContainsKey(i))
			{
				Dictionary<Item, int> dictionary2;
				(dictionary2 = dictionary)[i] = dictionary2[i] + 1;
			}
			else
			{
				dictionary.Add(i, 1);
			}
		}

		public void DropItem(Item i)
		{
			Dictionary<Item, int> dictionary = null;
			switch (i.pocket)
			{
			case Pocket.Items:
				dictionary = this.ItemBag;
				break;
			case Pocket.Medicine:
				dictionary = this.MedicineBag;
				break;
			case Pocket.Balls:
				dictionary = this.BallBag;
				break;
			case Pocket.TMs:
				dictionary = this.TMBag;
				break;
			case Pocket.Battle:
				dictionary = this.BattleBag;
				break;
			case Pocket.Key:
				dictionary = this.KeyBag;
				break;
			}
			if (dictionary[i] == 1)
			{
				dictionary.Remove(i);
			}
			else
			{
				if (dictionary.ContainsKey(i))
				{
					Dictionary<Item, int> dictionary2;
					(dictionary2 = dictionary)[i] = dictionary2[i] - 1;
				}
			}
		}
		public void GiveItem(Item i, Pokemon p)
		{
			this.DropItem(i);
			p.heldItem = i;
		}
	}
}
