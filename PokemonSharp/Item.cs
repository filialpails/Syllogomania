using System;
using System.Linq;
namespace PokemonSharp
{
	public sealed class Item
	{
		public readonly string name;
		public readonly ushort price;
		//private readonly byte specialValue1;
		//private readonly byte specialValue2;
		public readonly string description;
		//private readonly short mysteryValue;
		public readonly Pocket pocket;
		private readonly Action<Pokemon, int> fieldEffect;
		//private readonly byte battleUsage;
		private readonly Action<Pokemon, int> battleEffect;

		public Item(string n, string d, ushort p, Pocket b, Action<Pokemon, int> a)
		{
			name = n;
			description = d;
			price = p;
			pocket = b;
			battleEffect = a;
			fieldEffect = a;
		}

		public void Use(Pokemon target, bool battle)
		{
			if (battle) battleEffect(target, 0);
			else fieldEffect(target, 0);
		}
		public void Use(Pokemon target, byte i, bool battle)
		{
			if (battle) battleEffect(target, i);
			else fieldEffect(target, i);
		}


	}
}
