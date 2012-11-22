namespace PokemonSharp
{
	public sealed class Roamer
	{
		public readonly Pokemon mon;
		public readonly Map currentMap;

		public Roamer(Pokemon p, Map m)
		{
			this.mon = p;
			this.currentMap = m;
		}
	}
}
