using System;
using System.Linq;

namespace PokemonSharp
{
	public static class Items
	{
		#region Medicine
		public static readonly Item potion = new Item("POTION", "Restores 20 HP", 300, Pocket.Medicine, (p, m) => p.HP += 20);
		public static readonly Item superPotion = new Item("SUPER POTION", "Restores 50 HP", 700, Pocket.Medicine, (p, m) => p.HP += 50);
		public static readonly Item hyperPotion = new Item("HYPER POTION", "Restores 200 HP", 1200, Pocket.Medicine, (p, m) => p.HP += 200);
		public static readonly Item maxPotion = new Item("MAX POTION", "Restores all HP", 2500, Pocket.Medicine, (p, m) => p.HP = p.MaxHP);
		public static readonly Item ether = new Item("ETHER", "Restores 10 of one attack's PP", 1200, Pocket.Medicine, (p, m) => p.PP[m] += 10);
		public static readonly Item maxEther = new Item("MAX ETHER", "Restores all of one attack's PP", 2000, Pocket.Medicine, (p, m) => p.PP[m] = (byte)(p.moveSet[m].basePP + p.PPbonuses[m] * p.moveSet[m].basePP * 0.2));
		public static readonly Item elixir = new Item("ELIXIR", "Restores 10 PP to all attacks", 3000, Pocket.Medicine, (p, m) => { for (int i = 0; i < p.PP.Length; i++) p.PP[i] += 10; });
		public static readonly Item maxElixir = new Item("MAX ELIXIR", "Restores all PP to all attacks", 4500, Pocket.Medicine, (p, m) => { for (int i = 0; i < p.PP.Length; i++) p.PP[i] = (byte)(p.moveSet[i].basePP + p.PPbonuses[i] * p.moveSet[m].basePP * 0.2); });
		public static readonly Item revive = new Item("REVIVE", "Revives a Pokemon to half HP", 1500, Pocket.Medicine, (p, m) => p.HP = (ushort)(p.MaxHP >> 1));
		public static readonly Item maxRevive = new Item("MAX REVIVE", "Fully revives a KO'd Pokemon", 4000, Pocket.Medicine, (p, m) => p.HP = p.MaxHP);
		public static readonly Item antidote = new Item("ANTIDOTE", "Cures posion", 100, Pocket.Medicine, (p, m) => { if (p.NonVolStatus == NonVolatileAilment.Poison) p.NonVolStatus = NonVolatileAilment.None; });
		public static readonly Item awakening = new Item("AWAKENING", "Cures sleep", 250, Pocket.Medicine, (p, m) => { if (p.NonVolStatus == NonVolatileAilment.Sleep) p.NonVolStatus = NonVolatileAilment.None; });
		public static readonly Item burnHeal = new Item("BURN HEAL", "Cures burn", 250, Pocket.Medicine, (p, m) => { if (p.NonVolStatus == NonVolatileAilment.Burn) p.NonVolStatus = NonVolatileAilment.None; });
		public static readonly Item iceHeal = new Item("ICE HEAL", "Cures freeze", 250, Pocket.Medicine, (p, m) => { if (p.NonVolStatus == NonVolatileAilment.Freeze) p.NonVolStatus = NonVolatileAilment.None; });
		public static readonly Item paralyzeHeal = new Item("PARALYZE HEAL", "Cures paralysis", 200, Pocket.Medicine, (p, m) => { if (p.NonVolStatus == NonVolatileAilment.Paralyze) p.NonVolStatus = NonVolatileAilment.None; });
		public static readonly Item fullHeal = new Item("FULL HEAL", "Cures all status ailments", 600, Pocket.Medicine, (p, m) => { if (p.NonVolStatus != NonVolatileAilment.None) p.NonVolStatus = NonVolatileAilment.None; });
		public static readonly Item fullRestore = new Item("FULL RESTORE", "Restores status and all HP", 3000, Pocket.Medicine, (p, m) => { if (p.NonVolStatus != NonVolatileAilment.None || p.HP != p.MaxHP) p.NonVolStatus = NonVolatileAilment.None; p.HP = p.MaxHP; });
		public static readonly Item protein = new Item("PROTEIN", "Raises attack stat", 9800, Pocket.Medicine, (p, m) => { if (p.attackEV <= 90) p.attackEV += 10; });
		public static readonly Item iron = new Item("IRON", "Raises defense stat", 9800, Pocket.Medicine, (p, m) => { if (p.defenseEV <= 90) p.defenseEV += 10; });
		public static readonly Item carbos = new Item("CARBOS", "Raises speed stat", 9800, Pocket.Medicine, (p, m) => { if (p.speedEV <= 90) p.speedEV += 10; });
		public static readonly Item calcium = new Item("CALCIUM", "Raises special attack stat", 9800, Pocket.Medicine, (p, m) => { if (p.specialAttackEV <= 90) p.specialAttackEV += 10; });
		public static readonly Item zinc = new Item("Zinc", "Raises special defense stat", 9800, Pocket.Medicine, (p, m) => { if (p.specialDefenseEV <= 90) p.specialDefenseEV += 10; });
		public static readonly Item hpUp = new Item("HP UP", "Raises maximum HP", 9800, Pocket.Medicine, (p, m) => { if (p.hpEV <= 90) p.hpEV += 10; });
		public static readonly Item ppUp = new Item("PP UP", "Raises maximum PP for an attack", 9800, Pocket.Medicine, (p, m) => { if (p.PPbonuses[m] < 3) p.PPbonuses[m]++; });
		public static readonly Item rareCandy = new Item("RARE CANDY", "Raises level by one", 4800, Pocket.Medicine, (p, m) => p.LevelUp());
		#endregion
		#region Balls
		public static readonly Item Pokeball = new Item("POKEBALL", "Used to catch low-level monsters", 200, Pocket.Balls, (p, m) => catcher(p, 0));
		public static readonly Item GreatBall = new Item("GREATBALL", "Used to catch mid-level monsters", 600, Pocket.Balls, (p, m) => catcher(p, 1));
		public static readonly Item UltraBall = new Item("ULTRABALL", "Used to catch high-level monsters", 1200, Pocket.Balls, (p, m) => catcher(p, 2));
		public static readonly Item MasterBall = new Item("MASTERBALL", "Catch any monster", 0, Pocket.Balls, (p, m) => catcher(p, 3));
		#endregion
		#region misc
		public static readonly Item nugget = new Item("NUGGET", "Sell it for lots of money!", 5000, Pocket.Items, (p, m) => { });
		public static readonly Item townMap = new Item("Town Map", "Displays a map of Kanto.", 0, Pocket.Key, (p, m) => { });
		#endregion

