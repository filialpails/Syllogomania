using System;
using System.Drawing;

namespace PokemonSharp
{
	public sealed class TrainerNPC : NPC
	{
		public Trainer trainer;
		public readonly int view;

		public TrainerNPC(Sprite s, Point p, Action scr, MovementType m, int spd, Trainer t, int v) : base(s, p, scr, m, spd)
		{
			this.trainer = t;
			this.view = v;
		}
	}
}
