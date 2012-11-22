namespace PokemonSharp
{
	public sealed class Ability
	{
		public readonly string name;
		public readonly string desc;
		
		public Ability(string n, string d)
		{
			this.name = n;
			this.desc = d;
		}
	}
}
