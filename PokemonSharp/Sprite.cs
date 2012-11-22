using System;
using System.Drawing;
using PokemonSharp.Properties;

namespace PokemonSharp
{
	public sealed class Sprite
	{
		public readonly Bitmap Up;
		public readonly Bitmap Down;
		public readonly Bitmap Left;
		public readonly Bitmap Right;
		public readonly Bitmap WalkUp1;
		public readonly Bitmap WalkDown1;
		public readonly Bitmap WalkLeft1;
		public readonly Bitmap WalkRight1;
		public readonly Bitmap WalkUp2;
		public readonly Bitmap WalkDown2;
		public readonly Bitmap WalkLeft2;
		public readonly Bitmap WalkRight2;
		public static readonly Sprite OakSprite = new Sprite(Resources.oak_up1, Resources.oak_down1, Resources.oak_left1, Resources.oak_right1, Resources.oak_up2, Resources.oak_down2, Resources.oak_left2, Resources.oak_right2, Resources.oak_up3, Resources.oak_down3, Resources.oak_left3, Resources.oak_right3);
		public static readonly Sprite NoSprite = new Sprite(Resources.nonpc);
		public static readonly Sprite SignSprite = new Sprite(Resources.sign);
		public static readonly Sprite BoySprite = new Sprite(Resources.black);
		public static readonly Sprite GirlSprite = new Sprite(Resources.black);
		public Sprite(Bitmap b) : this(b, b, b, b, b, b, b, b, b, b, b, b)
		{
		}
		public Sprite(Bitmap u, Bitmap d, Bitmap l, Bitmap r, Bitmap wu1, Bitmap wd1, Bitmap wl1, Bitmap wr1, Bitmap wu2, Bitmap wd2, Bitmap wl2, Bitmap wr2)
		{
			this.Up = u;
			this.Down = d;
			this.Left = l;
			this.Right = r;
			this.WalkUp1 = wu1;
			this.WalkDown1 = wd1;
			this.WalkLeft1 = wl1;
			this.WalkRight1 = wr1;
			this.WalkUp2 = wu2;
			this.WalkDown2 = wd2;
			this.WalkLeft2 = wl2;
			this.WalkRight2 = wr2;
		}
	}
}
