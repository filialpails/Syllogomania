using System;
using System.Drawing;
using System.Linq;
using PokemonSharp.Properties;

namespace PokemonSharp
{	
	public static class Maps
	{
		//private static readonly Event[] PalletTownEvents = { NPCs.Oak, NPCs.PalletTownNPC1, NPCs.PalletTownNPC2, Signposts.palletTownSign1, Signposts.palletTownSign2, Signposts.palletTownSign3, Signposts.palletTownSign4, Objects.BulbasaurBall, Objects.charmanderBall, Objects.squirtleBall };
		
		private static readonly WildPokemon[] Route1TallGrassWild =
		{
			new WildPokemon(BaseStats.Pidgey, 2, 5, 50),
			new WildPokemon(BaseStats.Rattata, 2, 4, 50)
		};

		//public static readonly Map PalletTown = new Map(20, 24, Resources.QuestionMark, PalletTownEvents, Resources.Pallet_Town, /*MusicPlayer.PalletTown*/"", "Pallet Town", true);
		public static readonly Map Route1 = new Map(40, 24, Resources.QuestionMark, null, Resources.Route_1, /*MusicPlayer.Route1*/"", "Route 1", true, Route1TallGrassWild);
		public static readonly Map ViridianCity = new Map(40, 48, Resources.QuestionMark, null, Resources.Viridian_City, /*MusicPlayer.PewterCity*/"", "Viridian City", true);

		static Maps()
		{
			//PalletTown.connections = new[] { new Connection(PalletTown, Route1, Direction.Up, 0) };
			//Route1.connections = new[]
			//{
			//	new Connection(Route1, PalletTown, Direction.Down, 0),
			//	new Connection(Route1, ViridianCity, Direction.Up, -12)
			//};
			//ViridianCity.connections = new[] { new Connection(ViridianCity, Route1, Direction.Down, 12) };
		}
	}
}
