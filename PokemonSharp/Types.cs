using System;
namespace PokemonSharp
{
	[Flags]
	public enum Types : byte
	{
		None = 0,
		Normal = 1,
		Fighting = 2,
		Flying = 3,
		Poison = 4,
		Ground = 5,
		Rock = 6,
		Bug = 7,
		Ghost = 8,
		Steel = 9,
		Fire = 11,
		Water = 12,
		Grass = 13,
		Electric = 14,
		Psychic = 15,
		Ice = 16,
		Dragon = 17,
		Dark = 18
	}
}
