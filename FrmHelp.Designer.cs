/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 2008-05-13
 * Time: 10:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace soundscool
{
	partial class FrmHelp
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
			this.txtHelp = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtHelp
			// 
			this.txtHelp.Location = new System.Drawing.Point(12, 12);
			this.txtHelp.Multiline = true;
			this.txtHelp.Name = "txtHelp";
			this.txtHelp.ReadOnly = true;
			this.txtHelp.Size = new System.Drawing.Size(327, 235);
			this.txtHelp.TabIndex = 0;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(127, 253);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(98, 25);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// FrmHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 295);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtHelp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmHelp";
			this.ShowInTaskbar = false;
			this.Text = "SoundsCool --- Help";
			this.Load += new System.EventHandler(this.FrmHelpLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox txtHelp;
	}
}
