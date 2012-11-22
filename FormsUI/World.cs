using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsUI.Properties;
using PokemonSharp;

namespace FormsUI
{
	public partial class World : Form
	{
		private const int SCREEN_WIDTH = 15;
		private const int SCREEN_HEIGHT = 10;
		private const int TILE_SIZE = 16;
		private const int BLOCK_SIZE = 32;
		private const int PLAYER_OFFSET_X = 7;
		private const int PLAYER_OFFSET_Y = 5;
		private int SCROLLX;
		private int SCROLLY;
		private Color[] BGP = new Color[256];
		private Color[] OBJP = new Color[256];
		private Bitmap[,] BG0 = new Bitmap[32, 32];
		private Bitmap[,] BG1 = new Bitmap[32, 32];
		private Bitmap[,] BG2 = new Bitmap[32, 32];
		private Bitmap[,] BG3 = new Bitmap[32, 32];
		private Bitmap[,] OBJ = new Bitmap[32, 32];
		public static TimeOfDay time;
		private int delay;

		public World()
		{
			InitializeComponent();

			if (new TextWindow(new[] { "" }).ShowQuestion("New Game", "Continue") == DialogResult.Yes)
			{
				MusicPlayer.playBG("resources\\music\\kanto\\1-05 Welcome to the World of Pokemon.mp3");
				new TextWindow(new[] {
					"Hello, there! Glad  to meet you!",
					"Welcome to the world of Pokemon!",
					"My name is Oak.",
					"People affectionately refer to me as the Pokemon Professor.",
					"This world is inhabited far and wide by creatures called Pokemon!",
					"For some people, Pokemon are pets. Others use them for battling.",
					"As for myself...",
					"I study Pokemon as a profession.",
					"But first, tell me a little about yourself."
				}).ShowDialog();
				Gender gender = (new TextWindow(new[] { "Now tell me. Are you a boy?  Or are you a girl?" }).ShowQuestion("Boy", "Girl") == DialogResult.Yes) ? Gender.Male : Gender.Female;
				new TextWindow(new[] { "Let's begin with your name. What is it?" }).ShowDialog();
				string text = new NameEntry((gender == Gender.Male) ? Sprite.BoySprite.Down : Sprite.GirlSprite.Down).enterName();
				new TextWindow(new[] { "Right, so your name is " + text }).ShowDialog();
				new TextWindow(new[] {
					"This is my grandson.",
					"He's been your rival since you were both babies.",
					"...Erm, what was his name now?"
				}).ShowDialog();
				string text2 = new NameEntry(Resources.black).enterName();
				new TextWindow(new string[]
				{
					"That's right! I remember now! His name is " + text2,
					text + "!",
					"Your very own Pokemon legend is about to unfold!",
					"A world of dreams and adventures with Pokemon awaits!"
				}).ShowDialog();
				Player.CreatePlayer(text, gender, text2);
			}
			else
			{
				if (this.LoadFile.ShowDialog() == DialogResult.OK)
				{
					using (FileStream fileStream = new FileStream(this.LoadFile.FileName, FileMode.Open, FileAccess.Read, FileShare.None))
					{
						Player.CreatePlayer((Player)new BinaryFormatter().Deserialize(fileStream));
					}
					base.Close();
				}
			}
			this.timer2.Stop();
			PRNG.Seed(this.delay);
			this.timer1.Start();
			this.mnuPlayer.Text = Player.Instance.name;
			MusicPlayer.playBG(Player.Instance.currentMap.music);
			this.readMap();
		}

