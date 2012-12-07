using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PokemonSharp;

namespace FormsUI
{
	public class Pokedex : Form
	{
		private BaseStats currentPokemon = BaseStats.Bulbasaur;
		private int page = 0;
		private IContainer components = null;
		private Label lblINFO;
		private PictureBox pboxImage;
		private Label lblSpecies;
		private Label lblSpeciesDesc;
		private PictureBox pboxFoot;
		private Panel pnlList;
		private Label lblType1;
		private Label lblType2;
		private Label lblHeight;
		private Label lblWeight;
		private Label lblFlavour;
		private PictureBox pboxPokemon14;
		private PictureBox pboxPokemon13;
		private PictureBox pboxPokemon12;
		private PictureBox pboxPokemon11;
		private PictureBox pboxPokemon15;
		private PictureBox pboxPokemon9;
		private PictureBox pboxPokemon8;
		private PictureBox pboxPokemon7;
		private PictureBox pboxPokemon6;
		private PictureBox pboxPokemon10;
		private PictureBox pboxPokemon4;
		private PictureBox pboxPokemon3;
		private PictureBox pboxPokemon2;
		private PictureBox pboxPokemon1;
		private PictureBox pboxPokemon5;
		private BaseStats CurrentPokemon
		{
			get
			{
				return this.currentPokemon;
			}
			set
			{
				this.currentPokemon = value;
				this.pboxImage.Image = this.currentPokemon.frontImg;
				this.lblSpecies.Text = (int)(this.currentPokemon.id + 32) + this.currentPokemon.name;
				this.lblSpeciesDesc.Text = this.currentPokemon.entry.species + " Pokemon";
				this.lblType1.Text = this.currentPokemon.types.ToString().ToUpper();
				this.lblType2.Text = this.currentPokemon.types.ToString().ToUpper();
				this.lblHeight.Text = "HT" + (double)this.currentPokemon.entry.height * 0.1 + " m";
				this.lblWeight.Text = "WT" + (double)this.currentPokemon.entry.weight * 0.1 + " kg";
				this.lblFlavour.Text = this.currentPokemon.entry.description;
			}
		}
		private int Page
		{
			get
			{
				return this.page;
			}
			set
			{
				this.page = value;
			}
		}
		public Pokedex()
		{
			this.InitializeComponent();
		}
		private void pboxPokemon1_Click(object sender, EventArgs e)
		{
			PictureBox pictureBox = sender as PictureBox;
			int num = this.page;
			if (num != 0)
			{
				switch (num)
				{
				case 9:
					if (pictureBox == this.pboxPokemon15)
					{
						this.currentPokemon = BaseStats.Mewtwo;
					}
					break;
				case 10:
					if (pictureBox == this.pboxPokemon1)
					{
						this.currentPokemon = BaseStats.Mew;
					}
					break;
				}
			}
			else
			{
				if (pictureBox == this.pboxPokemon1)
				{
					this.currentPokemon = BaseStats.Bulbasaur;
				}
				else
				{
					if (pictureBox == this.pboxPokemon2)
					{
						this.currentPokemon = BaseStats.Ivysaur;
					}
					else
					{
						if (pictureBox == this.pboxPokemon2)
						{
							this.currentPokemon = BaseStats.Venusaur;
						}
						else
						{
							if (pictureBox == this.pboxPokemon3)
							{
								this.currentPokemon = BaseStats.Charmander;
							}
							else
							{
								if (pictureBox == this.pboxPokemon4)
								{
									this.currentPokemon = BaseStats.Charmeleon;
								}
								else
								{
									if (pictureBox == this.pboxPokemon5)
									{
										this.currentPokemon = BaseStats.Charizard;
									}
									else
									{
										if (pictureBox == this.pboxPokemon6)
										{
											this.currentPokemon = BaseStats.Squirtle;
										}
										else
										{
											if (pictureBox == this.pboxPokemon7)
											{
												this.currentPokemon = BaseStats.Wartortle;
											}
											else
											{
												if (pictureBox == this.pboxPokemon8)
												{
													this.currentPokemon = BaseStats.Blastoise;
												}
												else
												{
													if (pictureBox == this.pboxPokemon9)
													{
														this.currentPokemon = BaseStats.Caterpie;
													}
													else
													{
														if (pictureBox == this.pboxPokemon10)
														{
															this.currentPokemon = BaseStats.Metapod;
														}
														else
														{
															if (pictureBox == this.pboxPokemon11)
															{
																this.currentPokemon = BaseStats.Butterfree;
															}
															else
															{
																if (pictureBox == this.pboxPokemon15)
																{
																	this.currentPokemon = BaseStats.Pidgey;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Pokedex));
			this.lblINFO = new Label();
			this.pboxImage = new PictureBox();
			this.lblSpecies = new Label();
			this.lblSpeciesDesc = new Label();
			this.pboxFoot = new PictureBox();
			this.pnlList = new Panel();
			this.pboxPokemon14 = new PictureBox();
			this.pboxPokemon13 = new PictureBox();
			this.pboxPokemon12 = new PictureBox();
			this.pboxPokemon11 = new PictureBox();
			this.pboxPokemon15 = new PictureBox();
			this.pboxPokemon9 = new PictureBox();
			this.pboxPokemon8 = new PictureBox();
			this.pboxPokemon7 = new PictureBox();
			this.pboxPokemon6 = new PictureBox();
			this.pboxPokemon10 = new PictureBox();
			this.pboxPokemon4 = new PictureBox();
			this.pboxPokemon3 = new PictureBox();
			this.pboxPokemon2 = new PictureBox();
			this.pboxPokemon1 = new PictureBox();
			this.pboxPokemon5 = new PictureBox();
			this.lblType1 = new Label();
			this.lblType2 = new Label();
			this.lblHeight = new Label();
			this.lblWeight = new Label();
			this.lblFlavour = new Label();
			((ISupportInitialize)this.pboxImage).BeginInit();
			((ISupportInitialize)this.pboxFoot).BeginInit();
			this.pnlList.SuspendLayout();
			((ISupportInitialize)this.pboxPokemon14).BeginInit();
			((ISupportInitialize)this.pboxPokemon13).BeginInit();
			((ISupportInitialize)this.pboxPokemon12).BeginInit();
			((ISupportInitialize)this.pboxPokemon11).BeginInit();
			((ISupportInitialize)this.pboxPokemon15).BeginInit();
			((ISupportInitialize)this.pboxPokemon9).BeginInit();
			((ISupportInitialize)this.pboxPokemon8).BeginInit();
			((ISupportInitialize)this.pboxPokemon7).BeginInit();
			((ISupportInitialize)this.pboxPokemon6).BeginInit();
			((ISupportInitialize)this.pboxPokemon10).BeginInit();
			((ISupportInitialize)this.pboxPokemon4).BeginInit();
			((ISupportInitialize)this.pboxPokemon3).BeginInit();
			((ISupportInitialize)this.pboxPokemon2).BeginInit();
			((ISupportInitialize)this.pboxPokemon1).BeginInit();
			((ISupportInitialize)this.pboxPokemon5).BeginInit();
			base.SuspendLayout();
			this.lblINFO.BackColor = Color.Red;
			this.lblINFO.Dock = DockStyle.Top;
			this.lblINFO.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblINFO.ForeColor = Color.White;
			this.lblINFO.Location = new Point(0, 0);
			this.lblINFO.Margin = new Padding(4, 0, 4, 0);
			this.lblINFO.Name = "lblINFO";
			this.lblINFO.Size = new Size(480, 32);
			this.lblINFO.TabIndex = 0;
			this.lblINFO.Text = "INFO";
			this.lblINFO.TextAlign = ContentAlignment.MiddleLeft;
			this.pboxImage.Location = new Point(12, 44);
			this.pboxImage.Margin = new Padding(4);
			this.pboxImage.Name = "pboxImage";
			this.pboxImage.Size = new Size(144, 133);
			this.pboxImage.TabIndex = 1;
			this.pboxImage.TabStop = false;
			this.lblSpecies.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblSpecies.BackColor = Color.Red;
			this.lblSpecies.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpecies.ForeColor = Color.DarkGray;
			this.lblSpecies.ImageAlign = ContentAlignment.MiddleLeft;
			this.lblSpecies.Location = new Point(184, 44);
			this.lblSpecies.Margin = new Padding(4, 0, 4, 0);
			this.lblSpecies.Name = "lblSpecies";
			this.lblSpecies.Size = new Size(288, 32);
			this.lblSpecies.TabIndex = 2;
			this.lblSpecies.Text = "010 PIDGEY";
			this.lblSpecies.TextAlign = ContentAlignment.MiddleLeft;
			this.lblSpeciesDesc.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblSpeciesDesc.BackColor = Color.White;
			this.lblSpeciesDesc.FlatStyle = FlatStyle.Flat;
			this.lblSpeciesDesc.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblSpeciesDesc.ForeColor = Color.DarkGray;
			this.lblSpeciesDesc.Location = new Point(184, 78);
			this.lblSpeciesDesc.Margin = new Padding(4, 0, 4, 0);
			this.lblSpeciesDesc.Name = "lblSpeciesDesc";
			this.lblSpeciesDesc.Size = new Size(288, 32);
			this.lblSpeciesDesc.TabIndex = 3;
			this.lblSpeciesDesc.Text = "Tiny Bird Pokemon";
			this.lblSpeciesDesc.TextAlign = ContentAlignment.MiddleRight;
			this.pboxFoot.Location = new Point(168, 122);
			this.pboxFoot.Margin = new Padding(4);
			this.pboxFoot.Name = "pboxFoot";
			this.pboxFoot.Size = new Size(72, 66);
			this.pboxFoot.TabIndex = 4;
			this.pboxFoot.TabStop = false;
			this.pnlList.AutoScroll = true;
			this.pnlList.Controls.Add(this.pboxPokemon14);
			this.pnlList.Controls.Add(this.pboxPokemon13);
			this.pnlList.Controls.Add(this.pboxPokemon12);
			this.pnlList.Controls.Add(this.pboxPokemon11);
			this.pnlList.Controls.Add(this.pboxPokemon15);
			this.pnlList.Controls.Add(this.pboxPokemon9);
			this.pnlList.Controls.Add(this.pboxPokemon8);
			this.pnlList.Controls.Add(this.pboxPokemon7);
			this.pnlList.Controls.Add(this.pboxPokemon6);
			this.pnlList.Controls.Add(this.pboxPokemon10);
			this.pnlList.Controls.Add(this.pboxPokemon4);
			this.pnlList.Controls.Add(this.pboxPokemon3);
			this.pnlList.Controls.Add(this.pboxPokemon2);
			this.pnlList.Controls.Add(this.pboxPokemon1);
			this.pnlList.Controls.Add(this.pboxPokemon5);
			this.pnlList.Dock = DockStyle.Bottom;
			this.pnlList.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.pnlList.ForeColor = Color.Black;
			this.pnlList.Location = new Point(0, 371);
			this.pnlList.Margin = new Padding(4);
			this.pnlList.Name = "pnlList";
			this.pnlList.Size = new Size(480, 271);
			this.pnlList.TabIndex = 5;
			this.pboxPokemon14.Location = new Point(288, 177);
			this.pboxPokemon14.Margin = new Padding(4);
			this.pboxPokemon14.Name = "pboxPokemon14";
			this.pboxPokemon14.Size = new Size(96, 89);
			this.pboxPokemon14.TabIndex = 23;
			this.pboxPokemon14.TabStop = false;
			this.pboxPokemon14.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon13.Location = new Point(192, 177);
			this.pboxPokemon13.Margin = new Padding(4);
			this.pboxPokemon13.Name = "pboxPokemon13";
			this.pboxPokemon13.Size = new Size(96, 89);
			this.pboxPokemon13.TabIndex = 22;
			this.pboxPokemon13.TabStop = false;
			this.pboxPokemon13.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon12.Location = new Point(96, 177);
			this.pboxPokemon12.Margin = new Padding(4);
			this.pboxPokemon12.Name = "pboxPokemon12";
			this.pboxPokemon12.Size = new Size(96, 89);
			this.pboxPokemon12.TabIndex = 21;
			this.pboxPokemon12.TabStop = false;
			this.pboxPokemon12.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon11.Location = new Point(0, 177);
			this.pboxPokemon11.Margin = new Padding(4);
			this.pboxPokemon11.Name = "pboxPokemon11";
			this.pboxPokemon11.Size = new Size(96, 89);
			this.pboxPokemon11.TabIndex = 20;
			this.pboxPokemon11.TabStop = false;
			this.pboxPokemon11.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon15.Location = new Point(384, 177);
			this.pboxPokemon15.Margin = new Padding(4);
			this.pboxPokemon15.Name = "pboxPokemon15";
			this.pboxPokemon15.Size = new Size(96, 89);
			this.pboxPokemon15.TabIndex = 19;
			this.pboxPokemon15.TabStop = false;
			this.pboxPokemon15.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon9.Location = new Point(288, 89);
			this.pboxPokemon9.Margin = new Padding(4);
			this.pboxPokemon9.Name = "pboxPokemon9";
			this.pboxPokemon9.Size = new Size(96, 89);
			this.pboxPokemon9.TabIndex = 18;
			this.pboxPokemon9.TabStop = false;
			this.pboxPokemon9.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon8.Location = new Point(192, 89);
			this.pboxPokemon8.Margin = new Padding(4);
			this.pboxPokemon8.Name = "pboxPokemon8";
			this.pboxPokemon8.Size = new Size(96, 89);
			this.pboxPokemon8.TabIndex = 17;
			this.pboxPokemon8.TabStop = false;
			this.pboxPokemon8.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon7.Location = new Point(96, 89);
			this.pboxPokemon7.Margin = new Padding(4);
			this.pboxPokemon7.Name = "pboxPokemon7";
			this.pboxPokemon7.Size = new Size(96, 89);
			this.pboxPokemon7.TabIndex = 16;
			this.pboxPokemon7.TabStop = false;
			this.pboxPokemon7.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon6.Location = new Point(0, 89);
			this.pboxPokemon6.Margin = new Padding(4);
			this.pboxPokemon6.Name = "pboxPokemon6";
			this.pboxPokemon6.Size = new Size(96, 89);
			this.pboxPokemon6.TabIndex = 15;
			this.pboxPokemon6.TabStop = false;
			this.pboxPokemon6.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon10.Location = new Point(384, 89);
			this.pboxPokemon10.Margin = new Padding(4);
			this.pboxPokemon10.Name = "pboxPokemon10";
			this.pboxPokemon10.Size = new Size(96, 89);
			this.pboxPokemon10.TabIndex = 14;
			this.pboxPokemon10.TabStop = false;
			this.pboxPokemon10.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon4.Location = new Point(288, 0);
			this.pboxPokemon4.Margin = new Padding(4);
			this.pboxPokemon4.Name = "pboxPokemon4";
			this.pboxPokemon4.Size = new Size(96, 89);
			this.pboxPokemon4.TabIndex = 13;
			this.pboxPokemon4.TabStop = false;
			this.pboxPokemon4.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon3.Location = new Point(192, 0);
			this.pboxPokemon3.Margin = new Padding(4);
			this.pboxPokemon3.Name = "pboxPokemon3";
			this.pboxPokemon3.Size = new Size(96, 89);
			this.pboxPokemon3.TabIndex = 12;
			this.pboxPokemon3.TabStop = false;
			this.pboxPokemon3.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon2.Location = new Point(96, 0);
			this.pboxPokemon2.Margin = new Padding(4);
			this.pboxPokemon2.Name = "pboxPokemon2";
			this.pboxPokemon2.Size = new Size(96, 89);
			this.pboxPokemon2.TabIndex = 11;
			this.pboxPokemon2.TabStop = false;
			this.pboxPokemon2.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon1.Location = new Point(0, 0);
			this.pboxPokemon1.Margin = new Padding(4);
			this.pboxPokemon1.Name = "pboxPokemon1";
			this.pboxPokemon1.Size = new Size(96, 89);
			this.pboxPokemon1.TabIndex = 10;
			this.pboxPokemon1.TabStop = false;
			this.pboxPokemon1.Click += new EventHandler(this.pboxPokemon1_Click);
			this.pboxPokemon5.Location = new Point(384, 0);
			this.pboxPokemon5.Margin = new Padding(4);
			this.pboxPokemon5.Name = "pboxPokemon5";
			this.pboxPokemon5.Size = new Size(96, 89);
			this.pboxPokemon5.TabIndex = 9;
			this.pboxPokemon5.TabStop = false;
			this.pboxPokemon5.Click += new EventHandler(this.pboxPokemon1_Click);
			this.lblType1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblType1.BackColor = Color.LightGray;
			this.lblType1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblType1.ForeColor = Color.White;
			this.lblType1.Location = new Point(268, 122);
			this.lblType1.Margin = new Padding(4, 0, 4, 0);
			this.lblType1.Name = "lblType1";
			this.lblType1.Size = new Size(96, 33);
			this.lblType1.TabIndex = 6;
			this.lblType1.Text = "NORMAL";
			this.lblType1.TextAlign = ContentAlignment.MiddleCenter;
			this.lblType2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblType2.BackColor = Color.LightGray;
			this.lblType2.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblType2.ForeColor = Color.White;
			this.lblType2.Location = new Point(376, 122);
			this.lblType2.Margin = new Padding(4, 0, 4, 0);
			this.lblType2.Name = "lblType2";
			this.lblType2.Size = new Size(96, 33);
			this.lblType2.TabIndex = 7;
			this.lblType2.Text = "FLYING";
			this.lblType2.TextAlign = ContentAlignment.MiddleCenter;
			this.lblHeight.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblHeight.BackColor = Color.White;
			this.lblHeight.FlatStyle = FlatStyle.Flat;
			this.lblHeight.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblHeight.ForeColor = Color.Black;
			this.lblHeight.Location = new Point(268, 166);
			this.lblHeight.Margin = new Padding(4, 0, 4, 0);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new Size(204, 32);
			this.lblHeight.TabIndex = 8;
			this.lblHeight.Text = "HT 1'00\"";
			this.lblHeight.TextAlign = ContentAlignment.MiddleRight;
			this.lblWeight.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblWeight.BackColor = Color.White;
			this.lblWeight.FlatStyle = FlatStyle.Flat;
			this.lblWeight.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblWeight.ForeColor = Color.Black;
			this.lblWeight.Location = new Point(268, 199);
			this.lblWeight.Margin = new Padding(4, 0, 4, 0);
			this.lblWeight.Name = "lblWeight";
			this.lblWeight.Size = new Size(204, 32);
			this.lblWeight.TabIndex = 9;
			this.lblWeight.Text = "WT 4.0 lbs";
			this.lblWeight.TextAlign = ContentAlignment.MiddleRight;
			this.lblFlavour.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.lblFlavour.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblFlavour.ForeColor = Color.Black;
			this.lblFlavour.Location = new Point(12, 244);
			this.lblFlavour.Margin = new Padding(4, 0, 4, 0);
			this.lblFlavour.Name = "lblFlavour";
			this.lblFlavour.Size = new Size(460, 120);
			this.lblFlavour.TabIndex = 10;
			this.lblFlavour.Text = "Common in grassy areas and forests, it is very docile and will chase off enemies by flappig up sand.";
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(480, 642);
			base.Controls.Add(this.lblFlavour);
			base.Controls.Add(this.lblWeight);
			base.Controls.Add(this.lblHeight);
			base.Controls.Add(this.lblType2);
			base.Controls.Add(this.lblType1);
			base.Controls.Add(this.pnlList);
			base.Controls.Add(this.pboxFoot);
			base.Controls.Add(this.lblSpeciesDesc);
			base.Controls.Add(this.lblSpecies);
			base.Controls.Add(this.pboxImage);
			base.Controls.Add(this.lblINFO);
			this.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ForeColor = Color.Black;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new Padding(4);
			base.Name = "Pokedex";
			this.Text = "Pokedex";
			((ISupportInitialize)this.pboxImage).EndInit();
			((ISupportInitialize)this.pboxFoot).EndInit();
			this.pnlList.ResumeLayout(false);
			((ISupportInitialize)this.pboxPokemon14).EndInit();
			((ISupportInitialize)this.pboxPokemon13).EndInit();
			((ISupportInitialize)this.pboxPokemon12).EndInit();
			((ISupportInitialize)this.pboxPokemon11).EndInit();
			((ISupportInitialize)this.pboxPokemon15).EndInit();
			((ISupportInitialize)this.pboxPokemon9).EndInit();
			((ISupportInitialize)this.pboxPokemon8).EndInit();
			((ISupportInitialize)this.pboxPokemon7).EndInit();
			((ISupportInitialize)this.pboxPokemon6).EndInit();
			((ISupportInitialize)this.pboxPokemon10).EndInit();
			((ISupportInitialize)this.pboxPokemon4).EndInit();
			((ISupportInitialize)this.pboxPokemon3).EndInit();
			((ISupportInitialize)this.pboxPokemon2).EndInit();
			((ISupportInitialize)this.pboxPokemon1).EndInit();
			((ISupportInitialize)this.pboxPokemon5).EndInit();
			base.ResumeLayout(false);
		}
	}
}
