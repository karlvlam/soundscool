/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 12/5/2008
 * Time: 17:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace soundscool
{
	partial class FrmEffect
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
			this.label7 = new System.Windows.Forms.Label();
			this.txtFOS = new System.Windows.Forms.TextBox();
			this.tbFOS = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtFOD = new System.Windows.Forms.TextBox();
			this.tbFOD = new System.Windows.Forms.TrackBar();
			this.txtArpDepth = new System.Windows.Forms.TextBox();
			this.txtArpGain = new System.Windows.Forms.TextBox();
			this.tbArpDepth = new System.Windows.Forms.TrackBar();
			this.tbArpGain = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFOO = new System.Windows.Forms.TextBox();
			this.tbFOO = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.tbFOS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFOD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbArpDepth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbArpGain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFOO)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(160, 164);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(184, 22);
			this.label7.TabIndex = 127;
			this.label7.Text = "Frequency Oscillator Speed";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtFOS
			// 
			this.txtFOS.Location = new System.Drawing.Point(23, 144);
			this.txtFOS.MaxLength = 5;
			this.txtFOS.Name = "txtFOS";
			this.txtFOS.Size = new System.Drawing.Size(50, 20);
			this.txtFOS.TabIndex = 128;
			this.txtFOS.Text = "0";
			this.txtFOS.Leave += new System.EventHandler(this.TxtFOSLeave);
			this.txtFOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFOSKeyPress);
			// 
			// tbFOS
			// 
			this.tbFOS.Location = new System.Drawing.Point(79, 144);
			this.tbFOS.Maximum = 2000000;
			this.tbFOS.Minimum = 1;
			this.tbFOS.Name = "tbFOS";
			this.tbFOS.Size = new System.Drawing.Size(339, 42);
			this.tbFOS.TabIndex = 126;
			this.tbFOS.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbFOS.Value = 1;
			this.tbFOS.Scroll += new System.EventHandler(this.TbFOSScroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(160, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 22);
			this.label1.TabIndex = 124;
			this.label1.Text = "Frequency Oscillator Depth";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(160, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 22);
			this.label2.TabIndex = 120;
			this.label2.Text = "Arpeggiate Depth";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(160, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 22);
			this.label5.TabIndex = 119;
			this.label5.Text = "Arpeggiate Gain Rescale";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtFOD
			// 
			this.txtFOD.Location = new System.Drawing.Point(22, 99);
			this.txtFOD.MaxLength = 5;
			this.txtFOD.Name = "txtFOD";
			this.txtFOD.Size = new System.Drawing.Size(50, 20);
			this.txtFOD.TabIndex = 125;
			this.txtFOD.Text = "0";
			this.txtFOD.Leave += new System.EventHandler(this.TxtFODLeave);
			this.txtFOD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFODKeyPress);
			// 
			// tbFOD
			// 
			this.tbFOD.Location = new System.Drawing.Point(78, 99);
			this.tbFOD.Maximum = 50000;
			this.tbFOD.Name = "tbFOD";
			this.tbFOD.Size = new System.Drawing.Size(339, 42);
			this.tbFOD.TabIndex = 123;
			this.tbFOD.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbFOD.Scroll += new System.EventHandler(this.TbFODScroll);
			// 
			// txtArpDepth
			// 
			this.txtArpDepth.Location = new System.Drawing.Point(22, 22);
			this.txtArpDepth.MaxLength = 5;
			this.txtArpDepth.Name = "txtArpDepth";
			this.txtArpDepth.Size = new System.Drawing.Size(50, 20);
			this.txtArpDepth.TabIndex = 122;
			this.txtArpDepth.Text = "1";
			this.txtArpDepth.Leave += new System.EventHandler(this.TxtArpDepthLeave);
			this.txtArpDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtArpDepthKeyPress);
			// 
			// txtArpGain
			// 
			this.txtArpGain.Location = new System.Drawing.Point(22, 60);
			this.txtArpGain.MaxLength = 5;
			this.txtArpGain.Name = "txtArpGain";
			this.txtArpGain.Size = new System.Drawing.Size(50, 20);
			this.txtArpGain.TabIndex = 121;
			this.txtArpGain.Text = "0";
			this.txtArpGain.Leave += new System.EventHandler(this.TxtArpGainLeave);
			this.txtArpGain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtArpGainKeyPress);
			// 
			// tbArpDepth
			// 
			this.tbArpDepth.Location = new System.Drawing.Point(79, 22);
			this.tbArpDepth.Maximum = 100000;
			this.tbArpDepth.Name = "tbArpDepth";
			this.tbArpDepth.Size = new System.Drawing.Size(338, 42);
			this.tbArpDepth.TabIndex = 118;
			this.tbArpDepth.Tag = "";
			this.tbArpDepth.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbArpDepth.Value = 1000;
			this.tbArpDepth.Scroll += new System.EventHandler(this.TbArpDepthScroll);
			// 
			// tbArpGain
			// 
			this.tbArpGain.Location = new System.Drawing.Point(78, 60);
			this.tbArpGain.Maximum = 1000000;
			this.tbArpGain.Name = "tbArpGain";
			this.tbArpGain.Size = new System.Drawing.Size(339, 42);
			this.tbArpGain.TabIndex = 117;
			this.tbArpGain.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbArpGain.Value = 100;
			this.tbArpGain.Scroll += new System.EventHandler(this.TbArpGainScroll);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(160, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 22);
			this.label3.TabIndex = 130;
			this.label3.Text = "Frequency Oscillator Offset";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtFOO
			// 
			this.txtFOO.Location = new System.Drawing.Point(22, 189);
			this.txtFOO.MaxLength = 5;
			this.txtFOO.Name = "txtFOO";
			this.txtFOO.Size = new System.Drawing.Size(50, 20);
			this.txtFOO.TabIndex = 131;
			this.txtFOO.Text = "0";
			this.txtFOO.Leave += new System.EventHandler(this.TxtFOOLeave);
			this.txtFOO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFOOKeyPress);
			// 
			// tbFOO
			// 
			this.tbFOO.Location = new System.Drawing.Point(78, 189);
			this.tbFOO.Maximum = 50000;
			this.tbFOO.Minimum = -50000;
			this.tbFOO.Name = "tbFOO";
			this.tbFOO.Size = new System.Drawing.Size(339, 42);
			this.tbFOO.TabIndex = 129;
			this.tbFOO.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbFOO.Scroll += new System.EventHandler(this.TbFOOScroll);
			// 
			// FrmEffect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 258);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFOO);
			this.Controls.Add(this.tbFOO);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtFOS);
			this.Controls.Add(this.tbFOS);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtFOD);
			this.Controls.Add(this.tbFOD);
			this.Controls.Add(this.txtArpDepth);
			this.Controls.Add(this.txtArpGain);
			this.Controls.Add(this.tbArpDepth);
			this.Controls.Add(this.tbArpGain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmEffect";
			this.ShowInTaskbar = false;
			this.Text = "Effect Panel";
			this.Load += new System.EventHandler(this.FrmEffectLoad);
			((System.ComponentModel.ISupportInitialize)(this.tbFOS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFOD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbArpDepth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbArpGain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFOO)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtFOS;
		private System.Windows.Forms.TrackBar tbFOO;
		private System.Windows.Forms.TextBox txtFOO;
		private System.Windows.Forms.TrackBar tbArpGain;
		private System.Windows.Forms.TrackBar tbArpDepth;
		private System.Windows.Forms.TextBox txtArpGain;
		private System.Windows.Forms.TextBox txtArpDepth;
		private System.Windows.Forms.TrackBar tbFOD;
		private System.Windows.Forms.TextBox txtFOD;
		private System.Windows.Forms.TrackBar tbFOS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
	}
}
