using System;
using System.Drawing;

namespace PokemonSharp
{
	public sealed class Connection
	{
		public readonly Map toMap;
		public readonly Rectangle connRect;
		public readonly Direction dir;
		public readonly int shift;

		public Connection(Map from, Map to, Direction d, int s)
		{
			toMap = to;
			dir = d;
			shift = s;
			switch (dir)
			{
				case Direction.Up: connRect = new Rectangle(shift, -toMap.height, toMap.width, toMap.height); break;
				case Direction.Down: connRect = new Rectangle(shift, from.height, toMap.width, toMap.height); break;
				case Direction.Left: connRect = new Rectangle(-toMap.width, shift, from.width, from.height); break;
				case Direction.Right: connRect = new Rectangle(from.width, shift, from.width, from.height); break;
			}
		}
	}
}
