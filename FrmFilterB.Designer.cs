/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 11/5/2008
 * Time: 17:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace soundscool
{
	partial class FrmFilterB
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
			this.label8 = new System.Windows.Forms.Label();
			this.txtRing = new System.Windows.Forms.TextBox();
			this.tbRing = new System.Windows.Forms.TrackBar();
			this.cbRing = new System.Windows.Forms.CheckBox();
			this.cbHP = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtHPFeq = new System.Windows.Forms.TextBox();
			this.tbHPFeq = new System.Windows.Forms.TrackBar();
			this.cbHPD = new System.Windows.Forms.CheckBox();
			this.cbLPD = new System.Windows.Forms.CheckBox();
			this.cbLP = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLPFeq = new System.Windows.Forms.TextBox();
			this.tbLPFeq = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.tbRing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbHPFeq)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLPFeq)).BeginInit();
			this.SuspendLayout();
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(164, 61);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(170, 22);
			this.label8.TabIndex = 91;
			this.label8.Text = "Sine Wave Frequency";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtRing
			// 
			this.txtRing.Location = new System.Drawing.Point(13, 41);
			this.txtRing.MaxLength = 5;
			this.txtRing.Name = "txtRing";
			this.txtRing.Size = new System.Drawing.Size(50, 20);
			this.txtRing.TabIndex = 92;
			this.txtRing.Text = "1";
			this.txtRing.Leave += new System.EventHandler(this.TxtRingLeave);
			this.txtRing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRingKeyPress);
			// 
			// tbRing
			// 
			this.tbRing.Location = new System.Drawing.Point(70, 41);
			this.tbRing.Maximum = 100000;
			this.tbRing.Minimum = 100;
			this.tbRing.Name = "tbRing";
			this.tbRing.Size = new System.Drawing.Size(338, 42);
			this.tbRing.TabIndex = 90;
			this.tbRing.Tag = "";
			this.tbRing.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbRing.Value = 1000;
			this.tbRing.Scroll += new System.EventHandler(this.TbRingScroll);
			// 
			// cbRing
			// 
			this.cbRing.Location = new System.Drawing.Point(13, 16);
			this.cbRing.Name = "cbRing";
			this.cbRing.Size = new System.Drawing.Size(140, 19);
			this.cbRing.TabIndex = 114;
			this.cbRing.Text = "Ring Modulation";
			this.cbRing.UseVisualStyleBackColor = true;
			this.cbRing.CheckedChanged += new System.EventHandler(this.CbRingCheckedChanged);
			// 
			// cbHP
			// 
			this.cbHP.Location = new System.Drawing.Point(13, 107);
			this.cbHP.Name = "cbHP";
			this.cbHP.Size = new System.Drawing.Size(140, 19);
			this.cbHP.TabIndex = 118;
			this.cbHP.Text = "High Pass Filter";
			this.cbHP.UseVisualStyleBackColor = true;
			this.cbHP.CheckedChanged += new System.EventHandler(this.CbHPCheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(164, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 22);
			this.label1.TabIndex = 116;
			this.label1.Text = "High Pass Cutoff Frequency";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtHPFeq
			// 
			this.txtHPFeq.Location = new System.Drawing.Point(13, 132);
			this.txtHPFeq.MaxLength = 5;
			this.txtHPFeq.Name = "txtHPFeq";
			this.txtHPFeq.Size = new System.Drawing.Size(50, 20);
			this.txtHPFeq.TabIndex = 117;
			this.txtHPFeq.Text = "1";
			this.txtHPFeq.Leave += new System.EventHandler(this.TxtHPFeqLeave);
			this.txtHPFeq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHPFeqKeyPress);
			// 
			// tbHPFeq
			// 
			this.tbHPFeq.Location = new System.Drawing.Point(70, 132);
			this.tbHPFeq.Maximum = 2000000;
			this.tbHPFeq.Minimum = 2000;
			this.tbHPFeq.Name = "tbHPFeq";
			this.tbHPFeq.Size = new System.Drawing.Size(338, 42);
			this.tbHPFeq.TabIndex = 115;
			this.tbHPFeq.Tag = "";
			this.tbHPFeq.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbHPFeq.Value = 2000;
			this.tbHPFeq.Scroll += new System.EventHandler(this.TbHPFeqScroll);
			// 
			// cbHPD
			// 
			this.cbHPD.Location = new System.Drawing.Point(115, 107);
			this.cbHPD.Name = "cbHPD";
			this.cbHPD.Size = new System.Drawing.Size(140, 19);
			this.cbHPD.TabIndex = 119;
			this.cbHPD.Text = "Double filtering";
			this.cbHPD.UseVisualStyleBackColor = true;
			this.cbHPD.CheckedChanged += new System.EventHandler(this.CbHPDCheckedChanged);
			// 
			// cbLPD
			// 
			this.cbLPD.Location = new System.Drawing.Point(115, 195);
			this.cbLPD.Name = "cbLPD";
			this.cbLPD.Size = new System.Drawing.Size(140, 19);
			this.cbLPD.TabIndex = 124;
			this.cbLPD.Text = "Double filtering";
			this.cbLPD.UseVisualStyleBackColor = true;
			this.cbLPD.CheckedChanged += new System.EventHandler(this.CbLPDCheckedChanged);
			// 
			// cbLP
			// 
			this.cbLP.Location = new System.Drawing.Point(13, 195);
			this.cbLP.Name = "cbLP";
			this.cbLP.Size = new System.Drawing.Size(140, 19);
			this.cbLP.TabIndex = 123;
			this.cbLP.Text = "Low Pass Filter";
			this.cbLP.UseVisualStyleBackColor = true;
			this.cbLP.CheckedChanged += new System.EventHandler(this.CbLPCheckedChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(173, 240);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 22);
			this.label2.TabIndex = 121;
			this.label2.Text = "Low Pass Cutoff Frequency";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtLPFeq
			// 
			this.txtLPFeq.Location = new System.Drawing.Point(13, 220);
			this.txtLPFeq.MaxLength = 5;
			this.txtLPFeq.Name = "txtLPFeq";
			this.txtLPFeq.Size = new System.Drawing.Size(50, 20);
			this.txtLPFeq.TabIndex = 122;
			this.txtLPFeq.Text = "1";
			this.txtLPFeq.Leave += new System.EventHandler(this.TxtLPFeqLeave);
			this.txtLPFeq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLPFeqKeyPress);
			// 
			// tbLPFeq
			// 
			this.tbLPFeq.Location = new System.Drawing.Point(70, 220);
			this.tbLPFeq.Maximum = 2000000;
			this.tbLPFeq.Minimum = 2000;
			this.tbLPFeq.Name = "tbLPFeq";
			this.tbLPFeq.Size = new System.Drawing.Size(338, 42);
			this.tbLPFeq.TabIndex = 120;
			this.tbLPFeq.Tag = "";
			this.tbLPFeq.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbLPFeq.Value = 2000;
			this.tbLPFeq.Scroll += new System.EventHandler(this.TbLPFeqScroll);
			// 
			// FrmFilterB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 297);
			this.Controls.Add(this.cbLPD);
			this.Controls.Add(this.cbLP);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLPFeq);
			this.Controls.Add(this.tbLPFeq);
			this.Controls.Add(this.cbHPD);
			this.Controls.Add(this.cbHP);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtHPFeq);
			this.Controls.Add(this.tbHPFeq);
			this.Controls.Add(this.cbRing);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtRing);
			this.Controls.Add(this.tbRing);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmFilterB";
			this.ShowInTaskbar = false;
			this.Text = "Filter Panel B";
			this.Load += new System.EventHandler(this.FrmFilterBLoad);
			((System.ComponentModel.ISupportInitialize)(this.tbRing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbHPFeq)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLPFeq)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtHPFeq;
		private System.Windows.Forms.TrackBar tbHPFeq;
		private System.Windows.Forms.TextBox txtLPFeq;
		private System.Windows.Forms.TrackBar tbLPFeq;
		private System.Windows.Forms.CheckBox cbHP;
		private System.Windows.Forms.CheckBox cbHPD;
		private System.Windows.Forms.CheckBox cbLPD;
		private System.Windows.Forms.CheckBox cbLP;
		private System.Windows.Forms.TrackBar tbRing;
		private System.Windows.Forms.TextBox txtRing;
		private System.Windows.Forms.CheckBox cbRing;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
	}
}
