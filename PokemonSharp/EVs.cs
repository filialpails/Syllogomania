using System;
namespace PokemonSharp
{
	[Flags]
	public enum EVs : ushort
	{
		SDF = 1024,
		SAK = 256,
		SPD = 64,
		DEF = 16,
		ATK = 4,
		HP = 1
	}
}
