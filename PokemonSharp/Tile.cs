using System;
using System.Drawing;
using PokemonSharp.Properties;

namespace PokemonSharp
{
	public sealed class Tile
	{
		public readonly TerrainType attribute;
		public readonly Bitmap img;
		public bool occupied;
		public Tile(string t)
		{
			this.occupied = false;
			switch (t)
			{
			case "gl":
				this.attribute = TerrainType.Walkable;
				this.img = Resources.light_grass;
				return;
			case "gm":
				this.attribute = TerrainType.Walkable;
				this.img = Resources.med_grass;
				return;
			case "gd":
				this.attribute = TerrainType.Walkable;
				this.img = Resources.dark_grass;
				return;
			case "tg":
				this.attribute = TerrainType.TallGrass;
				this.img = Resources.tall_grass;
				return;
			case "ba":
				this.attribute = TerrainType.NotWalkable;
				this.img = Resources.barrier;
				return;
			case "sa":
				this.attribute = TerrainType.Walkable;
				this.img = Resources.sand;
				return;
			case "di":
				this.attribute = TerrainType.Walkable;
				this.img = Resources.dirt;
				return;
			case "sl":
				this.attribute = TerrainType.Walkable;
				this.img = Resources.light_stone;
				return;
			case "sd":
				this.attribute = TerrainType.Walkable;
				this.img = Resources.dark_stone;
				return;
			case "wl":
				this.attribute = TerrainType.Water;
				this.img = Resources.light_water_still;
				return;
			case "wm":
				this.attribute = TerrainType.Water;
				this.img = Resources.med_water;
				return;
			case "wd":
				this.attribute = TerrainType.Water;
				this.img = Resources.dark_water;
				return;
			case "fb":
				this.attribute = TerrainType.NotWalkable;
				this.img = Resources.brown_fence;
				return;
			case "bu":
				this.attribute = TerrainType.NotWalkable;
				this.img = Resources.bush;
				return;
			}
			this.attribute = TerrainType.NotWalkable;
			this.img = Resources.nobg;
		}
	}
}
