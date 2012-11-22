using System;

namespace PokemonSharp
{
	public sealed class WildPokemon
	{
		public readonly BaseStats mon;
		public readonly byte minLevel;
		public readonly byte maxLevel;
		public readonly byte rate;

		public WildPokemon(BaseStats p, byte min, byte max, byte r)
		{
			mon = p;
			minLevel = min;
			maxLevel = max;
			rate = r;
		}
	}
}
