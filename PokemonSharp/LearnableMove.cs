namespace PokemonSharp
{
	public sealed class LearnableMove
	{
		public readonly Move move;
		public readonly byte level;

		public LearnableMove(Move m, byte l)
		{
			this.move = m;
			this.level = l;
		}
	}
}
