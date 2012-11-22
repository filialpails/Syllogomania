using System;

namespace PokemonSharp
{
	public static class Moves
	{
		public static Move calculateHiddenPower(Pokemon target, Pokemon user)
		{
			int a = (user.hpIV % 2);
			int b = ((user.attackIV % 2) * 2);
			int c = ((user.defenseIV % 2) * 4);
			int d = ((user.speedIV % 2) * 8);
			int e = ((user.specialAttackIV % 2) * 16);
			int f = ((user.specialDefenseIV % 2) * 32);
			int elementint = ((a + b + c + d + e + f) * 15 / 63);
			Types element = Types.Normal;
			switch (elementint)
			{
				case 0: element = Types.Fighting; break;
				case 1: element = Types.Flying; break;
				case 2: element = Types.Poison; break;
				case 3: element = Types.Ground; break;
				case 4: element = Types.Rock; break;
				case 5: element = Types.Bug; break;
				case 6: element = Types.Ghost; break;
				case 7: element = Types.Steel; break;
				case 8: element = Types.Fire; break;
				case 9: element = Types.Water; break;
				case 10: element = Types.Grass; break;
				case 11: element = Types.Electric; break;
				case 12: element = Types.Psychic; break;
				case 13: element = Types.Ice; break;
				case 14: element = Types.Dragon; break;
				case 15: element = Types.Dark; break;
			}
			int u = (user.hpIV % 4 < 2 ? 1 : 0);
			int v = ((user.attackIV % 4 < 2 ? 1 : 0) * 2);
			int w = ((user.defenseIV % 4 < 2 ? 1 : 0) * 4);
			int x = ((user.speedIV % 4 < 2 ? 1 : 0) * 8);
			int y = ((user.specialAttackIV % 4 < 2 ? 1 : 0) * 16);
			int z = ((user.specialDefenseIV % 4 < 2 ? 1 : 0) * 32);
			byte power = (byte)((u + v + w + x + y + z) * 40 / 63 + 30);

			return new Move("Hidden Power", element, DamageCategory.Special, 15, power, 100, false);
		}
		public static byte calcFlail(int hp)
		{
			if (hp < 5) return 200;
			else if (hp <= 10) return 150;
			else if (hp <= 20) return 100;
			else if (hp <= 35) return 80;
			else if (hp <= 70) return 40;
			else return 20;
		}

