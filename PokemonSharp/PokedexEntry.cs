namespace PokemonSharp
{
	public sealed class PokedexEntry
	{
		public readonly string species;
		public readonly ushort height;
		public readonly ushort weight;
		public readonly string description;

		public PokedexEntry(string s, ushort h, ushort w, string d)
		{
			this.species = s;
			this.height = h;
			this.weight = w;
			this.description = d;
		}
	}
}
