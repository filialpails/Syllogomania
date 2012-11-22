using System;

namespace PokemonSharp
{
	public interface IEvolution
	{
		BaseStats EvolveTo { get; }
	}

	public interface ILevelEvolution : IEvolution
	{
		int Level { get; }
	}

	public class LevelEvolution : ILevelEvolution
	{
		public BaseStats EvolveTo { get; private set; }
		public int Level { get; private set; }

		public LevelEvolution(BaseStats to, int level)
		{
			EvolveTo = to;
			Level = level;
		}
	}

	public interface IItemEvolution : IEvolution
	{
		Item Item { get; }
	}

	public sealed class UseItemEvolution : IItemEvolution
	{
		public BaseStats EvolveTo { get; private set; }
		public Item Item { get; private set; }

		public UseItemEvolution(BaseStats to, Item i)
		{
			EvolveTo = to;
			Item = i;
		}
	}

	public interface IHeldItemEvolution : IItemEvolution
	{
	}

	public class HeldItemEvolution : IHeldItemEvolution
	{
		public BaseStats EvolveTo { get; private set; }
		public Item Item { get; private set; }

		public HeldItemEvolution(BaseStats to, Item i)
		{
			EvolveTo = to;
			Item = i;
		}
	}
	
	public interface IHappinessEvolution : IEvolution
	{
		int Happiness { get; }
	}

	public class HappinessEvolution : IHappinessEvolution
	{
		public BaseStats EvolveTo { get; private set; }
		public int Happiness { get; private set; }

		public HappinessEvolution(BaseStats to, int h)
		{
			EvolveTo = to;
			Happiness = h;
		}
	}

	public interface IMoveEvolution : IEvolution
	{
		Move Move { get; }
	}

	public interface IAreaEvolution : IEvolution
	{
		Map Map { get; }
	}

	public interface ITimeEvolution : IEvolution
	{
		TimeOfDay TimeOfDay { get; }
	}

	public interface ITradeEvolution : IEvolution
	{
	}

	public class HeldItemTradeEvolution : IHeldItemEvolution, ITradeEvolution
	{
		public BaseStats EvolveTo { get; private set; }
		public Item Item { get; private set; }

		public HeldItemTradeEvolution(BaseStats to, Item i)
		{
			EvolveTo = to;
			Item = i;
		}
	}

	public class TradeEvolution : ITradeEvolution
	{
		public BaseStats EvolveTo { get; private set; }

		public TradeEvolution(BaseStats to)
		{
			EvolveTo = to;
		}
	}
}
