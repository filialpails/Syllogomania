using System;
using System.Drawing;

namespace PokemonSharp
{
	public class Signposts
	{
		public static readonly Signpost palletTownSign1 = new Signpost(Sprite.SignSprite, new Point(4, 7), () => new TextWindow(new[] { Player.Instance.name + "'s house" }).Show());
		public static readonly Signpost palletTownSign3 = new Signpost(Sprite.SignSprite, new Point(13, 7), () => new TextWindow(new[] { Player.Instance.rivalName + "'s house" }).Show());
		public static readonly Signpost palletTownSign2 = new Signpost(Sprite.SignSprite, new Point(9, 11), () => new TextWindow(new[] { "Pallet Town\nShades of your journey await!" }).Show());
		public static readonly Signpost palletTownSign4 = new Signpost(Sprite.SignSprite, new Point(16, 16), () => new TextWindow(new[] { "Oak Pokemon Research Lab" }).Show());
	}
}
