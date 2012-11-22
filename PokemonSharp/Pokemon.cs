using System;
using System.Linq;
using System.Drawing;

namespace PokemonSharp
{
	public sealed class Pokemon
	{
		#region Block A
		public BaseStats baseStats { get; private set; }
		public Item heldItem;
		public readonly uint personality;
		public readonly Nature nature;
		public ushort OTid;
		public ushort OTsecretid;
		private uint exp;
		public byte happiness;
		public readonly Ability ability;
		//markings
		public readonly Language country = Language.English;
		public byte hpEV;
		public byte attackEV;
		public byte defenseEV;
		public byte speedEV;
		public byte specialAttackEV;
		public byte specialDefenseEV;
		//contest stats
		//ribbons
		#endregion
		#region Block B
		public readonly Move[] moveSet = new Move[4];
		public byte[] PP = new byte[4];
		public byte[] PPbonuses = new byte[4];
		public readonly byte hpIV;
		public readonly byte attackIV;
		public readonly byte defenseIV;
		public readonly byte speedIV;
		public readonly byte specialAttackIV;
		public readonly byte specialDefenseIV;
		public bool isEgg;
		//ribbons 2
		//private readonly bool fatefulEncounter;
		public Gender gender
		{
			get
			{
				switch (baseStats.genderRatio)
				{
					case GenderRatio.AlwaysFemale:
						return Gender.Female;
					case GenderRatio.AlwaysMale:
						return Gender.Male;
					case GenderRatio.Genderless:
						return Gender.Genderless;
					default:
						if ((personality & 255) >= (byte)baseStats.genderRatio) return Gender.Male;
						else return Gender.Female;
				}
			}
		}
		//alternate forms
		#endregion
		#region Block C
		public string nickname;
		//hometown
		//contests
		#endregion
		#region Block D
		public string OTname;
		public readonly DateTime dateEggRecieved = DateTime.Now;
		public readonly DateTime dateMet = DateTime.Now;
		public readonly Map eggLocation;
		public readonly Map metLocation;
		public bool pokerus = false;
		//pokeball
		public readonly byte metLevel;
		//encounter type
		//performance
		#endregion

		#region stats
		public byte Level { get; private set; }
		private ushort hp;
		private ushort maxHP;
		private ushort attack;
		private ushort defense;
		private ushort speed;
		private ushort specialAttack;
		private ushort specialDefense;
		#endregion

		public readonly bool shiny;

		#region battle stats
		private NonVolatileAilment nonVolStatus = NonVolatileAilment.None;
		private VolatileAilments volStatus = VolatileAilments.None;
		public sbyte attackLevel = 0;
		public sbyte defenseLevel = 0;
		public sbyte speedLevel = 0;
		public sbyte specialAttackLevel = 0;
		public sbyte specialDefenseLevel = 0;
		public sbyte accuracyLevel = 0;
		public sbyte evasionLevel = 0;
		public byte toxicCount = 1;
		public int sleepTime = 0;
		public int trapTime = 0;
		#endregion

		public Pokemon(BaseStats bs, int l = 1, Move[] ms = null, string n = null)
		{
			baseStats = bs;
			personality = (uint)((PRNG.Instance.Next() << 16) + PRNG.Instance.Next());
			nature = (Nature)(personality % 25);
			happiness = baseStats.baseHappiness;
			if (baseStats.abilities.Length == 1) ability = baseStats.abilities[0];
			else ability = baseStats.abilities[personality % 2];

			int iv1 = PRNG.Instance.Next();
			int iv2 = PRNG.Instance.Next();
			hpIV = (byte)(iv1 & 0x1F);
			attackIV = (byte)(iv1 & 0x3E0);
			defenseIV = (byte)(iv1 & 0x7C00);
			specialDefenseIV = (byte)(iv2 & 0x1F);
			specialAttackIV = (byte)(iv2 & 0x3E0);
			speedIV = (byte)(iv2 & 0x7C00);
			nickname = n;

			shiny = ((OTid ^ OTsecretid) ^ ((personality >> 16) ^ (personality & 65535))) < 8 ? true : false;

			for (int i = 0; i < l; i++) LevelUp();
			hp = maxHP;

			metLocation = Player.Instance.currentMap;
			metLevel = Level;

			if (ms == null)
			{
				int i = 0;
				foreach (LearnableMove m in baseStats.learnset)
				{
					if (Level >= m.level)
					{
						moveSet[i] = m.move;
						PP[i] = m.move.basePP;
						i = (i == 3) ? 0 : i + 1;
					}
					else break;
				}
			}
			else moveSet = ms;
		}

