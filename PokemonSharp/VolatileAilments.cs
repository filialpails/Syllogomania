using System;
namespace PokemonSharp
{
	[Flags]
	public enum VolatileAilments : ushort
	{
		None = 0,
		Confusion = 1,
		Curse = 2,
		Encore = 4,
		Flinch = 8,
		Identify = 16,
		Infatuation = 32,
		LeechSeed = 64,
		MindReader = 128,
		Nightmare = 256,
		Trapped = 512,
		PerishSong = 1024,
		Taunt = 2048,
		Torment = 4096
	}
}
