namespace PokemonSharp
{
	public static class Mart
	{
		private static readonly Item[] stock = new Item[] { Items.Pokeball, Items.GreatBall, Items.UltraBall, Items.potion, Items.superPotion, Items.hyperPotion, Items.maxPotion, Items.fullRestore, Items.revive, Items.antidote, Items.paralyzeHeal, Items.awakening, Items.burnHeal, Items.iceHeal, Items.fullHeal };

		public static Item Buy(Player p, byte i)
		{
			p.money -= stock[i].price;
			return stock[i];
		}
		public static void Sell(Player p, Item i)
		{
			p.DropItem(i);
			p.money += (ushort)(i.price >> 1);
		}
	}
}