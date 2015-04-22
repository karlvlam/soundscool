/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 9/5/2008
 * Time: 17:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace soundscool
{
	partial class FrmTest
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtTest = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtTest
			// 
			this.txtTest.Location = new System.Drawing.Point(42, 21);
			this.txtTest.Multiline = true;
			this.txtTest.Name = "txtTest";
			this.txtTest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtTest.Size = new System.Drawing.Size(680, 270);
			this.txtTest.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(538, 325);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "sample CSD";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(437, 351);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(95, 25);
			this.button2.TabIndex = 2;
			this.button2.Text = "wavDur";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(409, 310);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 24);
			this.button3.TabIndex = 3;
			this.button3.Text = "inWav";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(42, 325);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(81, 26);
			this.button4.TabIndex = 4;
			this.button4.Text = "F2F csd";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(208, 334);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(79, 20);
			this.button5.TabIndex = 5;
			this.button5.Text = "Live";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(312, 321);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(70, 29);
			this.button6.TabIndex = 6;
			this.button6.Text = "on/off";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// FrmTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 388);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtTest);
			this.Name = "FrmTest";
			this.Text = "FrmTest";
			this.Load += new System.EventHandler(this.FrmTestLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtTest;
		private System.Windows.Forms.Button button1;
	}
}
