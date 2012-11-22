using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace FormsUI
{
	public static class MusicPlayer
	{
		private static readonly WindowsMediaPlayer BG = new WindowsMediaPlayer();
		private static readonly WindowsMediaPlayer SE = new WindowsMediaPlayer();

		static MusicPlayer()
		{
			BG.settings.setMode("loop", true);
			SE.settings.setMode("loop", false);
		}

		public static void playBG(string song)
		{
			BG.controls.stop();
			BG.URL = Path.Combine(Application.StartupPath, song);
		}
		public static void playSE(string song)
		{
			BG.controls.pause();
			SE.controls.stop();
			SE.URL = Path.Combine(Application.StartupPath, song);
			BG.controls.play();
		}

		public const string Opening = @"resources\music\kanto\1-03 Opening.mp3";
		public const string Welcome = @"resources\music\kanto\1-05 Welcome to the World of Pokemon.mp3";
		public const string BattleVSTrainer = @"resources\music\kanto\1-011 Battle (VS Trainer).mp3";
		public const string BattleVSWildPokemon = @"resources\music\kanto\1-18 Battle (VS Wild Pokemon).mp3";
		public const string PalletTown = @"resources\music\kanto\1-06 Pallet Town Theme.mp3";
		public const string PewterCity = @"resources\music\kanto\1-15 Pewter City Theme.mp3";
		public const string FanfareSuccess = @"resources\music\kanto\1-43 Fanfare Success!.mp3";
		public const string VictoryVSTrainer = @"resources\music\kanto\1-12 Victory (VS Trainer).mp3";
		public const string VictoryVSWildPokemon = @"resources\music\kanto\1-19 Victory (VS Wild Pokemon).mp3";
		public const string Route1 = @"resources\music\kanto\1-13 Route 1.mp3";
	}
}
