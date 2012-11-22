using System;
namespace PokemonSharp
{
	[Serializable]
	public sealed class Tileset
	{
		public readonly Tile[] tiles;
		public static readonly Tileset Outdoors = new Tileset();
	}
}
