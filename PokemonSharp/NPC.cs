using System;
using System.Drawing;

namespace PokemonSharp
{
	public class NPC : Signpost
	{
		public readonly MovementType movement;
		public readonly int speed;
		public Direction dir;

		public NPC(Sprite s, Point p, Action scr, MovementType m, int spd)
			: base(s, p, scr)
		{
			movement = m;
			speed = spd;
		}
	}
}
