using System;

namespace PokemonSharp
{
	public class TM
	{
		private byte id;
		private Move move;

		public TM(byte i, Move m)
		{
			this.id = i;
			this.move = m;
		}
	}
}
