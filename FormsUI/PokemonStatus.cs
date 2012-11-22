using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace FormsUI
{
	public class PokemonStatus : Form
	{
		private IContainer components = null;
		private TabControl tabs;
		private TabPage tabInfo;
		private TabPage tabMoves;
		private Label lblName;
		private PictureBox pbox;
		private Label lblLevel;
		private Label lblItem;
		private Label lblItemName;
		private Label lblEXP;
		private ProgressBar pbEXP;
		private Label lblToNextLv;
		private Label lblExpPoints;
		private Label lblIDNo;
		private Label lblOT;
		private Label lblType;
		private Label lblSpecies;
		private Label lblPokedexNo;
		private Label lblToNextLvLabel;
		private Label lblExpPointsLabel;
		private Label lblIDNoLabel;
		private Label lblOTLabel;
		private Label lblTypeLabel;
		private Label lblSpeciesLabel;
		private Label lblPokedexNoLabel;
		private Label spacer1;
		private Label spacer2;
		private Label spacer7;
		private Label lblPP3;
		private Label spacer6;
		private Label lblMove4;
		private Label lblPP2;
		private Label spacer5;
		private Label lblMove3;
		private Label lblPP1;
		private Label spacer4;
		private Label lblMove2;
		private Label lblPP4;
		private Label spacer3;
		private Label lblMove1;
		private TabPage tabSkills;
		private ProgressBar pbHP;
		private Label lblAbilityName;
		private Label lblpbHPLabel;
		private Label lblAbility;
		private Label lblAbilityDesc1;
		private Label lblHP;
		private Label lblAttack;
		private Label lblDefense;
		private Label lblSpAtk;
		private Label lblSpDef;
		private Label lblSpeed;
		private Label lblAbilityDesc2;
		private Label lblSpeedLabel;
		private Label lblSpDefLabel;
		private Label lblDefenseLabel;
		private Label lblSpAtkLabel;
		private Label lblAttackLabel;
		private Label lblHPLabel;
		private Label spacer8;
		private TabPage tabMemo;
		private Label spacer10;
		private Label spacer9;
		private Label lblFlavour;
		private Label lblChar;
		private Label lblMetLevel;
		private Label lblMetLocation;
		private Label lblDateMet;
		private Label lblNature;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PokemonStatus));
			this.tabs = new TabControl();
			this.tabInfo = new TabPage();
			this.lblEXP = new Label();
			this.lblToNextLv = new Label();
			this.lblExpPoints = new Label();
			this.lblIDNo = new Label();
			this.lblOT = new Label();
			this.lblType = new Label();
			this.lblSpecies = new Label();
			this.lblPokedexNo = new Label();
			this.pbEXP = new ProgressBar();
			this.lblToNextLvLabel = new Label();
			this.lblExpPointsLabel = new Label();
			this.lblIDNoLabel = new Label();
			this.lblOTLabel = new Label();
			this.lblTypeLabel = new Label();
			this.lblSpeciesLabel = new Label();
			this.lblPokedexNoLabel = new Label();
			this.spacer1 = new Label();
			this.spacer2 = new Label();
			this.tabMemo = new TabPage();
			this.spacer10 = new Label();
			this.spacer9 = new Label();
			this.lblFlavour = new Label();
			this.lblChar = new Label();
			this.lblMetLevel = new Label();
			this.lblMetLocation = new Label();
			this.lblDateMet = new Label();
			this.lblNature = new Label();
			this.tabSkills = new TabPage();
			this.pbHP = new ProgressBar();
			this.lblAbilityName = new Label();
			this.lblpbHPLabel = new Label();
			this.lblAbility = new Label();
			this.lblAbilityDesc1 = new Label();
			this.lblHP = new Label();
			this.lblAttack = new Label();
			this.lblDefense = new Label();
			this.lblSpAtk = new Label();
			this.lblSpDef = new Label();
			this.lblSpeed = new Label();
			this.lblAbilityDesc2 = new Label();
			this.lblSpeedLabel = new Label();
			this.lblSpDefLabel = new Label();
			this.lblDefenseLabel = new Label();
			this.lblSpAtkLabel = new Label();
			this.lblAttackLabel = new Label();
			this.lblHPLabel = new Label();
			this.spacer8 = new Label();
			this.tabMoves = new TabPage();
			this.spacer7 = new Label();
			this.lblPP3 = new Label();
			this.spacer6 = new Label();
			this.lblMove4 = new Label();
			this.lblPP2 = new Label();
			this.spacer5 = new Label();
			this.lblMove3 = new Label();
			this.lblPP1 = new Label();
			this.spacer4 = new Label();
			this.lblMove2 = new Label();
			this.lblPP4 = new Label();
			this.spacer3 = new Label();
			this.lblMove1 = new Label();
			this.lblName = new Label();
			this.pbox = new PictureBox();
			this.lblLevel = new Label();
			this.lblItem = new Label();
			this.lblItemName = new Label();
			this.tabs.SuspendLayout();
			this.tabInfo.SuspendLayout();
			this.tabMemo.SuspendLayout();
			this.tabSkills.SuspendLayout();
			this.tabMoves.SuspendLayout();
			((ISupportInitialize)this.pbox).BeginInit();
			base.SuspendLayout();
			this.tabs.Appearance = TabAppearance.FlatButtons;
			this.tabs.Controls.Add(this.tabInfo);
			this.tabs.Controls.Add(this.tabMemo);
			this.tabs.Controls.Add(this.tabSkills);
			this.tabs.Controls.Add(this.tabMoves);
			this.tabs.Dock = DockStyle.Right;
			this.tabs.Location = new Point(194, 0);
			this.tabs.Margin = new Padding(4);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new Size(312, 358);
			this.tabs.TabIndex = 0;
			this.tabInfo.BackColor = Color.LightGreen;
			this.tabInfo.Controls.Add(this.lblEXP);
			this.tabInfo.Controls.Add(this.lblToNextLv);
			this.tabInfo.Controls.Add(this.lblExpPoints);
			this.tabInfo.Controls.Add(this.lblIDNo);
			this.tabInfo.Controls.Add(this.lblOT);
			this.tabInfo.Controls.Add(this.lblType);
			this.tabInfo.Controls.Add(this.lblSpecies);
			this.tabInfo.Controls.Add(this.lblPokedexNo);
			this.tabInfo.Controls.Add(this.pbEXP);
			this.tabInfo.Controls.Add(this.lblToNextLvLabel);
			this.tabInfo.Controls.Add(this.lblExpPointsLabel);
			this.tabInfo.Controls.Add(this.lblIDNoLabel);
			this.tabInfo.Controls.Add(this.lblOTLabel);
			this.tabInfo.Controls.Add(this.lblTypeLabel);
			this.tabInfo.Controls.Add(this.lblSpeciesLabel);
			this.tabInfo.Controls.Add(this.lblPokedexNoLabel);
			this.tabInfo.Controls.Add(this.spacer1);
			this.tabInfo.Controls.Add(this.spacer2);
			this.tabInfo.Location = new Point(4, 30);
			this.tabInfo.Margin = new Padding(4);
			this.tabInfo.Name = "tabInfo";
			this.tabInfo.Padding = new Padding(4);
			this.tabInfo.Size = new Size(304, 324);
			this.tabInfo.TabIndex = 0;
			this.tabInfo.Text = "Info";
			this.lblEXP.Anchor = AnchorStyles.Right;
			this.lblEXP.BackColor = Color.LimeGreen;
			this.lblEXP.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblEXP.ForeColor = Color.White;
			this.lblEXP.Location = new Point(112, 304);
			this.lblEXP.Margin = new Padding(4, 0, 4, 0);
			this.lblEXP.Name = "lblEXP";
			this.lblEXP.Size = new Size(40, 16);
			this.lblEXP.TabIndex = 15;
			this.lblEXP.Text = "EXP";
			this.lblToNextLv.Anchor = AnchorStyles.Right;
			this.lblToNextLv.BackColor = Color.White;
			this.lblToNextLv.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblToNextLv.ForeColor = Color.Black;
			this.lblToNextLv.Location = new Point(136, 272);
			this.lblToNextLv.Margin = new Padding(4, 0, 4, 0);
			this.lblToNextLv.Name = "lblToNextLv";
			this.lblToNextLv.Padding = new Padding(0, 0, 24, 0);
			this.lblToNextLv.Size = new Size(156, 32);
			this.lblToNextLv.TabIndex = 13;
			this.lblToNextLv.Text = "123456";
			this.lblToNextLv.TextAlign = ContentAlignment.MiddleRight;
			this.lblExpPoints.Anchor = AnchorStyles.Right;
			this.lblExpPoints.BackColor = Color.White;
			this.lblExpPoints.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblExpPoints.ForeColor = Color.Black;
			this.lblExpPoints.Location = new Point(136, 208);
			this.lblExpPoints.Margin = new Padding(4, 0, 4, 0);
			this.lblExpPoints.Name = "lblExpPoints";
			this.lblExpPoints.Padding = new Padding(0, 0, 24, 0);
			this.lblExpPoints.Size = new Size(156, 32);
			this.lblExpPoints.TabIndex = 12;
			this.lblExpPoints.Text = "654321";
			this.lblExpPoints.TextAlign = ContentAlignment.MiddleRight;
			this.lblIDNo.Anchor = AnchorStyles.Right;
			this.lblIDNo.BackColor = Color.LightYellow;
			this.lblIDNo.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblIDNo.ForeColor = Color.Black;
			this.lblIDNo.Location = new Point(136, 144);
			this.lblIDNo.Margin = new Padding(4, 0, 4, 0);
			this.lblIDNo.Name = "lblIDNo";
			this.lblIDNo.Size = new Size(156, 32);
			this.lblIDNo.TabIndex = 11;
			this.lblIDNo.Text = "123456";
			this.lblIDNo.TextAlign = ContentAlignment.MiddleCenter;
			this.lblOT.Anchor = AnchorStyles.Right;
			this.lblOT.BackColor = Color.White;
			this.lblOT.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblOT.ForeColor = Color.Blue;
			this.lblOT.Location = new Point(136, 112);
			this.lblOT.Margin = new Padding(4, 0, 4, 0);
			this.lblOT.Name = "lblOT";
			this.lblOT.Size = new Size(156, 32);
			this.lblOT.TabIndex = 10;
			this.lblOT.Text = "RED";
			this.lblOT.TextAlign = ContentAlignment.MiddleCenter;
			this.lblType.Anchor = AnchorStyles.Right;
			this.lblType.BackColor = Color.LightYellow;
			this.lblType.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblType.ForeColor = Color.Black;
			this.lblType.Location = new Point(136, 80);
			this.lblType.Margin = new Padding(4, 0, 4, 0);
			this.lblType.Name = "lblType";
			this.lblType.Size = new Size(156, 32);
			this.lblType.TabIndex = 9;
			this.lblType.Text = "Psychic";
			this.lblType.TextAlign = ContentAlignment.MiddleCenter;
			this.lblSpecies.Anchor = AnchorStyles.Right;
			this.lblSpecies.BackColor = Color.White;
			this.lblSpecies.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpecies.ForeColor = Color.Black;
			this.lblSpecies.Location = new Point(136, 48);
			this.lblSpecies.Margin = new Padding(4, 0, 4, 0);
			this.lblSpecies.Name = "lblSpecies";
			this.lblSpecies.Size = new Size(156, 32);
			this.lblSpecies.TabIndex = 8;
			this.lblSpecies.Text = "MEW";
			this.lblSpecies.TextAlign = ContentAlignment.MiddleCenter;
			this.lblPokedexNo.Anchor = AnchorStyles.Right;
			this.lblPokedexNo.BackColor = Color.LightYellow;
			this.lblPokedexNo.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblPokedexNo.ForeColor = Color.Black;
			this.lblPokedexNo.Location = new Point(136, 16);
			this.lblPokedexNo.Margin = new Padding(4, 0, 4, 0);
			this.lblPokedexNo.Name = "lblPokedexNo";
			this.lblPokedexNo.Size = new Size(156, 32);
			this.lblPokedexNo.TabIndex = 7;
			this.lblPokedexNo.Text = "151";
			this.lblPokedexNo.TextAlign = ContentAlignment.MiddleCenter;
			this.pbEXP.Anchor = AnchorStyles.Right;
			this.pbEXP.Location = new Point(152, 304);
			this.pbEXP.Margin = new Padding(4);
			this.pbEXP.Name = "pbEXP";
			this.pbEXP.Size = new Size(144, 16);
			this.pbEXP.Style = ProgressBarStyle.Continuous;
			this.pbEXP.TabIndex = 14;
			this.lblToNextLvLabel.BackColor = Color.Transparent;
			this.lblToNextLvLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblToNextLvLabel.ForeColor = Color.White;
			this.lblToNextLvLabel.Location = new Point(0, 240);
			this.lblToNextLvLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblToNextLvLabel.Name = "lblToNextLvLabel";
			this.lblToNextLvLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblToNextLvLabel.Size = new Size(112, 32);
			this.lblToNextLvLabel.TabIndex = 6;
			this.lblToNextLvLabel.Text = "To Next Lv.";
			this.lblToNextLvLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblExpPointsLabel.BackColor = Color.Transparent;
			this.lblExpPointsLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblExpPointsLabel.ForeColor = Color.White;
			this.lblExpPointsLabel.Location = new Point(0, 176);
			this.lblExpPointsLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblExpPointsLabel.Name = "lblExpPointsLabel";
			this.lblExpPointsLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblExpPointsLabel.Size = new Size(112, 32);
			this.lblExpPointsLabel.TabIndex = 5;
			this.lblExpPointsLabel.Text = "Exp. Points";
			this.lblExpPointsLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblIDNoLabel.BackColor = Color.LimeGreen;
			this.lblIDNoLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblIDNoLabel.ForeColor = Color.White;
			this.lblIDNoLabel.Location = new Point(0, 144);
			this.lblIDNoLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblIDNoLabel.Name = "lblIDNoLabel";
			this.lblIDNoLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblIDNoLabel.Size = new Size(304, 32);
			this.lblIDNoLabel.TabIndex = 4;
			this.lblIDNoLabel.Text = "ID No.";
			this.lblIDNoLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblOTLabel.BackColor = Color.Transparent;
			this.lblOTLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblOTLabel.ForeColor = Color.White;
			this.lblOTLabel.Location = new Point(0, 112);
			this.lblOTLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblOTLabel.Name = "lblOTLabel";
			this.lblOTLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblOTLabel.Size = new Size(56, 32);
			this.lblOTLabel.TabIndex = 3;
			this.lblOTLabel.Text = "OT";
			this.lblOTLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblTypeLabel.BackColor = Color.LimeGreen;
			this.lblTypeLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblTypeLabel.ForeColor = Color.White;
			this.lblTypeLabel.Location = new Point(0, 80);
			this.lblTypeLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblTypeLabel.Name = "lblTypeLabel";
			this.lblTypeLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblTypeLabel.Size = new Size(304, 32);
			this.lblTypeLabel.TabIndex = 2;
			this.lblTypeLabel.Text = "Type";
			this.lblTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblSpeciesLabel.BackColor = Color.Transparent;
			this.lblSpeciesLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpeciesLabel.ForeColor = Color.White;
			this.lblSpeciesLabel.Location = new Point(0, 48);
			this.lblSpeciesLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblSpeciesLabel.Name = "lblSpeciesLabel";
			this.lblSpeciesLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblSpeciesLabel.Size = new Size(80, 32);
			this.lblSpeciesLabel.TabIndex = 1;
			this.lblSpeciesLabel.Text = "Name";
			this.lblSpeciesLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblPokedexNoLabel.BackColor = Color.LimeGreen;
			this.lblPokedexNoLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblPokedexNoLabel.ForeColor = Color.White;
			this.lblPokedexNoLabel.Location = new Point(0, 16);
			this.lblPokedexNoLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblPokedexNoLabel.Name = "lblPokedexNoLabel";
			this.lblPokedexNoLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblPokedexNoLabel.Size = new Size(304, 32);
			this.lblPokedexNoLabel.TabIndex = 0;
			this.lblPokedexNoLabel.Text = "Pokedex No.";
			this.lblPokedexNoLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.spacer1.BackColor = Color.LimeGreen;
			this.spacer1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.spacer1.ForeColor = Color.White;
			this.spacer1.Location = new Point(0, 208);
			this.spacer1.Margin = new Padding(4, 0, 4, 0);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new Size(304, 32);
			this.spacer1.TabIndex = 16;
			this.spacer1.TextAlign = ContentAlignment.MiddleLeft;
			this.spacer2.BackColor = Color.LimeGreen;
			this.spacer2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.spacer2.ForeColor = Color.White;
			this.spacer2.Location = new Point(0, 272);
			this.spacer2.Margin = new Padding(4, 0, 4, 0);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new Size(304, 32);
			this.spacer2.TabIndex = 17;
			this.spacer2.TextAlign = ContentAlignment.MiddleLeft;
			this.tabMemo.BackColor = Color.PaleTurquoise;
			this.tabMemo.Controls.Add(this.spacer10);
			this.tabMemo.Controls.Add(this.spacer9);
			this.tabMemo.Controls.Add(this.lblFlavour);
			this.tabMemo.Controls.Add(this.lblChar);
			this.tabMemo.Controls.Add(this.lblMetLevel);
			this.tabMemo.Controls.Add(this.lblMetLocation);
			this.tabMemo.Controls.Add(this.lblDateMet);
			this.tabMemo.Controls.Add(this.lblNature);
			this.tabMemo.Location = new Point(4, 30);
			this.tabMemo.Name = "tabMemo";
			this.tabMemo.Padding = new Padding(3);
			this.tabMemo.Size = new Size(304, 324);
			this.tabMemo.TabIndex = 3;
			this.tabMemo.Text = "Memo";
			this.spacer10.BackColor = Color.CadetBlue;
			this.spacer10.Location = new Point(0, 264);
			this.spacer10.Name = "spacer10";
			this.spacer10.Padding = new Padding(16, 0, 0, 0);
			this.spacer10.Size = new Size(304, 48);
			this.spacer10.TabIndex = 7;
			this.spacer10.TextAlign = ContentAlignment.MiddleLeft;
			this.spacer9.BackColor = Color.CadetBlue;
			this.spacer9.Location = new Point(0, 144);
			this.spacer9.Name = "spacer9";
			this.spacer9.Padding = new Padding(16, 0, 0, 0);
			this.spacer9.Size = new Size(304, 32);
			this.spacer9.TabIndex = 6;
			this.spacer9.TextAlign = ContentAlignment.MiddleLeft;
			this.lblFlavour.BackColor = Color.CadetBlue;
			this.lblFlavour.Location = new Point(0, 208);
			this.lblFlavour.Name = "lblFlavour";
			this.lblFlavour.Padding = new Padding(16, 0, 0, 0);
			this.lblFlavour.Size = new Size(304, 32);
			this.lblFlavour.TabIndex = 5;
			this.lblFlavour.Text = "lblFlavour";
			this.lblFlavour.TextAlign = ContentAlignment.MiddleLeft;
			this.lblChar.Location = new Point(0, 176);
			this.lblChar.Name = "lblChar";
			this.lblChar.Padding = new Padding(16, 0, 0, 0);
			this.lblChar.Size = new Size(304, 32);
			this.lblChar.TabIndex = 4;
			this.lblChar.Text = "lblChar";
			this.lblChar.TextAlign = ContentAlignment.MiddleLeft;
			this.lblMetLevel.Location = new Point(0, 112);
			this.lblMetLevel.Name = "lblMetLevel";
			this.lblMetLevel.Padding = new Padding(16, 0, 0, 0);
			this.lblMetLevel.Size = new Size(304, 32);
			this.lblMetLevel.TabIndex = 3;
			this.lblMetLevel.Text = "lblMetLevel";
			this.lblMetLevel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblMetLocation.BackColor = Color.CadetBlue;
			this.lblMetLocation.Location = new Point(0, 80);
			this.lblMetLocation.Name = "lblMetLocation";
			this.lblMetLocation.Padding = new Padding(16, 0, 0, 0);
			this.lblMetLocation.Size = new Size(304, 32);
			this.lblMetLocation.TabIndex = 2;
			this.lblMetLocation.Text = "lblMetLocation";
			this.lblMetLocation.TextAlign = ContentAlignment.MiddleLeft;
			this.lblDateMet.Location = new Point(0, 48);
			this.lblDateMet.Name = "lblDateMet";
			this.lblDateMet.Padding = new Padding(16, 0, 0, 0);
			this.lblDateMet.Size = new Size(304, 32);
			this.lblDateMet.TabIndex = 1;
			this.lblDateMet.Text = "lblDateMet";
			this.lblDateMet.TextAlign = ContentAlignment.MiddleLeft;
			this.lblNature.BackColor = Color.CadetBlue;
			this.lblNature.Location = new Point(0, 16);
			this.lblNature.Name = "lblNature";
			this.lblNature.Padding = new Padding(16, 0, 0, 0);
			this.lblNature.Size = new Size(304, 32);
			this.lblNature.TabIndex = 0;
			this.lblNature.Text = "lblNature";
			this.lblNature.TextAlign = ContentAlignment.MiddleLeft;
			this.tabSkills.BackColor = Color.LightSteelBlue;
			this.tabSkills.Controls.Add(this.pbHP);
			this.tabSkills.Controls.Add(this.lblAbilityName);
			this.tabSkills.Controls.Add(this.lblpbHPLabel);
			this.tabSkills.Controls.Add(this.lblAbility);
			this.tabSkills.Controls.Add(this.lblAbilityDesc1);
			this.tabSkills.Controls.Add(this.lblHP);
			this.tabSkills.Controls.Add(this.lblAttack);
			this.tabSkills.Controls.Add(this.lblDefense);
			this.tabSkills.Controls.Add(this.lblSpAtk);
			this.tabSkills.Controls.Add(this.lblSpDef);
			this.tabSkills.Controls.Add(this.lblSpeed);
			this.tabSkills.Controls.Add(this.lblAbilityDesc2);
			this.tabSkills.Controls.Add(this.lblSpeedLabel);
			this.tabSkills.Controls.Add(this.lblSpDefLabel);
			this.tabSkills.Controls.Add(this.lblDefenseLabel);
			this.tabSkills.Controls.Add(this.lblSpAtkLabel);
			this.tabSkills.Controls.Add(this.lblAttackLabel);
			this.tabSkills.Controls.Add(this.lblHPLabel);
			this.tabSkills.Controls.Add(this.spacer8);
			this.tabSkills.Location = new Point(4, 30);
			this.tabSkills.Margin = new Padding(4);
			this.tabSkills.Name = "tabSkills";
			this.tabSkills.Padding = new Padding(4);
			this.tabSkills.Size = new Size(304, 324);
			this.tabSkills.TabIndex = 2;
			this.tabSkills.Text = "Skills";
			this.pbHP.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.pbHP.ForeColor = Color.LimeGreen;
			this.pbHP.Location = new Point(176, 40);
			this.pbHP.Margin = new Padding(4);
			this.pbHP.Name = "pbHP";
			this.pbHP.Size = new Size(104, 12);
			this.pbHP.Style = ProgressBarStyle.Continuous;
			this.pbHP.TabIndex = 18;
			this.lblAbilityName.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.lblAbilityName.BackColor = Color.Transparent;
			this.lblAbilityName.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblAbilityName.ForeColor = Color.White;
			this.lblAbilityName.Location = new Point(72, 232);
			this.lblAbilityName.Margin = new Padding(4, 0, 4, 0);
			this.lblAbilityName.Name = "lblAbilityName";
			this.lblAbilityName.Size = new Size(232, 30);
			this.lblAbilityName.TabIndex = 16;
			this.lblAbilityName.Text = "Torrent";
			this.lblAbilityName.TextAlign = ContentAlignment.MiddleLeft;
			this.lblpbHPLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblpbHPLabel.BackColor = Color.Black;
			this.lblpbHPLabel.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblpbHPLabel.ForeColor = Color.LightCoral;
			this.lblpbHPLabel.Location = new Point(148, 37);
			this.lblpbHPLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblpbHPLabel.Name = "lblpbHPLabel";
			this.lblpbHPLabel.Size = new Size(140, 18);
			this.lblpbHPLabel.TabIndex = 19;
			this.lblpbHPLabel.Text = "HP";
			this.lblAbility.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.lblAbility.BackColor = Color.MediumSlateBlue;
			this.lblAbility.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblAbility.ForeColor = Color.White;
			this.lblAbility.Location = new Point(0, 224);
			this.lblAbility.Margin = new Padding(4, 0, 4, 0);
			this.lblAbility.Name = "lblAbility";
			this.lblAbility.Padding = new Padding(0, 0, 0, 11);
			this.lblAbility.Size = new Size(304, 37);
			this.lblAbility.TabIndex = 17;
			this.lblAbility.Text = "Ability";
			this.lblAbility.TextAlign = ContentAlignment.BottomLeft;
			this.lblAbilityDesc1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.lblAbilityDesc1.BackColor = Color.White;
			this.lblAbilityDesc1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblAbilityDesc1.ForeColor = Color.Black;
			this.lblAbilityDesc1.Location = new Point(0, 261);
			this.lblAbilityDesc1.Margin = new Padding(4, 0, 4, 0);
			this.lblAbilityDesc1.Name = "lblAbilityDesc1";
			this.lblAbilityDesc1.Size = new Size(304, 32);
			this.lblAbilityDesc1.TabIndex = 15;
			this.lblAbilityDesc1.Text = "Powers up Water-type";
			this.lblAbilityDesc1.TextAlign = ContentAlignment.MiddleLeft;
			this.lblHP.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblHP.BackColor = Color.White;
			this.lblHP.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblHP.ForeColor = Color.Black;
			this.lblHP.Location = new Point(152, 0);
			this.lblHP.Margin = new Padding(4, 0, 4, 0);
			this.lblHP.Name = "lblHP";
			this.lblHP.Size = new Size(144, 32);
			this.lblHP.TabIndex = 14;
			this.lblHP.Text = "20/20";
			this.lblHP.TextAlign = ContentAlignment.MiddleCenter;
			this.lblAttack.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblAttack.BackColor = Color.White;
			this.lblAttack.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblAttack.ForeColor = Color.Black;
			this.lblAttack.Location = new Point(168, 64);
			this.lblAttack.Margin = new Padding(4, 0, 4, 0);
			this.lblAttack.Name = "lblAttack";
			this.lblAttack.Padding = new Padding(0, 0, 24, 0);
			this.lblAttack.Size = new Size(120, 32);
			this.lblAttack.TabIndex = 13;
			this.lblAttack.Text = "12";
			this.lblAttack.TextAlign = ContentAlignment.MiddleRight;
			this.lblDefense.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblDefense.BackColor = Color.LightYellow;
			this.lblDefense.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblDefense.ForeColor = Color.Black;
			this.lblDefense.Location = new Point(168, 96);
			this.lblDefense.Margin = new Padding(4, 0, 4, 0);
			this.lblDefense.Name = "lblDefense";
			this.lblDefense.Padding = new Padding(0, 0, 24, 0);
			this.lblDefense.Size = new Size(120, 32);
			this.lblDefense.TabIndex = 12;
			this.lblDefense.Text = "10";
			this.lblDefense.TextAlign = ContentAlignment.MiddleRight;
			this.lblSpAtk.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblSpAtk.BackColor = Color.White;
			this.lblSpAtk.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpAtk.ForeColor = Color.Black;
			this.lblSpAtk.Location = new Point(168, 128);
			this.lblSpAtk.Margin = new Padding(4, 0, 4, 0);
			this.lblSpAtk.Name = "lblSpAtk";
			this.lblSpAtk.Padding = new Padding(0, 0, 24, 0);
			this.lblSpAtk.Size = new Size(120, 32);
			this.lblSpAtk.TabIndex = 11;
			this.lblSpAtk.Text = "9";
			this.lblSpAtk.TextAlign = ContentAlignment.MiddleRight;
			this.lblSpDef.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblSpDef.BackColor = Color.LightYellow;
			this.lblSpDef.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpDef.ForeColor = Color.Black;
			this.lblSpDef.Location = new Point(168, 160);
			this.lblSpDef.Margin = new Padding(4, 0, 4, 0);
			this.lblSpDef.Name = "lblSpDef";
			this.lblSpDef.Padding = new Padding(0, 0, 24, 0);
			this.lblSpDef.Size = new Size(120, 32);
			this.lblSpDef.TabIndex = 10;
			this.lblSpDef.Text = "11";
			this.lblSpDef.TextAlign = ContentAlignment.MiddleRight;
			this.lblSpeed.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblSpeed.BackColor = Color.White;
			this.lblSpeed.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpeed.ForeColor = Color.Black;
			this.lblSpeed.Location = new Point(168, 192);
			this.lblSpeed.Margin = new Padding(4, 0, 4, 0);
			this.lblSpeed.Name = "lblSpeed";
			this.lblSpeed.Padding = new Padding(0, 0, 24, 0);
			this.lblSpeed.Size = new Size(120, 32);
			this.lblSpeed.TabIndex = 9;
			this.lblSpeed.Text = "10";
			this.lblSpeed.TextAlign = ContentAlignment.MiddleRight;
			this.lblAbilityDesc2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.lblAbilityDesc2.BackColor = Color.LightYellow;
			this.lblAbilityDesc2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblAbilityDesc2.ForeColor = Color.Black;
			this.lblAbilityDesc2.Location = new Point(0, 293);
			this.lblAbilityDesc2.Margin = new Padding(4, 0, 4, 0);
			this.lblAbilityDesc2.Name = "lblAbilityDesc2";
			this.lblAbilityDesc2.Size = new Size(304, 32);
			this.lblAbilityDesc2.TabIndex = 8;
			this.lblAbilityDesc2.Text = "moves in a pinch.";
			this.lblAbilityDesc2.TextAlign = ContentAlignment.MiddleLeft;
			this.lblSpeedLabel.BackColor = Color.Transparent;
			this.lblSpeedLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpeedLabel.ForeColor = Color.White;
			this.lblSpeedLabel.Location = new Point(0, 192);
			this.lblSpeedLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblSpeedLabel.Name = "lblSpeedLabel";
			this.lblSpeedLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblSpeedLabel.Size = new Size(80, 32);
			this.lblSpeedLabel.TabIndex = 7;
			this.lblSpeedLabel.Text = "Speed";
			this.lblSpeedLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblSpDefLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.lblSpDefLabel.BackColor = Color.MediumSlateBlue;
			this.lblSpDefLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpDefLabel.ForeColor = Color.White;
			this.lblSpDefLabel.Location = new Point(0, 160);
			this.lblSpDefLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblSpDefLabel.Name = "lblSpDefLabel";
			this.lblSpDefLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblSpDefLabel.Size = new Size(304, 32);
			this.lblSpDefLabel.TabIndex = 6;
			this.lblSpDefLabel.Text = "Sp. Def";
			this.lblSpDefLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblDefenseLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.lblDefenseLabel.BackColor = Color.MediumSlateBlue;
			this.lblDefenseLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblDefenseLabel.ForeColor = Color.White;
			this.lblDefenseLabel.Location = new Point(0, 96);
			this.lblDefenseLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblDefenseLabel.Name = "lblDefenseLabel";
			this.lblDefenseLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblDefenseLabel.Size = new Size(304, 32);
			this.lblDefenseLabel.TabIndex = 5;
			this.lblDefenseLabel.Text = "Defense";
			this.lblDefenseLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblSpAtkLabel.BackColor = Color.Transparent;
			this.lblSpAtkLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpAtkLabel.ForeColor = Color.White;
			this.lblSpAtkLabel.Location = new Point(0, 128);
			this.lblSpAtkLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblSpAtkLabel.Name = "lblSpAtkLabel";
			this.lblSpAtkLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblSpAtkLabel.Size = new Size(88, 32);
			this.lblSpAtkLabel.TabIndex = 4;
			this.lblSpAtkLabel.Text = "Sp. Atk";
			this.lblSpAtkLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblAttackLabel.BackColor = Color.Transparent;
			this.lblAttackLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblAttackLabel.ForeColor = Color.White;
			this.lblAttackLabel.Location = new Point(0, 64);
			this.lblAttackLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblAttackLabel.Name = "lblAttackLabel";
			this.lblAttackLabel.Padding = new Padding(24, 0, 0, 0);
			this.lblAttackLabel.Size = new Size(80, 32);
			this.lblAttackLabel.TabIndex = 3;
			this.lblAttackLabel.Text = "Attack";
			this.lblAttackLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblHPLabel.BackColor = Color.Transparent;
			this.lblHPLabel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblHPLabel.ForeColor = Color.White;
			this.lblHPLabel.Location = new Point(0, 0);
			this.lblHPLabel.Margin = new Padding(4, 0, 4, 0);
			this.lblHPLabel.Name = "lblHPLabel";
			this.lblHPLabel.Size = new Size(152, 32);
			this.lblHPLabel.TabIndex = 2;
			this.lblHPLabel.Text = "HP";
			this.lblHPLabel.TextAlign = ContentAlignment.MiddleCenter;
			this.spacer8.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.spacer8.BackColor = Color.MediumSlateBlue;
			this.spacer8.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.spacer8.ForeColor = Color.White;
			this.spacer8.Location = new Point(0, 32);
			this.spacer8.Margin = new Padding(4, 0, 4, 0);
			this.spacer8.Name = "spacer8";
			this.spacer8.Padding = new Padding(24, 0, 0, 0);
			this.spacer8.Size = new Size(304, 32);
			this.spacer8.TabIndex = 20;
			this.spacer8.TextAlign = ContentAlignment.MiddleLeft;
			this.tabMoves.BackColor = Color.LightCoral;
			this.tabMoves.Controls.Add(this.spacer7);
			this.tabMoves.Controls.Add(this.lblPP3);
			this.tabMoves.Controls.Add(this.spacer6);
			this.tabMoves.Controls.Add(this.lblMove4);
			this.tabMoves.Controls.Add(this.lblPP2);
			this.tabMoves.Controls.Add(this.spacer5);
			this.tabMoves.Controls.Add(this.lblMove3);
			this.tabMoves.Controls.Add(this.lblPP1);
			this.tabMoves.Controls.Add(this.spacer4);
			this.tabMoves.Controls.Add(this.lblMove2);
			this.tabMoves.Controls.Add(this.lblPP4);
			this.tabMoves.Controls.Add(this.spacer3);
			this.tabMoves.Controls.Add(this.lblMove1);
			this.tabMoves.Location = new Point(4, 30);
			this.tabMoves.Margin = new Padding(4);
			this.tabMoves.Name = "tabMoves";
			this.tabMoves.Padding = new Padding(4);
			this.tabMoves.Size = new Size(304, 324);
			this.tabMoves.TabIndex = 1;
			this.tabMoves.Text = "Moves";
			this.spacer7.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.spacer7.BackColor = Color.Tomato;
			this.spacer7.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.spacer7.ForeColor = Color.White;
			this.spacer7.Location = new Point(0, 256);
			this.spacer7.Margin = new Padding(4, 0, 4, 0);
			this.spacer7.Name = "spacer7";
			this.spacer7.Size = new Size(304, 32);
			this.spacer7.TabIndex = 12;
			this.spacer7.TextAlign = ContentAlignment.MiddleCenter;
			this.lblPP3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblPP3.BackColor = Color.White;
			this.lblPP3.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblPP3.ForeColor = Color.Black;
			this.lblPP3.Location = new Point(152, 160);
			this.lblPP3.Margin = new Padding(4, 0, 4, 0);
			this.lblPP3.Name = "lblPP3";
			this.lblPP3.Size = new Size(152, 32);
			this.lblPP3.TabIndex = 11;
			this.lblPP3.Text = "lblPP3";
			this.lblPP3.TextAlign = ContentAlignment.MiddleLeft;
			this.spacer6.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.spacer6.ForeColor = Color.White;
			this.spacer6.Location = new Point(0, 224);
			this.spacer6.Margin = new Padding(4, 0, 4, 0);
			this.spacer6.Name = "spacer6";
			this.spacer6.Size = new Size(152, 32);
			this.spacer6.TabIndex = 10;
			this.lblMove4.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.lblMove4.BackColor = Color.Tomato;
			this.lblMove4.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblMove4.ForeColor = Color.White;
			this.lblMove4.Location = new Point(0, 192);
			this.lblMove4.Margin = new Padding(4, 0, 4, 0);
			this.lblMove4.Name = "lblMove4";
			this.lblMove4.Size = new Size(304, 32);
			this.lblMove4.TabIndex = 9;
			this.lblMove4.Text = "lblMove4";
			this.lblMove4.TextAlign = ContentAlignment.MiddleCenter;
			this.lblPP2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblPP2.BackColor = Color.White;
			this.lblPP2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblPP2.ForeColor = Color.Black;
			this.lblPP2.Location = new Point(152, 96);
			this.lblPP2.Margin = new Padding(4, 0, 4, 0);
			this.lblPP2.Name = "lblPP2";
			this.lblPP2.Size = new Size(152, 32);
			this.lblPP2.TabIndex = 8;
			this.lblPP2.Text = "lblPP2";
			this.lblPP2.TextAlign = ContentAlignment.MiddleLeft;
			this.spacer5.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.spacer5.ForeColor = Color.White;
			this.spacer5.Location = new Point(0, 160);
			this.spacer5.Margin = new Padding(4, 0, 4, 0);
			this.spacer5.Name = "spacer5";
			this.spacer5.Size = new Size(152, 32);
			this.spacer5.TabIndex = 7;
			this.lblMove3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.lblMove3.BackColor = Color.Tomato;
			this.lblMove3.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblMove3.ForeColor = Color.White;
			this.lblMove3.Location = new Point(0, 128);
			this.lblMove3.Margin = new Padding(4, 0, 4, 0);
			this.lblMove3.Name = "lblMove3";
			this.lblMove3.Size = new Size(304, 32);
			this.lblMove3.TabIndex = 6;
			this.lblMove3.Text = "lblMove3";
			this.lblMove3.TextAlign = ContentAlignment.MiddleCenter;
			this.lblPP1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblPP1.BackColor = Color.White;
			this.lblPP1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblPP1.ForeColor = Color.Black;
			this.lblPP1.Location = new Point(152, 32);
			this.lblPP1.Margin = new Padding(4, 0, 4, 0);
			this.lblPP1.Name = "lblPP1";
			this.lblPP1.Size = new Size(152, 32);
			this.lblPP1.TabIndex = 5;
			this.lblPP1.Text = "lblPP1";
			this.lblPP1.TextAlign = ContentAlignment.MiddleLeft;
			this.spacer4.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.spacer4.ForeColor = Color.White;
			this.spacer4.Location = new Point(0, 96);
			this.spacer4.Margin = new Padding(4, 0, 4, 0);
			this.spacer4.Name = "spacer4";
			this.spacer4.Size = new Size(152, 32);
			this.spacer4.TabIndex = 4;
			this.lblMove2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.lblMove2.BackColor = Color.Tomato;
			this.lblMove2.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblMove2.ForeColor = Color.White;
			this.lblMove2.Location = new Point(0, 64);
			this.lblMove2.Margin = new Padding(4, 0, 4, 0);
			this.lblMove2.Name = "lblMove2";
			this.lblMove2.Size = new Size(304, 32);
			this.lblMove2.TabIndex = 3;
			this.lblMove2.Text = "lblMove2";
			this.lblMove2.TextAlign = ContentAlignment.MiddleCenter;
			this.lblPP4.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblPP4.BackColor = Color.White;
			this.lblPP4.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblPP4.ForeColor = Color.Black;
			this.lblPP4.Location = new Point(152, 224);
			this.lblPP4.Margin = new Padding(4, 0, 4, 0);
			this.lblPP4.Name = "lblPP4";
			this.lblPP4.Size = new Size(152, 32);
			this.lblPP4.TabIndex = 2;
			this.lblPP4.Text = "lblPP4";
			this.lblPP4.TextAlign = ContentAlignment.MiddleLeft;
			this.spacer3.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.spacer3.ForeColor = Color.White;
			this.spacer3.Location = new Point(0, 32);
			this.spacer3.Margin = new Padding(4, 0, 4, 0);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new Size(152, 32);
			this.spacer3.TabIndex = 1;
			this.lblMove1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.lblMove1.BackColor = Color.Tomato;
			this.lblMove1.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblMove1.ForeColor = Color.White;
			this.lblMove1.Location = new Point(0, 0);
			this.lblMove1.Margin = new Padding(4, 0, 4, 0);
			this.lblMove1.Name = "lblMove1";
			this.lblMove1.Size = new Size(304, 32);
			this.lblMove1.TabIndex = 0;
			this.lblMove1.Text = "lblMove1";
			this.lblMove1.TextAlign = ContentAlignment.MiddleCenter;
			this.lblName.BackColor = Color.Gold;
			this.lblName.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblName.ForeColor = Color.White;
			this.lblName.ImageAlign = ContentAlignment.MiddleLeft;
			this.lblName.Location = new Point(0, 0);
			this.lblName.Margin = new Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Padding = new Padding(24, 0, 0, 0);
			this.lblName.Size = new Size(192, 40);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Mew~ :3";
			this.lblName.TextAlign = ContentAlignment.MiddleLeft;
			this.pbox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.pbox.BackColor = Color.WhiteSmoke;
			this.pbox.Location = new Point(32, 120);
			this.pbox.Margin = new Padding(4);
			this.pbox.Name = "pbox";
			this.pbox.Size = new Size(128, 128);
			this.pbox.TabIndex = 2;
			this.pbox.TabStop = false;
			this.lblLevel.BackColor = Color.White;
			this.lblLevel.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblLevel.Location = new Point(0, 40);
			this.lblLevel.Margin = new Padding(4, 0, 4, 0);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Padding = new Padding(16, 0, 0, 0);
			this.lblLevel.Size = new Size(192, 33);
			this.lblLevel.TabIndex = 3;
			this.lblLevel.Text = "Lv.50";
			this.lblLevel.TextAlign = ContentAlignment.MiddleLeft;
			this.lblItem.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.lblItem.BackColor = Color.Gold;
			this.lblItem.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblItem.ForeColor = Color.White;
			this.lblItem.Location = new Point(0, 288);
			this.lblItem.Margin = new Padding(4, 0, 4, 0);
			this.lblItem.Name = "lblItem";
			this.lblItem.Padding = new Padding(16, 0, 0, 0);
			this.lblItem.Size = new Size(192, 40);
			this.lblItem.TabIndex = 4;
			this.lblItem.Text = "Item";
			this.lblItem.TextAlign = ContentAlignment.MiddleLeft;
			this.lblItemName.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.lblItemName.BackColor = Color.White;
			this.lblItemName.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblItemName.Location = new Point(0, 328);
			this.lblItemName.Margin = new Padding(4, 0, 4, 0);
			this.lblItemName.Name = "lblItemName";
			this.lblItemName.Padding = new Padding(16, 0, 0, 0);
			this.lblItemName.Size = new Size(192, 27);
			this.lblItemName.TabIndex = 5;
			this.lblItemName.Text = "None";
			this.lblItemName.TextAlign = ContentAlignment.MiddleLeft;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Gainsboro;
			base.ClientSize = new Size(506, 358);
			base.Controls.Add(this.lblItemName);
			base.Controls.Add(this.lblItem);
			base.Controls.Add(this.lblLevel);
			base.Controls.Add(this.pbox);
			base.Controls.Add(this.lblName);
			base.Controls.Add(this.tabs);
			this.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ForeColor = Color.Black;
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "PokemonStatus";
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Pokemon Status";
			base.TopMost = true;
			this.tabs.ResumeLayout(false);
			this.tabInfo.ResumeLayout(false);
			this.tabMemo.ResumeLayout(false);
			this.tabSkills.ResumeLayout(false);
			this.tabMoves.ResumeLayout(false);
			((ISupportInitialize)this.pbox).EndInit();
			base.ResumeLayout(false);
		}
		public PokemonStatus(Pokemon pokemon)
		{
			this.InitializeComponent();
			this.lblName.Text = (string.IsNullOrEmpty(pokemon.nickname) ? pokemon.nickname : pokemon.baseStats.name);
			this.lblLevel.Text = "Lv." + pokemon.Level;
			this.pbox.Image = pokemon.FrontImage;
			this.lblItemName.Text = ((pokemon.heldItem == null) ? "None" : pokemon.heldItem.name);
			this.lblPokedexNo.Text = pokemon.baseStats.id.ToString();
			this.lblSpecies.Text = pokemon.baseStats.name;
			this.lblType.Text = pokemon.baseStats.types.ToString();
			this.lblOT.Text = pokemon.OTname;
			this.lblIDNo.Text = pokemon.OTid.ToString();
			this.lblExpPoints.Text = pokemon.Exp.ToString();
			switch (pokemon.baseStats.growthRate)
			{
			case GrowthRate.MediumFast:
				this.lblToNextLv.Text = (Math.Pow((double)pokemon.Level, 3.0) - pokemon.Exp).ToString();
				break;
			case GrowthRate.Erratic:
				if (pokemon.Level <= 50)
				{
					this.lblToNextLv.Text = (Math.Pow((double)pokemon.Level, 3.0) * (double)(100 - pokemon.Level) * 0.02 - pokemon.Exp).ToString();
				}
				else
				{
					if (pokemon.Level <= 68)
					{
						this.lblToNextLv.Text = (Math.Pow((double)pokemon.Level, 3.0) * (double)(150 - pokemon.Level) * 0.01 - pokemon.Exp).ToString();
					}
					else
					{
						if (pokemon.Level <= 98)
						{
							this.lblToNextLv.Text = (Math.Pow((double)pokemon.Level, 3.0) * (double)(1911 - (int)(10 * pokemon.Level / 3)) * 0.02 - pokemon.Exp).ToString();
						}
						else
						{
							if (pokemon.Level <= 100)
							{
								this.lblToNextLv.Text = (Math.Pow((double)pokemon.Level, 3.0) * (double)(160 - pokemon.Level) * 0.01 - pokemon.Exp).ToString();
							}
						}
					}
				}
				break;
			case GrowthRate.Fluctuating:
				if (pokemon.Level <= 15)
				{
					this.lblToNextLv.Text = (Math.Pow((double)pokemon.Level, 3.0) * ((double)((pokemon.Level + 1) / 3 + 24) * 0.02) - pokemon.Exp).ToString();
				}
				else
				{
					if (pokemon.Level <= 36)
					{
						this.lblToNextLv.Text = (Math.Pow((double)pokemon.Level, 3.0) * ((double)(pokemon.Level + 14) * 0.02) - pokemon.Exp).ToString();
					}
					else
					{
						if (pokemon.Level <= 100)
						{
							this.lblToNextLv.Text = (Math.Pow((double)pokemon.Level, 3.0) * ((double)((pokemon.Level >> 1) + 32) * 0.02) - pokemon.Exp).ToString();
						}
					}
				}
				break;
			case GrowthRate.MediumSlow:
				this.lblToNextLv.Text = (1.2 * Math.Pow((double)pokemon.Level, 3.0) - 15.0 * Math.Pow((double)pokemon.Level, 2.0) + (double)(100 * pokemon.Level) - 140.0 - pokemon.Exp).ToString();
				break;
			case GrowthRate.Fast:
				this.lblToNextLv.Text = (0.8 * Math.Pow((double)pokemon.Level, 3.0) - pokemon.Exp).ToString();
				break;
			case GrowthRate.Slow:
				this.lblToNextLv.Text = (1.25 * Math.Pow((double)pokemon.Level, 3.0) - pokemon.Exp).ToString();
				break;
			}
			this.pbEXP.Value = (int)((ulong)pokemon.Exp / (ulong)((long)int.Parse(this.lblToNextLv.Text) + (long)((ulong)pokemon.Exp))) * 100;
			this.lblNature.Text = pokemon.nature + " nature.";
			this.lblDateMet.Text = pokemon.dateMet.ToString();
			this.lblMetLocation.Text = pokemon.metLocation.name;
			this.lblMetLevel.Text = "Met at Lv." + pokemon.metLevel + '.';
			byte[] array = new byte[]
			{
				pokemon.hpIV,
				pokemon.attackIV,
				pokemon.defenseIV,
				pokemon.speedIV,
				pokemon.specialAttackIV,
				pokemon.specialDefenseIV
			};
			Array.Sort<byte>(array);
			byte b = 0;
			if (array[array.Length - 1] == array[array.Length - 2])
			{
				int num = (int)(pokemon.personality % 6u);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[num] == array[array.Length - 1])
					{
						b = array[array.Length - 1];
						break;
					}
					if (array[num] == array[array.Length - 2])
					{
						b = array[array.Length - 2];
						break;
					}
					if (++num == 6)
					{
						num = 0;
					}
				}
			}
			else
			{
				b = array[array.Length - 1];
			}
			if (b == pokemon.hpIV)
			{
				switch (pokemon.hpIV % 5)
				{
				case 0:
					this.lblChar.Text = "Loves to eat.";
					break;
				case 1:
					this.lblChar.Text = "Often dozes off.";
					break;
				case 2:
					this.lblChar.Text = "Often scatters things.";
					break;
				case 3:
					this.lblChar.Text = "Scatters things often.";
					break;
				case 4:
					this.lblChar.Text = "Likes to relax.";
					break;
				}
			}
			else
			{
				if (b == pokemon.attackIV)
				{
					switch (pokemon.attackIV % 5)
					{
					case 0:
						this.lblChar.Text = "Proud of its power.";
						break;
					case 1:
						this.lblChar.Text = "Likes to thrash about.";
						break;
					case 2:
						this.lblChar.Text = "A little quick tempered.";
						break;
					case 3:
						this.lblChar.Text = "Likes to fight.";
						break;
					case 4:
						this.lblChar.Text = "Quick tempered.";
						break;
					}
				}
				else
				{
					if (b == pokemon.defenseIV)
					{
						switch (pokemon.defenseIV % 5)
						{
						case 0:
							this.lblChar.Text = "";
							break;
						case 1:
							this.lblChar.Text = "";
							break;
						case 2:
							this.lblChar.Text = "";
							break;
						case 3:
							this.lblChar.Text = "";
							break;
						case 4:
							this.lblChar.Text = "";
							break;
						}
					}
					else
					{
						if (b == pokemon.specialAttackIV)
						{
							switch (pokemon.specialAttackIV % 5)
							{
							case 0:
								this.lblChar.Text = "";
								break;
							case 1:
								this.lblChar.Text = "";
								break;
							case 2:
								this.lblChar.Text = "";
								break;
							case 3:
								this.lblChar.Text = "";
								break;
							case 4:
								this.lblChar.Text = "";
								break;
							}
						}
						else
						{
							if (b == pokemon.specialDefenseIV)
							{
								switch (pokemon.specialDefenseIV % 5)
								{
								case 0:
									this.lblChar.Text = "";
									break;
								case 1:
									this.lblChar.Text = "";
									break;
								case 2:
									this.lblChar.Text = "";
									break;
								case 3:
									this.lblChar.Text = "";
									break;
								case 4:
									this.lblChar.Text = "";
									break;
								}
							}
							else
							{
								if (b == pokemon.speedIV)
								{
									switch (pokemon.speedIV % 5)
									{
									case 0:
										this.lblChar.Text = "";
										break;
									case 1:
										this.lblChar.Text = "";
										break;
									case 2:
										this.lblChar.Text = "";
										break;
									case 3:
										this.lblChar.Text = "";
										break;
									case 4:
										this.lblChar.Text = "";
										break;
									}
								}
							}
						}
					}
				}
			}
			this.lblFlavour.Text = "NYI";
			this.lblHP.Text = pokemon.HP + "/" + pokemon.MaxHP;
			this.pbHP.Value = (int)(pokemon.HP / pokemon.MaxHP * 100);
			this.lblAttack.Text = pokemon.Attack.ToString();
			this.lblDefense.Text = pokemon.Defense.ToString();
			this.lblSpAtk.Text = pokemon.SpecialAttack.ToString();
			this.lblSpDef.Text = pokemon.SpecialDefense.ToString();
			this.lblSpeed.Text = pokemon.Speed.ToString();
			this.lblAbilityName.Text = pokemon.ability.name;
			if (pokemon.ability.desc.Length > 22)
			{
				this.lblAbilityDesc1.Text = pokemon.ability.desc.Substring(0, pokemon.ability.desc.IndexOf(' ', 17));
				this.lblAbilityDesc2.Text = pokemon.ability.desc.Substring(pokemon.ability.desc.IndexOf(' ', 17));
			}
			else
			{
				this.lblAbilityDesc1.Text = pokemon.ability.desc;
			}
			Label[] array2 = new Label[]
			{
				this.lblMove1,
				this.lblMove2,
				this.lblMove3,
				this.lblMove4
			};
			Label[] array3 = new Label[]
			{
				this.lblPP1,
				this.lblPP2,
				this.lblPP3,
				this.lblPP4
			};
			for (int i = 0; i < pokemon.moveSet.Length; i++)
			{
				if (pokemon.moveSet[i] != null)
				{
					array2[i].Text = pokemon.moveSet[i].name;
					array3[i].Text = string.Concat(new object[]
					{
						"PP ",
						pokemon.PP[i],
						'/',
						(double)pokemon.moveSet[i].basePP + (double)pokemon.moveSet[i].basePP * 0.2 * (double)pokemon.PPbonuses[i]
					});
				}
				else
				{
					array2[i].Text = "---";
					array3[i].Text = "---";
				}
			}
		}
	}
}
