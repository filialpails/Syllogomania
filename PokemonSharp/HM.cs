using System;

namespace PokemonSharp
{
	public sealed class HM : TM
	{
		private Action fieldEffect;

		public HM(byte i, Move m, Action e) : base(i, m)
		{
			this.fieldEffect = e;
		}
	}
}
