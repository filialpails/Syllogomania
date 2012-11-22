using System;
namespace PokemonSharp
{
	[Flags]
	public enum AffectsWhom : byte
	{
		SelectedTarget = 0,
		Varies = 1,
		Random = 4,
		BothFoes = 8,
		User = 16,
		FoesAndPartner = 32,
		OpponentField = 64
	}
}
