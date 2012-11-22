using System;

namespace PokemonSharp
{
	public sealed class PRNG
	{
		private uint seed;

		private PRNG(int s)
		{
			seed = (uint)(((DateTime.Now.Month * DateTime.Now.Day + DateTime.Now.Minute + DateTime.Now.Second) % 0x100) * 0x1000000 + DateTime.Now.Hour * 0x10000 + DateTime.Now.Year - 2000 + s);
		}

		public ushort Next(int max = Int16.MaxValue)
		{
			seed = (0x41C64E6D * seed + 0x6073) & 0xFFFFFFFF;
			return (ushort)((seed & 0xFFFF) / 0xFFFF * max);
		}

		public ushort Next(int min, int max)
		{
			return (ushort)(Next(max - min) + min);
		}

		#region singleton
		private static PRNG instance = null;
		public static PRNG Instance { get { return instance; } }
		public static void Seed(int s) { if (instance == null) instance = new PRNG(s); }
		#endregion
	}
}
