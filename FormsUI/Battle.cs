using PokemonSharp.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PokemonSharp;

namespace FormsUI
{
	public class Battle : Form
	{
		private Trainer enemy;
		private Pokemon playerMon;
		private Pokemon enemyMon;
		private int playerMonNum = 0;
		private int enemyMonNum = 0;
		private bool wild;
		private Move playerMove;
		private Move enemyMove;
		public static Weather weather = Weather.Normal;
		private static readonly double[][] TYPE_ADVANTAGES = new double[][]
		{				// NRM  FGT  FLY  PSN  GRN  RCK  BUG  GST  STL  FIR  WTR  GRS  ELC  PSY  ICE  DRG  DRK
			new double[] { 1.0, 1.0, 1.0, 1.0, 1.0, 0.5, 1.0, 0.0, 0.5, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0 }, //NRM
			new double[] { 2.0, 1.0, 0.5, 0.5, 1.0, 2.0, 0.5, 0.0, 2.0, 1.0, 1.0, 1.0, 1.0, 0.5, 2.0, 1.0, 2.0 }, //FGT
			new double[] { 1.0, 2.0, 1.0, 1.0, 1.0, 0.5, 2.0, 1.0, 0.5, 1.0, 1.0, 2.0, 0.5, 1.0, 1.0, 1.0, 1.0 }, //FLY
			new double[] { 1.0, 1.0, 1.0, 0.5, 0.5, 0.5, 1.0, 0.5, 0.0, 1.0, 1.0, 2.0, 1.0, 1.0, 1.0, 1.0, 1.0 }, //PSN
			new double[] { 1.0, 1.0, 0.0, 2.0, 1.0, 2.0, 0.5, 1.0, 2.0, 2.0, 1.0, 0.5, 2.0, 1.0, 1.0, 1.0, 1.0 }, //GRN
			new double[] { 1.0, 0.5, 2.0, 1.0, 0.5, 1.0, 2.0, 1.0, 0.5, 2.0, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0 }, //RCK
			new double[] { 1.0, 0.5, 0.5, 0.5, 1.0, 1.0, 1.0, 0.5, 0.5, 0.5, 1.0, 2.0, 1.0, 2.0, 1.0, 1.0, 2.0 }, //BUG
			new double[] { 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 2.0, 0.5, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0, 0.5 }, //GST
			new double[] { 1.0, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0, 0.5, 0.5, 0.5, 1.0, 0.5, 1.0, 2.0, 1.0, 1.0 }, //STL
			new double[] { 1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			0.5,
			2.0,
			1.0,
			2.0,
			0.5,
			0.5,
			2.0,
			1.0,
			1.0,
			2.0,
			0.5,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			2.0,
			2.0,
			1.0,
			1.0,
			1.0,
			2.0,
			0.5,
			0.5,
			1.0,
			1.0,
			1.0,
			0.5,
			1.0,
			1.0,
			1.0,
			0.5,
			0.5,
			2.0,
			2.0,
			0.5,
			1.0,
			0.5,
			0.5,
			2.0,
			0.5,
			1.0,
			1.0,
			1.0,
			0.5,
			1.0,
			1.0,
			1.0,
			2.0,
			1.0,
			0.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			2.0,
			0.5,
			0.5,
			1.0,
			1.0,
			0.5,
			1.0,
			1.0,
			2.0,
			1.0,
			2.0,
			1.0,
			1.0,
			1.0,
			1.0,
			0.5,
			1.0,
			1.0,
			1.0,
			1.0,
			0.5,
			1.0,
			1.0,
			0.0,
			1.0,
			1.0,
			2.0,
			1.0,
			2.0,
			1.0,
			1.0,
			1.0,
			0.5,
			0.5,
			0.5,
			2.0,
			1.0,
			1.0,
			0.5,
			2.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			0.5,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			2.0,
			1.0,
			1.0,
			0.5,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			2.0,
			0.5,
			1.0,
			1.0,
			1.0,
			1.0,
			2.0,
			1.0,
			1.0,
			0.5 }
		};
		private IContainer components = null;
		private PictureBox pbxEnemyPic;
		private PictureBox pbxPlayerPic;
		private Label lblPlayerName;
		private Label lblEnemyName;
		private Label lblPlayerHP;
		private Panel commandPanel;
		private Panel pnlMoves;
		private ProgressBar pbEnemy;
		private Label lblEnemyHPPrompt;
		private ProgressBar pbPlayer;
		private Label lblPlayerHPPrompt;
		private Label lblPlayerLevel;
		private Label lblEnemyLevel;
		private Panel pnlLevelUpStats;
		private Label lblSpecialAttackStat;
		private Label lblSpeedStat;
		private Label lblDefenseStat;
		private Label lblAttackStat;
		private Label lblSpecialDefenseStat;
		private Label lblEnemyArrow;
		private Label lblPlayerArrow;
		private ProgressBar pbExp;
		private Button btnPokemon;
		private Button btnRun;
		private Button btnBag;
		private Button btnFight;
		private Button btnMove4;
		private Button btnMove3;
		private Button btnMove2;
		private Button btnMove1;
		private Button button1;
		public Battle(Trainer t)
		{
			this.InitializeComponent();
			this.enemy = t;
			this.playerMon = Player.Instance.party[0];
			this.enemyMon = this.enemy.party[0];
			this.wild = false;
			MusicPlayer.playBG("resources\\music\\kanto\\1-011 Battle (VS Trainer).mp3");
		}
		public Battle(Pokemon m)
		{
			this.InitializeComponent();
			this.playerMon = Player.Instance.party[0];
			this.enemyMon = m;
			this.wild = true;
			MusicPlayer.playBG("resources\\music\\kanto\\1-18 Battle (VS Wild Pokemon).mp3");
		}
		private void preTurn()
		{
			this.commandPanel.Visible = true;
			this.enemyMove = this.enemyMon.moveSet[(int)PRNG.Instance.Next(this.enemyMon.moveSet.Length)];
		}
		private void postTurn()
		{
			int priority = (int)this.enemyMove.priority;
			int priority2 = (int)this.playerMove.priority;
			bool flag = priority2 > priority || (priority2 >= priority && (this.playerMon.Speed > this.enemyMon.Speed || (this.playerMon.Speed >= this.enemyMon.Speed && PRNG.Instance.Next(2) == 0)));
			if (flag)
			{
				this.fight(this.playerMove, this.playerMon, this.enemyMon);
				this.fight(this.enemyMove, this.enemyMon, this.playerMon);
			}
			else
			{
				this.fight(this.enemyMove, this.enemyMon, this.playerMon);
				this.fight(this.playerMove, this.playerMon, this.enemyMon);
			}
		}
		private void fight(Move m, Pokemon user, Pokemon target)
		{
			this.commandPanel.Visible = false;
			bool flag = true;
			bool flag2 = false;
			bool flag3 = false;
			if (user.VolStatus.HasFlag(VolatileAilments.Confusion))
			{
				long num = (long)((ulong)PRNG.Instance.Next(2));
				if (num == 0L)
				{
					double num2 = (user.NonVolStatus == NonVolatileAilment.Burn && m.category == DamageCategory.Physical) ? 0.5 : 1.0;
					long num3 = (long)(PRNG.Instance.Next(217, 255) * 100 / 255);
					ushort num4 = (ushort)((((double)user.Level * 0.4 + 2.0) * 40.0 * (double)user.Attack * 0.02 / (double)user.Defense * num2 + 2.0) * (double)num3 * 0.01);
					user.HP -= num4;
					flag = false;
				}
			}
			if (user.VolStatus.HasFlag(VolatileAilments.LeechSeed))
			{
				if (target.HP >= 16)
				{
					ushort num5 = (ushort)Math.Floor(0.0625 * (double)target.HP);
					target.HP -= num5;
					user.HP += num5;
				}
				else
				{
					target.HP -= 1;
					user.HP += 1;
				}
			}
			if (user.VolStatus.HasFlag(VolatileAilments.Curse))
			{
				user.HP -= (ushort)(user.MaxHP >> 2);
			}
			if (user.VolStatus.HasFlag(VolatileAilments.Flinch))
			{
				flag = false;
				user.removeVolStatus(VolatileAilments.Flinch);
			}
			if (user.VolStatus.HasFlag(VolatileAilments.Trapped))
			{
				user.HP -= (ushort)(user.MaxHP >> 4);
				user.trapTime--;
				if (user.trapTime == -1)
				{
					user.trapTime = (int)PRNG.Instance.Next(4, 5);
				}
				else
				{
					if (user.trapTime == 0)
					{
						user.removeVolStatus(VolatileAilments.Trapped);
					}
				}
			}
			switch (user.NonVolStatus)
			{
			case NonVolatileAilment.Sleep:
				flag = false;
				user.sleepTime--;
				if (user.sleepTime == -1)
				{
					user.sleepTime = (int)((sbyte)PRNG.Instance.Next(1, 4));
				}
				else
				{
					if (user.sleepTime == 0)
					{
						user.NonVolStatus = NonVolatileAilment.None;
					}
				}
				break;
			case NonVolatileAilment.Freeze:
			{
				int num6 = (int)PRNG.Instance.Next(5);
				if (num6 == 0)
				{
					flag = true;
					user.NonVolStatus = NonVolatileAilment.None;
				}
				break;
			}
			case NonVolatileAilment.Paralyze:
			{
				int num7 = (int)PRNG.Instance.Next(4);
				if (num7 == 0)
				{
					flag = false;
				}
				break;
			}
			}
			if (flag)
			{
				if (user.Equals(this.playerMon))
				{
					new TextWindow(new string[]
					{
						string.Concat(new object[]
						{
							user.nickname,
							"! Use ",
							m.name,
							'!'
						})
					}).ShowDialog();
				}
				else
				{
					if (this.wild)
					{
						new TextWindow(new string[]
						{
							string.Concat(new object[]
							{
								"Wild ",
								user.nickname,
								" used ",
								m.name,
								'!'
							})
						}).ShowDialog();
					}
					else
					{
						new TextWindow(new string[]
						{
							string.Concat(new object[]
							{
								"Enemy ",
								user.nickname,
								" used ",
								m.name,
								'!'
							})
						}).ShowDialog();
					}
				}
				int num8 = 0;
				if (m.accuracy != 100)
				{
					int num9 = 1;
					if (user.accuracyLevel > 0)
					{
						num9 = (int)((3 + user.accuracyLevel) / 3);
					}
					else
					{
						if (user.accuracyLevel < 0)
						{
							num9 = (int)(3 / (3 - user.accuracyLevel));
						}
					}
					int num10 = 1;
					if (target.evasionLevel > 0)
					{
						num10 = (int)((3 + target.evasionLevel) / 3);
					}
					else
					{
						if (target.evasionLevel > 0)
						{
							num10 = (int)(3 / (3 - target.evasionLevel));
						}
					}
					int num11 = (int)m.accuracy * num9 * num10;
					if (num11 > 100)
					{
						num11 = 100;
					}
					num8 = (int)Math.Floor((double)num11 * 2.56);
				}
				int num12 = (int)PRNG.Instance.Next(256);
				if (num12 < num8)
				{
					int num13 = (int)((byte)PRNG.Instance.Next(100));
					if ((int)m.effectAccuracy < num13)
					{
						m.effect(target, user, 0);
					}
					if (m.power > 0)
					{
						byte level = user.Level;
						byte power = m.power;
						ushort num14 = 0;
						ushort num15 = 0;
						switch (m.category)
						{
						case DamageCategory.Physical:
							num14 = user.Attack;
							num15 = target.Defense;
							break;
						case DamageCategory.Special:
							num14 = user.SpecialAttack;
							num15 = target.SpecialDefense;
							break;
						}
						bool flag4 = false;
						bool flag5 = false;
						bool flag6 = false;
						double num16 = (user.NonVolStatus == NonVolatileAilment.Burn && m.category == DamageCategory.Physical) ? 0.5 : 1.0;
						double num17 = ((m.category == DamageCategory.Physical && flag4) || (m.category == DamageCategory.Special && flag5)) ? 0.5 : 1.0;
						double num18 = flag6 ? 0.75 : 1.0;
						double num19 = 1.0;
						switch (Battle.weather)
						{
						case Weather.IntenseSunlight:
							switch (m.element)
							{
							case Types.Fire:
								num19 = 1.5;
								break;
							case Types.Water:
								num19 = 0.5;
								break;
							}
							break;
						case Weather.HeavyRain:
							switch (m.element)
							{
							case Types.Fire:
								num19 = 0.5;
								break;
							case Types.Water:
								num19 = 1.5;
								break;
							}
							break;
						}
						double num2 = num16 * num17 * num18 * num19 * 1.0;
						if (user.baseStats.types.HasFlag(m.element))
						{
							flag2 = true;
						}
						double num20 = 1.0;
						foreach (Types types in Enum.GetValues(typeof(Types)))
						{
							if (target.baseStats.types.HasFlag(types))
							{
								num20 *= Battle.TYPE_ADVANTAGES[(int)m.element][(int)types];
							}
						}
						ushort num4 = (ushort)((((double)level * 0.4 + 2.0) * (double)power * (double)num14 * 0.02 / (double)num15 * num2 + 2.0) * (double)(flag3 ? 2 : 1) * 1.0 * (double)(PRNG.Instance.Next(217, 255) * 100 / 255) * 0.01 * (flag2 ? 1.5 : 1.0) * num20 * 1.0);
						target.HP -= num4;
					}
					this.update();
					if (flag3)
					{
						new TextWindow(new string[]
						{
							"Critical hit!"
						}).ShowDialog();
					}
					if (flag2)
					{
						new TextWindow(new string[]
						{
							"It's super effective!!"
						}).ShowDialog();
					}
				}
				else
				{
					new TextWindow(new string[]
					{
						"Attack missed!"
					}).ShowDialog();
				}
				if (user.NonVolStatus == NonVolatileAilment.Poison)
				{
					user.HP -= (ushort)(user.MaxHP >> 3);
				}
				else
				{
					if (user.NonVolStatus == NonVolatileAilment.BadPoison)
					{
						user.HP -= (ushort)((int)user.toxicCount * (user.MaxHP >> 4));
						user.toxicCount += 1;
					}
				}
			}
		}
		private void useItem(Item i, Pokemon target)
		{
			this.commandPanel.Visible = false;
			if (i.name.Contains("BALL") && !this.wild)
			{
				new TextWindow(new string[]
				{
					"No stealing!"
				}).ShowDialog();
			}
			else
			{
				i.Use(target, true);
				if (i.name.Contains("BALL"))
				{
					new TextWindow(new string[]
					{
						"Go! " + i.name + '!'
					}).ShowDialog();
					this.playerMon.attackLevel = 0;
					this.playerMon.defenseLevel = 0;
					this.playerMon.speedLevel = 0;
					this.playerMon.specialAttackLevel = 0;
					this.playerMon.specialDefenseLevel = 0;
					this.playerMon.accuracyLevel = 0;
					this.playerMon.evasionLevel = 0;
					this.enemyMon.attackLevel = 0;
					this.enemyMon.defenseLevel = 0;
					this.enemyMon.speedLevel = 0;
					this.enemyMon.specialAttackLevel = 0;
					this.enemyMon.specialDefenseLevel = 0;
					this.enemyMon.accuracyLevel = 0;
					this.enemyMon.evasionLevel = 0;
					Player.Instance.givePokemon(this.enemyMon);
					base.Close();
				}
				else
				{
					new TextWindow(new string[]
					{
						string.Concat(new object[]
						{
							Player.Instance.name,
							" uses ",
							i.name,
							" on ",
							target.nickname,
							'!'
						})
					}).ShowDialog();
				}
			}
		}
		private bool pokemonSwitch(bool playerSwitch)
		{
			bool result;
			if (playerSwitch)
			{
				this.commandPanel.Visible = false;
				this.playerMon.attackLevel = 0;
				this.playerMon.defenseLevel = 0;
				this.playerMon.speedLevel = 0;
				this.playerMon.specialAttackLevel = 0;
				this.playerMon.accuracyLevel = 0;
				this.playerMon.evasionLevel = 0;
				if (this.playerMonNum + 1 < Player.Instance.party.Count)
				{
					this.playerMonNum++;
					new TextWindow(new string[]
					{
						string.Concat(new object[]
						{
							this.playerMon.nickname,
							"! That's enough!\nGo! ",
							Player.Instance.party[this.playerMonNum].nickname,
							'!'
						})
					}).ShowDialog();
					this.playerMon = Player.Instance.party[this.playerMonNum];
					this.btnMove1.Text = this.playerMon.moveSet[0].name;
					this.btnMove2.Text = this.playerMon.moveSet[1].name;
					this.btnMove3.Text = this.playerMon.moveSet[2].name;
					this.btnMove4.Text = this.playerMon.moveSet[3].name;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			else
			{
				this.enemyMon.attackLevel = 0;
				this.enemyMon.defenseLevel = 0;
				this.enemyMon.speedLevel = 0;
				this.enemyMon.specialAttackLevel = 0;
				this.enemyMon.accuracyLevel = 0;
				this.enemyMon.evasionLevel = 0;
				if (this.enemyMonNum++ <= this.enemy.party.Count)
				{
					new TextWindow(new string[]
					{
						string.Concat(new object[]
						{
							this.enemy.name,
							" recalled ",
							this.enemyMon.nickname,
							"!\nAnd...\n",
							this.enemy.name,
							" sent out ",
							this.enemy.party[this.enemyMonNum].nickname,
							'!'
						})
					}).ShowDialog();
					this.enemyMon = this.enemy.party[this.enemyMonNum];
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}
		private void run()
		{
			this.commandPanel.Visible = false;
			if (this.wild)
			{
				new TextWindow(new string[]
				{
					"You ran away!"
				}).ShowDialog();
				base.Close();
			}
			else
			{
				new TextWindow(new string[]
				{
					"You can't run from this battle!"
				}).ShowDialog();
				this.commandPanel.Visible = true;
			}
		}
		private void update()
		{
			this.btnMove1.Text = ((this.playerMon.moveSet[0] == null) ? "---" : this.playerMon.moveSet[0].name);
			this.btnMove2.Text = ((this.playerMon.moveSet[1] == null) ? "---" : this.playerMon.moveSet[1].name);
			this.btnMove3.Text = ((this.playerMon.moveSet[2] == null) ? "---" : this.playerMon.moveSet[2].name);
			this.btnMove4.Text = ((this.playerMon.moveSet[3] == null) ? "---" : this.playerMon.moveSet[3].name);
			this.pbxPlayerPic.Image = this.playerMon.BackImage;
			this.pbxEnemyPic.Image = this.enemyMon.FrontImage;
			this.lblPlayerName.Text = this.playerMon.nickname;
			this.lblEnemyName.Text = this.enemyMon.nickname;
			switch (this.playerMon.NonVolStatus)
			{
			case NonVolatileAilment.Sleep:
				this.lblPlayerLevel.Text = "SLP";
				break;
			case NonVolatileAilment.Poison:
				this.lblPlayerLevel.Text = "PSN";
				break;
			case NonVolatileAilment.Burn:
				this.lblPlayerLevel.Text = "BRN";
				break;
			case NonVolatileAilment.Freeze:
				this.lblPlayerLevel.Text = "FRZ";
				break;
			case NonVolatileAilment.Paralyze:
				this.lblPlayerLevel.Text = "PAR";
				break;
			default:
				switch (this.playerMon.gender)
				{
				case Gender.Genderless:
					this.lblPlayerLevel.ForeColor = Color.Black;
					this.lblPlayerLevel.Text = this.playerMon.Level.ToString();
					break;
				case Gender.Male:
					this.lblPlayerLevel.ForeColor = Color.Blue;
					this.lblPlayerLevel.Text = "♂Lv" + this.playerMon.Level;
					break;
				case Gender.Female:
					this.lblPlayerLevel.ForeColor = Color.Pink;
					this.lblPlayerLevel.Text = "♀Lv" + this.playerMon.Level;
					break;
				}
				break;
			}
			switch (this.enemyMon.NonVolStatus)
			{
			case NonVolatileAilment.Sleep:
				this.lblEnemyLevel.Text = "SLP";
				break;
			case NonVolatileAilment.Poison:
				this.lblEnemyLevel.Text = "PSN";
				break;
			case NonVolatileAilment.Burn:
				this.lblEnemyLevel.Text = "BRN";
				break;
			case NonVolatileAilment.Freeze:
				this.lblEnemyLevel.Text = "FRZ";
				break;
			case NonVolatileAilment.Paralyze:
				this.lblEnemyLevel.Text = "PAR";
				break;
			default:
				switch (this.enemyMon.gender)
				{
				case Gender.Genderless:
					this.lblEnemyLevel.ForeColor = Color.Black;
					this.lblEnemyLevel.Text = this.enemyMon.Level.ToString();
					break;
				case Gender.Male:
					this.lblEnemyLevel.ForeColor = Color.Blue;
					this.lblEnemyLevel.Text = "♂Lv" + this.enemyMon.Level;
					break;
				case Gender.Female:
					this.lblEnemyLevel.ForeColor = Color.Pink;
					this.lblEnemyLevel.Text = "♀Lv" + this.enemyMon.Level;
					break;
				}
				break;
			}
			if (this.playerMon.HP / this.playerMon.MaxHP * 100 < 100)
			{
				this.lblPlayerHP.Text = string.Concat(new object[]
				{
					"HP: ",
					this.playerMon.HP,
					'/',
					this.playerMon.MaxHP
				});
			}
			else
			{
				this.lblPlayerHP.Text = string.Concat(new object[]
				{
					"HP: ",
					this.playerMon.HP,
					'/',
					this.playerMon.MaxHP
				});
			}
			this.pbPlayer.Value = (int)Math.Floor((double)this.playerMon.HP / (double)this.playerMon.MaxHP * 100.0);
			this.pbEnemy.Value = (int)Math.Floor((double)this.enemyMon.HP / (double)this.enemyMon.MaxHP * 100.0);
			if ((int)this.playerMon.HP >= this.playerMon.MaxHP >> 1)
			{
				this.pbPlayer.ForeColor = Color.LimeGreen;
			}
			else
			{
				if ((int)this.playerMon.HP >= this.playerMon.MaxHP >> 2)
				{
					this.pbPlayer.ForeColor = Color.Orange;
				}
				else
				{
					this.pbPlayer.ForeColor = Color.Red;
				}
			}
			if ((int)this.enemyMon.HP >= this.enemyMon.MaxHP >> 1)
			{
				this.pbEnemy.ForeColor = Color.LimeGreen;
			}
			else
			{
				if ((int)this.enemyMon.HP >= this.enemyMon.MaxHP >> 2)
				{
					this.pbEnemy.ForeColor = Color.Orange;
				}
				else
				{
					this.pbEnemy.ForeColor = Color.Red;
				}
			}
			if (this.playerMon.HP == 0)
			{
				if (!this.pokemonSwitch(true))
				{
					this.end(false);
				}
			}
			if (this.enemyMon.HP == 0)
			{
				if (!this.wild)
				{
					if (!this.pokemonSwitch(false))
					{
						this.end(true);
					}
				}
				else
				{
					this.end(true);
				}
			}
		}
		private void end(bool win)
		{
			this.playerMon.attackLevel = 0;
			this.playerMon.defenseLevel = 0;
			this.playerMon.speedLevel = 0;
			this.playerMon.specialAttackLevel = 0;
			this.playerMon.specialDefenseLevel = 0;
			this.playerMon.accuracyLevel = 0;
			this.playerMon.evasionLevel = 0;
			this.enemyMon.attackLevel = 0;
			this.enemyMon.defenseLevel = 0;
			this.enemyMon.speedLevel = 0;
			this.enemyMon.specialAttackLevel = 0;
			this.enemyMon.specialDefenseLevel = 0;
			this.enemyMon.accuracyLevel = 0;
			this.enemyMon.evasionLevel = 0;
			if (win)
			{
				byte b = (byte)(this.playerMon.pokerus ? 2 : 1);
				Pokemon expr_D0 = this.playerMon;
				expr_D0.hpEV += (byte)((this.enemyMon.baseStats.evYield & 3) / 1 * (ushort)b);
				Pokemon expr_FA = this.playerMon;
				expr_FA.attackEV += (byte)((this.enemyMon.baseStats.evYield & 12) / 4 * (ushort)b);
				Pokemon expr_125 = this.playerMon;
				expr_125.defenseEV += (byte)((this.enemyMon.baseStats.evYield & 48) / 16 * (ushort)b);
				Pokemon expr_151 = this.playerMon;
				expr_151.speedEV += (byte)((this.enemyMon.baseStats.evYield & 192) / 64 * (ushort)b);
				Pokemon expr_180 = this.playerMon;
				expr_180.specialAttackEV += (byte)((this.enemyMon.baseStats.evYield & 768) / 256 * (ushort)b);
				Pokemon expr_1B2 = this.playerMon;
				expr_1B2.specialDefenseEV += (byte)((this.enemyMon.baseStats.evYield & 3072) / 1024 * (ushort)b);
				double num = this.wild ? 1.0 : 1.5;
				double num2 = (this.playerMon.OTid == Player.Instance.id) ? 1.0 : 1.5;
				byte expYield = this.enemyMon.baseStats.expYield;
				byte level = this.enemyMon.Level;
				byte level2 = this.playerMon.Level;
				uint num3 = (uint)Math.Floor(num * num2 * (double)expYield * (double)level / 7.0);
				this.playerMon.Exp += num3;
				new TextWindow(new string[]
				{
					string.Concat(new object[]
					{
						this.playerMon.nickname,
						" gained ",
						num3,
						" experience points!"
					})
				}).ShowDialog();
				if (this.playerMon.Level > level2)
				{
					new TextWindow(new string[]
					{
						string.Concat(new object[]
						{
							this.playerMon.nickname,
							" grew to level ",
							this.playerMon.Level,
							'!'
						})
					}).ShowDialog();
					this.pnlLevelUpStats.Visible = true;
					MusicPlayer.playSE("resources\\music\\kanto\\1-43 Fanfare Success!.mp3");
					this.lblAttackStat.Text = this.playerMon.Attack.ToString();
					this.lblDefenseStat.Text = this.playerMon.Defense.ToString();
					this.lblSpeedStat.Text = this.playerMon.Speed.ToString();
					this.lblSpecialAttackStat.Text = this.playerMon.SpecialAttack.ToString();
					this.lblSpecialDefenseStat.Text = this.playerMon.SpecialDefense.ToString();
				}
				if (!this.wild)
				{
					MusicPlayer.playSE("resources\\music\\kanto\\1-12 Victory (VS Trainer).mp3");
					new TextWindow(new string[]
					{
						this.enemy.name + " was defeated!",
						Player.Instance.name + " got $0 for winning!"
					}).ShowDialog();
					this.enemy.defeated = true;
					base.Close();
				}
				else
				{
					MusicPlayer.playSE("resources\\music\\kanto\\1-19 Victory (VS Wild Pokemon).mp3");
					base.Close();
				}
			}
			else
			{
				new TextWindow(new string[]
				{
					Player.Instance.name + " blacked out!"
				}).ShowDialog();
				byte b2 = 0;
				foreach (Pokemon current in Player.Instance.party)
				{
					if (current.Level > b2)
					{
						b2 = current.Level;
					}
				}
				uint num4 = 0u;
				Badges badges = Player.Instance.badges;
				if (badges <= Badges.Soul)
				{
					switch (badges)
					{
					case Badges.None:
						num4 = 8u;
						break;
					case Badges.Boulder:
						num4 = 16u;
						break;
					case Badges.Cascade:
						num4 = 24u;
						break;
					case Badges.Boulder | Badges.Cascade:
					case Badges.Boulder | Badges.Thunder:
					case Badges.Cascade | Badges.Thunder:
					case Badges.Boulder | Badges.Cascade | Badges.Thunder:
						break;
					case Badges.Thunder:
						num4 = 36u;
						break;
					case Badges.Rainbow:
						num4 = 48u;
						break;
					default:
						if (badges == Badges.Soul)
						{
							num4 = 80u;
						}
						break;
					}
				}
				else
				{
					if (badges != Badges.Marsh)
					{
						if (badges != Badges.Volcano)
						{
							if (badges == Badges.Earth)
							{
								num4 = 120u;
							}
						}
						else
						{
							num4 = 100u;
						}
					}
					else
					{
						num4 = 60u;
					}
				}
				Player.Instance.money -= (((uint)b2 * num4 > Player.Instance.money) ? Player.Instance.money : ((uint)b2 * num4));
				base.Close();
			}
		}
		private void Battle_Load(object sender, EventArgs e)
		{
			switch (Player.Instance.gender)
			{
			case Gender.Male:
				//this.pbxPlayerPic.Image = Resources.boybattle1;
				break;
			case Gender.Female:
				//this.pbxPlayerPic.Image = Resources.girlbattle1;
				break;
			default:
				//this.pbxPlayerPic.Image = Resources.black;
				break;
			}
			if (this.wild)
			{
				new TextWindow(new string[]
				{
					"Wild " + this.enemyMon.nickname + " wants to fight!"
				}).ShowDialog();
			}
			else
			{
				new TextWindow(new string[]
				{
					this.enemy.name + " wants to fight!"
				}).ShowDialog();
			}
			new TextWindow(new string[]
			{
				"Go! " + this.playerMon.nickname + '!'
			}).ShowDialog();
			this.update();
			this.preTurn();
		}
		private void Battle_FormClosed(object sender, FormClosedEventArgs e)
		{
			MusicPlayer.playBG(Player.Instance.currentMap.music);
		}
		private void btnFight_Click(object sender, EventArgs e)
		{
			this.btnMove1.Text = string.Concat(new object[]
			{
				this.playerMon.moveSet[0].name,
				' ',
				this.playerMon.PP[0],
				'/',
				(double)this.playerMon.moveSet[0].basePP + (double)this.playerMon.moveSet[0].basePP * 0.2 * (double)this.playerMon.PPbonuses[0]
			});
			this.pnlMoves.Visible = true;
		}
		private void btnBag_Click(object sender, EventArgs e)
		{
			this.commandPanel.Visible = false;
		}
		private void btnPokemon_Click(object sender, EventArgs e)
		{
			this.commandPanel.Visible = false;
			this.postTurn();
		}
		private void btnRun_Click(object sender, EventArgs e)
		{
			this.commandPanel.Visible = false;
			this.postTurn();
		}
		private void lblMove_Click(object sender, EventArgs e)
		{
			this.pnlMoves.Visible = false;
			this.commandPanel.Visible = false;
			byte b = 0;
			if (sender == this.btnMove1)
			{
				b = 0;
			}
			else
			{
				if (sender == this.btnMove2)
				{
					b = 1;
				}
				else
				{
					if (sender == this.btnMove3)
					{
						b = 2;
					}
					else
					{
						if (sender == this.btnMove4)
						{
							b = 3;
						}
					}
				}
			}
			this.playerMove = this.playerMon.moveSet[(int)b];
			byte[] expr_8F_cp_0 = this.playerMon.PP;
			--expr_8F_cp_0[b];
			this.postTurn();
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Battle));
			this.pbxEnemyPic = new PictureBox();
			this.pbxPlayerPic = new PictureBox();
			this.lblPlayerName = new Label();
			this.lblEnemyName = new Label();
			this.lblPlayerHP = new Label();
			this.commandPanel = new Panel();
			this.btnPokemon = new Button();
			this.btnRun = new Button();
			this.btnBag = new Button();
			this.btnFight = new Button();
			this.pnlMoves = new Panel();
			this.btnMove4 = new Button();
			this.btnMove3 = new Button();
			this.btnMove2 = new Button();
			this.btnMove1 = new Button();
			this.pbEnemy = new ProgressBar();
			this.lblEnemyHPPrompt = new Label();
			this.pbPlayer = new ProgressBar();
			this.lblPlayerHPPrompt = new Label();
			this.lblPlayerLevel = new Label();
			this.lblEnemyLevel = new Label();
			this.pnlLevelUpStats = new Panel();
			this.lblSpecialDefenseStat = new Label();
			this.lblSpecialAttackStat = new Label();
			this.lblSpeedStat = new Label();
			this.lblDefenseStat = new Label();
			this.lblAttackStat = new Label();
			this.lblEnemyArrow = new Label();
			this.lblPlayerArrow = new Label();
			this.pbExp = new ProgressBar();
			this.button1 = new Button();
			((ISupportInitialize)this.pbxEnemyPic).BeginInit();
			((ISupportInitialize)this.pbxPlayerPic).BeginInit();
			this.commandPanel.SuspendLayout();
			this.pnlMoves.SuspendLayout();
			this.pnlLevelUpStats.SuspendLayout();
			base.SuspendLayout();
			this.pbxEnemyPic.Location = new Point(256, 0);
			this.pbxEnemyPic.Margin = new Padding(4);
			this.pbxEnemyPic.Name = "pbxEnemyPic";
			this.pbxEnemyPic.Size = new Size(256, 256);
			this.pbxEnemyPic.TabIndex = 1;
			this.pbxEnemyPic.TabStop = false;
			this.pbxPlayerPic.Location = new Point(0, 128);
			this.pbxPlayerPic.Margin = new Padding(4);
			this.pbxPlayerPic.Name = "pbxPlayerPic";
			this.pbxPlayerPic.Size = new Size(256, 256);
			this.pbxPlayerPic.TabIndex = 2;
			this.pbxPlayerPic.TabStop = false;
			this.lblPlayerName.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblPlayerName.Location = new Point(296, 264);
			this.lblPlayerName.Margin = new Padding(4, 0, 4, 0);
			this.lblPlayerName.Name = "lblPlayerName";
			this.lblPlayerName.Size = new Size(160, 24);
			this.lblPlayerName.TabIndex = 3;
			this.lblPlayerName.Text = "MMMMMMMMMM";
			this.lblPlayerName.TextAlign = ContentAlignment.BottomLeft;
			this.lblEnemyName.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblEnemyName.Location = new Point(8, 40);
			this.lblEnemyName.Margin = new Padding(4, 0, 4, 0);
			this.lblEnemyName.Name = "lblEnemyName";
			this.lblEnemyName.Size = new Size(160, 24);
			this.lblEnemyName.TabIndex = 4;
			this.lblEnemyName.Text = "MMMMMMMMMM";
			this.lblEnemyName.TextAlign = ContentAlignment.BottomLeft;
			this.lblPlayerHP.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblPlayerHP.Location = new Point(408, 304);
			this.lblPlayerHP.Margin = new Padding(4, 0, 4, 0);
			this.lblPlayerHP.Name = "lblPlayerHP";
			this.lblPlayerHP.Size = new Size(88, 24);
			this.lblPlayerHP.TabIndex = 6;
			this.lblPlayerHP.Text = "777/777";
			this.lblPlayerHP.TextAlign = ContentAlignment.MiddleLeft;
			this.commandPanel.BorderStyle = BorderStyle.FixedSingle;
			this.commandPanel.Controls.Add(this.btnPokemon);
			this.commandPanel.Controls.Add(this.btnRun);
			this.commandPanel.Controls.Add(this.btnBag);
			this.commandPanel.Controls.Add(this.btnFight);
			this.commandPanel.Location = new Point(0, 385);
			this.commandPanel.Margin = new Padding(4);
			this.commandPanel.Name = "commandPanel";
			this.commandPanel.Size = new Size(512, 384);
			this.commandPanel.TabIndex = 9;
			this.commandPanel.Visible = false;
			this.btnPokemon.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnPokemon.BackColor = Color.ForestGreen;
			this.btnPokemon.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnPokemon.ForeColor = Color.White;
			this.btnPokemon.Location = new Point(352, 296);
			this.btnPokemon.Name = "btnPokemon";
			this.btnPokemon.Size = new Size(160, 80);
			this.btnPokemon.TabIndex = 7;
			this.btnPokemon.Text = "POKEMON";
			this.btnPokemon.UseVisualStyleBackColor = false;
			this.btnPokemon.Click += new EventHandler(this.btnPokemon_Click);
			this.btnRun.Anchor = AnchorStyles.Bottom;
			this.btnRun.BackColor = Color.DodgerBlue;
			this.btnRun.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnRun.ForeColor = Color.White;
			this.btnRun.Location = new Point(174, 304);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new Size(160, 80);
			this.btnRun.TabIndex = 6;
			this.btnRun.Text = "RUN";
			this.btnRun.UseVisualStyleBackColor = false;
			this.btnRun.Click += new EventHandler(this.btnRun_Click);
			this.btnBag.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.btnBag.BackColor = Color.Orange;
			this.btnBag.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnBag.ForeColor = Color.White;
			this.btnBag.Location = new Point(0, 296);
			this.btnBag.Name = "btnBag";
			this.btnBag.Size = new Size(160, 80);
			this.btnBag.TabIndex = 5;
			this.btnBag.Text = "BAG";
			this.btnBag.UseVisualStyleBackColor = false;
			this.btnBag.Click += new EventHandler(this.btnBag_Click);
			this.btnFight.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.btnFight.BackColor = Color.Red;
			this.btnFight.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnFight.ForeColor = Color.White;
			this.btnFight.ImageAlign = ContentAlignment.MiddleLeft;
			this.btnFight.Location = new Point(64, 32);
			this.btnFight.Name = "btnFight";
			this.btnFight.Size = new Size(384, 240);
			this.btnFight.TabIndex = 4;
			this.btnFight.Text = "FIGHT";
			this.btnFight.UseVisualStyleBackColor = false;
			this.btnFight.Click += new EventHandler(this.btnFight_Click);
			this.pnlMoves.BorderStyle = BorderStyle.FixedSingle;
			this.pnlMoves.Controls.Add(this.button1);
			this.pnlMoves.Controls.Add(this.btnMove4);
			this.pnlMoves.Controls.Add(this.btnMove3);
			this.pnlMoves.Controls.Add(this.btnMove2);
			this.pnlMoves.Controls.Add(this.btnMove1);
			this.pnlMoves.Location = new Point(0, 384);
			this.pnlMoves.Margin = new Padding(4);
			this.pnlMoves.Name = "pnlMoves";
			this.pnlMoves.Size = new Size(512, 384);
			this.pnlMoves.TabIndex = 10;
			this.pnlMoves.Visible = false;
			this.btnMove4.BackColor = Color.MediumPurple;
			this.btnMove4.ForeColor = Color.White;
			this.btnMove4.Location = new Point(264, 160);
			this.btnMove4.Name = "btnMove4";
			this.btnMove4.Size = new Size(240, 96);
			this.btnMove4.TabIndex = 7;
			this.btnMove4.Text = "button4";
			this.btnMove4.UseVisualStyleBackColor = false;
			this.btnMove4.Click += new EventHandler(this.lblMove_Click);
			this.btnMove3.BackColor = Color.MediumPurple;
			this.btnMove3.ForeColor = Color.White;
			this.btnMove3.Location = new Point(8, 160);
			this.btnMove3.Name = "btnMove3";
			this.btnMove3.Size = new Size(240, 96);
			this.btnMove3.TabIndex = 6;
			this.btnMove3.Text = "button3";
			this.btnMove3.UseVisualStyleBackColor = false;
			this.btnMove3.Click += new EventHandler(this.lblMove_Click);
			this.btnMove2.BackColor = Color.MediumPurple;
			this.btnMove2.ForeColor = Color.White;
			this.btnMove2.Location = new Point(264, 48);
			this.btnMove2.Name = "btnMove2";
			this.btnMove2.Size = new Size(240, 96);
			this.btnMove2.TabIndex = 5;
			this.btnMove2.Text = "button2";
			this.btnMove2.UseVisualStyleBackColor = false;
			this.btnMove2.Click += new EventHandler(this.lblMove_Click);
			this.btnMove1.BackColor = Color.MediumPurple;
			this.btnMove1.ForeColor = Color.White;
			this.btnMove1.Location = new Point(8, 48);
			this.btnMove1.Name = "btnMove1";
			this.btnMove1.Size = new Size(240, 96);
			this.btnMove1.TabIndex = 4;
			this.btnMove1.Text = "button1";
			this.btnMove1.UseVisualStyleBackColor = false;
			this.btnMove1.Click += new EventHandler(this.lblMove_Click);
			this.pbEnemy.Location = new Point(120, 64);
			this.pbEnemy.Margin = new Padding(4);
			this.pbEnemy.Name = "pbEnemy";
			this.pbEnemy.Size = new Size(96, 12);
			this.pbEnemy.Style = ProgressBarStyle.Continuous;
			this.pbEnemy.TabIndex = 11;
			this.pbEnemy.Value = 100;
			this.lblEnemyHPPrompt.BackColor = Color.Black;
			this.lblEnemyHPPrompt.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblEnemyHPPrompt.ForeColor = Color.Orange;
			this.lblEnemyHPPrompt.Location = new Point(92, 62);
			this.lblEnemyHPPrompt.Margin = new Padding(4, 0, 4, 0);
			this.lblEnemyHPPrompt.Name = "lblEnemyHPPrompt";
			this.lblEnemyHPPrompt.Size = new Size(128, 16);
			this.lblEnemyHPPrompt.TabIndex = 5;
			this.lblEnemyHPPrompt.Text = "HP:";
			this.lblEnemyHPPrompt.TextAlign = ContentAlignment.MiddleLeft;
			this.pbPlayer.Location = new Point(414, 290);
			this.pbPlayer.Margin = new Padding(4);
			this.pbPlayer.Name = "pbPlayer";
			this.pbPlayer.Size = new Size(96, 12);
			this.pbPlayer.Style = ProgressBarStyle.Continuous;
			this.pbPlayer.TabIndex = 12;
			this.pbPlayer.Value = 100;
			this.lblPlayerHPPrompt.BackColor = Color.Black;
			this.lblPlayerHPPrompt.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblPlayerHPPrompt.ForeColor = Color.Orange;
			this.lblPlayerHPPrompt.Location = new Point(384, 288);
			this.lblPlayerHPPrompt.Margin = new Padding(4, 0, 4, 0);
			this.lblPlayerHPPrompt.Name = "lblPlayerHPPrompt";
			this.lblPlayerHPPrompt.Size = new Size(128, 16);
			this.lblPlayerHPPrompt.TabIndex = 13;
			this.lblPlayerHPPrompt.Text = "HP:";
			this.lblPlayerHPPrompt.TextAlign = ContentAlignment.MiddleLeft;
			this.lblPlayerLevel.Location = new Point(456, 264);
			this.lblPlayerLevel.Margin = new Padding(4, 0, 4, 0);
			this.lblPlayerLevel.Name = "lblPlayerLevel";
			this.lblPlayerLevel.Size = new Size(55, 22);
			this.lblPlayerLevel.TabIndex = 14;
			this.lblPlayerLevel.Text = "Lv100";
			this.lblPlayerLevel.TextAlign = ContentAlignment.BottomRight;
			this.lblEnemyLevel.Location = new Point(168, 40);
			this.lblEnemyLevel.Margin = new Padding(4, 0, 4, 0);
			this.lblEnemyLevel.Name = "lblEnemyLevel";
			this.lblEnemyLevel.Size = new Size(56, 22);
			this.lblEnemyLevel.TabIndex = 15;
			this.lblEnemyLevel.Text = "Lv100";
			this.lblEnemyLevel.TextAlign = ContentAlignment.BottomRight;
			this.pnlLevelUpStats.BorderStyle = BorderStyle.FixedSingle;
			this.pnlLevelUpStats.Controls.Add(this.lblSpecialDefenseStat);
			this.pnlLevelUpStats.Controls.Add(this.lblSpecialAttackStat);
			this.pnlLevelUpStats.Controls.Add(this.lblSpeedStat);
			this.pnlLevelUpStats.Controls.Add(this.lblDefenseStat);
			this.pnlLevelUpStats.Controls.Add(this.lblAttackStat);
			this.pnlLevelUpStats.Location = new Point(256, 136);
			this.pnlLevelUpStats.Margin = new Padding(4);
			this.pnlLevelUpStats.Name = "pnlLevelUpStats";
			this.pnlLevelUpStats.Size = new Size(140, 122);
			this.pnlLevelUpStats.TabIndex = 16;
			this.pnlLevelUpStats.Visible = false;
			this.lblSpecialDefenseStat.Location = new Point(0, 72);
			this.lblSpecialDefenseStat.Margin = new Padding(4, 0, 4, 0);
			this.lblSpecialDefenseStat.Name = "lblSpecialDefenseStat";
			this.lblSpecialDefenseStat.Size = new Size(136, 24);
			this.lblSpecialDefenseStat.TabIndex = 4;
			this.lblSpecialDefenseStat.Text = "lblSpecialDefenseStat";
			this.lblSpecialDefenseStat.TextAlign = ContentAlignment.MiddleLeft;
			this.lblSpecialAttackStat.Location = new Point(0, 48);
			this.lblSpecialAttackStat.Margin = new Padding(4, 0, 4, 0);
			this.lblSpecialAttackStat.Name = "lblSpecialAttackStat";
			this.lblSpecialAttackStat.Size = new Size(136, 24);
			this.lblSpecialAttackStat.TabIndex = 3;
			this.lblSpecialAttackStat.Text = "lblSpecialAttackStat";
			this.lblSpecialAttackStat.TextAlign = ContentAlignment.MiddleLeft;
			this.lblSpeedStat.Location = new Point(0, 96);
			this.lblSpeedStat.Margin = new Padding(4, 0, 4, 0);
			this.lblSpeedStat.Name = "lblSpeedStat";
			this.lblSpeedStat.Size = new Size(136, 24);
			this.lblSpeedStat.TabIndex = 2;
			this.lblSpeedStat.Text = "lblSpeedStat";
			this.lblSpeedStat.TextAlign = ContentAlignment.MiddleLeft;
			this.lblDefenseStat.Location = new Point(0, 24);
			this.lblDefenseStat.Margin = new Padding(4, 0, 4, 0);
			this.lblDefenseStat.Name = "lblDefenseStat";
			this.lblDefenseStat.Size = new Size(136, 24);
			this.lblDefenseStat.TabIndex = 1;
			this.lblDefenseStat.Text = "lblDefenseStat";
			this.lblDefenseStat.TextAlign = ContentAlignment.MiddleLeft;
			this.lblAttackStat.Location = new Point(0, 0);
			this.lblAttackStat.Margin = new Padding(4, 0, 4, 0);
			this.lblAttackStat.Name = "lblAttackStat";
			this.lblAttackStat.Size = new Size(136, 24);
			this.lblAttackStat.TabIndex = 0;
			this.lblAttackStat.Text = "lblAttackStat";
			this.lblAttackStat.TextAlign = ContentAlignment.MiddleLeft;
			this.lblEnemyArrow.Location = new Point(8, 80);
			this.lblEnemyArrow.Name = "lblEnemyArrow";
			this.lblEnemyArrow.Size = new Size(248, 16);
			this.lblEnemyArrow.TabIndex = 17;
			this.lblEnemyArrow.Text = "------------------------------------>";
			this.lblEnemyArrow.TextAlign = ContentAlignment.MiddleRight;
			this.lblPlayerArrow.Location = new Point(256, 328);
			this.lblPlayerArrow.Name = "lblPlayerArrow";
			this.lblPlayerArrow.Size = new Size(256, 16);
			this.lblPlayerArrow.TabIndex = 18;
			this.lblPlayerArrow.Text = "<------------------------------------";
			this.lblPlayerArrow.TextAlign = ContentAlignment.MiddleLeft;
			this.pbExp.ForeColor = Color.Cyan;
			this.pbExp.Location = new Point(312, 344);
			this.pbExp.Margin = new Padding(4);
			this.pbExp.Name = "pbExp";
			this.pbExp.Size = new Size(200, 8);
			this.pbExp.Style = ProgressBarStyle.Continuous;
			this.pbExp.TabIndex = 19;
			this.pbExp.Value = 100;
			this.button1.BackColor = Color.DodgerBlue;
			this.button1.ForeColor = Color.White;
			this.button1.Location = new Point(16, 280);
			this.button1.Name = "button1";
			this.button1.Size = new Size(480, 96);
			this.button1.TabIndex = 8;
			this.button1.Text = "CANCEL";
			this.button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(510, 766);
			base.Controls.Add(this.pnlLevelUpStats);
			base.Controls.Add(this.pnlMoves);
			base.Controls.Add(this.commandPanel);
			base.Controls.Add(this.pbPlayer);
			base.Controls.Add(this.pbExp);
			base.Controls.Add(this.lblPlayerArrow);
			base.Controls.Add(this.lblEnemyArrow);
			base.Controls.Add(this.lblEnemyLevel);
			base.Controls.Add(this.lblPlayerLevel);
			base.Controls.Add(this.lblPlayerHPPrompt);
			base.Controls.Add(this.pbEnemy);
			base.Controls.Add(this.lblPlayerHP);
			base.Controls.Add(this.lblEnemyHPPrompt);
			base.Controls.Add(this.lblEnemyName);
			base.Controls.Add(this.lblPlayerName);
			base.Controls.Add(this.pbxPlayerPic);
			base.Controls.Add(this.pbxEnemyPic);
			this.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ForeColor = Color.Black;
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Battle";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Battle";
			base.TopMost = true;
			base.FormClosed += new FormClosedEventHandler(this.Battle_FormClosed);
			base.Load += new EventHandler(this.Battle_Load);
			((ISupportInitialize)this.pbxEnemyPic).EndInit();
			((ISupportInitialize)this.pbxPlayerPic).EndInit();
			this.commandPanel.ResumeLayout(false);
			this.pnlMoves.ResumeLayout(false);
			this.pnlLevelUpStats.ResumeLayout(false);
			base.ResumeLayout(false);
		}
	}
}
