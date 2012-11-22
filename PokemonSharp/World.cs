using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSharp
{
	public static class World
	{
		public static TimeOfDay CurrentTime { get; private set; }
		public static void AdvanceTimeOfDay() { CurrentTime++; }
		public static Weather weather { get; set; }
	}
}
