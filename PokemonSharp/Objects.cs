using System;
using System.Drawing;

namespace PokemonSharp
{
	public static class Objects
	{
		public static readonly Signpost palletTownSign1 = new Signpost(Sprites.SignSprite, new Point(4, 7), delegate
		{
			new TextWindow(new string[]
			{
				Player.Instance.name + "'s house"
			}).Show();
		}, false);
		public static readonly Signpost palletTownSign3 = new Signpost(Sprites.SignSprite, new Point(13, 7), delegate
		{
			new TextWindow(new string[]
			{
				Player.Instance.rivalName + "'s house"
			}).Show();
		}, false);
		public static readonly Signpost palletTownSign2 = new Signpost(Sprites.SignSprite, new Point(9, 11), delegate
		{
			new TextWindow(new string[]
			{
				"Pallet Town\nShades of your journey await!"
			}).Show();
		}, false);
		public static readonly Signpost palletTownSign4 = new Signpost(Sprites.SignSprite, new Point(16, 16), () => new TextWindow(new[] { "Oak Pokemon Research Lab" }).Show(), false);
		public static readonly NPC BulbasaurBall = new NPC(Sprites.NoSprite, new Point(11, 3), () =>
		{
			if (Player.Instance.pokemonCaught == 0 && new TextWindow(new[] { "Bulbasaur?" }, new[] { "Yes", "No" }).Show() == 0)
			{
				Player.Instance.givePokemon(new Pokemon(BaseStats.Bulbasaur, 5, null, null));
				Trainers.Rival.party.Add(new Pokemon(BaseStats.Charmander, 5));
			}
		}, MovementType.LookDown, 17);
		public static readonly NPC charmanderBall = new NPC(Sprites.NoSprite, new Point(12, 3), () =>
		{
			if (Player.Instance.pokemonCaught == 0 && new TextWindow(new[] { "Charmander?" }, new[] { "Yes", "No" }).Show() == 0)
			{
				Player.Instance.givePokemon(new Pokemon(BaseStats.Charmander, 5, null, null));
				Trainers.Rival.party.Add(new Pokemon(BaseStats.Squirtle, 5));
			}
		}, MovementType.LookDown, 17);
		public static readonly NPC squirtleBall = new NPC(Sprites.NoSprite, new Point(13, 3), () =>
		{
			if (Player.Instance.pokemonCaught == 0 && new TextWindow(new[] { "Squirtle?" }, new[] { "Yes", "No" }).Show() == 0)
			{
				Player.Instance.givePokemon(new Pokemon(BaseStats.Squirtle, 5, null, null));
				Trainers.Rival.party.Add(new Pokemon(BaseStats.Bulbasaur, 5));
			}
		}, MovementType.LookDown, 17);
	}
}
