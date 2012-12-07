using System;
using System.Drawing;
using System.Linq;
using PokemonSharp.Properties;

namespace PokemonSharp
{
	public sealed class Block
	{
		public readonly TerrainType attribute;
		public readonly Bitmap upperTopLeft, upperTopRight, upperBottomLeft, upperBottomRight, lowerTopLeft, lowerTopRight, lowerBottomLeft, lowerBottomRight;
		public bool Occupied { get; set; }

		public Block(TerrainType tt, Bitmap utl, Bitmap utr, Bitmap ubl, Bitmap ubr, Bitmap ltl, Bitmap ltr, Bitmap lbl, Bitmap lbr)
		{
			attribute = tt;
			upperTopLeft = utl;
			upperTopRight = utr;
			upperBottomLeft = ubl;
			upperBottomRight = ubr;
			lowerTopLeft = ltl;
			lowerTopRight = ltr;
			lowerBottomLeft = lbl;
			lowerBottomRight = lbr;
		}

		//public static readonly Block[] Outdoors = new[] { new Block(TerrainType.Walkable, Resources.light_grass), new Block(TerrainType.Walkable, Resources.med_grass), new Block(TerrainType.Walkable, Resources.dark_grass), new Block(TerrainType.TallGrass, Resources.tall_grass), new Block(TerrainType.NotWalkable, Resources.barrier), new Block(TerrainType.Walkable, Resources.sand), new Block(TerrainType.Walkable, Resources.dirt), new Block(TerrainType.Walkable, Resources.light_stone), new Block(TerrainType.Walkable, Resources.dark_stone), new Block(TerrainType.Water, Resources.light_water_still), new Block(TerrainType.Water, Resources.med_water), new Block(TerrainType.Water, Resources.dark_water), new Block(TerrainType.NotWalkable, Resources.brown_fence), new Block(TerrainType.NotWalkable, Resources.bush) };
		//public static readonly Block[] Pallet = new[] { new Block(TerrainType.Walkable, Resources.light_grass), new Block(TerrainType.Walkable, Resources.med_grass), new Block(TerrainType.Walkable, Resources.dark_grass), new Block(TerrainType.TallGrass, Resources.tall_grass), new Block(TerrainType.NotWalkable, Resources.barrier), new Block(TerrainType.Walkable, Resources.sand), new Block(TerrainType.Walkable, Resources.dirt), new Block(TerrainType.Walkable, Resources.light_stone), new Block(TerrainType.Walkable, Resources.dark_stone), new Block(TerrainType.Water, Resources.light_water_still), new Block(TerrainType.Water, Resources.med_water), new Block(TerrainType.Water, Resources.dark_water), new Block(TerrainType.NotWalkable, Resources.brown_fence), new Block(TerrainType.NotWalkable, Resources.bush) };
	}
}
