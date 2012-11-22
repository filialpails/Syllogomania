using System;
using System.Drawing;

namespace PokemonSharp
{
	public sealed class ItemBall : Event
	{
		public readonly Item item;

		public ItemBall(Sprite s, Point p, Action scr, Item i) : base(s, p, scr)
		{
			item = i;
		}
	}
}