		#region properties
		public uint Exp
		{
			set
			{
				exp = value;
				switch (baseStats.growthRate)
				{
					case GrowthRate.MediumFast:
						while (exp >= Math.Pow(Level, 3)) LevelUp();
						break;
					case GrowthRate.Erratic:
						while (Level <= 50 && exp >= Math.Pow(Level, 3) * (100 - Level) * 0.02) LevelUp();
						while (Level <= 68 && exp >= Math.Pow(Level, 3) * (150 - Level) * 0.01) LevelUp();
						while (Level <= 98 && exp >= Math.Pow(Level, 3) * (1911 - ((10 * Level) / 3)) * 0.002) LevelUp();
						while (Level <= 100 && exp >= Math.Pow(Level, 3) * (160 - Level) * 0.01) LevelUp();
						break;
					case GrowthRate.Fluctuating:
						while (Level <= 15 && exp >= Math.Pow(Level, 3) * ((((Level + 1) / 3) + 24) * 0.02)) LevelUp();
						while (Level <= 36 && exp >= Math.Pow(Level, 3) * ((Level + 14) * 0.02)) LevelUp();
						while (Level <= 100 && exp >= Math.Pow(Level, 3) * (((Level >> 1) + 32) * 0.02)) LevelUp();
						break;
					case GrowthRate.MediumSlow:
						while (exp >= ((1.2 * Math.Pow(Level, 3)) - (15 * Math.Pow(Level, 2)) + (100 * Level) - 140)) LevelUp();
						break;
					case GrowthRate.Fast:
						while (exp >= (0.8 * Math.Pow(Level, 3))) LevelUp();
						break;
					case GrowthRate.Slow:
						while (exp >= (1.25 * Math.Pow(Level, 3))) LevelUp();
						break;
				}
			}
			get { return exp; }
		}
		public ushort HP
		{
			set
			{
				if (value > maxHP) hp = maxHP;
				else hp = value;
			}
			get { return hp; }
		}
		public ushort MaxHP { get { return maxHP; } }
		public ushort Attack
		{
			get
			{
				if (attackLevel > 0) return (ushort)(attack * (attackLevel + 2) >> 1);
				else if (attackLevel < 0) return (ushort)(attack * 2 / (2 - attackLevel));
				else return attack;
			}
		}
		public ushort Defense
		{
			get
			{
				if (defenseLevel > 0) return (ushort)(defense * (defenseLevel + 2) >> 1);
				else if (defenseLevel < 0) return (ushort)(defense * 2 / (2 - defenseLevel));
				else return defense;
			}
		}
		public ushort Speed
		{
			get
			{
				if (speedLevel > 0) return (ushort)(speed * (speedLevel + 2) >> 1);
				else if (speedLevel < 0) return (ushort)(speed * 2 / (2 - speedLevel));
				else return speed;
			}
		}
		public ushort SpecialAttack
		{
			get
			{
				if (specialAttackLevel > 0) return (ushort)(specialAttack * (specialAttackLevel + 2) >> 1);
				else if (specialAttackLevel < 0) return (ushort)(specialAttack * 2 / (2 - specialAttackLevel));
				else return specialAttack;
			}
		}
		public ushort SpecialDefense
		{
			get
			{
				if (specialDefenseLevel > 0) return (ushort)(specialDefense * (specialDefenseLevel + 2) >> 1);
				else if (specialDefenseLevel < 0) return (ushort)(specialDefense * 2 / (2 - specialDefenseLevel));
				else return specialDefense;
			}
		}
		public Bitmap BackImage
		{
			get { return shiny ? baseStats.shinyBackImg : baseStats.backImg; }
		}
		public Bitmap FrontImage
		{
			get { return shiny ? baseStats.shinyFrontImg : baseStats.frontImg; }
		}
		public NonVolatileAilment NonVolStatus
		{
			get { return nonVolStatus; }
			set
			{
				if (nonVolStatus == NonVolatileAilment.None && !(baseStats.types.HasFlag(Types.Poison) && (value == NonVolatileAilment.Poison || value == NonVolatileAilment.BadPoison))) nonVolStatus = value;
			}
		}
		public VolatileAilments VolStatus { get { return volStatus; } }
		public void addVolStatus(VolatileAilments v)
		{
			volStatus |= v;
		}
		public void removeVolStatus(VolatileAilments v)
		{
			volStatus ^= v;
		}
		#endregion

