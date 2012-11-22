using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace FormsUI
{
	public class TextWindow : Form
	{
		private IContainer components = null;
		private Label label1;
		private GroupBox groupBox1;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private readonly string[] text;
		private int page = 0;
		private bool question = false;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TextWindow));
			this.label1 = new Label();
			this.groupBox1 = new GroupBox();
			this.radioButton2 = new RadioButton();
			this.radioButton1 = new RadioButton();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.label1.Dock = DockStyle.Fill;
			this.label1.Location = new Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(420, 96);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new Point(352, -8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(64, 96);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Visible = false;
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new Point(8, 56);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new Size(46, 22);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "No";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new Point(8, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new Size(52, 22);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Yes";
			this.radioButton1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(420, 96);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.label1);
			this.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ForeColor = Color.Black;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Margin = new Padding(4);
			base.Name = "TextWindow";
			base.StartPosition = FormStartPosition.CenterParent;
			base.KeyDown += new KeyEventHandler(this.TextWindow_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}
		public TextWindow(params string[] s)
		{
			this.InitializeComponent();
			this.text = s;
			this.label1.Text = this.text[0];
		}
		private void TextWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (!this.groupBox1.Visible)
			{
				if (this.page < this.text.Length)
				{
					this.label1.Text = this.text[this.page];
					if (this.page == this.text.Length - 1 && this.question)
					{
						this.groupBox1.Visible = true;
					}
					this.page++;
				}
				else
				{
					if (!this.question)
					{
						base.Close();
					}
				}
			}
			else
			{
				if (this.radioButton1.Checked)
				{
					base.DialogResult = DialogResult.Yes;
				}
				else
				{
					if (this.radioButton2.Checked)
					{
						base.DialogResult = DialogResult.No;
					}
					else
					{
						base.DialogResult = DialogResult.Cancel;
					}
				}
				base.Close();
			}
		}
		public DialogResult ShowQuestion(string opt1 = "Yes", string opt2 = "No")
		{
			this.question = true;
			this.radioButton1.Text = opt1;
			this.radioButton2.Text = opt2;
			if (this.text.Length == 1)
			{
				this.groupBox1.Visible = true;
			}
			return base.ShowDialog();
		}
	}
}
