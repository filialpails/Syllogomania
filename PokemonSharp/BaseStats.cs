using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PokemonSharp
{
	public sealed class BaseStats
	{
		public readonly ushort id;
		public readonly string name;

		public readonly byte baseHP;
		public readonly byte baseAttack;
		public readonly byte baseDefense;
		public readonly byte baseSpeed;
		public readonly byte baseSpecialAttack;
		public readonly byte baseSpecialDefense;
		public readonly Types types;
		public readonly byte catchRate;
		public readonly byte expYield;
		public readonly ushort evYield;
		public readonly Item[] wildHeldItems = new Item[2];
		public readonly GenderRatio genderRatio;
		public readonly byte eggSteps;
		public readonly byte baseHappiness;
		public readonly GrowthRate growthRate;
		public readonly EggGroups eggGroups;

		public readonly Ability[] abilities;
		//public readonly byte safariRate;
		public readonly PokemonColor color;
		public readonly Dictionary<TM, bool> TMflags;

		public readonly LearnableMove[] learnset;
		public readonly PokedexEntry entry;
		public readonly IEvolution[] evolutions;
		public readonly Bitmap frontImg;
		public readonly Bitmap backImg;
		public readonly Bitmap shinyFrontImg;
		public readonly Bitmap shinyBackImg;

		public BaseStats(ushort i, string n, byte h, byte atk, byte def, byte satk, byte sdef, byte spd, Types t, byte ctch, byte exp, ushort ev, GenderRatio gender, GrowthRate growth, EggGroups eg, Ability[] ab, LearnableMove[] ls, PokedexEntry pe, IEvolution[] evo = null)
		{
			id = i;
			name = n;

			baseHP = h;
			baseAttack = atk;
			baseDefense = def;
			baseSpeed = sdef;
			baseSpecialAttack = satk;
			baseSpecialDefense = spd;
			types = t;
			catchRate = ctch;
			expYield = exp;
			evYield = ev;
			genderRatio = gender;
			/* 0	Arceus, Buneary, Darkrai, Deoxys, Deoxys (Attack), Deoxys (Defense), Deoxys (Speed), Dialga, Genosekuto, Giratina (Altered), Giratina (Origin), Groudon, Ho-oh, Kyogre, Kyuremu, Lugia, Mewtwo, Palkia, Rayquaza, Regigigas, Reshiram, Zekrom
			 * 35	Absol, Aggron, Aron, Articuno, Axew, Bagon, Banette, Baruchai, Barujiina, Beldum, Birijion, Cacnea, Cacturne, Carvanha, Chatot, Dragonair, Dragonite, Dratini, Dusclops, Dusknoir, Duskull, Entei, Fraxure, Gallade, Gardevoir, Glaceon, Haxorus, Honchkrow, Houndoom, Houndour, Jiheddo, Kerudio, Kirikizan, Kirlia, Kobaruon, Komatana, Lairon, Larvitar, Leafeon, Metagross, Metang, Misdreavus, Mismagius, Moltres, Monozu, Murkrow, Pupitar, Raikou, Ralts, Regice, Regirock, Registeel, Sableye, Salamence, Sazandora, Sharpedo, Shelgon, Shuppet, Sneasel, Suicune, Terakion, Tyranitar, Umbreon, Weavile, Zapdos, Zuruggu
			 * 70	All other Pokemon
			 * 90	Borutorosu, Latias, Latios, Randorosu, Torunerosu
			 * 100	Ambipom, Celebi, Cresselia, Croagunk, Heatran, Jirachi, Luxio, Meroetta, Meroetta, Mew, Pachirisu, Shaymin, Shaymin (Sky), Victini
			 * 140	Azelf, Blissey, Chansey, Clefable, Clefairy, Cleffa, Happiny, Lopunny, Mesprit, Uxie
			 */
			if (i == 150) baseHappiness = 0;
			else if (i >= 144 && i <= 149) baseHappiness = 35;
			else if (i == 151) baseHappiness = 100;
			else baseHappiness = 70;
			growthRate = growth;
			eggGroups = eg;
			abilities = ab;
			learnset = ls;
			entry = pe;
			evolutions = evo;
		}

		private static readonly PokedexEntry blank = new PokedexEntry("Unknown", 0, 0, "This space intentionally left blank.");
		private static readonly LearnableMove[] noMoves = { };

		#region moves
		private static readonly LearnableMove[] BulbasaurMoves =
		{
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.Growl,			3),
			new LearnableMove(Moves.LeechSeed,		7),
			new LearnableMove(Moves.VineWhip,		9),
			new LearnableMove(Moves.PoisonPowder,	13),
			new	LearnableMove(Moves.SleepPowder,	13),
			new LearnableMove(Moves.TakeDown,		15),
			new LearnableMove(Moves.RazorLeaf,		19),
			//new LearnableMove(Moves.SweetScent,		21),
			//new LearnableMove(Moves.Growth,			25),
			//new LearnableMove(Moves.DoubleEdge,		27),
			//new LearnableMove(Moves.WorrySeed,		31),
			//new LearnableMove(Moves.Synthesis,		33),
			//new LearnableMove(Moves.SeedBomb,		37)
		};
		private static readonly LearnableMove[] IvysaurMoves =
		{
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.Growl,			1),
			new LearnableMove(Moves.LeechSeed,		1),
			new LearnableMove(Moves.Growl,			3),
			new LearnableMove(Moves.LeechSeed,		7),
			new LearnableMove(Moves.VineWhip,		9),
			new LearnableMove(Moves.PoisonPowder,	13),
			new LearnableMove(Moves.SleepPowder,	13),
			new LearnableMove(Moves.TakeDown,		15),
			new LearnableMove(Moves.RazorLeaf,		20),
			//new LearnableMove(Moves.SweetScent,		23),
			//new LearnableMove(Moves.Growth,			28),
			//new LearnableMove(Moves.DoubleEdge,		31),
			//new LearnableMove(Moves.WorrySeed,		36),
			//new LearnableMove(Moves.Synthesis,		39),
			//new LearnableMove(Moves.SolarBeam,		44)
		};
		private static readonly LearnableMove[] VenusaurMoves =
		{
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.Growl,			1),
			new LearnableMove(Moves.LeechSeed,		1),
			new LearnableMove(Moves.VineWhip,		1),
			new LearnableMove(Moves.Growl,			3),
			new LearnableMove(Moves.LeechSeed,		7),
			new LearnableMove(Moves.VineWhip,		9),
			new LearnableMove(Moves.PoisonPowder,	13),
			new LearnableMove(Moves.SleepPowder,	13),
			new LearnableMove(Moves.TakeDown,		15),
			new LearnableMove(Moves.RazorLeaf,		20),
			//new LearnableMove(Moves.SweetScent,		23),
			//new LearnableMove(Moves.Growth,			28),
			//new LearnableMove(Moves.DoubleEdge,		31),
			//new LearnableMove(Moves.PetalDance,		32),
			//new LearnableMove(Moves.WorrySeed,		39),
			//new LearnableMove(Moves.Synthesis,		45),
			//new LearnableMove(Moves.SolarBeam,		53)
		};
		private static readonly LearnableMove[] CharmanderMoves =
		{
			new LearnableMove(Moves.Scratch,		1),
			new LearnableMove(Moves.Growl,			1),
			new LearnableMove(Moves.Ember,			7),
			new LearnableMove(Moves.SmokeScreen,	10),
			new LearnableMove(Moves.DragonRage,		16),
			new LearnableMove(Moves.ScaryFace,		19),
			//new LearnableMove(Moves.FireFang,		25),
			//new LearnableMove(Moves.FlameBurst,		28),
			//new LearnableMove(Moves.Slash,			34),
			new LearnableMove(Moves.Flamethrower,	37),
			new LearnableMove(Moves.FireSpin,		43),
			//new LearnableMove(Moves.Purgatory,		46)
		};
		private static readonly LearnableMove[] CharmeleonMoves =
		{
			new LearnableMove(Moves.Scratch,		1),
			new LearnableMove(Moves.Growl,			1),
			new LearnableMove(Moves.Ember,			1),
			new LearnableMove(Moves.Ember,			7),
			new LearnableMove(Moves.SmokeScreen,	10),
			new LearnableMove(Moves.DragonRage,		17),
			new LearnableMove(Moves.ScaryFace,		21),
			//new LearnableMove(Moves.FireFang,		28),
			//new LearnableMove(Moves.FlameBurst,		32),
			//new LearnableMove(Moves.Slash,			39),
			new LearnableMove(Moves.Flamethrower,	43),
			new LearnableMove(Moves.FireSpin,		50),
			//new LearnableMove(Moves.Purgatory,		54)
		};
		private static readonly LearnableMove[] CharizardMoves =
		{
			//new LearnableMove(Moves.DragonClaw,		1),
			//new LearnableMove(Moves.ShadowClaw,		1),
			//new LearnableMove(Moves.AirSlash,		1),
			new LearnableMove(Moves.Scratch,		1),
			new LearnableMove(Moves.Growl,			1),
			new LearnableMove(Moves.Ember,			1),
			new LearnableMove(Moves.SmokeScreen,	1),
			new LearnableMove(Moves.Ember,			7),
			new LearnableMove(Moves.SmokeScreen,	10),
			new LearnableMove(Moves.DragonRage,		17),
			new LearnableMove(Moves.ScaryFace,		21),
			//new LearnableMove(Moves.FireFang,		28),
			//new LearnableMove(Moves.FlameBurst,		32),
			//new LearnableMove(Moves.WingAttack,		36),
			//new LearnableMove(Moves.Slash,			41),
			new LearnableMove(Moves.Flamethrower,	47),
			new LearnableMove(Moves.FireSpin,		56),
			//new LearnableMove(Moves.Purgatory,		62),
			//new LearnableMove(Moves.HeatWave,		71),
			//new LearnableMove(Moves.FlareBlitz,		77)
		};
		private static readonly LearnableMove[] SquirtleMoves =
		{
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.TailWhip,		4),
			new LearnableMove(Moves.Bubble,			7),
			new LearnableMove(Moves.Withdraw,		10),
			new LearnableMove(Moves.WaterGun,		13),
			new LearnableMove(Moves.Bite,			16),
			new LearnableMove(Moves.RapidSpin,		19),
			new LearnableMove(Moves.Protect,		22),
			//new LearnableMove(Moves.WaterPulse,		25),
			//new LearnableMove(Moves.AquaTail,		28),
			//new LearnableMove(Moves.SkullBash,		31),
			//new LearnableMove(Moves.IronDefense,	34),
			new LearnableMove(Moves.RainDance,		37),
			//new LearnableMove(Moves.HydroPump,		40)
		};
		private static readonly LearnableMove[] WartortleMoves =
		{
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.TailWhip,		1),
			new LearnableMove(Moves.Bubble,			1),
			new LearnableMove(Moves.TailWhip,		4),
			new LearnableMove(Moves.Bubble,			7),
			new LearnableMove(Moves.Withdraw,		10),
			new LearnableMove(Moves.WaterGun,		13),
			new LearnableMove(Moves.Bite,			16),
			new LearnableMove(Moves.RapidSpin,		20),
			new LearnableMove(Moves.Protect,		24),
			//new LearnableMove(Moves.WaterPulse,		28),
			//new LearnableMove(Moves.AquaTail,		32),
			//new LearnableMove(Moves.SkullBash,		36),
			//new LearnableMove(Moves.IronDefense,	40),
			new LearnableMove(Moves.RainDance,		44),
			//new LearnableMove(Moves.HydroPump,		48)
		};
		private static readonly LearnableMove[] BlastoiseMoves =
		{
			//new LearnableMove(Moves.FlashCannon,	1),
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.TailWhip,		1),
			new LearnableMove(Moves.Bubble,			1),
			new LearnableMove(Moves.Withdraw,		1),
			new LearnableMove(Moves.TailWhip,		4),
			new LearnableMove(Moves.Bubble,			7),
			new LearnableMove(Moves.Withdraw,		10),
			new LearnableMove(Moves.WaterGun,		13),
			new LearnableMove(Moves.Bite,			16),
			new LearnableMove(Moves.RapidSpin,		20),
			new LearnableMove(Moves.Protect,		24),
			//new LearnableMove(Moves.WaterPulse,		28),
			//new LearnableMove(Moves.AquaTail,		32),
			//new LearnableMove(Moves.SkullBash,		39),
			//new LearnableMove(Moves.IronDefense,	46),
			new LearnableMove(Moves.RainDance,		53),
			//new LearnableMove(Moves.HydroPump,		60)
		};
		private static readonly LearnableMove[] CaterpieMoves =
		{
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.StringShot,		1),
			new LearnableMove(Moves.BugBite,		15)
		};
		private static readonly LearnableMove[] MetapodMoves =
		{
			new LearnableMove(Moves.Harden,			1),
			new LearnableMove(Moves.Harden,			7)
		};
		private static readonly LearnableMove[] ButterfreeMoves =
		{
			new LearnableMove(Moves.Confusion,		1),
			new LearnableMove(Moves.Confusion,		10),
			new LearnableMove(Moves.PoisonPowder,	12),
			//new LearnableMove(Moves.stunSpore,		12),
			new LearnableMove(Moves.SleepPowder,	12),
			new LearnableMove(Moves.Gust,			16),
			//new LearnableMove(Moves.supersonic,		18),
			new LearnableMove(Moves.Whirlwind,		22),
			//new LearnableMove(Moves.psyBeam,		24),
			//new LearnableMove(Moves.silverWind,		28),
			//new LearnableMove(Moves.tailwind,	30),
			//new LearnableMove(Moves.angelPowder,	34),
			new LearnableMove(Moves.Safeguard,	36),
			//new LearnableMove(Moves.captivate,	40),
			//new LearnableMove(Moves.buggBuzz,	42),
			//new LearnableMove(Moves.butterflyDance,	46),
		};
		private static readonly LearnableMove[] PidgeyMoves =
		{
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.SandAttack,		5),
			new LearnableMove(Moves.Gust,			9),
			new LearnableMove(Moves.QuickAttack,	13),
			new LearnableMove(Moves.Whirlwind,		17),
			new LearnableMove(Moves.Twister,		21),
			//new LearnableMove(Moves.FeatherDance,	25),
			//new LearnableMove(Moves.Agility,		29),
			//new LearnableMove(Moves.WingAttack,		33),
			//new LearnableMove(Moves.Roost,			37),
			//new LearnableMove(Moves.TailWind,		41),
			//new LearnableMove(Moves.MirrorMove,		45),
			//new LearnableMove(Moves.AirSlash,		49),
			//new LearnableMove(Moves.Hurricane,		53)
		};
		private static readonly LearnableMove[] PidgeottoMoves =
		{
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.SandAttack,		1),
			new LearnableMove(Moves.Gust,			1),
			new LearnableMove(Moves.SandAttack,		5),
			new LearnableMove(Moves.Gust,			9),
			new LearnableMove(Moves.QuickAttack,	13),
			new LearnableMove(Moves.Whirlwind,		17),
			new LearnableMove(Moves.Twister,		22),
			//new LearnableMove(Moves.FeatherDance,	27),
			//new LearnableMove(Moves.Agility,		32),
			//new LearnableMove(Moves.WingAttack,		37),
			//new LearnableMove(Moves.Roost,			42),
			//new LearnableMove(Moves.TailWind,		47),
			//new LearnableMove(Moves.MirrorMove,		52),
			//new LearnableMove(Moves.AirSlash,		57),
			//new LearnableMove(Moves.Hurricane,		62)
		};
		private static readonly LearnableMove[] PidgeotMoves =
		{
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.SandAttack,		1),
			new LearnableMove(Moves.Gust,			1),
			new LearnableMove(Moves.QuickAttack,	1),
			new LearnableMove(Moves.SandAttack,		5),
			new LearnableMove(Moves.Gust,			9),
			new LearnableMove(Moves.QuickAttack,	13),
			new LearnableMove(Moves.Whirlwind,		17),
			new LearnableMove(Moves.Twister,		22),
			//new LearnableMove(Moves.FeatherDance,	27),
			//new LearnableMove(Moves.Agility,		32),
			//new LearnableMove(Moves.WingAttack,		38),
			//new LearnableMove(Moves.Roost,			44),
			//new LearnableMove(Moves.TailWind,		50),
			//new LearnableMove(Moves.MirrorMove,		56),
			//new LearnableMove(Moves.AirSlash,		62),
			//new LearnableMove(Moves.Hurricane,		68)
		};
		private static readonly LearnableMove[] RattataMoves =
		{
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.TailWhip,		1),
			new LearnableMove(Moves.QuickAttack,	4),
			new LearnableMove(Moves.FocusEnergy,	7),
			new LearnableMove(Moves.Bite,			10),
			new LearnableMove(Moves.Pursuit,		13),
			new LearnableMove(Moves.HyperFang,		16),
			new LearnableMove(Moves.SuckerPunch,	19),
			//new LearnableMove(Moves.Crunch,			22),
			//new LearnableMove(Moves.Assurance,		25),
			//new LearnableMove(Moves.SuperFang,		28),
			//new LearnableMove(Moves.DoubleEdge,		31),
			//new LearnableMove(Moves.Endeavor,		34),

		};
		private static readonly LearnableMove[] RaticateMoves =
		{
			//new LearnableMove(Moves.SwordsDance,	1),
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.TailWhip,		1),
			new LearnableMove(Moves.QuickAttack,	1),
			new LearnableMove(Moves.FocusEnergy,	1),
			new LearnableMove(Moves.QuickAttack,	4),
			new LearnableMove(Moves.FocusEnergy,	7),
			new LearnableMove(Moves.Bite,			10),
			new LearnableMove(Moves.Pursuit,		13),
			new LearnableMove(Moves.HyperFang,		16),
			new LearnableMove(Moves.SuckerPunch,	19),
			new LearnableMove(Moves.ScaryFace,		20),
			//new LearnableMove(Moves.Crunch,			24),
			//new LearnableMove(Moves.Assurance,		29),
			//new LearnableMove(Moves.SuperFang,		34),
			//new LearnableMove(Moves.DoubleEdge,		39),
			//new LearnableMove(Moves.Endeavor,		44),
		};
		private static readonly LearnableMove[] PikachuMoves =
		{
			new LearnableMove(Moves.Growl,			1),
			new LearnableMove(Moves.ThunderShock,	1),
			new LearnableMove(Moves.TailWhip,		5),
			new LearnableMove(Moves.ThunderWave,	8),
			new LearnableMove(Moves.QuickAttack,	13),
			//new LearnableMove(Moves.Elecball,		18),
			new LearnableMove(Moves.DoubleTeam,	21),
			//new LearnableMove(Moves.Slam,			26),
			new LearnableMove(Moves.Thunderbolt,	29),
			//new LearnableMove(Moves.Feint,		34),
			//new LearnableMove(Moves.Agility,		37),
			//new LearnableMove(Moves.Discharge,	42),
			//new LearnableMove(Moves.LightScreen,	45),
			new LearnableMove(Moves.Thunder,		50)
		};
		private static readonly LearnableMove[] JigglypuffMoves =
		{
			//new LearnableMove(Moves.Sing,			1),
			//new LearnableMove(Moves.DefenseCurl,	5),
			new LearnableMove(Moves.Pound,			9),
			new LearnableMove(Moves.Disable,		13),
			//new LearnableMove(Moves.Round,			17),
			//new LearnableMove(Moves.Rollout,		21),
			//new LearnableMove(Moves.DoubleSlap,		25),
			new LearnableMove(Moves.Rest,			29),
			//new LearnableMove(Moves.BodySlam,		33),
			//new LearnableMove(Moves.GyroBall,		37),
			//new LearnableMove(Moves.WakeUpSlap,		41),
			//new LearnableMove(Moves.Mimic,			45),
			//new LearnableMove(Moves.HyperVoice,		49),
			//new LearnableMove(Moves.DoubleEdge,		53)
		};
		private static readonly LearnableMove[] ParasMoves =
		{
			new LearnableMove(Moves.Scratch,		1),
			//new LearnableMove(Moves.StunSpore,		6),
			new LearnableMove(Moves.PoisonPowder,	6),
			//new LearnableMove(Moves.LeechLife,		11),
			//new LearnableMove(Moves.FuryCutter,		17),
			//new LearnableMove(Moves.Spore,			22),
			//new LearnableMove(Moves.Slash,			27),
			//new LearnableMove(Moves.Growth,			33),
			//new LearnableMove(Moves.GigaDrain,		38),
			//new LearnableMove(Moves.Aromatherapy,	43),
			//new LearnableMove(Moves.AngerPowder,	49),
			//new LearnableMove(Moves.XScissor,		54)
		};
		private static readonly LearnableMove[] NinetailsMoves =
		{
			new LearnableMove(Moves.NastyPlot,		1),
			new LearnableMove(Moves.Ember,			1),
			new LearnableMove(Moves.QuickAttack,	1),
			new LearnableMove(Moves.ConfuseRay,		1),
			new LearnableMove(Moves.Safeguard,		1)
		};
		private static readonly LearnableMove[] HaunterMoves =
		{
			new LearnableMove(Moves.Hypnosis,		1),
			new LearnableMove(Moves.Lick,			1),
			new LearnableMove(Moves.Spite,			1),
			new LearnableMove(Moves.Spite,			5),
			new LearnableMove(Moves.MeanLook,		8),
			new LearnableMove(Moves.Curse,			12),
			new LearnableMove(Moves.NightShade,		15),
			new LearnableMove(Moves.ConfuseRay,		19)
		};
		private static readonly LearnableMove[] KoffingMoves =
		{
			//new LearnableMove(Moves.PoisonGas,		1),
			new LearnableMove(Moves.Tackle,			1),
			//new LearnableMove(Moves.Smog,			6),
			new LearnableMove(Moves.SmokeScreen,	10),
			//new LearnableMove(Moves.ClearSmog,		19),
			//new LearnableMove(Moves.Selfdestruct,	24),
			//new LearnableMove(Moves.Sludge,			28),
			//new LearnableMove(Moves.Haze,			33),
			//new LearnableMove(Moves.GyroBall,		37),
			//new LearnableMove(Moves.Explosion,		42),
			new LearnableMove(Moves.SludgeBomb,		46),
			//new LearnableMove(Moves.DestinyBomb,	51),
			//new LearnableMove(Moves.Memento,		55)
		};
		private static readonly LearnableMove[] MagikarpMoves =
		{
			new LearnableMove(Moves.Splash, 1),
			new LearnableMove(Moves.Tackle, 15),
			new LearnableMove(Moves.Flail, 30)
		};
		private static readonly LearnableMove[] DittoMoves =
		{
			//new LearnableMove(Moves.Transform,		1)
		};
		private static readonly LearnableMove[] EeveeMoves =
		{
			new LearnableMove(Moves.TailWhip,		1),
			new LearnableMove(Moves.Tackle,			1),
			new LearnableMove(Moves.SandAttack,		8),
			new LearnableMove(Moves.Growl,			15),
			new LearnableMove(Moves.QuickAttack,	22),
			new LearnableMove(Moves.Bite,			29)
		};
		private static readonly LearnableMove[] MewtwoMoves =
		{
			new LearnableMove(Moves.Confusion,		1),
			new LearnableMove(Moves.Disable,		1),
			new LearnableMove(Moves.Barrier,		1),
			new LearnableMove(Moves.Swift,			8),
			new LearnableMove(Moves.FutureSight,	15)
		};
		private static readonly LearnableMove[] MewMoves =
		{
			new LearnableMove(Moves.Pound,			1),
			new LearnableMove(Moves.MirrorType,		1),
			//new LearnableMove(Moves.Transform,		1),
			//new LearnableMove(Moves.MegaPunch,		10),
			//new LearnableMove(Moves.Metranome,		20),
			new LearnableMove(Moves.Psychic,		30),
			new LearnableMove(Moves.Barrier,		40),
			//new LearnableMove(Moves.AncientPower,	50),
			//new LearnableMove(Moves.Amnesia,		60),
			//new LearnableMove(Moves.MeFirst,		70),
			//new LearnableMove(Moves.BatonPass,		80),
			new LearnableMove(Moves.NastyPlot,		90),
			//new LearnableMove(Moves.AuraSphere,		100)
		};
		#endregion

		#region genI
		public static readonly BaseStats MissingNo = new BaseStats(0, "-----", 0, 0, 0, 0, 0, 0, Types.Normal, 0, 0, 0, GenderRatio.Genderless, GrowthRate.MediumSlow, EggGroups.NoEgg, new Ability[] { }, new LearnableMove[] { }, blank);
		public static readonly BaseStats Bulbasaur = new BaseStats(1, "Bulbasaur", 45, 49, 49, 65, 65, 45, Types.Grass | Types.Poison, 45, 64, (ushort)EVs.SAK, GenderRatio.SevenEighthsMale, GrowthRate.MediumSlow, EggGroups.Monster | EggGroups.Plant, new[] { Abilities.Overgrow }, BulbasaurMoves, blank, new[] { new LevelEvolution(Ivysaur, 16) });
		public static readonly BaseStats Ivysaur = new BaseStats(2, "Ivysaur", 60, 62, 63, 80, 80, 60, Types.Grass | Types.Poison, 45, 141, (ushort)(EVs.SAK | EVs.SDF), GenderRatio.SevenEighthsMale, GrowthRate.MediumSlow, EggGroups.Monster | EggGroups.Plant, new[] { Abilities.Overgrow }, IvysaurMoves, blank, new[] { new LevelEvolution(Venusaur, 32) });
		public static readonly BaseStats Venusaur = new BaseStats(3, "Venusaur", 80, 82, 83, 100, 100, 80, Types.Grass | Types.Poison, 45, 208, ((ushort)EVs.SAK * 2) | (ushort)EVs.SDF, GenderRatio.SevenEighthsMale, GrowthRate.MediumSlow, EggGroups.Monster | EggGroups.Plant, new[] { Abilities.Overgrow }, VenusaurMoves, blank);
		public static readonly BaseStats Charmander = new BaseStats(4, "Charmander", 39, 52, 43, 60, 50, 65, Types.Fire, 45, 65, (ushort)EVs.SPD, GenderRatio.SevenEighthsMale, GrowthRate.MediumSlow, EggGroups.Monster | EggGroups.Dragon, new[] { Abilities.Blaze }, CharmanderMoves, blank, new[] { new LevelEvolution(Charmeleon, 16) });
		public static readonly BaseStats Charmeleon = new BaseStats(5, "Charmeleon", 58, 64, 58, 80, 65, 80, Types.Fire, 45, 142, (ushort)(EVs.SAK | EVs.SPD), GenderRatio.SevenEighthsMale, GrowthRate.MediumSlow, EggGroups.Monster | EggGroups.Dragon, new[] { Abilities.Blaze }, CharmeleonMoves, blank, new[] { new LevelEvolution(Charizard, 36) });
		public static readonly BaseStats Charizard = new BaseStats(6, "Charizard", 78, 84, 78, 109, 85, 100, Types.Fire | Types.Flying, 45, 209, (ushort)EVs.SAK * 3, GenderRatio.SevenEighthsMale, GrowthRate.MediumSlow, EggGroups.Monster | EggGroups.Dragon, new[] { Abilities.Blaze }, CharizardMoves, blank);
		public static readonly BaseStats Squirtle = new BaseStats(7, "Squirtle", 44, 48, 65, 50, 64, 43, Types.Water, 45, 66, (ushort)EVs.DEF, GenderRatio.SevenEighthsMale, GrowthRate.MediumSlow, EggGroups.Monster | EggGroups.Water1, new[] { Abilities.Torrent }, SquirtleMoves, blank, new[] { new LevelEvolution(Wartortle, 16) });
		public static readonly BaseStats Wartortle = new BaseStats(8, "Wartortle", 59, 63, 80, 58, 65, 80, Types.Water, 45, 143, (ushort)(EVs.DEF | EVs.SDF), GenderRatio.SevenEighthsMale, GrowthRate.MediumSlow, EggGroups.Monster | EggGroups.Water1, new[] { Abilities.Torrent }, WartortleMoves, blank, new[] { new LevelEvolution(Blastoise, 36) });
		public static readonly BaseStats Blastoise = new BaseStats(9, "Blastoise", 79, 83, 100, 85, 105, 78, Types.Water, 45, 210, (ushort)EVs.SDF * 3, GenderRatio.SevenEighthsMale, GrowthRate.MediumSlow, EggGroups.Monster | EggGroups.Water1, new[] { Abilities.Torrent }, BlastoiseMoves, blank);
		public static readonly BaseStats Caterpie = new BaseStats(10, "Caterpie", 45, 30, 35, 20, 20, 45, Types.Bug, 255, 53, (ushort)EVs.HP, GenderRatio.HalfAndHalf, GrowthRate.MediumFast, EggGroups.Bug | EggGroups.Bug, new[] { Abilities.ShieldDust }, CaterpieMoves, blank, new[] { new LevelEvolution(Metapod, 6) });
		public static readonly BaseStats Metapod = new BaseStats(11, "Metapod", 50, 20, 55, 25, 25, 30, Types.Bug, 120, 72, (ushort)EVs.DEF * 2, GenderRatio.HalfAndHalf, GrowthRate.MediumFast, EggGroups.Bug, new[] { Abilities.ShedSkin }, MetapodMoves, blank, new[] { new LevelEvolution(Butterfree, 10) });
		public static readonly BaseStats Butterfree = new BaseStats(12, "Butterfree", 60, 45, 50, 80, 80, 70, Types.Bug | Types.Flying, 45, 173, (ushort)(EVs.SAK | EVs.SDF), GenderRatio.HalfAndHalf, GrowthRate.MediumFast, EggGroups.Bug, new[] { Abilities.CompoundEyes }, ButterfreeMoves, blank);
		public static readonly BaseStats Weedle;
		public static readonly BaseStats Kakuna;
		public static readonly BaseStats Beedrill;
		public static readonly BaseStats Pidgey = new BaseStats(16, "Pidgey", 40, 45, 40, 35, 35, 56, Types.Normal | Types.Flying, 255, 55, (ushort)EVs.SPD, GenderRatio.HalfAndHalf, GrowthRate.MediumSlow, EggGroups.Flying, new[] { Abilities.KeenEye }, PidgeyMoves, blank, new[] { new LevelEvolution(Pidgeotto, 18) });
		public static readonly BaseStats Pidgeotto = new BaseStats(17, "Pidgeotto", 63, 60, 55, 50, 50, 71, Types.Normal | Types.Flying, 120, 113, (ushort)EVs.SPD * 2, GenderRatio.HalfAndHalf, GrowthRate.MediumSlow, EggGroups.Flying, new[] { Abilities.KeenEye/*, Abilities.TangledFeet*/ }, PidgeottoMoves, blank, new[] { new LevelEvolution(Pidgeot, 36) });
		public static readonly BaseStats Pidgeot = new BaseStats(18, "Pidgeot", 83, 80, 75, 70, 70, 91, Types.Normal | Types.Flying, 45, 172, (ushort)EVs.SPD * 3, GenderRatio.HalfAndHalf, GrowthRate.MediumSlow, EggGroups.Flying, new[] { Abilities.KeenEye/*, Abilities.TangledFeet*/ }, PidgeotMoves, blank);
		public static readonly BaseStats Rattata = new BaseStats(19, "Rattata", 30, 56, 35, 25, 35, 72, Types.Normal, 255, 57, (ushort)EVs.SPD, GenderRatio.HalfAndHalf, GrowthRate.MediumFast, EggGroups.Ground, new[] { Abilities.RunAway, Abilities.Guts }, RattataMoves, blank, new[] { new LevelEvolution(Raticate, 20) });
		public static readonly BaseStats Raticate = new BaseStats(20, "Raticate", 55, 81, 60, 50, 70, 97, Types.Normal, 127, 116, (ushort)EVs.SPD * 2, GenderRatio.HalfAndHalf, GrowthRate.MediumFast, EggGroups.Ground, new[] { Abilities.RunAway, Abilities.Guts }, RaticateMoves, blank);
		public static readonly BaseStats Spearow;
		public static readonly BaseStats Fearow;
		public static readonly BaseStats Ekans;
		public static readonly BaseStats Arbok;
		public static readonly BaseStats Pikachu = new BaseStats(25, "Pikachu", 35, 55, 30, 50, 40, 90, Types.Electric, 190, 82, (ushort)EVs.SPD * 2, GenderRatio.HalfAndHalf, GrowthRate.MediumFast, EggGroups.Ground | EggGroups.Fairy, new[] { Abilities.Static }, PikachuMoves, new PokedexEntry("Mouse", 4, 60, "It occasionally uses an electric shock to recharge a fellow Pikachu that is in a weakened state."), new[] { new UseItemEvolution(Raichu, Items.thunderStone) });
		public static readonly BaseStats Raichu;
		public static readonly BaseStats sandshrew;
		public static readonly BaseStats sandslash;
		public static readonly BaseStats nidoran_f;
		public static readonly BaseStats nidorina;
		public static readonly BaseStats nidoqueen;
		public static readonly BaseStats nidoran_m;
		public static readonly BaseStats nidorino;
		public static readonly BaseStats nidoking;
		public static readonly BaseStats clefairy;
		public static readonly BaseStats clefable;
		public static readonly BaseStats vulpix;
		public static readonly BaseStats Ninetails = new BaseStats(38, "Ninetails", 73, 76, 75, 81, 100, 100, Types.Fire, 75, 178, (ushort)EVs.SDF + (ushort)EVs.SPD, GenderRatio.OneQuarterMale, GrowthRate.MediumFast, EggGroups.Ground, new[] { Abilities.FlashFire }, NinetailsMoves, blank);
		public static readonly BaseStats Jigglypuff = new BaseStats(39, "Jigglypuff", 115, 45, 20, 45, 25, 20, Types.Normal, 170, 76, (ushort)EVs.HP * 2, GenderRatio.OneQuarterMale, GrowthRate.Fast, EggGroups.Fairy, new[] { Abilities.CuteCharm }, JigglypuffMoves, blank);
		public static readonly BaseStats wigglytuff;
		public static readonly BaseStats zubat;
		public static readonly BaseStats golbat;
		public static readonly BaseStats oddish;
		public static readonly BaseStats gloom;
		public static readonly BaseStats vileplume;
		public static readonly BaseStats Paras = new BaseStats(46, "Paras", 35, 70, 55, 45, 55, 25, Types.Bug | Types.Grass, 190, 70, (ushort)EVs.ATK, GenderRatio.HalfAndHalf, GrowthRate.MediumFast, EggGroups.Bug | EggGroups.Plant, new[] { Abilities.EffectSpore }, ParasMoves, blank, new[] { new LevelEvolution(Parasect, 24) });
		public static readonly BaseStats Parasect;
		public static readonly BaseStats venonat;
		public static readonly BaseStats venomoth;
		public static readonly BaseStats diglett;
		public static readonly BaseStats dugtrio;
		public static readonly BaseStats meowth;
		public static readonly BaseStats persian;
		public static readonly BaseStats psyduck;
		public static readonly BaseStats golduck;
		public static readonly BaseStats mankey;
		public static readonly BaseStats primeape;
		public static readonly BaseStats growlithe;
		public static readonly BaseStats arcanine;
		public static readonly BaseStats poliwag;
		public static readonly BaseStats poliwhirl;
		public static readonly BaseStats poliwrath;
		public static readonly BaseStats abra;
		public static readonly BaseStats kadabra;
		public static readonly BaseStats alakazam;
		public static readonly BaseStats machop;
		public static readonly BaseStats machoke;
		public static readonly BaseStats machamp;
		public static readonly BaseStats bellsprout;
		public static readonly BaseStats weepinbell;
		public static readonly BaseStats victreebel;
		public static readonly BaseStats tentacool;
		public static readonly BaseStats tentacruel;
		public static readonly BaseStats geodude;
		public static readonly BaseStats graveler;
		public static readonly BaseStats golem;
		public static readonly BaseStats ponyta;
		public static readonly BaseStats rapidash;
		public static readonly BaseStats slowpoke;
		public static readonly BaseStats slowbro;
		public static readonly BaseStats magnemite;
		public static readonly BaseStats mangeton;
		public static readonly BaseStats farfetchd;
		public static readonly BaseStats doduo;
		public static readonly BaseStats dodrio;
		public static readonly BaseStats seel;
		public static readonly BaseStats dewgong;
		public static readonly BaseStats grimer;
		public static readonly BaseStats muk;
		public static readonly BaseStats shellder;
		public static readonly BaseStats cloyster;
		public static readonly BaseStats Ghastly;
		public static readonly BaseStats Haunter = new BaseStats(93, "Haunter", 45, 50, 45, 115, 55, 95, Types.Ghost | Types.Poison, 90, 126, (ushort)EVs.SAK * 2, GenderRatio.HalfAndHalf, GrowthRate.MediumSlow, EggGroups.Indeterminate, new[] { Abilities.Levitate }, HaunterMoves, blank, new[] { new TradeEvolution(Gengar) });
		public static readonly BaseStats Gengar;
		public static readonly BaseStats onix;
		public static readonly BaseStats drowzee;
		public static readonly BaseStats hypno;
		public static readonly BaseStats krabby;
		public static readonly BaseStats kingler;
		public static readonly BaseStats voltorb;
		public static readonly BaseStats electrode;
		public static readonly BaseStats exeggcute;
		public static readonly BaseStats exeggutor;
		public static readonly BaseStats cubone;
		public static readonly BaseStats marowak;
		public static readonly BaseStats hitmonlee;
		public static readonly BaseStats hitmonchan;
		public static readonly BaseStats lickitung;
		public static readonly BaseStats Koffing = new BaseStats(109, "Koffing", 40, 65, 95, 60, 45, 35, Types.Poison, 190, 114, (ushort)EVs.DEF, GenderRatio.HalfAndHalf, GrowthRate.MediumFast, EggGroups.Indeterminate, new[] { Abilities.Levitate }, KoffingMoves, blank, new[] { new LevelEvolution(Weezing, 35) });
		public static readonly BaseStats Weezing;
		public static readonly BaseStats rhyhorn;
		public static readonly BaseStats rhydon;
		public static readonly BaseStats chansey;
		public static readonly BaseStats tangela;
		public static readonly BaseStats kangaskhan;
		public static readonly BaseStats horsea;
		public static readonly BaseStats seadra;
		public static readonly BaseStats goldeen;
		public static readonly BaseStats seaking;
		public static readonly BaseStats staryu;
		public static readonly BaseStats starmie;
		public static readonly BaseStats MrMime;
		public static readonly BaseStats Scyther;
		public static readonly BaseStats Jynx;
		public static readonly BaseStats Electabuzz;
		public static readonly BaseStats Magmar;
		public static readonly BaseStats Pinsir;
		public static readonly BaseStats Tauros;
		public static readonly BaseStats Magikarp = new BaseStats(129, "Magikarp", 20, 10, 55, 15, 20, 80, Types.Water, 255, 20, (ushort)EVs.SPD, GenderRatio.HalfAndHalf, GrowthRate.Slow, EggGroups.Water2 | EggGroups.Dragon, new[] { Abilities.SwiftSwim }, MagikarpMoves, blank);
		public static readonly BaseStats Gyarados;
		public static readonly BaseStats Lapras;
		public static readonly BaseStats Ditto = new BaseStats(132, "Ditto", 48, 48, 48, 48, 48, 48, Types.Normal, 35, 61, (ushort)EVs.HP, GenderRatio.Genderless, GrowthRate.MediumFast, EggGroups.Ditto, new[] { Abilities.Limber }, DittoMoves, blank);
		public static readonly BaseStats Eevee = new BaseStats(133, "Eevee", 55, 55, 50, 45, 65, 55, Types.Normal, 45, 92, (ushort)EVs.SDF, GenderRatio.SevenEighthsMale, GrowthRate.MediumFast, EggGroups.Ground, new[] { Abilities.RunAway }, EeveeMoves, blank);
		public static readonly BaseStats Vaporeon;
		public static readonly BaseStats Jolteon;
		public static readonly BaseStats Flareon;
		public static readonly BaseStats porygon;
		public static readonly BaseStats omanyte;
		public static readonly BaseStats omastar;
		public static readonly BaseStats kabuto;
		public static readonly BaseStats kabutops;
		public static readonly BaseStats aerodactyl;
		public static readonly BaseStats snorlax;
		public static readonly BaseStats articuno;
		public static readonly BaseStats zapdos;
		public static readonly BaseStats moltres;
		public static readonly BaseStats dratini;
		public static readonly BaseStats dragonair;
		public static readonly BaseStats dragonite;
		public static readonly BaseStats Mewtwo = new BaseStats(150, "Mewtwo", 106, 110, 90, 154, 90, 130, Types.Psychic, 3, 220, (ushort)EVs.SAK * 3, GenderRatio.Genderless, GrowthRate.Slow, EggGroups.NoEgg, new[] { Abilities.Pressure }, MewtwoMoves, blank);
		public static readonly BaseStats Mew = new BaseStats(151, "Mew", 100, 100, 100, 100, 100, 100, Types.Psychic, 45, 64, (ushort)EVs.HP * 3, GenderRatio.Genderless, GrowthRate.MediumSlow, EggGroups.NoEgg, new[] { Abilities.Synchronize }, MewMoves, blank);
		#endregion
		#region gen II
		//152-251
		#endregion
		#region gen III
		private static readonly LearnableMove[] GulpinMoves = { };
		//252-315
		public static readonly BaseStats Gulpin = new BaseStats(316, "Gulpin", 70, 43, 53, 43, 53, 40, Types.Poison, 225, 75, (ushort)EVs.HP, GenderRatio.HalfAndHalf, GrowthRate.Fluctuating, EggGroups.Indeterminate, new[] { Abilities.LiquidOoze, Abilities.StickyHold }, GulpinMoves, blank, new[] { new LevelEvolution(MissingNo, 26) });
		//317-386
		#endregion
		#region gen IV
		//387-493
		#endregion
		#region gen V
		//494-649
		#endregion

		public static Pokemon breed(Pokemon father, Pokemon mother)
		{
			int compat;
			if (father.gender == mother.gender || father.baseStats.eggGroups.HasFlag(EggGroups.NoEgg) || mother.baseStats.eggGroups.HasFlag(EggGroups.NoEgg)) return null;
			foreach (EggGroups group in Enum.GetValues(typeof(EggGroups)))
			{
				if ((mother.baseStats.eggGroups & group) != group) return null;
			}
			compat = father.baseStats == mother.baseStats ? (father.OTid == mother.OTid ? 50 : 70) : (father.OTid == mother.OTid ? 20 : 50);
			int chance = PRNG.Instance.Next(100);
			if (chance < compat)
			{
				Pokemon child;
				child = mother.baseStats.eggGroups == EggGroups.Ditto ? new Pokemon(father.baseStats) : new Pokemon(mother.baseStats);
				int i = 0;
				foreach (LearnableMove m in child.baseStats.learnset)
				{
					if (father.moveSet.Contains(m.move) && mother.moveSet.Contains(m.move))
					{
						child.moveSet[i] = m.move;
						i = i == 3 ? 0 : i + 1;
					}
				}
				//hm
				//tm
				//egg moves
				return child;
			}
			else return null;
		}
	}
}
