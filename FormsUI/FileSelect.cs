using PokemonSharp.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace FormsUI
{
	public class FileSelect : Form
	{
		private IContainer components;
		private Label lblName;
		private TextBox txtName;
		private RadioButton radGirl;
		private RadioButton radBoy;
		private Button btnGo;
		private OpenFileDialog LoadFile;
		private Button btnLoad;
		private GroupBox gbGender;
		private Label lblIntro;
		private PictureBox pbOak;
		private Label lblNameConfirm;
		private PictureBox pbRival;
		private Label lblRival;
		private TextBox txtRival;
		private Label lblRivalConfirm;
		private Label lblLetsGo;
		private Button btnLetsGo;
		public FileSelect()
		{
			this.InitializeComponent();
		}
		private void btnNewGame_Click(object sender, EventArgs e)
		{
			MusicPlayer.playBG(MusicPlayer.Welcome);
			this.pbOak.Visible = true;
			this.lblIntro.Visible = true;
			this.gbGender.Visible = true;
		}
		private void gender_CheckedChanged(object sender, EventArgs e)
		{
			this.lblName.Visible = true;
			this.txtName.Visible = true;
		}
		private void txtName_TextChanged(object sender, EventArgs e)
		{
			this.lblNameConfirm.Text = "Right, so your name is " + this.txtName.Text + '.';
			this.lblLetsGo.Text = this.txtName.Text + "!\nYour very own Pokemon legend is about to unfold!\nA world of dreams and adventures with Pokemon awaits! Let's go!";
			this.lblNameConfirm.Visible = true;
			this.pbRival.Visible = true;
			this.lblRival.Visible = true;
			this.txtRival.Visible = true;
		}
		private void txtRival_TextChanged(object sender, EventArgs e)
		{
			this.lblRivalConfirm.Text = "That's right! I remember now! His name is " + this.txtRival.Text + '!';
			this.lblRivalConfirm.Visible = true;
			this.lblLetsGo.Visible = true;
			this.btnLetsGo.Visible = true;
		}
		private void btnLetsGo_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txtName.Text))
			{
				return;
			}
			if (this.radGirl.Checked)
			{
				Player.CreatePlayer(this.txtName.Text, Gender.Female, this.txtRival.Text);
			}
			else
			{
				if (!this.radBoy.Checked)
				{
					return;
				}
				Player.CreatePlayer(this.txtName.Text, Gender.Male, this.txtRival.Text);
			}
			Player.Instance.givePokemon(new Pokemon(Pokemons.Pikachu, 5, null, null));
			base.Close();
		}
		private void btnContinue_Click(object sender, EventArgs e)
		{
			if (this.LoadFile.ShowDialog() == DialogResult.OK)
			{
				using (FileStream fileStream = new FileStream(this.LoadFile.FileName, FileMode.Open, FileAccess.Read, FileShare.None))
				{
					Player.CreatePlayer((Player)new BinaryFormatter().Deserialize(fileStream));
				}
				base.Close();
			}
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FileSelect));
			this.lblName = new Label();
			this.txtName = new TextBox();
			this.radGirl = new RadioButton();
			this.radBoy = new RadioButton();
			this.btnGo = new Button();
			this.LoadFile = new OpenFileDialog();
			this.btnLoad = new Button();
			this.gbGender = new GroupBox();
			this.lblIntro = new Label();
			this.pbOak = new PictureBox();
			this.lblNameConfirm = new Label();
			this.pbRival = new PictureBox();
			this.lblRival = new Label();
			this.txtRival = new TextBox();
			this.lblRivalConfirm = new Label();
			this.lblLetsGo = new Label();
			this.btnLetsGo = new Button();
			this.gbGender.SuspendLayout();
			((ISupportInitialize)this.pbOak).BeginInit();
			((ISupportInitialize)this.pbRival).BeginInit();
			base.SuspendLayout();
			this.lblName.Location = new Point(8, 384);
			this.lblName.Margin = new Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new Size(272, 18);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Let's begin with your name. What is it?";
			this.lblName.Visible = false;
			this.txtName.BorderStyle = BorderStyle.FixedSingle;
			this.txtName.ImeMode = ImeMode.NoControl;
			this.txtName.Location = new Point(280, 384);
			this.txtName.Margin = new Padding(4);
			this.txtName.MaxLength = 7;
			this.txtName.Name = "txtName";
			this.txtName.Size = new Size(131, 26);
			this.txtName.TabIndex = 5;
			this.txtName.Visible = false;
			this.txtName.TextChanged += new EventHandler(this.txtName_TextChanged);
			this.radGirl.FlatStyle = FlatStyle.Flat;
			this.radGirl.Location = new Point(64, 24);
			this.radGirl.Margin = new Padding(4);
			this.radGirl.Name = "radGirl";
			this.radGirl.Size = new Size(49, 22);
			this.radGirl.TabIndex = 4;
			this.radGirl.TabStop = true;
			this.radGirl.Text = "Girl";
			this.radGirl.UseVisualStyleBackColor = true;
			this.radGirl.CheckedChanged += new EventHandler(this.gender_CheckedChanged);
			this.radBoy.FlatStyle = FlatStyle.Flat;
			this.radBoy.Location = new Point(8, 24);
			this.radBoy.Margin = new Padding(4);
			this.radBoy.Name = "radBoy";
			this.radBoy.Size = new Size(52, 22);
			this.radBoy.TabIndex = 3;
			this.radBoy.TabStop = true;
			this.radBoy.Text = "Boy";
			this.radBoy.UseVisualStyleBackColor = true;
			this.radBoy.CheckedChanged += new EventHandler(this.gender_CheckedChanged);
			this.btnGo.FlatStyle = FlatStyle.Flat;
			this.btnGo.Location = new Point(18, 37);
			this.btnGo.Margin = new Padding(4);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new Size(186, 39);
			this.btnGo.TabIndex = 1;
			this.btnGo.Text = "New Game";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new EventHandler(this.btnNewGame_Click);
			this.LoadFile.DefaultExt = "pksav";
			this.LoadFile.Filter = "PokemonSharp saves|*.pksav";
			this.LoadFile.Title = "Load save game";
			this.btnLoad.FlatStyle = FlatStyle.Flat;
			this.btnLoad.Location = new Point(18, 84);
			this.btnLoad.Margin = new Padding(4);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new Size(186, 39);
			this.btnLoad.TabIndex = 2;
			this.btnLoad.Text = "Continue";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new EventHandler(this.btnContinue_Click);
			this.gbGender.Controls.Add(this.radGirl);
			this.gbGender.Controls.Add(this.radBoy);
			this.gbGender.Location = new Point(0, 336);
			this.gbGender.Margin = new Padding(4);
			this.gbGender.Name = "gbGender";
			this.gbGender.Padding = new Padding(4);
			this.gbGender.Size = new Size(344, 48);
			this.gbGender.TabIndex = 0;
			this.gbGender.TabStop = false;
			this.gbGender.Text = "Now tell me. Are you a boy?  Or are you a girl?";
			this.gbGender.Visible = false;
			this.lblIntro.Location = new Point(8, 168);
			this.lblIntro.Margin = new Padding(4, 0, 4, 0);
			this.lblIntro.Name = "lblIntro";
			this.lblIntro.Size = new Size(464, 166);
			this.lblIntro.TabIndex = 0;
			this.lblIntro.Text = componentResourceManager.GetString("lblIntro.Text");
			this.lblIntro.Visible = false;
			this.pbOak.Image = Resources.OakHGSSIntro;
			this.pbOak.Location = new Point(208, 32);
			this.pbOak.Margin = new Padding(4);
			this.pbOak.Name = "pbOak";
			this.pbOak.Size = new Size(67, 131);
			this.pbOak.TabIndex = 14;
			this.pbOak.TabStop = false;
			this.pbOak.Visible = false;
			this.lblNameConfirm.AutoSize = true;
			this.lblNameConfirm.Location = new Point(8, 408);
			this.lblNameConfirm.Margin = new Padding(4, 0, 4, 0);
			this.lblNameConfirm.Name = "lblNameConfirm";
			this.lblNameConfirm.Size = new Size(165, 18);
			this.lblNameConfirm.TabIndex = 0;
			this.lblNameConfirm.Text = "Right, so your name is ";
			this.lblNameConfirm.Visible = false;
			this.pbRival.Image = Resources.FRLG_Blue_Title;
			this.pbRival.Location = new Point(640, 64);
			this.pbRival.Margin = new Padding(4);
			this.pbRival.Name = "pbRival";
			this.pbRival.Size = new Size(61, 100);
			this.pbRival.TabIndex = 17;
			this.pbRival.TabStop = false;
			this.pbRival.Visible = false;
			this.lblRival.Location = new Point(472, 168);
			this.lblRival.Margin = new Padding(4, 0, 4, 0);
			this.lblRival.Name = "lblRival";
			this.lblRival.Size = new Size(344, 56);
			this.lblRival.TabIndex = 0;
			this.lblRival.Text = "This is my grandson.\r\nHe's been your rival since you were both babies.\r\n...Erm, what was his name now?";
			this.lblRival.Visible = false;
			this.txtRival.BorderStyle = BorderStyle.FixedSingle;
			this.txtRival.ImeMode = ImeMode.NoControl;
			this.txtRival.Location = new Point(472, 224);
			this.txtRival.Margin = new Padding(4);
			this.txtRival.MaxLength = 7;
			this.txtRival.Name = "txtRival";
			this.txtRival.Size = new Size(131, 26);
			this.txtRival.TabIndex = 6;
			this.txtRival.Visible = false;
			this.txtRival.TextChanged += new EventHandler(this.txtRival_TextChanged);
			this.lblRivalConfirm.AutoSize = true;
			this.lblRivalConfirm.Location = new Point(472, 256);
			this.lblRivalConfirm.Margin = new Padding(4, 0, 4, 0);
			this.lblRivalConfirm.Name = "lblRivalConfirm";
			this.lblRivalConfirm.Size = new Size(298, 18);
			this.lblRivalConfirm.TabIndex = 20;
			this.lblRivalConfirm.Text = "That's right! I remember now! His name is \r\n";
			this.lblRivalConfirm.Visible = false;
			this.lblRivalConfirm.TextChanged += new EventHandler(this.txtRival_TextChanged);
			this.lblLetsGo.Location = new Point(472, 280);
			this.lblLetsGo.Margin = new Padding(4, 0, 4, 0);
			this.lblLetsGo.Name = "lblLetsGo";
			this.lblLetsGo.Size = new Size(400, 56);
			this.lblLetsGo.TabIndex = 0;
			this.lblLetsGo.Text = "!\r\nYour very own Pokemon legend is about to unfold!\r\nA world of dreams and adventures with Pokemon awaits!";
			this.lblLetsGo.Visible = false;
			this.btnLetsGo.FlatStyle = FlatStyle.Flat;
			this.btnLetsGo.Location = new Point(616, 336);
			this.btnLetsGo.Margin = new Padding(4);
			this.btnLetsGo.Name = "btnLetsGo";
			this.btnLetsGo.Size = new Size(112, 32);
			this.btnLetsGo.TabIndex = 7;
			this.btnLetsGo.Text = "Let's go!";
			this.btnLetsGo.UseVisualStyleBackColor = true;
			this.btnLetsGo.Visible = false;
			this.btnLetsGo.Click += new EventHandler(this.btnLetsGo_Click);
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(872, 431);
			base.Controls.Add(this.btnLetsGo);
			base.Controls.Add(this.lblLetsGo);
			base.Controls.Add(this.lblRivalConfirm);
			base.Controls.Add(this.txtRival);
			base.Controls.Add(this.lblRival);
			base.Controls.Add(this.pbRival);
			base.Controls.Add(this.lblNameConfirm);
			base.Controls.Add(this.pbOak);
			base.Controls.Add(this.lblIntro);
			base.Controls.Add(this.gbGender);
			base.Controls.Add(this.btnLoad);
			base.Controls.Add(this.btnGo);
			base.Controls.Add(this.txtName);
			base.Controls.Add(this.lblName);
			this.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FileSelect";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "File Select";
			this.gbGender.ResumeLayout(false);
			((ISupportInitialize)this.pbOak).EndInit();
			((ISupportInitialize)this.pbRival).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
