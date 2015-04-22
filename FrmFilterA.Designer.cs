/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 11/5/2008
 * Time: 17:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace soundscool
{
	partial class FrmFilterA
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
			this.txtSNS = new System.Windows.Forms.TextBox();
			this.tbSNS = new System.Windows.Forms.TrackBar();
			this.cbDistort = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSPS = new System.Windows.Forms.TextBox();
			this.tbSPS = new System.Windows.Forms.TrackBar();
			this.txtPregain = new System.Windows.Forms.TextBox();
			this.txtPostgain = new System.Windows.Forms.TextBox();
			this.tbPregain = new System.Windows.Forms.TrackBar();
			this.tbPostgain = new System.Windows.Forms.TrackBar();
			this.cbDelay = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDelayFreeback = new System.Windows.Forms.TextBox();
			this.tbDelayFreeback = new System.Windows.Forms.TrackBar();
			this.txtDelayTime = new System.Windows.Forms.TextBox();
			this.txtDelayDwMix = new System.Windows.Forms.TextBox();
			this.tbDelayTime = new System.Windows.Forms.TrackBar();
			this.tbDelayDwMix = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.tbSNS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSPS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPregain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPostgain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbDelayFreeback)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbDelayTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbDelayDwMix)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(182, 363);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 22);
			this.label7.TabIndex = 115;
			this.label7.Text = "Shape for Negative Signal";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtSNS
			// 
			this.txtSNS.Location = new System.Drawing.Point(13, 343);
			this.txtSNS.MaxLength = 5;
			this.txtSNS.Name = "txtSNS";
			this.txtSNS.Size = new System.Drawing.Size(50, 20);
			this.txtSNS.TabIndex = 116;
			this.txtSNS.Text = "0";
			this.txtSNS.Leave += new System.EventHandler(this.TxtSNSLeave);
			this.txtSNS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSNSKeyPress);
			// 
			// tbSNS
			// 
			this.tbSNS.Location = new System.Drawing.Point(69, 343);
			this.tbSNS.Maximum = 100000;
			this.tbSNS.Name = "tbSNS";
			this.tbSNS.Size = new System.Drawing.Size(339, 42);
			this.tbSNS.TabIndex = 114;
			this.tbSNS.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbSNS.Scroll += new System.EventHandler(this.TbSNSScroll);
			// 
			// cbDistort
			// 
			this.cbDistort.Location = new System.Drawing.Point(12, 187);
			this.cbDistort.Name = "cbDistort";
			this.cbDistort.Size = new System.Drawing.Size(140, 19);
			this.cbDistort.TabIndex = 113;
			this.cbDistort.Text = "Distort Filter";
			this.cbDistort.UseVisualStyleBackColor = true;
			this.cbDistort.CheckedChanged += new System.EventHandler(this.CbDistortCheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(181, 318);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 22);
			this.label1.TabIndex = 111;
			this.label1.Text = "Shape for Positive Signal";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(181, 234);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 22);
			this.label2.TabIndex = 107;
			this.label2.Text = "Pregain";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(181, 279);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 22);
			this.label5.TabIndex = 106;
			this.label5.Text = "Postgain";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtSPS
			// 
			this.txtSPS.Location = new System.Drawing.Point(12, 298);
			this.txtSPS.MaxLength = 5;
			this.txtSPS.Name = "txtSPS";
			this.txtSPS.Size = new System.Drawing.Size(50, 20);
			this.txtSPS.TabIndex = 112;
			this.txtSPS.Text = "0";
			this.txtSPS.Leave += new System.EventHandler(this.TxtSPSLeave);
			this.txtSPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSPSKeyPress);
			// 
			// tbSPS
			// 
			this.tbSPS.Location = new System.Drawing.Point(68, 298);
			this.tbSPS.Maximum = 100000;
			this.tbSPS.Name = "tbSPS";
			this.tbSPS.Size = new System.Drawing.Size(339, 42);
			this.tbSPS.TabIndex = 110;
			this.tbSPS.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbSPS.Scroll += new System.EventHandler(this.TbSPSScroll);
			// 
			// txtPregain
			// 
			this.txtPregain.Location = new System.Drawing.Point(12, 221);
			this.txtPregain.MaxLength = 5;
			this.txtPregain.Name = "txtPregain";
			this.txtPregain.Size = new System.Drawing.Size(50, 20);
			this.txtPregain.TabIndex = 109;
			this.txtPregain.Text = "1";
			this.txtPregain.Leave += new System.EventHandler(this.TxtPregainLeave);
			this.txtPregain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPregainKeyPress);
			// 
			// txtPostgain
			// 
			this.txtPostgain.Location = new System.Drawing.Point(12, 259);
			this.txtPostgain.MaxLength = 5;
			this.txtPostgain.Name = "txtPostgain";
			this.txtPostgain.Size = new System.Drawing.Size(50, 20);
			this.txtPostgain.TabIndex = 108;
			this.txtPostgain.Text = "0";
			this.txtPostgain.Leave += new System.EventHandler(this.TxtPostgainLeave);
			this.txtPostgain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPostgainKeyPress);
			// 
			// tbPregain
			// 
			this.tbPregain.Location = new System.Drawing.Point(69, 221);
			this.tbPregain.Maximum = 100000;
			this.tbPregain.Name = "tbPregain";
			this.tbPregain.Size = new System.Drawing.Size(338, 42);
			this.tbPregain.TabIndex = 105;
			this.tbPregain.Tag = "";
			this.tbPregain.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbPregain.Value = 1000;
			this.tbPregain.Scroll += new System.EventHandler(this.TbPregainScroll);
			// 
			// tbPostgain
			// 
			this.tbPostgain.Location = new System.Drawing.Point(68, 259);
			this.tbPostgain.Maximum = 1000;
			this.tbPostgain.Minimum = 1;
			this.tbPostgain.Name = "tbPostgain";
			this.tbPostgain.Size = new System.Drawing.Size(339, 42);
			this.tbPostgain.TabIndex = 104;
			this.tbPostgain.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbPostgain.Value = 100;
			this.tbPostgain.Scroll += new System.EventHandler(this.TbPostgainScroll);
			// 
			// cbDelay
			// 
			this.cbDelay.Location = new System.Drawing.Point(12, 12);
			this.cbDelay.Name = "cbDelay";
			this.cbDelay.Size = new System.Drawing.Size(140, 19);
			this.cbDelay.TabIndex = 103;
			this.cbDelay.Text = "Delay Filter";
			this.cbDelay.UseVisualStyleBackColor = true;
			this.cbDelay.CheckedChanged += new System.EventHandler(this.CbDelayCheckedChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(181, 143);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(132, 22);
			this.label6.TabIndex = 101;
			this.label6.Text = "Delay Freeback Amount";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(181, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 22);
			this.label4.TabIndex = 97;
			this.label4.Text = "Delay Time";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(181, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 22);
			this.label3.TabIndex = 96;
			this.label3.Text = "Delay Dry/Wet Mix";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtDelayFreeback
			// 
			this.txtDelayFreeback.Location = new System.Drawing.Point(12, 123);
			this.txtDelayFreeback.MaxLength = 5;
			this.txtDelayFreeback.Name = "txtDelayFreeback";
			this.txtDelayFreeback.Size = new System.Drawing.Size(50, 20);
			this.txtDelayFreeback.TabIndex = 102;
			this.txtDelayFreeback.Text = "0";
			this.txtDelayFreeback.Leave += new System.EventHandler(this.TxtDelayFreebackLeave);
			this.txtDelayFreeback.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDelayFreebackKeyPress);
			// 
			// tbDelayFreeback
			// 
			this.tbDelayFreeback.Location = new System.Drawing.Point(68, 123);
			this.tbDelayFreeback.Maximum = 95000;
			this.tbDelayFreeback.Minimum = -95000;
			this.tbDelayFreeback.Name = "tbDelayFreeback";
			this.tbDelayFreeback.Size = new System.Drawing.Size(339, 42);
			this.tbDelayFreeback.TabIndex = 100;
			this.tbDelayFreeback.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbDelayFreeback.Scroll += new System.EventHandler(this.TbDelayFreebackScroll);
			// 
			// txtDelayTime
			// 
			this.txtDelayTime.Location = new System.Drawing.Point(12, 46);
			this.txtDelayTime.MaxLength = 5;
			this.txtDelayTime.Name = "txtDelayTime";
			this.txtDelayTime.Size = new System.Drawing.Size(50, 20);
			this.txtDelayTime.TabIndex = 99;
			this.txtDelayTime.Text = "1";
			this.txtDelayTime.Leave += new System.EventHandler(this.TxtDelayTimeLeave);
			this.txtDelayTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDelayTimeKeyPress);
			// 
			// txtDelayDwMix
			// 
			this.txtDelayDwMix.Location = new System.Drawing.Point(12, 84);
			this.txtDelayDwMix.MaxLength = 5;
			this.txtDelayDwMix.Name = "txtDelayDwMix";
			this.txtDelayDwMix.Size = new System.Drawing.Size(50, 20);
			this.txtDelayDwMix.TabIndex = 98;
			this.txtDelayDwMix.Text = "0";
			this.txtDelayDwMix.Leave += new System.EventHandler(this.TxtDelayDwMixLeave);
			this.txtDelayDwMix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDelayDwMixKeyPress);
			// 
			// tbDelayTime
			// 
			this.tbDelayTime.Location = new System.Drawing.Point(69, 46);
			this.tbDelayTime.Maximum = 500000;
			this.tbDelayTime.Name = "tbDelayTime";
			this.tbDelayTime.Size = new System.Drawing.Size(338, 42);
			this.tbDelayTime.TabIndex = 95;
			this.tbDelayTime.Tag = "";
			this.tbDelayTime.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbDelayTime.Value = 10000;
			this.tbDelayTime.Scroll += new System.EventHandler(this.TbDelayTimeScroll);
			// 
			// tbDelayDwMix
			// 
			this.tbDelayDwMix.Location = new System.Drawing.Point(68, 84);
			this.tbDelayDwMix.Maximum = 100000;
			this.tbDelayDwMix.Name = "tbDelayDwMix";
			this.tbDelayDwMix.Size = new System.Drawing.Size(339, 42);
			this.tbDelayDwMix.TabIndex = 94;
			this.tbDelayDwMix.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbDelayDwMix.Scroll += new System.EventHandler(this.TbDelayDwMixScroll);
			// 
			// FrmFilterA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(434, 404);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtSNS);
			this.Controls.Add(this.tbSNS);
			this.Controls.Add(this.cbDistort);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtSPS);
			this.Controls.Add(this.tbSPS);
			this.Controls.Add(this.txtPregain);
			this.Controls.Add(this.txtPostgain);
			this.Controls.Add(this.tbPregain);
			this.Controls.Add(this.tbPostgain);
			this.Controls.Add(this.cbDelay);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDelayFreeback);
			this.Controls.Add(this.tbDelayFreeback);
			this.Controls.Add(this.txtDelayTime);
			this.Controls.Add(this.txtDelayDwMix);
			this.Controls.Add(this.tbDelayTime);
			this.Controls.Add(this.tbDelayDwMix);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmFilterA";
			this.ShowInTaskbar = false;
			this.Text = "Filter Panel A";
			this.Load += new System.EventHandler(this.FrmFilterALoad);
			((System.ComponentModel.ISupportInitialize)(this.tbSNS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSPS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPregain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPostgain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbDelayFreeback)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbDelayTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbDelayDwMix)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TrackBar tbPostgain;
		private System.Windows.Forms.TrackBar tbPregain;
		private System.Windows.Forms.TextBox txtPostgain;
		private System.Windows.Forms.TextBox txtPregain;
		private System.Windows.Forms.TrackBar tbSPS;
		private System.Windows.Forms.TextBox txtSPS;
		private System.Windows.Forms.TrackBar tbSNS;
		private System.Windows.Forms.TextBox txtSNS;
		private System.Windows.Forms.CheckBox cbDistort;
		private System.Windows.Forms.TrackBar tbDelayDwMix;
		private System.Windows.Forms.TrackBar tbDelayTime;
		private System.Windows.Forms.TextBox txtDelayDwMix;
		private System.Windows.Forms.TextBox txtDelayTime;
		private System.Windows.Forms.TrackBar tbDelayFreeback;
		private System.Windows.Forms.TextBox txtDelayFreeback;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox cbDelay;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
	}
}
