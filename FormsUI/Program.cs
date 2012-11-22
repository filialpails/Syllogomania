using System;
using System.Windows.Forms;

namespace FormsUI
{
	public static class Program
	{
		private sealed class PokemonSharpApp : ApplicationContext
		{
			public PokemonSharpApp()
			{
				new Splash().ShowDialog();
				new World().Show();
			}
		}

		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Program.PokemonSharpApp());
		}
	}
}
