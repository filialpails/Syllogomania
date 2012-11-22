using System;
using System.Drawing;

namespace PokemonSharp
{
	public abstract class Event
	{
		public readonly Sprite sprite;
		public Point location;
		public readonly Action script;

		protected Event(Sprite s, Point p, Action scr)
		{
			sprite = s;
			location = p;
			script = scr;
		}
	}
}
