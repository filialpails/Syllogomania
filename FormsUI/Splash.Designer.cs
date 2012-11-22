namespace FormsUI
{
	partial class Splash
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
			this.pbImg = new System.Windows.Forms.PictureBox();
			this.lblTitle1 = new System.Windows.Forms.Label();
			this.lblTitle2 = new System.Windows.Forms.Label();
			this.lblCredits = new System.Windows.Forms.Label();
			this.lblStart = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
			this.SuspendLayout();
			// 
			// pbImg
			// 
			this.pbImg.BackColor = System.Drawing.Color.Transparent;
			this.pbImg.Location = new System.Drawing.Point(88, 168);
			this.pbImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pbImg.Name = "pbImg";
			this.pbImg.Size = new System.Drawing.Size(300, 300);
			this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbImg.TabIndex = 0;
			this.pbImg.TabStop = false;
			this.pbImg.Click += new System.EventHandler(this.Splash_Click);
			// 
			// lblTitle1
			// 
			this.lblTitle1.AutoSize = true;
			this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle1.Font = new System.Drawing.Font("Eras Demi ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle1.Location = new System.Drawing.Point(0, 0);
			this.lblTitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new System.Drawing.Size(476, 110);
			this.lblTitle1.TabIndex = 1;
			this.lblTitle1.Text = "Pokemon";
			// 
			// lblTitle2
			// 
			this.lblTitle2.AutoSize = true;
			this.lblTitle2.Font = new System.Drawing.Font("Eras Demi ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle2.Location = new System.Drawing.Point(360, 88);
			this.lblTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle2.Name = "lblTitle2";
			this.lblTitle2.Size = new System.Drawing.Size(71, 74);
			this.lblTitle2.TabIndex = 2;
			this.lblTitle2.Text = "#";
			// 
			// lblCredits
			// 
			this.lblCredits.AutoSize = true;
			this.lblCredits.Location = new System.Drawing.Point(0, 448);
			this.lblCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCredits.Name = "lblCredits";
			this.lblCredits.Size = new System.Drawing.Size(199, 18);
			this.lblCredits.TabIndex = 3;
			this.lblCredits.Text = "Developed by Rob Steward";
			// 
			// lblStart
			// 
			this.lblStart.AutoSize = true;
			this.lblStart.Location = new System.Drawing.Point(160, 152);
			this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblStart.Name = "lblStart";
			this.lblStart.Size = new System.Drawing.Size(173, 18);
			this.lblStart.TabIndex = 4;
			this.lblStart.Text = "PUSH START BUTTON";
			// 
			// Splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(480, 470);
			this.ControlBox = false;
			this.Controls.Add(this.lblStart);
			this.Controls.Add(this.lblCredits);
			this.Controls.Add(this.lblTitle2);
			this.Controls.Add(this.lblTitle1);
			this.Controls.Add(this.pbImg);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HelpButton = true;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Splash";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash";
			this.TopMost = true;
			this.Click += new System.EventHandler(this.Splash_Click);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Splash_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbImg;
		private System.Windows.Forms.Label lblTitle1;
		private System.Windows.Forms.Label lblTitle2;
		private System.Windows.Forms.Label lblCredits;
		private System.Windows.Forms.Label lblStart;
	}
}