		#region normal
		public static readonly Move Tackle		= new Move("Tackle",		Types.Normal, DamageCategory.Physical, 35, 35, 95, true);
		public static readonly Move Growl		= new Move("Growl",			Types.Normal, DamageCategory.Status, 40, 0, 100, false, (t, u, m) => { t.attackLevel--; });
		public static readonly Move Scratch		= new Move("Scratch",		Types.Normal, DamageCategory.Physical, 35, 40, 100, true);
		public static readonly Move Leer		= new Move("Leer",			Types.Normal, DamageCategory.Status, 30, 0, 100, false, (t, u, m) => { t.defenseLevel--; });
		public static readonly Move TailWhip	= new Move("Tail Whip",		Types.Normal, DamageCategory.Status, 30, 0, 100, false, (t, u, m) => { t.defenseLevel--; });
		public static readonly Move SandAttack	= new Move("Sand-Attack",	Types.Normal, DamageCategory.Status, 35, 0, 100, false, (t, u, m) => { t.accuracyLevel--; });
		public static readonly Move Screech		= new Move("Screech",		Types.Normal, DamageCategory.Status, 40, 0, 85, false, (t, u, m) => { t.defenseLevel -= 2; });
		public static readonly Move Recover		= new Move("Recover",		Types.Normal, DamageCategory.Status, 10, 0, 100, false, (t, u, m) => { if (u.HP != u.MaxHP && (u.MaxHP - u.HP) % 256 != 255) u.HP += (ushort)(PRNG.Instance.Next(51) * 0.01 * u.MaxHP); });
		public static readonly Move Flash		= new Move("Flash",			Types.Normal, DamageCategory.Status, 20, 0, 70, false, (t, u, m) => { t.accuracyLevel--; }, 70);
		public static readonly Move Cut			= new Move("Cut",			Types.Normal, DamageCategory.Physical, 30, 50, 95, true);
		public static readonly Move Strength	= new Move("Strength",		Types.Normal, DamageCategory.Physical, 15, 80, 100, true);
		public static readonly Move TakeDown	= new Move("Take Down",		Types.Normal, DamageCategory.Physical, 20, 90, 85, true, (t, u, m) => { u.HP -= (ushort)(1 >> 1); });
		public static readonly Move SmokeScreen	= new Move("SmokeScreen",	Types.Normal, DamageCategory.Status, 20, 0, 100, false, (t, u, m) => { t.accuracyLevel--; });
		public static readonly Move ScaryFace	= new Move("Scary Face",	Types.Normal, DamageCategory.Status, 10, 0, 90, false, (t, u, m) => { t.speedLevel -= 2; });
		public static readonly Move RapidSpin	= new Move("Rapid Spin",	Types.Normal, DamageCategory.Physical, 40, 20, 100, true, (t, u, m) => { u.removeVolStatus(VolatileAilments.LeechSeed | VolatileAilments.Trapped); });
		public static readonly Move MeanLook	= new Move("Mean Look",		Types.Normal, DamageCategory.Status, 5, 0, 100, false); //NYI
		public static readonly Move Disable		= new Move("Disable",		Types.Normal, DamageCategory.Status, 20, 0, 80, false); //NYI
		public static readonly Move Swift		= new Move("Swift",			Types.Normal, DamageCategory.Special, 20, 20, 100, false); //NYI
		public static readonly Move Struggle	= new Move("Struggle",		Types.Normal, DamageCategory.Physical, 255, 50, 100, true, (t, u, m) => { u.HP -= (ushort)(u.MaxHP >> 2); });
		public static readonly Move Harden		= new Move("Harden",		Types.Normal, DamageCategory.Status, 30, 0, 100, false, (t, u, m) => { t.defenseLevel++; });
		public static readonly Move QuickAttack	= new Move("Quick Attack",	Types.Normal, DamageCategory.Physical, 30, 40, 100, true, 1);
		public static readonly Move FocusEnergy	= new Move("Focus Energy",	Types.Normal, DamageCategory.Status, 30, 0, 100, false); //NYI
		public static readonly Move HyperFang	= new Move("Hyper Fang",	Types.Normal, DamageCategory.Physical, 15, 80, 90, true, (t, u, m) => { t.addVolStatus(VolatileAilments.Flinch); }, 10 );
		public static readonly Move Safeguard	= new Move("Safeguard",		Types.Normal, DamageCategory.Status, 25, 0, 100, false); //NYI
		public static readonly Move Pound		= new Move("Pound",			Types.Normal, DamageCategory.Physical, 35, 40, 100, true);
		public static readonly Move MirrorType	= new Move("Mirror Type",	Types.Normal, DamageCategory.Special, 15, 0, 100, false); //NYI
		public static readonly Move Roar		= new Move("Roar",			Types.Normal, DamageCategory.Status, 20, 0, 100, false, -6); //NYI
		public static readonly Move HiddenPower = new Move("Hidden Power",	Types.Normal, DamageCategory.Special, 15, 0, 100, false, (t, u, m) => { calculateHiddenPower(t, u); });
		public static readonly Move HyperBeam	= new Move("Hyper Beam",	Types.Normal, DamageCategory.Special, 5, 150, 90, false); //NYI
		public static readonly Move DoubleTeam = new Move("Double Team", Types.Normal, DamageCategory.Status, 15, 0, 100, false, (t, u, m) => { u.evasionLevel++; });
		public static readonly Move Frustration = new Move("Frustration", Types.Normal, DamageCategory.Physical, 20, 0, 100, true, (t, u, m) => { new Move("Frustration", Types.Normal, DamageCategory.Physical, 20, (byte)((255 - u.happiness) * 0.4), 100, true); });
		public static readonly Move Protect = new Move("Protect", Types.Normal, DamageCategory.Status, 10, 0, 100, false); //NYI
		public static readonly Move Return = new Move("Return", Types.Normal, DamageCategory.Physical, 20, 0, 100, true, (t, u, m) => { new Move("Return", Types.Normal, DamageCategory.Physical, 20, (byte)(u.happiness * 0.4), 100, true); });
		public static readonly Move Attract = new Move("Attract", Types.Normal, DamageCategory.Status, 15, 0, 100, false, (t, u, m) => { if (u.gender != t.gender) t.addVolStatus(VolatileAilments.Infatuation); });
		public static readonly Move Splash = new Move("Splash", Types.Normal, DamageCategory.Status, 40, 0, 0, false);
		public static readonly Move Flail = new Move("Flail", Types.Normal, DamageCategory.Physical, 15, 0, 100, true, (t, u, m) => { new Move("Flail", Types.Normal, DamageCategory.Physical, 15, calcFlail(u.HP / u.MaxHP * 100), 100, true); });
		#endregion
		#region fighting
		public static readonly Move RollingKick = new Move("ROLLING KICK", Types.Fighting, DamageCategory.Physical, 15, 60, 85, true, (t, u, m) => { t.addVolStatus(VolatileAilments.Flinch); });
		#endregion
		#region flying
		public static readonly Move Peck = new Move("PECK", Types.Flying, DamageCategory.Physical, 35, 35, 100, true);
		public static readonly Move DrillPeck = new Move("DRILL PECK", Types.Flying, DamageCategory.Physical, 20, 80, 100, true);
		public static readonly Move Fly = new Move("FLY", Types.Flying, DamageCategory.Physical, 15, 70, 95, true); //NYI
		public static readonly Move Gust = new Move("Gust", Types.Flying, DamageCategory.Special, 35, 40, 100, false);
		public static readonly Move Whirlwind = new Move("Whirlwind", Types.Flying, DamageCategory.Status, 20, 0, 100, false); //NYI
		#endregion
		#region poison
		public static readonly Move PoisonPowder = new Move("PoisonPowder", Types.Poison, DamageCategory.Status, 35, 0, 75, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Poison; });
		public static readonly Move Toxic = new Move("Toxic", Types.Poison, DamageCategory.Status, 10, 0, 90, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.BadPoison; });
		public static readonly Move SludgeBomb = new Move("Sludge Bomb", Types.Poison, DamageCategory.Special, 10, 90, 100, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Poison; }, 30);
		#endregion
		#region ground
		public static readonly Move Earthquake = new Move("Earthquake", Types.Ground, DamageCategory.Physical, 10, 100, 100, false);
		public static readonly Move Dig = new Move("Dig", Types.Ground, DamageCategory.Physical, 10, 80, 100, true);
		#endregion
		#region rock
		public static readonly Move Sandstorm = new Move("Sandstorm", Types.Rock, DamageCategory.Status, 10, 0, 100, false, (t, u, m) => World.weather = Weather.Sandstorm);
		#endregion
		#region bug
		public static readonly Move BugBite = new Move("Bug Bite", Types.Bug, DamageCategory.Physical, 20, 60, 100, true);
		public static readonly Move StringShot = new Move("String Shot", Types.Bug, DamageCategory.Status, 40, 0, 95, false, (t, u, m) => { t.speedLevel--; });
		#endregion
		#region ghost
		public static readonly Move Spite = new Move("Spite", Types.Ghost, DamageCategory.Status, 10, 0, 100, false, (t, u, m) => { t.PP[m] -= 4; });
		public static readonly Move Curse = new Move("Curse", Types.Ghost, DamageCategory.Status, 10, 0, 100, false, (t, u, m) => { t.addVolStatus(VolatileAilments.Curse); });
		public static readonly Move NightShade = new Move("Night Shade", Types.Ghost, DamageCategory.Special, 15, 0, 100, false, (t, u, m) => { t.HP -= u.Level; });
		public static readonly Move ConfuseRay = new Move("Confuse Ray", Types.Ghost, DamageCategory.Status, 10, 0, 100, false, (t, u, m) => { t.addVolStatus(VolatileAilments.Confusion); });
		public static readonly Move Lick = new Move("Lick", Types.Ghost, DamageCategory.Physical, 30, 20, 100, true, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Paralyze; }, 30);
		public static readonly Move ShadowBall = new Move("Shadow Ball", Types.Ghost, DamageCategory.Special, 15, 80, 100, false, (t, u, m) => { t.specialDefenseLevel--; }, 20);
		#endregion
		//steel
		#region fire
		public static readonly Move Ember = new Move("EMBER", Types.Fire, DamageCategory.Special, 25, 40, 100, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Burn; }, 10);
		public static readonly Move FirePunch = new Move("FIRE PUNCH", Types.Fire, DamageCategory.Physical, 15, 75, 100, true, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Burn; }, 10);
		public static readonly Move Flamethrower = new Move("FLAMETHROWER", Types.Fire, DamageCategory.Special, 15, 95, 100, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Burn; }, 10);
		public static readonly Move FireSpin = new Move("FIRE SPIN", Types.Fire, DamageCategory.Special, 15, 35, 85, false, (t, u, m) => { t.addVolStatus(VolatileAilments.Trapped); });
		public static readonly Move FireBlast = new Move("FIRE BLAST", Types.Fire, DamageCategory.Special, 5, 120, 85, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Burn; }, 30);
		public static readonly Move SunnyDay = new Move("Sunny Day", Types.Fire, DamageCategory.Status, 5, 0, 100, false, (t, u, m) => { /*UI.Battle.weather = Weather.IntenseSunlight;*/ });
		#endregion
		#region water
		public static readonly Move Bubble = new Move("BUBBLE", Types.Water, DamageCategory.Special, 30, 20, 100, false, (t, u, m) => { t.speedLevel--; }, 10);
		public static readonly Move Bubblebeam = new Move("BUBBLEBEAM", Types.Water, DamageCategory.Special, 20, 65, 100, false, (t, u, m) => { t.speedLevel--; }, 10);
		public static readonly Move WaterGun = new Move("WATER GUN", Types.Water, DamageCategory.Special, 25, 40, 100, false);
		public static readonly Move Waterfall = new Move("WATERFALL", Types.Water, DamageCategory.Special, 15, 80, 100, false);
		public static readonly Move HydroPump = new Move("HYDRO PUMP", Types.Water, DamageCategory.Special, 5, 120, 80, false);
		public static readonly Move Surf = new Move("SURF", Types.Water, DamageCategory.Special, 15, 95, 100, false);
		public static readonly Move Withdraw = new Move("Withdraw", Types.Water, DamageCategory.Status, 40, 0, 100, false, (t, u, m) => { t.defenseLevel--; });
		public static readonly Move RainDance = new Move("Rain Dance", Types.Water, DamageCategory.Status, 5, 0, 100, false, (t, u, m) => { /*UI.Battle.weather = Weather.HeavyRain;*/ });
		#endregion
		#region grass
		public static readonly Move LeechSeed = new Move("LEECH SEED", Types.Grass, DamageCategory.Status, 10, 0, 90, false, (t, u, m) => { t.addVolStatus(VolatileAilments.LeechSeed); });
		public static readonly Move VineWhip = new Move("VINE WHIP", Types.Grass, DamageCategory.Physical, 10, 35, 100, true);
		public static readonly Move RazorLeaf = new Move("RAZOR LEAF", Types.Grass, DamageCategory.Physical, 25, 55, 95, false);
		public static readonly Move SleepPowder = new Move("SleepPowder", Types.Grass, DamageCategory.Status, 15, 0, 75, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Sleep; });
		public static readonly Move SolarBeam = new Move("Solar Beam", Types.Grass, DamageCategory.Special, 10, 120, 100, false);
		#endregion
		#region electric
		public static readonly Move ThunderShock = new Move("ThunderShock", Types.Electric, DamageCategory.Special, 30, 40, 100, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Paralyze; }, 10);
		public static readonly Move ThunderWave = new Move("Thunder Wave", Types.Electric, DamageCategory.Special, 20, 0, 100, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Paralyze; });
		public static readonly Move Thunderpunch = new Move("Thunderpunch", Types.Electric, DamageCategory.Physical, 15, 75, 100, true, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Paralyze; }, 10);
		public static readonly Move Thunderbolt = new Move("Thunderbolt", Types.Electric, DamageCategory.Special, 15, 95, 100, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Paralyze; }, 10);
		public static readonly Move Thunder = new Move("Thunder", Types.Electric, DamageCategory.Special, 10, 120, 70, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Paralyze; }, 30);
		#endregion
		#region psychic
		public static readonly Move Hypnosis = new Move("Hypnosis", Types.Psychic, DamageCategory.Status, 20, 0, 60, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Sleep; });
		public static readonly Move Confusion = new Move("Confusion", Types.Psychic, DamageCategory.Special, 25, 50, 100, false, (t, u, m) => { t.addVolStatus(VolatileAilments.Confusion); }, 10);
		public static readonly Move Barrier = new Move("Barrier", Types.Psychic, DamageCategory.Status, 30, 0, 100, false, (t, u, m) => { u.defenseLevel += 2; });
		public static readonly Move FutureSight = new Move("Future Sight", Types.Psychic, DamageCategory.Special, 15, 0, 100, false, (t, u, m) => { /*futuresight*/ }, 90);
		public static readonly Move Psychic = new Move("Psychic", Types.Psychic, DamageCategory.Special, 10, 90, 100, false, (t, u, m) => { t.specialDefenseLevel--; }, 10);
		public static readonly Move Rest = new Move("Rest", Types.Psychic, DamageCategory.Status, 10, 0, 100, false, (t, u, m) => { u.NonVolStatus = NonVolatileAilment.Sleep; u.sleepTime = 3; u.HP = u.MaxHP; });
		#endregion
		#region ice
		public static readonly Move AuroraBeam = new Move("AURORA BEAM", Types.Ice, DamageCategory.Special, 20, 65, 100, false, (t, u, m) => { t.attackLevel--; }, 10);
		public static readonly Move IcePunch = new Move("ICE PUNCH", Types.Ice, DamageCategory.Physical, 15, 75, 100, true, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Freeze; }, 10);
		public static readonly Move IceBeam = new Move("ICE BEAM", Types.Ice, DamageCategory.Special, 10, 95, 100, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Freeze; }, 10);
		public static readonly Move Blizzard = new Move("BLIZZARD", Types.Ice, DamageCategory.Special, 5, 120, 90, false, (t, u, m) => { t.NonVolStatus = NonVolatileAilment.Freeze; }, 10);
		#endregion
		#region dragon
		public static readonly Move DragonRage = new Move("Dragon Rage", Types.Dragon, DamageCategory.Special, 10, 0, 100, false, (t, u, m) => { t.HP -= 40; });
		public static readonly Move Twister = new Move("Twister", Types.Dragon, DamageCategory.Special, 20, 40, 100, false, (t, u, m) => { t.addVolStatus(VolatileAilments.Flinch); }, 20);
		#endregion
		#region dark
		public static readonly Move Bite = new Move("Bite", Types.Dark, DamageCategory.Physical, 25, 60, 100, true, (t, u, m) => { t.addVolStatus(VolatileAilments.Flinch); }, 30);
		public static readonly Move Pursuit = new Move("Pursuit", Types.Dark, DamageCategory.Physical, 20, 40, 100, true, (t, u, m) => { /* unique = "pursuit"; */ });
		public static readonly Move SuckerPunch = new Move("Sucker Punch", Types.Dark, DamageCategory.Physical, 5, 80, 100, true);
		public static readonly Move NastyPlot = new Move("Nasty Plot", Types.Dark, DamageCategory.Status, 20, 0, 100, false, (t, u, m) => { u.specialAttackLevel += 2; });
		public static readonly Move Thief = new Move("Thief", Types.Dark, DamageCategory.Physical, 10, 40, 100, true, (t, u, m) => { u.heldItem = t.heldItem; t.heldItem = null; });
		#endregion

		#region TMs
		public static readonly TM TM05 = new TM(5, Roar);
		public static readonly TM TM06 = new TM(6, Toxic);
		public static readonly TM TM10 = new TM(10, HiddenPower);
		public static readonly TM TM11 = new TM(11, SunnyDay);
		public static readonly TM TM14 = new TM(14, Blizzard);
		public static readonly TM TM15 = new TM(15, HyperBeam);
		public static readonly TM TM17 = new TM(17, Protect);
		public static readonly TM TM18 = new TM(18, RainDance);
		public static readonly TM TM21 = new TM(21, Frustration);
		public static readonly TM TM22 = new TM(22, SolarBeam);
		public static readonly TM TM25 = new TM(25, Thunder);
		public static readonly TM TM26 = new TM(26, Earthquake);
		public static readonly TM TM27 = new TM(27, Return);
		public static readonly TM TM28 = new TM(28, Dig);
		public static readonly TM TM29 = new TM(29, Psychic);
		public static readonly TM TM30 = new TM(30, ShadowBall);
		public static readonly TM TM32 = new TM(32, DoubleTeam);
		public static readonly TM TM36 = new TM(36, SludgeBomb);
		public static readonly TM TM37 = new TM(37, Sandstorm);
		public static readonly TM TM38 = new TM(38, FireBlast);
		public static readonly TM TM44 = new TM(44, Rest);
		public static readonly TM TM45 = new TM(45, Attract);
		public static readonly TM TM46 = new TM(46, Thief);
		#endregion
		#region HMs
		public static readonly HM HM01 = new HM(1, Cut, null);
		public static readonly HM HM02 = new HM(2, Fly, null);
		public static readonly HM HM03 = new HM(3, Surf, null);
		public static readonly HM HM04 = new HM(4, Strength, null);
		public static readonly HM HM05 = new HM(5, Flash, null);
		#endregion
	}
}