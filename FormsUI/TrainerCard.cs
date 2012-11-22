using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace FormsUI
{
	public class TrainerCard : Form
	{
		private bool shouldPaint;
		private Point startPoint;
		private readonly GraphicsPath path;
		private IContainer components = null;
		private Label lblTrainerCard;
		private Label lblNameLabel;
		private Label lblArrow;
		private Label lblNatureLabel;
		private Label lblMoneyLabel;
		private Label lblFlavour;
		private Label lblName;
		private Label lblType;
		private Label lblNature;
		private Label lblMoney;
		private TabControl tabs;
		private TabPage tabFront;
		private TabPage tabBack;
		private PictureBox pbPic;
		private Label lblPokedex;
		private Label lblPokedexLabel;
		private GroupBox groupBox1;
		private Label lblIDLabel;
		private Label lblAdventureBeganLabel;
		private Label lblAdventureBegan;
		private Label lblPlaytime;
		private Label lblPlayTimeLabel;
		private Label lblID;
		private Panel pnlSignature;
		private Button btnSig;
		private Button btnCancel;
		public TrainerCard()
		{
			this.InitializeComponent();
			this.lblName.Text = Player.Instance.name;
			this.lblType.Text = Player.Instance.type.ToString();
			this.lblNature.Text = Player.Instance.nature.ToString();
			this.lblPokedex.Text = Player.Instance.pokemonCaught.ToString();
			this.lblMoney.Text = Player.Instance.money.ToString();
			this.lblAdventureBegan.Text = Player.Instance.adevntureStartedDate.ToString();
			this.lblID.Text = Player.Instance.id.ToString();
			this.lblPlaytime.Text = Player.Instance.playTime.ToString();
			if (Player.Instance.signaturePoints != null && Player.Instance.signatureTypes != null)
			{
				this.path = new GraphicsPath(Player.Instance.signaturePoints, Player.Instance.signatureTypes);
			}
			else
			{
				this.path = new GraphicsPath();
			}
		}
		private void pnlSignature_MouseDown(object sender, MouseEventArgs e)
		{
			this.path.StartFigure();
			this.startPoint = e.Location;
			this.shouldPaint = true;
		}
		private void pnlSignature_MouseUp(object sender, MouseEventArgs e)
		{
			this.shouldPaint = false;
		}
		private void pnlSignature_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.shouldPaint)
			{
				this.path.AddLine(this.startPoint, e.Location);
				this.startPoint = e.Location;
				this.pnlSignature.Invalidate();
			}
		}
		private void pnlSignature_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawPath(new Pen(Color.Black), this.path);
		}
		private void btnSig_Click(object sender, EventArgs e)
		{
			if (!this.pnlSignature.Enabled)
			{
				this.path.Reset();
				this.pnlSignature.Enabled = true;
				this.btnSig.Text = "Done";
			}
			else
			{
				this.pnlSignature.Enabled = false;
				Player.Instance.signaturePoints = this.path.PathPoints;
				Player.Instance.signatureTypes = this.path.PathTypes;
				this.btnSig.Text = "Change Signature";
			}
		}
		private void lblType_Click(object sender, EventArgs e)
		{
			Player expr_06 = Player.Instance;
			expr_06.type += 1;
			this.lblType.Text = Player.Instance.type.ToString();
		}
		private void lblNature_Click(object sender, EventArgs e)
		{
			Player expr_06 = Player.Instance;
			expr_06.nature += 1;
			this.lblNature.Text = Player.Instance.nature.ToString();
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.tabs.SelectedTab == this.tabBack)
			{
				this.btnSig.Visible = true;
			}
			else
			{
				this.btnSig.Visible = false;
			}
		}
		protected override void Dispose(bool disposing)
		{
			this.path.Dispose();
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TrainerCard));
			this.lblTrainerCard = new Label();
			this.lblNameLabel = new Label();
			this.lblArrow = new Label();
			this.lblNatureLabel = new Label();
			this.lblMoneyLabel = new Label();
			this.lblFlavour = new Label();
			this.lblName = new Label();
			this.lblType = new Label();
			this.lblNature = new Label();
			this.lblMoney = new Label();
			this.tabs = new TabControl();
			this.tabFront = new TabPage();
			this.lblPokedex = new Label();
			this.lblPokedexLabel = new Label();
			this.pbPic = new PictureBox();
			this.tabBack = new TabPage();
			this.groupBox1 = new GroupBox();
			this.lblIDLabel = new Label();
			this.lblAdventureBeganLabel = new Label();
			this.lblAdventureBegan = new Label();
			this.lblPlaytime = new Label();
			this.lblPlayTimeLabel = new Label();
			this.lblID = new Label();
			this.pnlSignature = new Panel();
			this.btnSig = new Button();
			this.btnCancel = new Button();
			this.tabs.SuspendLayout();
			this.tabFront.SuspendLayout();
			((ISupportInitialize)this.pbPic).BeginInit();
			this.tabBack.SuspendLayout();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.lblTrainerCard.Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblTrainerCard.ForeColor = Color.Red;
			this.lblTrainerCard.Location = new Point(4, 4);
			this.lblTrainerCard.Name = "lblTrainerCard";
			this.lblTrainerCard.Size = new Size(324, 44);
			this.lblTrainerCard.TabIndex = 0;
			this.lblTrainerCard.Text = "(• TRAINER CARD •)";
			this.lblNameLabel.Location = new Point(16, 56);
			this.lblNameLabel.Name = "lblNameLabel";
			this.lblNameLabel.Size = new Size(60, 18);
			this.lblNameLabel.TabIndex = 1;
			this.lblNameLabel.Text = "NAME";
			this.lblArrow.Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblArrow.ForeColor = Color.White;
			this.lblArrow.Location = new Point(32, 80);
			this.lblArrow.Name = "lblArrow";
			this.lblArrow.Size = new Size(32, 32);
			this.lblArrow.TabIndex = 2;
			this.lblArrow.Text = "▶";
			this.lblNatureLabel.Location = new Point(16, 120);
			this.lblNatureLabel.Name = "lblNatureLabel";
			this.lblNatureLabel.Size = new Size(80, 18);
			this.lblNatureLabel.TabIndex = 3;
			this.lblNatureLabel.Text = "NATURE";
			this.lblMoneyLabel.Location = new Point(8, 232);
			this.lblMoneyLabel.Name = "lblMoneyLabel";
			this.lblMoneyLabel.Size = new Size(72, 18);
			this.lblMoneyLabel.TabIndex = 4;
			this.lblMoneyLabel.Text = "MONEY";
			this.lblFlavour.BorderStyle = BorderStyle.FixedSingle;
			this.lblFlavour.Location = new Point(8, 256);
			this.lblFlavour.Name = "lblFlavour";
			this.lblFlavour.Size = new Size(488, 56);
			this.lblFlavour.TabIndex = 5;
			this.lblFlavour.Text = "I never miss INFORMATION.\r\nIt's part of what I do everyday.";
			this.lblFlavour.TextAlign = ContentAlignment.MiddleLeft;
			this.lblName.Location = new Point(200, 56);
			this.lblName.Name = "lblName";
			this.lblName.Size = new Size(120, 18);
			this.lblName.TabIndex = 6;
			this.lblName.Text = "Bulba";
			this.lblName.TextAlign = ContentAlignment.MiddleRight;
			this.lblType.Location = new Point(200, 88);
			this.lblType.Name = "lblType";
			this.lblType.Size = new Size(120, 18);
			this.lblType.TabIndex = 7;
			this.lblType.Text = "PKMN Trainer";
			this.lblType.TextAlign = ContentAlignment.MiddleRight;
			this.lblType.Click += new EventHandler(this.lblType_Click);
			this.lblNature.Location = new Point(200, 120);
			this.lblNature.Name = "lblNature";
			this.lblNature.Size = new Size(120, 18);
			this.lblNature.TabIndex = 8;
			this.lblNature.Text = "Jolly";
			this.lblNature.TextAlign = ContentAlignment.MiddleRight;
			this.lblNature.Click += new EventHandler(this.lblNature_Click);
			this.lblMoney.Location = new Point(288, 232);
			this.lblMoney.Name = "lblMoney";
			this.lblMoney.Size = new Size(192, 18);
			this.lblMoney.TabIndex = 9;
			this.lblMoney.Text = "$ 9001";
			this.lblMoney.TextAlign = ContentAlignment.MiddleRight;
			this.tabs.Alignment = TabAlignment.Bottom;
			this.tabs.Controls.Add(this.tabFront);
			this.tabs.Controls.Add(this.tabBack);
			this.tabs.Dock = DockStyle.Top;
			this.tabs.Location = new Point(0, 0);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new Size(512, 352);
			this.tabs.TabIndex = 11;
			this.tabs.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
			this.tabFront.BackColor = Color.MediumSpringGreen;
			this.tabFront.Controls.Add(this.lblPokedex);
			this.tabFront.Controls.Add(this.lblPokedexLabel);
			this.tabFront.Controls.Add(this.pbPic);
			this.tabFront.Controls.Add(this.lblTrainerCard);
			this.tabFront.Controls.Add(this.lblNature);
			this.tabFront.Controls.Add(this.lblMoney);
			this.tabFront.Controls.Add(this.lblType);
			this.tabFront.Controls.Add(this.lblNameLabel);
			this.tabFront.Controls.Add(this.lblName);
			this.tabFront.Controls.Add(this.lblNatureLabel);
			this.tabFront.Controls.Add(this.lblFlavour);
			this.tabFront.Controls.Add(this.lblArrow);
			this.tabFront.Controls.Add(this.lblMoneyLabel);
			this.tabFront.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.tabFront.Location = new Point(4, 4);
			this.tabFront.Name = "tabFront";
			this.tabFront.Padding = new Padding(3);
			this.tabFront.Size = new Size(504, 321);
			this.tabFront.TabIndex = 0;
			this.tabFront.Text = "Front";
			this.lblPokedex.Location = new Point(200, 152);
			this.lblPokedex.Name = "lblPokedex";
			this.lblPokedex.Size = new Size(120, 18);
			this.lblPokedex.TabIndex = 12;
			this.lblPokedex.Text = "0";
			this.lblPokedex.TextAlign = ContentAlignment.MiddleRight;
			this.lblPokedexLabel.Location = new Point(16, 152);
			this.lblPokedexLabel.Name = "lblPokedexLabel";
			this.lblPokedexLabel.Size = new Size(96, 18);
			this.lblPokedexLabel.TabIndex = 11;
			this.lblPokedexLabel.Text = "POKEDEX";
			this.pbPic.BorderStyle = BorderStyle.FixedSingle;
			this.pbPic.Location = new Point(336, 8);
			this.pbPic.Name = "pbPic";
			this.pbPic.Size = new Size(160, 160);
			this.pbPic.TabIndex = 10;
			this.pbPic.TabStop = false;
			this.tabBack.BackColor = Color.MediumSpringGreen;
			this.tabBack.Controls.Add(this.groupBox1);
			this.tabBack.Controls.Add(this.pnlSignature);
			this.tabBack.Location = new Point(4, 4);
			this.tabBack.Name = "tabBack";
			this.tabBack.Padding = new Padding(3);
			this.tabBack.Size = new Size(504, 321);
			this.tabBack.TabIndex = 1;
			this.tabBack.Text = "Back";
			this.groupBox1.Controls.Add(this.lblIDLabel);
			this.groupBox1.Controls.Add(this.lblAdventureBeganLabel);
			this.groupBox1.Controls.Add(this.lblAdventureBegan);
			this.groupBox1.Controls.Add(this.lblPlaytime);
			this.groupBox1.Controls.Add(this.lblPlayTimeLabel);
			this.groupBox1.Controls.Add(this.lblID);
			this.groupBox1.Location = new Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(488, 120);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.lblIDLabel.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblIDLabel.Location = new Point(8, 16);
			this.lblIDLabel.Name = "lblIDLabel";
			this.lblIDLabel.Size = new Size(56, 18);
			this.lblIDLabel.TabIndex = 16;
			this.lblIDLabel.Text = "ID No.";
			this.lblAdventureBeganLabel.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblAdventureBeganLabel.Location = new Point(8, 64);
			this.lblAdventureBeganLabel.Name = "lblAdventureBeganLabel";
			this.lblAdventureBeganLabel.Size = new Size(176, 18);
			this.lblAdventureBeganLabel.TabIndex = 12;
			this.lblAdventureBeganLabel.Text = "ADVENTURE BEGAN";
			this.lblAdventureBegan.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblAdventureBegan.Location = new Point(320, 88);
			this.lblAdventureBegan.Name = "lblAdventureBegan";
			this.lblAdventureBegan.Size = new Size(160, 18);
			this.lblAdventureBegan.TabIndex = 17;
			this.lblAdventureBegan.Text = "November 27, 2010";
			this.lblAdventureBegan.TextAlign = ContentAlignment.MiddleRight;
			this.lblPlaytime.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblPlaytime.Location = new Point(424, 40);
			this.lblPlaytime.Name = "lblPlaytime";
			this.lblPlaytime.Size = new Size(56, 18);
			this.lblPlaytime.TabIndex = 13;
			this.lblPlaytime.Text = "77:77";
			this.lblPlaytime.TextAlign = ContentAlignment.MiddleRight;
			this.lblPlayTimeLabel.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblPlayTimeLabel.Location = new Point(8, 40);
			this.lblPlayTimeLabel.Name = "lblPlayTimeLabel";
			this.lblPlayTimeLabel.Size = new Size(96, 18);
			this.lblPlayTimeLabel.TabIndex = 14;
			this.lblPlayTimeLabel.Text = "PLAY TIME";
			this.lblID.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblID.Location = new Point(112, 16);
			this.lblID.Name = "lblID";
			this.lblID.Size = new Size(56, 18);
			this.lblID.TabIndex = 15;
			this.lblID.Text = "77777";
			this.lblID.TextAlign = ContentAlignment.MiddleRight;
			this.pnlSignature.BackColor = Color.White;
			this.pnlSignature.BorderStyle = BorderStyle.FixedSingle;
			this.pnlSignature.Cursor = Cursors.Cross;
			this.pnlSignature.Enabled = false;
			this.pnlSignature.Location = new Point(64, 160);
			this.pnlSignature.Name = "pnlSignature";
			this.pnlSignature.Size = new Size(384, 128);
			this.pnlSignature.TabIndex = 18;
			this.pnlSignature.Paint += new PaintEventHandler(this.pnlSignature_Paint);
			this.pnlSignature.MouseDown += new MouseEventHandler(this.pnlSignature_MouseDown);
			this.pnlSignature.MouseMove += new MouseEventHandler(this.pnlSignature_MouseMove);
			this.pnlSignature.MouseUp += new MouseEventHandler(this.pnlSignature_MouseUp);
			this.btnSig.Location = new Point(0, 352);
			this.btnSig.Name = "btnSig";
			this.btnSig.Size = new Size(144, 31);
			this.btnSig.TabIndex = 20;
			this.btnSig.Text = "Change Signature";
			this.btnSig.UseVisualStyleBackColor = true;
			this.btnSig.Visible = false;
			this.btnSig.Click += new EventHandler(this.btnSig_Click);
			this.btnCancel.DialogResult = DialogResult.Cancel;
			this.btnCancel.FlatAppearance.BorderColor = Color.Black;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.Font = new Font("Arial", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = Color.Red;
			this.btnCancel.Location = new Point(448, 328);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(56, 56);
			this.btnCancel.TabIndex = 21;
			this.btnCancel.Text = "X";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			base.AcceptButton = this.btnCancel;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new Size(512, 384);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnSig);
			base.Controls.Add(this.tabs);
			this.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ForeColor = Color.Black;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TrainerCard";
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Trainer Card";
			this.tabs.ResumeLayout(false);
			this.tabFront.ResumeLayout(false);
			((ISupportInitialize)this.pbPic).EndInit();
			this.tabBack.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
		}
	}
}
