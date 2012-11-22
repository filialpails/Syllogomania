using System;
using PokemonSharp.Properties;

namespace PokemonSharp
{
	public static class Trainers
	{
		public static readonly Trainer Rival = new Trainer(Player.Instance.rivalName, new[] { new Pokemon(BaseStats.Eevee, 5, null, null) }, Resources.QuestionMark, TrainerType.Rival);
	}
}
