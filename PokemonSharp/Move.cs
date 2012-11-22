using System;

namespace PokemonSharp
{
	public sealed class Move
	{
		public readonly Action<Pokemon, Pokemon, int> effect = null;
		public readonly byte power = 0;
		public readonly Types element;
		public readonly byte accuracy = 100;
		public readonly byte basePP;
		public readonly byte effectAccuracy = 100;
		//public readonly AffectsWhom affectsWhom;
		public readonly sbyte priority = 0;
		public readonly bool contact;
		
		public readonly string name;
		public readonly DamageCategory category;

		public Move(string n, Types e, DamageCategory cat, byte bpp, byte p, byte a, bool cntct, Action<Pokemon, Pokemon, int> ef, byte efa = 0, sbyte pri = 0)
		{
			name = n;
			power = p;
			element = e;
			basePP = bpp;
			accuracy = a;
			effect = ef;
			category = cat;
			contact = cntct;
			priority = pri;
			effectAccuracy = efa;

			if (effectAccuracy == 0) effectAccuracy = accuracy;
		}
		public Move(string n, Types e, DamageCategory cat, byte bpp, byte p, byte a, bool cntct, sbyte pri = 0)
		{
			name = n;
			power = p;
			element = e;
			basePP = bpp;
			accuracy = a;
			category = cat;
			contact = cntct;
			priority = pri;
		}
	}
}
