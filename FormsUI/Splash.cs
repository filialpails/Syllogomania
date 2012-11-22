using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsUI
{
	public partial class Splash : Form
	{
		public Splash()
		{
			InitializeComponent();
			MusicPlayer.playBG("resources\\music\\kanto\\1-03 Opening.mp3");
		}

		private void Splash_KeyDown(object sender, KeyEventArgs e)
		{
			this.Close();
		}

		private void Splash_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
