using System;
using System.Drawing;
using System.Linq;

namespace PokemonSharp
{
	public sealed class Map
	{
		public readonly Event[] events;
		//scripts
		public Connection[] connections;
		public readonly string music;
		public readonly string name;
		//public readonly bool useFlash;
		//public readonly Weather weather;
		//public readonly byte type;
		public readonly bool showLabel;

		public readonly int height;
		public readonly int width;
		public readonly Bitmap border;
		private readonly Block[,] tiles;
		public readonly Block[] global;
		public readonly Block[] local;
		public readonly Size borderSize = new Size(3, 3);

		public readonly WildPokemon[] tallGrassWild;
		public readonly WildPokemon[] longGrassWild;
		public readonly WildPokemon[] caveWild;
		public readonly WildPokemon[] surfWild;
		//public readonly WildPokemon[] OldRodWild = { };
		//public readonly WildPokemon[] GoodRodWild = { };
		//public readonly WildPokemon[] SuperRodWild = { };

		public Map(int h, int w, Bitmap b, Event[] e, string m, string mu, string n, bool sl, WildPokemon[] tg = null)
		{
			height = h;
			width = w;
			border = b;
			events = e;
			tiles = new Block[height, width];
			string[] nums = m.Replace("\r", "").Replace("\n", "").Split(',');
			for (int i = 0, k = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++, k++)
				{
					tiles[i, j] = global[Int32.Parse(nums[k])];
				}
			}
			music = mu;
			name = n;
			showLabel = sl;
			tallGrassWild = tg;
		}

		public Block this[int y, int x]
		{
			get
			{
				Connection conn;
				if (x < 0)
				{
					if (y < 0 || y >= height)
					{
						return null;
					}
					else
					{
						conn = connections.Single<Connection>((c) => { if (c.dir == Direction.Left) return true; else return false; });
						return conn.toMap[y - conn.connRect.Top, x - conn.connRect.Left];
					}
				}
				else if (x >= Player.Instance.currentMap.width)
				{
					if (y < 0 || y >= Player.Instance.currentMap.height)
					{
						return null;
					}
					else
					{
						conn = connections.Single<Connection>((c) => { if (c.dir == Direction.Right) return true; else return false; });
						return conn.toMap[y - conn.connRect.Top, x - conn.connRect.Left];
					}
				}
				else if (y < 0)
				{
					conn = connections.Single<Connection>((c) => { if (c.dir == Direction.Up) return true; else return false; });
					return conn.toMap[y - conn.connRect.Top, x - conn.connRect.Left];
				}
				else if (y >= Player.Instance.currentMap.height)
				{
					conn = connections.Single<Connection>((c) => { if (c.dir == Direction.Down) return true; else return false; });
					return conn.toMap[y - conn.connRect.Top, x - conn.connRect.Left];
				}
				else
				{
					return tiles[y, x];
				}
			}
		}
	}
}
