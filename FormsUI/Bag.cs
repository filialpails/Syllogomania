using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PokemonSharp;

namespace FormsUI
{
	public class Bag : Form
	{
		private int page;
		private Dictionary<Item, int> currentBag = Player.Instance.ItemBag;
		private IContainer components = null;
		private Button btnCancel;
		private Button item1;
		private Button item6;
		private Button item4;
		private Button item5;
		private Button item3;
		private Button item2;
		private Label lblPage;
		private Panel panel1;
		private Button btnKey;
		private Button btnBattle;
		private Button btnMail;
		private Button btnBerries;
		private Button btnTMs;
		private Button btnBalls;
		private Button btnMedicine;
		private Button btnItems;
		private Label lblDesc;
		private int Page
		{
			get
			{
				return this.page;
			}
			set
			{
				this.page = value;
				this.lblPage.Text = this.page + 1 + "/" + Math.Ceiling((double)this.currentBag.Count / 6.0);
			}
		}
		public Bag()
		{
			this.InitializeComponent();
			Button[] array = new Button[]
			{
				this.item1,
				this.item2,
				this.item3,
				this.item4,
				this.item5,
				this.item6
			};
			for (int i = 0; i < array.Length; i++)
			{
				if (i >= this.currentBag.Count)
				{
					array[i].Visible = false;
				}
				else
				{
					array[i].Visible = true;
					array[i].Text = this.currentBag.Keys.ElementAt(6 * this.Page + i).name;
				}
			}
		}
		private void btnItems_Click(object sender, EventArgs e)
		{
			this.Page = 0;
			Button button = sender as Button;
			if (button == this.btnItems)
			{
				this.currentBag = Player.Instance.ItemBag;
				this.panel1.BackColor = Color.HotPink;
			}
			else
			{
				if (button == this.btnMedicine)
				{
					this.currentBag = Player.Instance.MedicineBag;
					this.panel1.BackColor = Color.Coral;
				}
				else
				{
					if (button == this.btnBalls)
					{
						this.currentBag = Player.Instance.BallBag;
						this.panel1.BackColor = Color.Orange;
					}
					else
					{
						if (button == this.btnTMs)
						{
							this.currentBag = Player.Instance.TMBag;
							this.panel1.BackColor = Color.YellowGreen;
						}
						else
						{
							if (button == this.btnBerries)
							{
								this.currentBag = Player.Instance.BerryBag;
								this.panel1.BackColor = Color.LimeGreen;
							}
							else
							{
								if (button == this.btnMail)
								{
									this.currentBag = Player.Instance.MailBag;
									this.panel1.BackColor = Color.DarkTurquoise;
								}
								else
								{
									if (button == this.btnBattle)
									{
										this.currentBag = Player.Instance.BattleBag;
										this.panel1.BackColor = Color.CornflowerBlue;
									}
									else
									{
										if (button == this.btnKey)
										{
											this.currentBag = Player.Instance.KeyBag;
											this.panel1.BackColor = Color.BlueViolet;
										}
									}
								}
							}
						}
					}
				}
			}
			Button[] array = new Button[]
			{
				this.item1,
				this.item2,
				this.item3,
				this.item4,
				this.item5,
				this.item6
			};
			for (int i = 0; i < array.Length; i++)
			{
				if (i >= this.currentBag.Count)
				{
					array[i].Visible = false;
				}
				else
				{
					array[i].Visible = true;
					array[i].Text = this.currentBag.Keys.ElementAt(6 * this.Page + i).name;
				}
			}
		}
		private void item1_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			if (button == this.item1)
			{
				this.lblDesc.Text = this.currentBag.Keys.ElementAt(6 * this.Page).description;
			}
			else
			{
				if (button == this.item2)
				{
					this.lblDesc.Text = this.currentBag.Keys.ElementAt(6 * this.Page + 1).description;
				}
				else
				{
					if (button == this.item3)
					{
						this.lblDesc.Text = this.currentBag.Keys.ElementAt(6 * this.Page + 2).description;
					}
					else
					{
						if (button == this.item4)
						{
							this.lblDesc.Text = this.currentBag.Keys.ElementAt(6 * this.Page + 3).description;
						}
						else
						{
							if (button == this.item5)
							{
								this.lblDesc.Text = this.currentBag.Keys.ElementAt(6 * this.Page + 4).description;
							}
							else
							{
								if (button == this.item6)
								{
									this.lblDesc.Text = this.currentBag.Keys.ElementAt(6 * this.Page + 5).description;
								}
							}
						}
					}
				}
			}
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Bag));
			this.btnCancel = new Button();
			this.item1 = new Button();
			this.item2 = new Button();
			this.item3 = new Button();
			this.item5 = new Button();
			this.item4 = new Button();
			this.item6 = new Button();
			this.lblPage = new Label();
			this.panel1 = new Panel();
			this.btnKey = new Button();
			this.btnBattle = new Button();
			this.btnMail = new Button();
			this.btnBerries = new Button();
			this.btnTMs = new Button();
			this.btnBalls = new Button();
			this.btnMedicine = new Button();
			this.btnItems = new Button();
			this.lblDesc = new Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.btnCancel.BackColor = Color.RoyalBlue;
			this.btnCancel.FlatAppearance.BorderColor = Color.Black;
			this.btnCancel.FlatStyle = FlatStyle.Flat;
			this.btnCancel.ForeColor = Color.White;
			this.btnCancel.Location = new Point(352, 272);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new Size(123, 47);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "CANCEL";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
			this.item1.Location = new Point(8, 32);
			this.item1.Name = "item1";
			this.item1.Size = new Size(224, 72);
			this.item1.TabIndex = 1;
			this.item1.UseVisualStyleBackColor = true;
			this.item1.Click += new EventHandler(this.item1_Click);
			this.item2.Location = new Point(248, 32);
			this.item2.Name = "item2";
			this.item2.Size = new Size(224, 72);
			this.item2.TabIndex = 2;
			this.item2.UseVisualStyleBackColor = true;
			this.item2.Click += new EventHandler(this.item1_Click);
			this.item3.Location = new Point(8, 112);
			this.item3.Name = "item3";
			this.item3.Size = new Size(224, 72);
			this.item3.TabIndex = 3;
			this.item3.UseVisualStyleBackColor = true;
			this.item3.Click += new EventHandler(this.item1_Click);
			this.item5.Location = new Point(8, 192);
			this.item5.Name = "item5";
			this.item5.Size = new Size(224, 72);
			this.item5.TabIndex = 4;
			this.item5.UseVisualStyleBackColor = true;
			this.item5.Click += new EventHandler(this.item1_Click);
			this.item4.Location = new Point(248, 112);
			this.item4.Name = "item4";
			this.item4.Size = new Size(224, 72);
			this.item4.TabIndex = 5;
			this.item4.UseVisualStyleBackColor = true;
			this.item4.Click += new EventHandler(this.item1_Click);
			this.item6.Location = new Point(248, 192);
			this.item6.Name = "item6";
			this.item6.Size = new Size(224, 72);
			this.item6.TabIndex = 6;
			this.item6.UseVisualStyleBackColor = true;
			this.item6.Click += new EventHandler(this.item1_Click);
			this.lblPage.ForeColor = Color.White;
			this.lblPage.Location = new Point(184, 288);
			this.lblPage.Name = "lblPage";
			this.lblPage.Size = new Size(48, 21);
			this.lblPage.TabIndex = 7;
			this.lblPage.Text = "1/1";
			this.lblPage.TextAlign = ContentAlignment.MiddleCenter;
			this.panel1.BackColor = Color.PaleVioletRed;
			this.panel1.Controls.Add(this.btnKey);
			this.panel1.Controls.Add(this.btnBattle);
			this.panel1.Controls.Add(this.item6);
			this.panel1.Controls.Add(this.btnMail);
			this.panel1.Controls.Add(this.item4);
			this.panel1.Controls.Add(this.btnBerries);
			this.panel1.Controls.Add(this.lblPage);
			this.panel1.Controls.Add(this.btnTMs);
			this.panel1.Controls.Add(this.item5);
			this.panel1.Controls.Add(this.btnBalls);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnMedicine);
			this.panel1.Controls.Add(this.item3);
			this.panel1.Controls.Add(this.btnItems);
			this.panel1.Controls.Add(this.item1);
			this.panel1.Controls.Add(this.item2);
			this.panel1.Dock = DockStyle.Bottom;
			this.panel1.Location = new Point(0, 320);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(480, 320);
			this.panel1.TabIndex = 8;
			this.btnKey.Location = new Point(424, 0);
			this.btnKey.Name = "btnKey";
			this.btnKey.Size = new Size(48, 31);
			this.btnKey.TabIndex = 16;
			this.btnKey.Text = "Key";
			this.btnKey.UseVisualStyleBackColor = true;
			this.btnKey.Click += new EventHandler(this.btnItems_Click);
			this.btnBattle.Location = new Point(368, 0);
			this.btnBattle.Name = "btnBattle";
			this.btnBattle.Size = new Size(56, 31);
			this.btnBattle.TabIndex = 15;
			this.btnBattle.Text = "Battle";
			this.btnBattle.UseVisualStyleBackColor = true;
			this.btnBattle.Click += new EventHandler(this.btnItems_Click);
			this.btnMail.Location = new Point(320, 0);
			this.btnMail.Name = "btnMail";
			this.btnMail.Size = new Size(48, 31);
			this.btnMail.TabIndex = 14;
			this.btnMail.Text = "Mail";
			this.btnMail.UseVisualStyleBackColor = true;
			this.btnMail.Click += new EventHandler(this.btnItems_Click);
			this.btnBerries.Location = new Point(248, 0);
			this.btnBerries.Name = "btnBerries";
			this.btnBerries.Size = new Size(72, 31);
			this.btnBerries.TabIndex = 13;
			this.btnBerries.Text = "Berries";
			this.btnBerries.UseVisualStyleBackColor = true;
			this.btnBerries.Click += new EventHandler(this.btnItems_Click);
			this.btnTMs.Location = new Point(200, 0);
			this.btnTMs.Name = "btnTMs";
			this.btnTMs.Size = new Size(48, 31);
			this.btnTMs.TabIndex = 12;
			this.btnTMs.Text = "TMs";
			this.btnTMs.UseVisualStyleBackColor = true;
			this.btnTMs.Click += new EventHandler(this.btnItems_Click);
			this.btnBalls.Location = new Point(144, 0);
			this.btnBalls.Name = "btnBalls";
			this.btnBalls.Size = new Size(56, 31);
			this.btnBalls.TabIndex = 11;
			this.btnBalls.Text = "Balls";
			this.btnBalls.UseVisualStyleBackColor = true;
			this.btnBalls.Click += new EventHandler(this.btnItems_Click);
			this.btnMedicine.Location = new Point(64, 0);
			this.btnMedicine.Name = "btnMedicine";
			this.btnMedicine.Size = new Size(80, 31);
			this.btnMedicine.TabIndex = 10;
			this.btnMedicine.Text = "Medicine";
			this.btnMedicine.UseVisualStyleBackColor = true;
			this.btnMedicine.Click += new EventHandler(this.btnItems_Click);
			this.btnItems.Location = new Point(8, 0);
			this.btnItems.Name = "btnItems";
			this.btnItems.Size = new Size(56, 31);
			this.btnItems.TabIndex = 9;
			this.btnItems.Text = "Items";
			this.btnItems.UseVisualStyleBackColor = true;
			this.btnItems.Click += new EventHandler(this.btnItems_Click);
			this.lblDesc.BackColor = Color.DarkGray;
			this.lblDesc.ForeColor = Color.White;
			this.lblDesc.Location = new Point(0, 264);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new Size(480, 56);
			this.lblDesc.TabIndex = 9;
			this.lblDesc.Text = "label1";
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			this.BackColor = Color.White;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new Size(480, 640);
			base.Controls.Add(this.lblDesc);
			base.Controls.Add(this.panel1);
			this.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ForeColor = Color.Black;
			base.Margin = new Padding(4);
			base.Name = "Bag";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Bag";
			base.TopMost = true;
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}
	}
}
