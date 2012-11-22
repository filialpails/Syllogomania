using System;
using System.Collections.Generic;
using System.Drawing;

namespace PokemonSharp
{
	public sealed class Trainer
	{
		private const int MAX_PARTY_SIZE = 6;
		private readonly ushort id = PRNG.Instance.Next(65536);
		private readonly ushort secretID = PRNG.Instance.Next(65536);
		public readonly string name;
		public readonly List<Pokemon> party = new List<Pokemon>(6);
		public readonly Bitmap img;
		public bool defeated;
		public readonly TrainerType type;
		
		public Trainer(string n, Pokemon[] m, Bitmap b, TrainerType t)
		{
			this.name = n;
			this.party.AddRange(m);
			for (int i = 0; i < this.party.Count; i++)
			{
				this.party[i].OTid = this.id;
				this.party[i].OTsecretid = this.secretID;
				this.party[i].OTname = this.name;
			}
			this.img = b;
			this.type = t;
		}
	}
}
