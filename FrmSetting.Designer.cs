/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 2008-05-08
 * Time: 21:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace soundscool
{
	partial class FrmSetting
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.ofDialog = new System.Windows.Forms.OpenFileDialog();
			this.btnCSound = new System.Windows.Forms.Button();
			this.txtCSound = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(32, 82);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(59, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(97, 82);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(59, 26);
			this.button2.TabIndex = 1;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(162, 82);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(59, 26);
			this.button3.TabIndex = 2;
			this.button3.Text = "Reset";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// ofDialog
			// 
			this.ofDialog.Filter = "Csound exe file|*.exe";
			this.ofDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OfDialogFileOk);
			// 
			// btnCSound
			// 
			this.btnCSound.Location = new System.Drawing.Point(346, 45);
			this.btnCSound.Name = "btnCSound";
			this.btnCSound.Size = new System.Drawing.Size(57, 23);
			this.btnCSound.TabIndex = 4;
			this.btnCSound.Text = "Browse";
			this.btnCSound.UseVisualStyleBackColor = true;
			this.btnCSound.Click += new System.EventHandler(this.BtnCSoundClick);
			// 
			// txtCSound
			// 
			this.txtCSound.Enabled = false;
			this.txtCSound.Location = new System.Drawing.Point(32, 45);
			this.txtCSound.Name = "txtCSound";
			this.txtCSound.Size = new System.Drawing.Size(299, 20);
			this.txtCSound.TabIndex = 5;
			this.txtCSound.TextChanged += new System.EventHandler(this.TxtCSoundTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Csound exe file :";
			// 
			// FrmSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 136);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCSound);
			this.Controls.Add(this.btnCSound);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmSetting";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SoundsCool - Settings";
			this.Load += new System.EventHandler(this.FrmSettingLoad);
			this.ResizeBegin += new System.EventHandler(this.FrmSettingResizeBegin);
			this.Resize += new System.EventHandler(this.FrmSettingResize);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCSound;
		private System.Windows.Forms.Button btnCSound;
		private System.Windows.Forms.OpenFileDialog ofDialog;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