		public static readonly Item fireStone = new Item("Fire Stone", "bluh bluh", 0, Pocket.Items, (p, i) => p.Evolve(p.baseStats.evolutions.Single(e => e is UseItemEvolution && ((UseItemEvolution)e).Item == fireStone).EvolveTo));
		public static readonly Item thunderStone = new Item("Thunder Stone", "bluh bluh", 0, Pocket.Items, (p, i) => p.Evolve(p.baseStats.evolutions.Single(e => e is UseItemEvolution && ((UseItemEvolution)e).Item == thunderStone).EvolveTo));
		public static readonly Item waterStone = new Item("Water Stone", "bluh bluh", 0, Pocket.Items, (p, i) => p.Evolve(p.baseStats.evolutions.Single(e => e is UseItemEvolution && ((UseItemEvolution)e).Item == waterStone).EvolveTo));

		private static bool catcher(Pokemon target, byte i)
		{
			ushort A = target.MaxHP;
			ushort B = target.HP;
			byte C = target.baseStats.catchRate;
			if (i == 1) C = (byte)(target.baseStats.catchRate * 1.5);
			else if (i == 2) C = (byte)(target.baseStats.catchRate * 2);
			else if (i == 3) C = 255;
			double D = 1;
			if (target.NonVolStatus == NonVolatileAilment.Poison) D = 1.5;
			else if (target.NonVolStatus == NonVolatileAilment.Burn) D = 1.5;
			else if (target.NonVolStatus == NonVolatileAilment.Sleep) D = 2;
			else if (target.NonVolStatus == NonVolatileAilment.Freeze) D = 2;
			else if (target.NonVolStatus == NonVolatileAilment.Paralyze) D = 1.5;
			uint X = (uint)((((A * 3) - (B * 2)) * C) / A * 3 * D);
			if (X == 0) X = 1;
			if (X > 255) return true;
			else return false;
		}
	}
}