		private void World_KeyDown(object sender, KeyEventArgs e)
		{
			e.Handled = true;
			Array.Clear(this.OBJ, Player.Instance.location.Y * 10 + Player.Instance.location.X, 1);
			if (Player.Instance.location.Y == -1)
			{
				Connection connection = Player.Instance.currentMap.connections.Single((Connection c) => c.dir == Direction.Up);
				Player.Instance.currentMap = connection.toMap;
				Player expr_A5_cp_0 = Player.Instance;
				expr_A5_cp_0.location.X = expr_A5_cp_0.location.X + connection.shift;
				Player.Instance.location.Y = Player.Instance.currentMap.height - 1;
				MusicPlayer.playBG(Player.Instance.currentMap.music);
				this.readMap();
			}
			else
			{
				if (Player.Instance.location.Y == Player.Instance.currentMap.height)
				{
					Connection connection = Player.Instance.currentMap.connections.Single((Connection c) => c.dir == Direction.Down);
					Player.Instance.currentMap = connection.toMap;
					Player expr_176_cp_0 = Player.Instance;
					expr_176_cp_0.location.X = expr_176_cp_0.location.X + connection.shift;
					Player.Instance.location.Y = 0;
					MusicPlayer.playBG(Player.Instance.currentMap.music);
					this.readMap();
				}
				else
				{
					if (Player.Instance.location.X == Player.Instance.currentMap.width)
					{
						Connection connection = Player.Instance.currentMap.connections.Single((Connection c) => c.dir == Direction.Right);
						Player.Instance.currentMap = connection.toMap;
						Player expr_237_cp_0 = Player.Instance;
						expr_237_cp_0.location.Y = expr_237_cp_0.location.Y + connection.shift;
						Player.Instance.location.X = 0;
						MusicPlayer.playBG(Player.Instance.currentMap.music);
						this.readMap();
					}
					else
					{
						if (Player.Instance.location.X == -1)
						{
							Connection connection = Player.Instance.currentMap.connections.Single((Connection c) => c.dir == Direction.Left);
							Player.Instance.currentMap = connection.toMap;
							Player expr_2EA_cp_0 = Player.Instance;
							expr_2EA_cp_0.location.Y = expr_2EA_cp_0.location.Y + connection.shift;
							Player.Instance.location.X = Player.Instance.currentMap.width - 1;
							MusicPlayer.playBG(Player.Instance.currentMap.music);
							this.readMap();
						}
					}
				}
			}
			Player.Instance.currentMap[Player.Instance.location.Y, Player.Instance.location.X].Occupied = false;
			switch (e.KeyCode)
			{
			case Keys.Space:
			{
				Event[] events = Player.Instance.currentMap.events;
				for (int i = 0; i < events.Length; i++)
				{
					Event @event = events[i];
					if ((Player.Instance.dir == Direction.Up && Player.Instance.location.Y == @event.location.Y + 1 && Player.Instance.location.X == @event.location.X) || (Player.Instance.dir == Direction.Down && Player.Instance.location.Y == @event.location.Y - 1 && Player.Instance.location.X == @event.location.X) || (Player.Instance.dir == Direction.Right && Player.Instance.location.X == @event.location.X - 1 && Player.Instance.location.Y == @event.location.Y) || (Player.Instance.dir == Direction.Left && Player.Instance.location.X == @event.location.X + 1 && Player.Instance.location.Y == @event.location.Y))
					{
						@event.script();
					}
				}
				break;
			}
			case Keys.Left:
			{
				Direction dir = Player.Instance.dir;
				if (dir != Direction.Left)
				{
					Player.Instance.dir = Direction.Left;
				}
				else
				{
					if (Player.Instance.currentMap[Player.Instance.location.Y, Player.Instance.location.X - 1].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.location.Y, Player.Instance.location.X - 1].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.location.Y, Player.Instance.location.X - 1].Occupied)
					{
						Player expr_73B_cp_0 = Player.Instance;
						expr_73B_cp_0.location.X = expr_73B_cp_0.location.X - 1;
					}
				}
				break;
			}
			case Keys.Up:
			{
				Direction dir = Player.Instance.dir;
				if (dir != Direction.Up)
				{
					Player.Instance.dir = Direction.Up;
				}
				else
				{
					if (Player.Instance.currentMap[Player.Instance.location.Y - 1, Player.Instance.location.X].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.location.Y - 1, Player.Instance.location.X].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.location.Y - 1, Player.Instance.location.X].Occupied)
					{
						Player expr_474_cp_0 = Player.Instance;
						expr_474_cp_0.location.Y = expr_474_cp_0.location.Y - 1;
					}
				}
				break;
			}
			case Keys.Right:
			{
				Direction dir = Player.Instance.dir;
				if (dir != Direction.Right)
				{
					Player.Instance.dir = Direction.Right;
				}
				else
				{
					if (Player.Instance.currentMap[Player.Instance.location.Y, Player.Instance.location.X + 1].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.location.Y, Player.Instance.location.X + 1].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.location.Y, Player.Instance.location.X + 1].Occupied)
					{
						Player expr_64E_cp_0 = Player.Instance;
						expr_64E_cp_0.location.X = expr_64E_cp_0.location.X + 1;
					}
				}
				break;
			}
			case Keys.Down:
			{
				Direction dir = Player.Instance.dir;
				if (dir != Direction.Down)
				{
					Player.Instance.dir = Direction.Down;
				}
				else
				{
					if (Player.Instance.currentMap[Player.Instance.location.Y + 1, Player.Instance.location.X].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.location.Y + 1, Player.Instance.location.X].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.location.Y + 1, Player.Instance.location.X].Occupied)
					{
						Player expr_561_cp_0 = Player.Instance;
						expr_561_cp_0.location.Y = expr_561_cp_0.location.Y + 1;
					}
				}
				break;
			}
			}
			Player.Instance.currentMap[Player.Instance.location.Y, Player.Instance.location.X].Occupied = true;
			this.pnlScreen.Invalidate();
			
			if (Player.Instance.party.Count > 0)
			{
				WildPokemon[] array = new WildPokemon[0];
				
				switch (Player.Instance.currentMap[Player.Instance.location.Y, Player.Instance.location.X].attribute)
				{
				case TerrainType.TallGrass:
					array = Player.Instance.currentMap.tallGrassWild;
					break;
				case TerrainType.LongGrass:
					array = Player.Instance.currentMap.longGrassWild;
					break;
				case TerrainType.Water:
					array = Player.Instance.currentMap.surfWild;
					break;
				case TerrainType.Cave:
					array = Player.Instance.currentMap.caveWild;
					break;
				}
				
				WildPokemon[] array2 = array;

				for (int i = 0; i < array2.Length; i++)
				{
					WildPokemon wildPokemon = array2[i];
					if (PRNG.Instance.Next((int)(187.5 / (double)wildPokemon.rate)) == 1)
					{
						new Battle(new Pokemon(wildPokemon.mon, (int)PRNG.Instance.Next((int)wildPokemon.minLevel, (int)wildPokemon.maxLevel), null, null)).ShowDialog();
						break;
					}
				}
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				switch (Player.Instance.dir)
				{
				case Direction.Up:
					this.OBJ[5, 7] = Player.Instance.sprite.Up;
					break;
				case Direction.Right:
					this.OBJ[5, 7] = Player.Instance.sprite.Right;
					break;
				case Direction.Down:
					this.OBJ[5, 7] = Player.Instance.sprite.Down;
					break;
				case Direction.Left:
					this.OBJ[5, 7] = Player.Instance.sprite.Left;
					break;
				}
				for (int i = 0; i < 10; i++)
				{
					for (int j = 0; j < 15; j++)
					{
						if (this.BG2[i, j] == null)
						{
							e.Graphics.DrawImage(Player.Instance.currentMap.border, 32 * j, 32 * i - 16, 32, 32);
						}
						else
						{
							e.Graphics.DrawImage(this.BG2[i, j], 32 * j, 32 * i - 16, 32, 32);
							if (this.OBJ[i, j] != null)
							{
								e.Graphics.DrawImage(this.OBJ[i, j], 32 * j, 32 * i - 16, 32, 32);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace, ex.Message);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Player.Instance.playTime += new TimeSpan(0, 0, 1);
			Array.Clear(this.OBJ, 0, this.OBJ.Length);
			for (int i = 0; i < Player.Instance.currentMap.events.Length; i++)
			{
				if (Player.Instance.currentMap.events[i] is NPC)
				{
					Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X].Occupied = false;
					NPC nPC = Player.Instance.currentMap.events[i] as NPC;
					switch (nPC.movement)
					{
					case MovementType.LookAround:
						switch (PRNG.Instance.Next(4))
						{
						case 0:
							nPC.dir = Direction.Up;
							break;
						case 1:
							nPC.dir = Direction.Down;
							break;
						case 2:
							nPC.dir = Direction.Left;
							break;
						case 3:
							nPC.dir = Direction.Right;
							break;
						}
						break;
					case MovementType.LookUp:
						nPC.dir = Direction.Up;
						break;
					case MovementType.LookDown:
						nPC.dir = Direction.Down;
						break;
					case MovementType.LookLeft:
						nPC.dir = Direction.Left;
						break;
					case MovementType.LookRight:
						nPC.dir = Direction.Right;
						break;
					case MovementType.LookClockwise:
						switch (nPC.dir)
						{
						case Direction.Up:
							nPC.dir = Direction.Right;
							break;
						case Direction.Right:
							nPC.dir = Direction.Down;
							break;
						case Direction.Down:
							nPC.dir = Direction.Left;
							break;
						case Direction.Left:
							nPC.dir = Direction.Up;
							break;
						}
						break;
					case MovementType.LookCounterClockwise:
						switch (nPC.dir)
						{
						case Direction.Up:
							nPC.dir = Direction.Left;
							break;
						case Direction.Right:
							nPC.dir = Direction.Up;
							break;
						case Direction.Down:
							nPC.dir = Direction.Right;
							break;
						case Direction.Left:
							nPC.dir = Direction.Down;
							break;
						}
						break;
					case MovementType.WalkAround:
						switch (PRNG.Instance.Next(4))
						{
						case 0:
							if (Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y - 1, Player.Instance.currentMap.events[i].location.X].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y - 1, Player.Instance.currentMap.events[i].location.X].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y - 1, Player.Instance.currentMap.events[i].location.X].Occupied)
							{
								nPC.dir = Direction.Up;
								Event expr_355_cp_0 = Player.Instance.currentMap.events[i];
								expr_355_cp_0.location.Y = expr_355_cp_0.location.Y - 1;
							}
							break;
						case 1:
							if (Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y + 1, Player.Instance.currentMap.events[i].location.X].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y + 1, Player.Instance.currentMap.events[i].location.X].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y + 1, Player.Instance.currentMap.events[i].location.X].Occupied)
							{
								nPC.dir = Direction.Down;
								Event expr_47B_cp_0 = Player.Instance.currentMap.events[i];
								expr_47B_cp_0.location.Y = expr_47B_cp_0.location.Y + 1;
							}
							break;
						case 2:
							if (Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X + 1].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X + 1].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X + 1].Occupied)
							{
								nPC.dir = Direction.Right;
								Event expr_5A1_cp_0 = Player.Instance.currentMap.events[i];
								expr_5A1_cp_0.location.X = expr_5A1_cp_0.location.X + 1;
							}
							break;
						case 3:
							if (Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X - 1].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X - 1].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X - 1].Occupied)
							{
								nPC.dir = Direction.Left;
								Event expr_6C7_cp_0 = Player.Instance.currentMap.events[i];
								expr_6C7_cp_0.location.X = expr_6C7_cp_0.location.X - 1;
							}
							break;
						}
						break;
					case MovementType.WalkUpAndDown:
						switch (PRNG.Instance.Next(2))
						{
						case 0:
							if (Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y - 1, Player.Instance.currentMap.events[i].location.X].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y - 1, Player.Instance.currentMap.events[i].location.X].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y - 1, Player.Instance.currentMap.events[i].location.X].Occupied)
							{
								nPC.dir = Direction.Up;
								Event expr_A7F_cp_0 = Player.Instance.currentMap.events[i];
								expr_A7F_cp_0.location.Y = expr_A7F_cp_0.location.Y - 1;
							}
							break;
						case 1:
							if (Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y + 1, Player.Instance.currentMap.events[i].location.X].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y + 1, Player.Instance.currentMap.events[i].location.X].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y + 1, Player.Instance.currentMap.events[i].location.X].Occupied)
							{
								nPC.dir = Direction.Down;
								Event expr_BA5_cp_0 = Player.Instance.currentMap.events[i];
								expr_BA5_cp_0.location.Y = expr_BA5_cp_0.location.Y + 1;
							}
							break;
						}
						break;
					case MovementType.WalkLeftAndRight:
						switch (PRNG.Instance.Next(2))
						{
						case 0:
							if (Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X + 1].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X + 1].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X + 1].Occupied)
							{
								nPC.dir = Direction.Right;
								Event expr_810_cp_0 = Player.Instance.currentMap.events[i];
								expr_810_cp_0.location.X = expr_810_cp_0.location.X + 1;
							}
							break;
						case 1:
							if (Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X - 1].attribute != TerrainType.NotWalkable && Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X - 1].attribute != TerrainType.Water && !Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X - 1].Occupied)
							{
								nPC.dir = Direction.Left;
								Event expr_936_cp_0 = Player.Instance.currentMap.events[i];
								expr_936_cp_0.location.X = expr_936_cp_0.location.X - 1;
							}
							break;
						}
						break;
					}
					switch (nPC.dir)
					{
					case Direction.Up:
						this.OBJ[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X] = Player.Instance.currentMap.events[i].sprite.Up;
						break;
					case Direction.Right:
						this.OBJ[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X] = Player.Instance.currentMap.events[i].sprite.Right;
						break;
					case Direction.Down:
						this.OBJ[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X] = Player.Instance.currentMap.events[i].sprite.Down;
						break;
					case Direction.Left:
						this.OBJ[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X] = Player.Instance.currentMap.events[i].sprite.Left;
						break;
					}
					Player.Instance.currentMap[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X].Occupied = true;
				}
				else
				{
					this.OBJ[Player.Instance.currentMap.events[i].location.Y, Player.Instance.currentMap.events[i].location.X] = Player.Instance.currentMap.events[i].sprite.Down;
				}
			}
			this.pnlScreen.Invalidate();
		}

		private void World_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		
		private void mnuDex_Click(object sender, EventArgs e)
		{
			this.timer1.Enabled = false;
			new Pokedex().ShowDialog();
			this.timer1.Enabled = true;
		}
		
		private void mnuPokemon_Click(object sender, EventArgs e)
		{
			this.timer1.Enabled = false;
			new PokemonList(PokemonListMode.Free).ShowDialog();
			this.timer1.Enabled = true;
		}
		
		private void mnuItems_Click(object sender, EventArgs e)
		{
			this.timer1.Enabled = false;
			new Bag().ShowDialog();
			this.timer1.Enabled = true;
		}
		
		private void mnuPlayer_Click(object sender, EventArgs e)
		{
			this.timer1.Enabled = false;
			new TrainerCard().ShowDialog();
			this.timer1.Enabled = true;
		}
		
		private void mnuSave_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Save?", "Save Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				using (FileStream fileStream = new FileStream(Player.Instance.name + ".pksav", FileMode.Create, FileAccess.Write, FileShare.None))
				{
					new BinaryFormatter().Serialize(fileStream, Player.Instance);
					this.showMessage(new[] { Player.Instance.name + " saved the game!" });
				}
			}
		}
		
		private void mnuExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to quit?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				this.Close();
			}
		}
		
		private void readMap()
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 15; j++)
				{
					Bitmap block = new Bitmap(32, 32);
					Graphics g = Graphics.FromImage(block);
					g.DrawImageUnscaled(Player.Instance.currentMap[i, j].lowerTopLeft, 0, 0);
					g.DrawImageUnscaled(Player.Instance.currentMap[i, j].lowerTopRight, 16, 0);
					g.DrawImageUnscaled(Player.Instance.currentMap[i, j].lowerBottomLeft, 0, 16);
					g.DrawImageUnscaled(Player.Instance.currentMap[i, j].lowerBottomRight, 16, 16);
					g.DrawImageUnscaled(Player.Instance.currentMap[i, j].upperTopLeft, 0, 0);
					g.DrawImageUnscaled(Player.Instance.currentMap[i, j].upperTopRight, 16, 0);
					g.DrawImageUnscaled(Player.Instance.currentMap[i, j].upperBottomLeft, 0, 16);
					g.DrawImageUnscaled(Player.Instance.currentMap[i, j].upperBottomRight, 16, 16);
					this.BG2[i, j] = block;
				}
			}
		}
		
		private void showMessage(params string[] s)
		{
			timer1.Enabled = false;
			Graphics graphics = pnlScreen.CreateGraphics();
			graphics.DrawString("/----------\\", new Font("Arial", 12f), Brushes.Black, 0f, 0f);
			timer1.Enabled = true;
		}
		
		private void timer2_Tick(object sender, EventArgs e)
		{
			this.delay++;
		}
	}
}
