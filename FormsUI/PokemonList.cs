using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace FormsUI
{
	public class PokemonList : Form
	{
		private IContainer components = null;
		private Button btnCancel;
		private Label lblChoose;
		private Panel pkmn5;
		private ProgressBar pbHP5;
		private Label lblHP5;
		private Label lblLevel5;
		private Label lblGender5;
		private PictureBox pb5;
		private Label lblName5;
		private Label lblHPLabel5;
		private Panel pkmn3;
		private ProgressBar pbHP3;
		private Label lblHP3;
		private Label lblLevel3;
		private Label lblGender3;
		private PictureBox pb3;
		private Label lblName3;
		private Label lblHPLabel3;
		private Panel pkmn1;
		private ProgressBar pbHP1;
		private Label lblHP1;
		private Label lblLevel1;
		private Label lblGender1;
		private PictureBox pb1;
		private Label lblName1;
		private Label lblHPLabel1;
		private Panel pkmn2;
		private ProgressBar pbHP2;
		private Label lblHP2;
		private Label lblLevel2;
		private Label lblGender2;
		private PictureBox pb2;
		private Label lblName2;
		private Label lblHPLabel2;
		private Panel pkmn4;
		private ProgressBar pbHP4;
		private Label lblHP4;
		private Label lblLevel4;
		private Label lblGender4;
		private PictureBox pb4;
		private Label lblName4;
		private Label lblHPLabel4;
		private Panel pkmn6;
		private ProgressBar pbHP6;
		private Label lblHP6;
		private Label lblLevel6;
		private Label lblGender6;
		private PictureBox pb6;
		private Label lblName6;
		private Label lblHPLabel6;
		private ContextMenuStrip contextFree;
		private ToolStripMenuItem mnuStatus;
		private ToolStripMenuItem mnuSwitch;
		private ToolStripMenuItem mnuItem;
		private ToolStripMenuItem mnuQuit;
		private ContextMenuStrip contextItem;
		private ToolStripMenuItem useToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItem6;
		private ContextMenuStrip contextSwitch;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem toolStripMenuItem2;
		private ToolStripMenuItem toolStripMenuItem3;
		private ToolStripMenuItem toolStripMenuItem4;
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
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PokemonList));
			this.btnCancel = new Button();
			this.lblChoose = new Label();
			this.pkmn5 = new Panel();
			this.pbHP5 = new ProgressBar();
			this.lblHP5 = new Label();
			this.lblLevel5 = new Label();
			this.lblGender5 = new Label();
			this.pb5 = new PictureBox();
			this.lblName5 = new Label();
			this.lblHPLabel5 = new Label();
			this.pkmn3 = new Panel();
			this.pbHP3 = new ProgressBar();
			this.lblHP3 = new Label();
			this.lblLevel3 = new Label();
			this.lblGender3 = new Label();
			this.pb3 = new PictureBox();
			this.lblName3 = new Label();
			this.lblHPLabel3 = new Label();
			this.pkmn1 = new Panel();
			this.pbHP1 = new ProgressBar();
			this.lblHP1 = new Label();
			this.lblLevel1 = new Label();
			this.lblGender1 = new Label();
			this.pb1 = new PictureBox();
			this.lblName1 = new Label();
			this.lblHPLabel1 = new Label();
			this.pkmn2 = new Panel();
			this.pbHP2 = new ProgressBar();
			this.lblHP2 = new Label();
			this.lblLevel2 = new Label();
			this.lblGender2 = new Label();
			this.pb2 = new PictureBox();
			this.lblName2 = new Label();
			this.lblHPLabel2 = new Label();
			this.pkmn4 = new Panel();
			this.pbHP4 = new ProgressBar();
			this.lblHP4 = new Label();
			this.lblLevel4 = new Label();
			this.lblGender4 = new Label();
			this.pb4 = new PictureBox();
			this.lblName4 = new Label();
			this.lblHPLabel4 = new Label();
			this.pkmn6 = new Panel();
			this.pbHP6 = new ProgressBar();
			this.lblHP6 = new Label();
			this.lblLevel6 = new Label();
			this.lblGender6 = new Label();
			this.pb6 = new PictureBox();
			this.lblName6 = new Label();
			this.lblHPLabel6 = new Label();
			this.contextFree = new ContextMenuStrip(this.components);
			this.mnuStatus = new ToolStripMenuItem();
			this.mnuSwitch = new ToolStripMenuItem();
			this.mnuItem = new ToolStripMenuItem();
			this.mnuQuit = new ToolStripMenuItem();
			this.contextItem = new ContextMenuStrip(this.components);
			this.useToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripMenuItem6 = new ToolStripMenuItem();
			this.contextSwitch = new ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new ToolStripMenuItem();
			this.toolStripMenuItem2 = new ToolStripMenuItem();
			this.toolStripMenuItem3 = new ToolStripMenuItem();
			this.toolStripMenuItem4 = new ToolStripMenuItem();
			this.pkmn5.SuspendLayout();
			((ISupportInitialize)this.pb5).BeginInit();
			this.pkmn3.SuspendLayout();
			((ISupportInitialize)this.pb3).BeginInit();
			this.pkmn1.SuspendLayout();
			((ISupportInitialize)this.pb1).BeginInit();
			this.pkmn2.SuspendLayout();
			((ISupportInitialize)this.pb2).BeginInit();
			this.pkmn4.SuspendLayout();
			((ISupportInitialize)this.pb4).BeginInit();
			this.pkmn6.SuspendLayout();
			((ISupportInitialize)this.pb6).BeginInit();
			this.contextFree.SuspendLayout();
			this.contextItem.SuspendLayout();
			this.contextSwitch.SuspendLayout();
			base.SuspendLayout();
			this.btnCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.btnCancel.BackColor = Color.RoyalBlue;
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatAppearance.BorderColor = Color.Black;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = Color.White;
			this.btnCancel.Location = new Point(380, 326);
			this.btnCancel.Margin = new Padding(4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(120, 44);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.lblChoose.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.lblChoose.BackColor = Color.White;
			this.lblChoose.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblChoose.Location = new Point(12, 326);
			this.lblChoose.Margin = new Padding(4, 0, 4, 0);
			this.lblChoose.Name = "lblChoose";
			this.lblChoose.Size = new Size(364, 43);
			this.lblChoose.TabIndex = 8;
			this.lblChoose.Text = "Choose a Pokemon";
			this.lblChoose.TextAlign = ContentAlignment.MiddleLeft;
			this.pkmn5.BackColor = Color.CornflowerBlue;
			this.pkmn5.Controls.Add(this.pbHP5);
			this.pkmn5.Controls.Add(this.lblHP5);
			this.pkmn5.Controls.Add(this.lblLevel5);
			this.pkmn5.Controls.Add(this.lblGender5);
			this.pkmn5.Controls.Add(this.pb5);
			this.pkmn5.Controls.Add(this.lblName5);
			this.pkmn5.Controls.Add(this.lblHPLabel5);
			this.pkmn5.Location = new Point(8, 200);
			this.pkmn5.Name = "pkmn5";
			this.pkmn5.Size = new Size(240, 80);
			this.pkmn5.TabIndex = 9;
			this.pkmn5.Visible = false;
			this.pkmn5.Click += new EventHandler(this.pkmn_Click);
			this.pbHP5.ForeColor = Color.Lime;
			this.pbHP5.Location = new Point(112, 44);
			this.pbHP5.Name = "pbHP5";
			this.pbHP5.Size = new Size(112, 8);
			this.pbHP5.TabIndex = 5;
			this.pbHP5.Value = 100;
			this.lblHP5.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHP5.ForeColor = Color.White;
			this.lblHP5.Location = new Point(128, 56);
			this.lblHP5.Name = "lblHP5";
			this.lblHP5.Size = new Size(56, 24);
			this.lblHP5.TabIndex = 4;
			this.lblHP5.Text = "22/22";
			this.lblLevel5.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblLevel5.ForeColor = Color.White;
			this.lblLevel5.Location = new Point(8, 56);
			this.lblLevel5.Name = "lblLevel5";
			this.lblLevel5.Size = new Size(56, 24);
			this.lblLevel5.TabIndex = 3;
			this.lblLevel5.Text = "Lv.6";
			this.lblGender5.ForeColor = Color.White;
			this.lblGender5.Location = new Point(208, 16);
			this.lblGender5.Name = "lblGender5";
			this.lblGender5.Size = new Size(16, 24);
			this.lblGender5.TabIndex = 2;
			this.lblGender5.Text = "♂";
			this.pb5.Location = new Point(24, 16);
			this.pb5.Name = "pb5";
			this.pb5.Size = new Size(32, 32);
			this.pb5.TabIndex = 1;
			this.pb5.TabStop = false;
			this.lblName5.ForeColor = Color.White;
			this.lblName5.Location = new Point(64, 16);
			this.lblName5.Name = "lblName5";
			this.lblName5.Size = new Size(112, 24);
			this.lblName5.TabIndex = 0;
			this.lblName5.Text = "PenPen";
			this.lblHPLabel5.BackColor = Color.Black;
			this.lblHPLabel5.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHPLabel5.ForeColor = Color.Red;
			this.lblHPLabel5.Location = new Point(80, 40);
			this.lblHPLabel5.Name = "lblHPLabel5";
			this.lblHPLabel5.Size = new Size(152, 16);
			this.lblHPLabel5.TabIndex = 6;
			this.lblHPLabel5.Text = "HP:";
			this.pkmn3.BackColor = Color.CornflowerBlue;
			this.pkmn3.Controls.Add(this.pbHP3);
			this.pkmn3.Controls.Add(this.lblHP3);
			this.pkmn3.Controls.Add(this.lblLevel3);
			this.pkmn3.Controls.Add(this.lblGender3);
			this.pkmn3.Controls.Add(this.pb3);
			this.pkmn3.Controls.Add(this.lblName3);
			this.pkmn3.Controls.Add(this.lblHPLabel3);
			this.pkmn3.Location = new Point(8, 104);
			this.pkmn3.Name = "pkmn3";
			this.pkmn3.Size = new Size(240, 80);
			this.pkmn3.TabIndex = 10;
			this.pkmn3.Visible = false;
			this.pkmn3.Click += new EventHandler(this.pkmn_Click);
			this.pbHP3.ForeColor = Color.Lime;
			this.pbHP3.Location = new Point(112, 44);
			this.pbHP3.Name = "pbHP3";
			this.pbHP3.Size = new Size(112, 8);
			this.pbHP3.TabIndex = 5;
			this.pbHP3.Value = 100;
			this.lblHP3.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHP3.ForeColor = Color.White;
			this.lblHP3.Location = new Point(128, 56);
			this.lblHP3.Name = "lblHP3";
			this.lblHP3.Size = new Size(56, 24);
			this.lblHP3.TabIndex = 4;
			this.lblHP3.Text = "22/22";
			this.lblLevel3.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblLevel3.ForeColor = Color.White;
			this.lblLevel3.Location = new Point(8, 56);
			this.lblLevel3.Name = "lblLevel3";
			this.lblLevel3.Size = new Size(56, 24);
			this.lblLevel3.TabIndex = 3;
			this.lblLevel3.Text = "Lv.6";
			this.lblGender3.ForeColor = Color.White;
			this.lblGender3.Location = new Point(208, 16);
			this.lblGender3.Name = "lblGender3";
			this.lblGender3.Size = new Size(16, 24);
			this.lblGender3.TabIndex = 2;
			this.lblGender3.Text = "♂";
			this.pb3.Location = new Point(24, 16);
			this.pb3.Name = "pb3";
			this.pb3.Size = new Size(32, 32);
			this.pb3.TabIndex = 1;
			this.pb3.TabStop = false;
			this.lblName3.ForeColor = Color.White;
			this.lblName3.Location = new Point(64, 16);
			this.lblName3.Name = "lblName3";
			this.lblName3.Size = new Size(112, 24);
			this.lblName3.TabIndex = 0;
			this.lblName3.Text = "PenPen";
			this.lblHPLabel3.BackColor = Color.Black;
			this.lblHPLabel3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHPLabel3.ForeColor = Color.Red;
			this.lblHPLabel3.Location = new Point(80, 40);
			this.lblHPLabel3.Name = "lblHPLabel3";
			this.lblHPLabel3.Size = new Size(152, 16);
			this.lblHPLabel3.TabIndex = 6;
			this.lblHPLabel3.Text = "HP:";
			this.pkmn1.BackColor = Color.CornflowerBlue;
			this.pkmn1.Controls.Add(this.pbHP1);
			this.pkmn1.Controls.Add(this.lblHP1);
			this.pkmn1.Controls.Add(this.lblLevel1);
			this.pkmn1.Controls.Add(this.lblGender1);
			this.pkmn1.Controls.Add(this.pb1);
			this.pkmn1.Controls.Add(this.lblName1);
			this.pkmn1.Controls.Add(this.lblHPLabel1);
			this.pkmn1.Location = new Point(8, 8);
			this.pkmn1.Name = "pkmn1";
			this.pkmn1.Size = new Size(240, 80);
			this.pkmn1.TabIndex = 11;
			this.pkmn1.Visible = false;
			this.pkmn1.Click += new EventHandler(this.pkmn_Click);
			this.pbHP1.ForeColor = Color.Lime;
			this.pbHP1.Location = new Point(112, 44);
			this.pbHP1.Name = "pbHP1";
			this.pbHP1.Size = new Size(112, 8);
			this.pbHP1.TabIndex = 5;
			this.pbHP1.Value = 100;
			this.lblHP1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHP1.ForeColor = Color.White;
			this.lblHP1.Location = new Point(128, 56);
			this.lblHP1.Name = "lblHP1";
			this.lblHP1.Size = new Size(56, 24);
			this.lblHP1.TabIndex = 4;
			this.lblHP1.Text = "22/22";
			this.lblLevel1.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblLevel1.ForeColor = Color.White;
			this.lblLevel1.Location = new Point(8, 56);
			this.lblLevel1.Name = "lblLevel1";
			this.lblLevel1.Size = new Size(56, 24);
			this.lblLevel1.TabIndex = 3;
			this.lblLevel1.Text = "Lv.6";
			this.lblGender1.ForeColor = Color.White;
			this.lblGender1.Location = new Point(208, 16);
			this.lblGender1.Name = "lblGender1";
			this.lblGender1.Size = new Size(16, 24);
			this.lblGender1.TabIndex = 2;
			this.lblGender1.Text = "♂";
			this.pb1.Location = new Point(24, 16);
			this.pb1.Name = "pb1";
			this.pb1.Size = new Size(32, 32);
			this.pb1.TabIndex = 1;
			this.pb1.TabStop = false;
			this.lblName1.ForeColor = Color.White;
			this.lblName1.Location = new Point(64, 16);
			this.lblName1.Name = "lblName1";
			this.lblName1.Size = new Size(112, 24);
			this.lblName1.TabIndex = 0;
			this.lblName1.Text = "PenPen";
			this.lblHPLabel1.BackColor = Color.Black;
			this.lblHPLabel1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHPLabel1.ForeColor = Color.Red;
			this.lblHPLabel1.Location = new Point(80, 40);
			this.lblHPLabel1.Name = "lblHPLabel1";
			this.lblHPLabel1.Size = new Size(152, 16);
			this.lblHPLabel1.TabIndex = 6;
			this.lblHPLabel1.Text = "HP:";
			this.pkmn2.BackColor = Color.CornflowerBlue;
			this.pkmn2.Controls.Add(this.pbHP2);
			this.pkmn2.Controls.Add(this.lblHP2);
			this.pkmn2.Controls.Add(this.lblLevel2);
			this.pkmn2.Controls.Add(this.lblGender2);
			this.pkmn2.Controls.Add(this.pb2);
			this.pkmn2.Controls.Add(this.lblName2);
			this.pkmn2.Controls.Add(this.lblHPLabel2);
			this.pkmn2.Location = new Point(264, 24);
			this.pkmn2.Name = "pkmn2";
			this.pkmn2.Size = new Size(240, 80);
			this.pkmn2.TabIndex = 12;
			this.pkmn2.Visible = false;
			this.pkmn2.Click += new EventHandler(this.pkmn_Click);
			this.pbHP2.ForeColor = Color.Lime;
			this.pbHP2.Location = new Point(112, 44);
			this.pbHP2.Name = "pbHP2";
			this.pbHP2.Size = new Size(112, 8);
			this.pbHP2.TabIndex = 5;
			this.pbHP2.Value = 100;
			this.lblHP2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHP2.ForeColor = Color.White;
			this.lblHP2.Location = new Point(128, 56);
			this.lblHP2.Name = "lblHP2";
			this.lblHP2.Size = new Size(56, 24);
			this.lblHP2.TabIndex = 4;
			this.lblHP2.Text = "22/22";
			this.lblLevel2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblLevel2.ForeColor = Color.White;
			this.lblLevel2.Location = new Point(8, 56);
			this.lblLevel2.Name = "lblLevel2";
			this.lblLevel2.Size = new Size(56, 24);
			this.lblLevel2.TabIndex = 3;
			this.lblLevel2.Text = "Lv.6";
			this.lblGender2.ForeColor = Color.White;
			this.lblGender2.Location = new Point(208, 16);
			this.lblGender2.Name = "lblGender2";
			this.lblGender2.Size = new Size(16, 24);
			this.lblGender2.TabIndex = 2;
			this.lblGender2.Text = "♂";
			this.pb2.Location = new Point(24, 16);
			this.pb2.Name = "pb2";
			this.pb2.Size = new Size(32, 32);
			this.pb2.TabIndex = 1;
			this.pb2.TabStop = false;
			this.lblName2.ForeColor = Color.White;
			this.lblName2.Location = new Point(64, 16);
			this.lblName2.Name = "lblName2";
			this.lblName2.Size = new Size(112, 24);
			this.lblName2.TabIndex = 0;
			this.lblName2.Text = "PenPen";
			this.lblHPLabel2.BackColor = Color.Black;
			this.lblHPLabel2.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHPLabel2.ForeColor = Color.Red;
			this.lblHPLabel2.Location = new Point(80, 40);
			this.lblHPLabel2.Name = "lblHPLabel2";
			this.lblHPLabel2.Size = new Size(152, 16);
			this.lblHPLabel2.TabIndex = 6;
			this.lblHPLabel2.Text = "HP:";
			this.pkmn4.BackColor = Color.CornflowerBlue;
			this.pkmn4.Controls.Add(this.pbHP4);
			this.pkmn4.Controls.Add(this.lblHP4);
			this.pkmn4.Controls.Add(this.lblLevel4);
			this.pkmn4.Controls.Add(this.lblGender4);
			this.pkmn4.Controls.Add(this.pb4);
			this.pkmn4.Controls.Add(this.lblName4);
			this.pkmn4.Controls.Add(this.lblHPLabel4);
			this.pkmn4.Location = new Point(264, 120);
			this.pkmn4.Name = "pkmn4";
			this.pkmn4.Size = new Size(240, 80);
			this.pkmn4.TabIndex = 13;
			this.pkmn4.Visible = false;
			this.pkmn4.Click += new EventHandler(this.pkmn_Click);
			this.pbHP4.ForeColor = Color.Lime;
			this.pbHP4.Location = new Point(112, 44);
			this.pbHP4.Name = "pbHP4";
			this.pbHP4.Size = new Size(112, 8);
			this.pbHP4.TabIndex = 5;
			this.pbHP4.Value = 100;
			this.lblHP4.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHP4.ForeColor = Color.White;
			this.lblHP4.Location = new Point(128, 56);
			this.lblHP4.Name = "lblHP4";
			this.lblHP4.Size = new Size(56, 24);
			this.lblHP4.TabIndex = 4;
			this.lblHP4.Text = "22/22";
			this.lblLevel4.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblLevel4.ForeColor = Color.White;
			this.lblLevel4.Location = new Point(8, 56);
			this.lblLevel4.Name = "lblLevel4";
			this.lblLevel4.Size = new Size(56, 24);
			this.lblLevel4.TabIndex = 3;
			this.lblLevel4.Text = "Lv.6";
			this.lblGender4.ForeColor = Color.White;
			this.lblGender4.Location = new Point(208, 16);
			this.lblGender4.Name = "lblGender4";
			this.lblGender4.Size = new Size(16, 24);
			this.lblGender4.TabIndex = 2;
			this.lblGender4.Text = "♂";
			this.pb4.Location = new Point(24, 16);
			this.pb4.Name = "pb4";
			this.pb4.Size = new Size(32, 32);
			this.pb4.TabIndex = 1;
			this.pb4.TabStop = false;
			this.lblName4.ForeColor = Color.White;
			this.lblName4.Location = new Point(64, 16);
			this.lblName4.Name = "lblName4";
			this.lblName4.Size = new Size(112, 24);
			this.lblName4.TabIndex = 0;
			this.lblName4.Text = "PenPen";
			this.lblHPLabel4.BackColor = Color.Black;
			this.lblHPLabel4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHPLabel4.ForeColor = Color.Red;
			this.lblHPLabel4.Location = new Point(80, 40);
			this.lblHPLabel4.Name = "lblHPLabel4";
			this.lblHPLabel4.Size = new Size(152, 16);
			this.lblHPLabel4.TabIndex = 6;
			this.lblHPLabel4.Text = "HP:";
			this.pkmn6.BackColor = Color.CornflowerBlue;
			this.pkmn6.Controls.Add(this.pbHP6);
			this.pkmn6.Controls.Add(this.lblHP6);
			this.pkmn6.Controls.Add(this.lblLevel6);
			this.pkmn6.Controls.Add(this.lblGender6);
			this.pkmn6.Controls.Add(this.pb6);
			this.pkmn6.Controls.Add(this.lblName6);
			this.pkmn6.Controls.Add(this.lblHPLabel6);
			this.pkmn6.Location = new Point(264, 216);
			this.pkmn6.Name = "pkmn6";
			this.pkmn6.Size = new Size(240, 80);
			this.pkmn6.TabIndex = 14;
			this.pkmn6.Visible = false;
			this.pkmn6.Click += new EventHandler(this.pkmn_Click);
			this.pbHP6.ForeColor = Color.Lime;
			this.pbHP6.Location = new Point(112, 44);
			this.pbHP6.Name = "pbHP6";
			this.pbHP6.Size = new Size(112, 8);
			this.pbHP6.TabIndex = 5;
			this.pbHP6.Value = 100;
			this.lblHP6.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHP6.ForeColor = Color.White;
			this.lblHP6.Location = new Point(128, 56);
			this.lblHP6.Name = "lblHP6";
			this.lblHP6.Size = new Size(56, 24);
			this.lblHP6.TabIndex = 4;
			this.lblHP6.Text = "22/22";
			this.lblLevel6.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblLevel6.ForeColor = Color.White;
			this.lblLevel6.Location = new Point(8, 56);
			this.lblLevel6.Name = "lblLevel6";
			this.lblLevel6.Size = new Size(56, 24);
			this.lblLevel6.TabIndex = 3;
			this.lblLevel6.Text = "Lv.6";
			this.lblGender6.ForeColor = Color.White;
			this.lblGender6.Location = new Point(208, 16);
			this.lblGender6.Name = "lblGender6";
			this.lblGender6.Size = new Size(16, 24);
			this.lblGender6.TabIndex = 2;
			this.lblGender6.Text = "♂";
			this.pb6.Location = new Point(24, 16);
			this.pb6.Name = "pb6";
			this.pb6.Size = new Size(32, 32);
			this.pb6.TabIndex = 1;
			this.pb6.TabStop = false;
			this.lblName6.ForeColor = Color.White;
			this.lblName6.Location = new Point(64, 16);
			this.lblName6.Name = "lblName6";
			this.lblName6.Size = new Size(112, 24);
			this.lblName6.TabIndex = 0;
			this.lblName6.Text = "PenPen";
			this.lblHPLabel6.BackColor = Color.Black;
			this.lblHPLabel6.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblHPLabel6.ForeColor = Color.Red;
			this.lblHPLabel6.Location = new Point(80, 40);
			this.lblHPLabel6.Name = "lblHPLabel6";
			this.lblHPLabel6.Size = new Size(152, 16);
			this.lblHPLabel6.TabIndex = 6;
			this.lblHPLabel6.Text = "HP:";
			this.contextFree.Items.AddRange(new ToolStripItem[]
			{
				this.mnuStatus,
				this.mnuSwitch,
				this.mnuItem,
				this.mnuQuit
			});
			this.contextFree.Name = "contextFree";
			this.contextFree.Size = new Size(126, 92);
			this.mnuStatus.Name = "mnuStatus";
			this.mnuStatus.Size = new Size(152, 22);
			this.mnuStatus.Text = "Summary";
			this.mnuStatus.Click += new EventHandler(this.mnuStatus_Click);
			this.mnuSwitch.Name = "mnuSwitch";
			this.mnuSwitch.Size = new Size(152, 22);
			this.mnuSwitch.Text = "Switch";
			this.mnuItem.Name = "mnuItem";
			this.mnuItem.Size = new Size(152, 22);
			this.mnuItem.Text = "Item";
			this.mnuQuit.Name = "mnuQuit";
			this.mnuQuit.Size = new Size(152, 22);
			this.mnuQuit.Text = "Quit";
			this.contextItem.Items.AddRange(new ToolStripItem[]
			{
				this.useToolStripMenuItem,
				this.toolStripMenuItem6
			});
			this.contextItem.Name = "contextFree";
			this.contextItem.Size = new Size(94, 48);
			this.useToolStripMenuItem.Name = "useToolStripMenuItem";
			this.useToolStripMenuItem.Size = new Size(152, 22);
			this.useToolStripMenuItem.Text = "Use";
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new Size(93, 22);
			this.toolStripMenuItem6.Text = "<-";
			this.contextSwitch.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem1,
				this.toolStripMenuItem2,
				this.toolStripMenuItem3,
				this.toolStripMenuItem4
			});
			this.contextSwitch.Name = "contextFree";
			this.contextSwitch.Size = new Size(153, 114);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new Size(145, 22);
			this.toolStripMenuItem1.Text = "Switch";
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new Size(152, 22);
			this.toolStripMenuItem2.Text = "Summary";
			this.toolStripMenuItem2.Click += new EventHandler(this.mnuStatus_Click);
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new Size(145, 22);
			this.toolStripMenuItem3.Text = "Check Moves";
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new Size(145, 22);
			this.toolStripMenuItem4.Text = "<-";
			base.AutoScaleMode = AutoScaleMode.None;
			this.BackColor = Color.DimGray;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new Size(512, 384);
			base.Controls.Add(this.pkmn6);
			base.Controls.Add(this.pkmn4);
			base.Controls.Add(this.pkmn2);
			base.Controls.Add(this.pkmn1);
			base.Controls.Add(this.pkmn3);
			base.Controls.Add(this.pkmn5);
			base.Controls.Add(this.lblChoose);
			base.Controls.Add(this.btnCancel);
			this.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new Padding(4);
			base.Name = "PokemonList";
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Pokemon List";
			base.TopMost = true;
			this.pkmn5.ResumeLayout(false);
			((ISupportInitialize)this.pb5).EndInit();
			this.pkmn3.ResumeLayout(false);
			((ISupportInitialize)this.pb3).EndInit();
			this.pkmn1.ResumeLayout(false);
			((ISupportInitialize)this.pb1).EndInit();
			this.pkmn2.ResumeLayout(false);
			((ISupportInitialize)this.pb2).EndInit();
			this.pkmn4.ResumeLayout(false);
			((ISupportInitialize)this.pb4).EndInit();
			this.pkmn6.ResumeLayout(false);
			((ISupportInitialize)this.pb6).EndInit();
			this.contextFree.ResumeLayout(false);
			this.contextItem.ResumeLayout(false);
			this.contextSwitch.ResumeLayout(false);
			base.ResumeLayout(false);
		}
		public PokemonList(PokemonListMode mode)
		{
			this.InitializeComponent();
			Panel[] array = new Panel[]
			{
				this.pkmn1,
				this.pkmn2,
				this.pkmn3,
				this.pkmn4,
				this.pkmn5,
				this.pkmn6
			};
			Label[] array2 = new Label[]
			{
				this.lblName1,
				this.lblName2,
				this.lblName3,
				this.lblName4,
				this.lblName5,
				this.lblName6
			};
			Label[] array3 = new Label[]
			{
				this.lblLevel1,
				this.lblLevel2,
				this.lblLevel3,
				this.lblLevel4,
				this.lblLevel5,
				this.lblLevel6
			};
			Label[] array4 = new Label[]
			{
				this.lblGender1,
				this.lblGender2,
				this.lblGender3,
				this.lblGender4,
				this.lblGender5,
				this.lblGender6
			};
			Label[] array5 = new Label[]
			{
				this.lblHP1,
				this.lblHP2,
				this.lblHP3,
				this.lblHP4,
				this.lblHP5,
				this.lblHP6
			};
			PictureBox[] array6 = new PictureBox[]
			{
				this.pb1,
				this.pb2,
				this.pb3,
				this.pb4,
				this.pb5,
				this.pb6
			};
			ProgressBar[] array7 = new ProgressBar[]
			{
				this.pbHP1,
				this.pbHP2,
				this.pbHP3,
				this.pbHP4,
				this.pbHP5,
				this.pbHP6
			};
			switch (mode)
			{
			case PokemonListMode.Free:
				for (int i = 0; i < array.Length; i++)
				{
					array[i].ContextMenuStrip = this.contextFree;
				}
				break;
			case PokemonListMode.UseItem:
				for (int i = 0; i < array.Length; i++)
				{
					array[i].ContextMenuStrip = this.contextItem;
				}
				break;
			case PokemonListMode.Switch:
				for (int i = 0; i < array.Length; i++)
				{
					array[i].ContextMenuStrip = this.contextSwitch;
				}
				break;
			}
			for (int i = 0; i < Player.Instance.party.Count; i++)
			{
				array[i].Visible = true;
				array6[i].Image = Player.Instance.party[i].FrontImage;
				array2[i].Text = (string.IsNullOrEmpty(Player.Instance.party[i].nickname) ? Player.Instance.party[i].baseStats.name : Player.Instance.party[i].nickname);
				switch (Player.Instance.party[i].gender)
				{
				case Gender.Male:
					array4[i].Text = "♂";
					array4[i].ForeColor = Color.Blue;
					break;
				case Gender.Female:
					array4[i].Text = "♀";
					array4[i].ForeColor = Color.Pink;
					break;
				default:
					array4[i].Text = "";
					break;
				}
				array3[i].Text = "Lv." + Player.Instance.party[i].Level;
				array5[i].Text = Player.Instance.party[i].HP + "/" + Player.Instance.party[i].MaxHP;
				array7[i].Value = (int)(Player.Instance.party[i].HP / Player.Instance.party[i].MaxHP * 100);
			}
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}
		private void pkmn_Click(object sender, EventArgs e)
		{
			Panel panel = sender as Panel;
			panel.ContextMenuStrip.Show(panel, Control.MousePosition);
		}
		private void mnuStatus_Click(object sender, EventArgs e)
		{
			Panel panel = sender as Panel;
			if (panel == this.pkmn1)
			{
				new PokemonStatus(Player.Instance.party[0]).ShowDialog();
			}
			else
			{
				if (panel == this.pkmn2)
				{
					new PokemonStatus(Player.Instance.party[1]).ShowDialog();
				}
				else
				{
					if (panel == this.pkmn3)
					{
						new PokemonStatus(Player.Instance.party[2]).ShowDialog();
					}
					else
					{
						if (panel == this.pkmn4)
						{
							new PokemonStatus(Player.Instance.party[3]).ShowDialog();
						}
						else
						{
							if (panel == this.pkmn5)
							{
								new PokemonStatus(Player.Instance.party[4]).ShowDialog();
							}
							else
							{
								if (panel == this.pkmn6)
								{
									new PokemonStatus(Player.Instance.party[5]).ShowDialog();
								}
							}
						}
					}
				}
			}
		}
	}
}
