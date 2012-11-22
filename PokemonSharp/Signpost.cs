using System;
using System.Drawing;

namespace PokemonSharp
{
	public class Signpost : Event
	{
		public bool Auto { get; private set; }

		public Signpost(Sprite s, Point p, Action scr, bool a = false) : base(s, p, scr)
		{
			Auto = a;
		}
	}
}
