namespace FormsUI
{
	partial class World
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.LoadFile = new System.Windows.Forms.OpenFileDialog();
			this.mnuMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuPokemon = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDex = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuBag = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPlayer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlScreen = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.mnuMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMenu
			// 
			this.mnuMenu.BackColor = System.Drawing.Color.White;
			this.mnuMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPokemon,
            this.mnuDex,
            this.mnuBag,
            this.mnuPlayer,
            this.mnuSave,
            this.mnuExit});
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.Size = new System.Drawing.Size(144, 136);
			// 
			// mnuPokemon
			// 
			this.mnuPokemon.Name = "mnuPokemon";
			this.mnuPokemon.Size = new System.Drawing.Size(125, 22);
			this.mnuPokemon.Text = "Pokemon";
			this.mnuPokemon.Click += new System.EventHandler(this.mnuPokemon_Click);
			// 
			// mnuDex
			// 
			this.mnuDex.Name = "mnuDex";
			this.mnuDex.Size = new System.Drawing.Size(125, 22);
			this.mnuDex.Text = "PokeDex";
			this.mnuDex.Click += new System.EventHandler(this.mnuDex_Click);
			// 
			// mnuBag
			// 
			this.mnuBag.Name = "mnuBag";
			this.mnuBag.Size = new System.Drawing.Size(125, 22);
			this.mnuBag.Text = "Bag";
			this.mnuBag.Click += new System.EventHandler(this.mnuItems_Click);
			// 
			// mnuPlayer
			// 
			this.mnuPlayer.Name = "mnuPlayer";
			this.mnuPlayer.Size = new System.Drawing.Size(125, 22);
			this.mnuPlayer.Text = "<Player>";
			this.mnuPlayer.Click += new System.EventHandler(this.mnuPlayer_Click);
			// 
			// mnuSave
			// 
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.Size = new System.Drawing.Size(125, 22);
			this.mnuSave.Text = "Save";
			this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(125, 22);
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// pnlScreen
			// 
			this.pnlScreen.AutoSize = true;
			this.pnlScreen.CausesValidation = false;
			this.pnlScreen.ContextMenuStrip = this.mnuMenu;
			this.pnlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlScreen.Location = new System.Drawing.Point(0, 0);
			this.pnlScreen.Margin = new System.Windows.Forms.Padding(0);
			this.pnlScreen.Name = "pnlScreen";
			this.pnlScreen.Size = new System.Drawing.Size(480, 320);
			this.pnlScreen.TabIndex = 1;
			this.pnlScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// World
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(480, 320);
			this.Controls.Add(this.pnlScreen);
			this.MaximizeBox = false;
			this.Name = "World";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pokemon#";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.World_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.World_KeyDown);
			this.mnuMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog LoadFile;
		private System.Windows.Forms.ContextMenuStrip mnuMenu;
		private System.Windows.Forms.ToolStripMenuItem mnuPokemon;
		private System.Windows.Forms.ToolStripMenuItem mnuDex;
		private System.Windows.Forms.ToolStripMenuItem mnuBag;
		private System.Windows.Forms.ToolStripMenuItem mnuPlayer;
		private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.Panel pnlScreen;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
	}
}