		public void LevelUp()
		{
			Level++;
			foreach (IEvolution e in baseStats.evolutions)
			{
				if (e is LevelEvolution && Level >= ((LevelEvolution)e).Level) baseStats = e.EvolveTo;
				else if (e is HappinessEvolution && happiness >= ((HappinessEvolution)e).Happiness) baseStats = e.EvolveTo;
				else if (e is HeldItemEvolution && heldItem == ((HeldItemEvolution)e).Item) baseStats = e.EvolveTo;
			}
			ushort hptemp = maxHP;
			maxHP = (ushort)((((hpIV + (2 * baseStats.baseHP) + (hpEV >> 2) + 100) * Level) * 0.01) + 10);
			attack = (ushort)((((attackIV + (2 * baseStats.baseAttack) + (attackEV >> 2)) * Level) * 0.01) + 5);
			defense = (ushort)((((defenseIV + (2 * baseStats.baseDefense) + (defenseEV >> 2)) * Level) * 0.01) + 5);
			speed = (ushort)((((speedIV + (2 * baseStats.baseSpeed) + (speedEV >> 2)) * Level) * 0.01) + 5);
			specialAttack = (ushort)((((specialAttackIV + (2 * baseStats.baseSpecialAttack) + (specialAttackEV >> 2)) * Level) * 0.01) + 5);
			specialDefense = (ushort)((((specialDefenseIV + (2 * baseStats.baseSpecialDefense) + (specialDefenseEV >> 2)) * Level) * 0.01) + 5);
			hp += (ushort)(maxHP - hptemp);
			int i = 0;
			foreach (LearnableMove m in baseStats.learnset)
			{
				if (Level >= m.level)
				{
					moveSet[i] = m.move;
					PP[i] = m.move.basePP;
					i = (i == 3) ? 0 : i + 1;
				}
				else break;
			}
			switch (nature)
			{
				case Nature.Hardy:
					break;
				case Nature.Lonely:
					attack = (ushort)(attack * 1.1);
					defense = (ushort)(defense * 0.9);
					break;
				case Nature.Brave:
					attack = (ushort)(attack * 1.1);
					speed = (ushort)(speed * 0.9);
					break;
				case Nature.Adamant:
					attack = (ushort)(attack * 1.1);
					specialAttack = (ushort)(specialAttack * 0.9);
					break;
				case Nature.Naughty:
					attack = (ushort)(attack * 1.1);
					specialDefense = (ushort)(specialDefense * 0.9);
					break;
				case Nature.Bold:
					defense = (ushort)(defense * 1.1);
					attack = (ushort)(attack * 0.9);
					break;
				case Nature.Docile:
					break;
				case Nature.Relaxed:
					defense = (ushort)(defense * 1.1);
					speed = (ushort)(speed * 0.9);
					break;
				case Nature.Impish:
					defense = (ushort)(defense * 1.1);
					specialAttack = (ushort)(specialAttack * 0.9);
					break;
				case Nature.Lax:
					defense = (ushort)(defense * 1.1);
					specialDefense = (ushort)(specialDefense * 0.9);
					break;
				case Nature.Timid:
					speed = (ushort)(speed * 1.1);
					attack = (ushort)(attack * 0.9);
					break;
				case Nature.Hasty:
					speed = (ushort)(speed * 1.1);
					defense = (ushort)(defense * 0.9);
					break;
				case Nature.Serious:
					break;
				case Nature.Jolly:
					speed = (ushort)(speed * 1.1);
					specialAttack = (ushort)(specialAttack * 0.9);
					break;
				case Nature.Naive:
					speed = (ushort)(speed * 1.1);
					specialDefense = (ushort)(specialDefense * 0.9);
					break;
				case Nature.Modest:
					specialAttack = (ushort)(specialAttack * 1.1);
					attack = (ushort)(attack * 0.9);
					break;
				case Nature.Mild:
					specialAttack = (ushort)(specialAttack * 1.1);
					defense = (ushort)(defense * 0.9);
					break;
				case Nature.Quiet:
					specialAttack = (ushort)(specialAttack * 1.1);
					speed = (ushort)(speed * 0.9);
					break;
				case Nature.Bashful:
					break;
				case Nature.Rash:
					specialAttack = (ushort)(specialAttack * 1.1);
					specialDefense = (ushort)(specialDefense * 0.9);
					break;
				case Nature.Calm:
					specialDefense = (ushort)(specialDefense * 1.1);
					attack = (ushort)(attack * 0.9);
					break;
				case Nature.Gentle:
					specialDefense = (ushort)(specialDefense * 1.1);
					defense = (ushort)(defense * 0.9);
					break;
				case Nature.Sassy:
					specialDefense = (ushort)(specialDefense * 1.1);
					speed = (ushort)(speed * 0.9);
					break;
				case Nature.Careful:
					specialDefense = (ushort)(specialDefense * 1.1);
					specialAttack = (ushort)(specialAttack * 0.9);
					break;
				case Nature.Quirky:
					break;
			}
		}
		public void Evolve(BaseStats bs)
		{
			baseStats = bs;
			ushort hptemp = maxHP;
			maxHP = (ushort)((((hpIV + (2 * baseStats.baseHP) + (hpEV >> 2) + 100) * Level) * 0.01) + 10);
			attack = (ushort)((((attackIV + (2 * baseStats.baseAttack) + (attackEV >> 2)) * Level) * 0.01) + 5);
			defense = (ushort)((((defenseIV + (2 * baseStats.baseDefense) + (defenseEV >> 2)) * Level) * 0.01) + 5);
			speed = (ushort)((((speedIV + (2 * baseStats.baseSpeed) + (speedEV >> 2)) * Level) * 0.01) + 5);
			specialAttack = (ushort)((((specialAttackIV + (2 * baseStats.baseSpecialAttack) + (specialAttackEV >> 2)) * Level) * 0.01) + 5);
			specialDefense = (ushort)((((specialDefenseIV + (2 * baseStats.baseSpecialDefense) + (specialDefenseEV >> 2)) * Level) * 0.01) + 5);
			hp += (ushort)(maxHP - hptemp);
			int i = 0;
			foreach (LearnableMove m in baseStats.learnset)
			{
				if (Level >= m.level)
				{
					moveSet[i] = m.move;
					PP[i] = m.move.basePP;
					i = (i == 3) ? 0 : i + 1;
				}
				else break;
			}
		}
	}
}
