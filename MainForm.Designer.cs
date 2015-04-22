/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 2008-05-08
 * Time: 21:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace soundscool
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.liveWAVChangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.realTimeChangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.txtInWav = new System.Windows.Forms.TextBox();
			this.txtOutWav = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbFeqShift = new System.Windows.Forms.TrackBar();
			this.tbFeqScale = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFeqShift = new System.Windows.Forms.TextBox();
			this.txtFeqScale = new System.Windows.Forms.TextBox();
			this.btnInWav = new System.Windows.Forms.Button();
			this.btnOutWav = new System.Windows.Forms.Button();
			this.lblDur = new System.Windows.Forms.Label();
			this.txtDur = new System.Windows.Forms.TextBox();
			this.DiaInWav = new System.Windows.Forms.OpenFileDialog();
			this.DiaOutWav = new System.Windows.Forms.SaveFileDialog();
			this.tbFeqShiftLow = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFeqShiftLow = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbACF = new System.Windows.Forms.TrackBar();
			this.tbFCF = new System.Windows.Forms.TrackBar();
			this.txtACF = new System.Windows.Forms.TextBox();
			this.txtFCF = new System.Windows.Forms.TextBox();
			this.DiaLiveWav = new System.Windows.Forms.OpenFileDialog();
			this.btnFileCsd = new System.Windows.Forms.Button();
			this.txtBlurTime = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbBlurTime = new System.Windows.Forms.TrackBar();
			this.btnFilterA = new System.Windows.Forms.Button();
			this.btnFilterB = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txtOAR = new System.Windows.Forms.TextBox();
			this.tbOAR = new System.Windows.Forms.TrackBar();
			this.btnTest = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnEffect = new System.Windows.Forms.Button();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbFeqShift)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFeqScale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFeqShiftLow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbACF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFCF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBlurTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbOAR)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.optionsToolStripMenuItem,
									this.toolsToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(644, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.settingToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.settingToolStripMenuItem.Text = "Settings";
			this.settingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItemClick);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.liveWAVChangerToolStripMenuItem,
									this.realTimeChangerToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// liveWAVChangerToolStripMenuItem
			// 
			this.liveWAVChangerToolStripMenuItem.Name = "liveWAVChangerToolStripMenuItem";
			this.liveWAVChangerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.liveWAVChangerToolStripMenuItem.Text = "Live WAV Changer";
			this.liveWAVChangerToolStripMenuItem.Click += new System.EventHandler(this.LiveWAVChangerToolStripMenuItemClick);
			// 
			// realTimeChangerToolStripMenuItem
			// 
			this.realTimeChangerToolStripMenuItem.Name = "realTimeChangerToolStripMenuItem";
			this.realTimeChangerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.realTimeChangerToolStripMenuItem.Text = "Real Voice Changer";
			this.realTimeChangerToolStripMenuItem.Click += new System.EventHandler(this.RealTimeChangerToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpToolStripMenuItem,
									this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.aboutToolStripMenuItem.Text = "Help";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1Click);
			// 
			// txtInWav
			// 
			this.txtInWav.Location = new System.Drawing.Point(99, 43);
			this.txtInWav.Name = "txtInWav";
			this.txtInWav.Size = new System.Drawing.Size(339, 20);
			this.txtInWav.TabIndex = 1;
			// 
			// txtOutWav
			// 
			this.txtOutWav.Location = new System.Drawing.Point(99, 69);
			this.txtOutWav.Name = "txtOutWav";
			this.txtOutWav.Size = new System.Drawing.Size(339, 20);
			this.txtOutWav.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Input WAV :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Output WAV :";
			// 
			// tbFeqShift
			// 
			this.tbFeqShift.Location = new System.Drawing.Point(94, 151);
			this.tbFeqShift.Maximum = 3000;
			this.tbFeqShift.Minimum = -3000;
			this.tbFeqShift.Name = "tbFeqShift";
			this.tbFeqShift.Size = new System.Drawing.Size(339, 42);
			this.tbFeqShift.TabIndex = 5;
			this.tbFeqShift.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbFeqShift.Scroll += new System.EventHandler(this.TbFeqShiftScroll);
			// 
			// tbFeqScale
			// 
			this.tbFeqScale.Location = new System.Drawing.Point(95, 113);
			this.tbFeqScale.Maximum = 8000;
			this.tbFeqScale.Minimum = 125;
			this.tbFeqScale.Name = "tbFeqScale";
			this.tbFeqScale.Size = new System.Drawing.Size(338, 42);
			this.tbFeqScale.TabIndex = 6;
			this.tbFeqScale.Tag = "";
			this.tbFeqScale.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbFeqScale.Value = 1000;
			this.tbFeqScale.Scroll += new System.EventHandler(this.TbFeqScaleScroll);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(190, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 22);
			this.label3.TabIndex = 7;
			this.label3.Text = "Freq Shift";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(188, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 22);
			this.label4.TabIndex = 8;
			this.label4.Text = "Freq Rescale";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtFeqShift
			// 
			this.txtFeqShift.Location = new System.Drawing.Point(38, 151);
			this.txtFeqShift.MaxLength = 5;
			this.txtFeqShift.Name = "txtFeqShift";
			this.txtFeqShift.Size = new System.Drawing.Size(50, 20);
			this.txtFeqShift.TabIndex = 9;
			this.txtFeqShift.Text = "0";
			this.txtFeqShift.TextChanged += new System.EventHandler(this.TxtFeqShiftTextChanged);
			this.txtFeqShift.Leave += new System.EventHandler(this.TxtFeqShiftLeave);
			this.txtFeqShift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFeqShiftKeyPress);
			this.txtFeqShift.TabIndexChanged += new System.EventHandler(this.TxtFeqShiftTabIndexChanged);
			// 
			// txtFeqScale
			// 
			this.txtFeqScale.Location = new System.Drawing.Point(38, 113);
			this.txtFeqScale.MaxLength = 5;
			this.txtFeqScale.Name = "txtFeqScale";
			this.txtFeqScale.Size = new System.Drawing.Size(50, 20);
			this.txtFeqScale.TabIndex = 10;
			this.txtFeqScale.Text = "1";
			this.txtFeqScale.TextChanged += new System.EventHandler(this.TxtFeqScaleTextChanged);
			this.txtFeqScale.Leave += new System.EventHandler(this.TxtFeqScaleLeave);
			this.txtFeqScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFeqScaleKeyPress);
			// 
			// btnInWav
			// 
			this.btnInWav.Location = new System.Drawing.Point(444, 43);
			this.btnInWav.Name = "btnInWav";
			this.btnInWav.Size = new System.Drawing.Size(49, 21);
			this.btnInWav.TabIndex = 11;
			this.btnInWav.Text = "In";
			this.btnInWav.UseVisualStyleBackColor = true;
			this.btnInWav.Click += new System.EventHandler(this.BtnInWavClick);
			// 
			// btnOutWav
			// 
			this.btnOutWav.Location = new System.Drawing.Point(444, 68);
			this.btnOutWav.Name = "btnOutWav";
			this.btnOutWav.Size = new System.Drawing.Size(49, 21);
			this.btnOutWav.TabIndex = 12;
			this.btnOutWav.Text = "Out";
			this.btnOutWav.UseVisualStyleBackColor = true;
			this.btnOutWav.Click += new System.EventHandler(this.BtnOutWavClick);
			// 
			// lblDur
			// 
			this.lblDur.Location = new System.Drawing.Point(505, 43);
			this.lblDur.Name = "lblDur";
			this.lblDur.Size = new System.Drawing.Size(176, 22);
			this.lblDur.TabIndex = 14;
			this.lblDur.Text = "(WAV duration : 0 sec)";
			// 
			// txtDur
			// 
			this.txtDur.Location = new System.Drawing.Point(505, 69);
			this.txtDur.Name = "txtDur";
			this.txtDur.Size = new System.Drawing.Size(50, 20);
			this.txtDur.TabIndex = 15;
			this.txtDur.Text = "5";
			this.txtDur.Leave += new System.EventHandler(this.TxtDurLeave);
			// 
			// DiaInWav
			// 
			this.DiaInWav.Filter = "WAV files|*.wav|All files|*";
			this.DiaInWav.Title = "Input WAV File";
			this.DiaInWav.FileOk += new System.ComponentModel.CancelEventHandler(this.DiaInWavFileOk);
			// 
			// DiaOutWav
			// 
			this.DiaOutWav.DefaultExt = "wav";
			this.DiaOutWav.Filter = "WAV files|*.wav";
			this.DiaOutWav.Title = "Output WAV file";
			this.DiaOutWav.FileOk += new System.ComponentModel.CancelEventHandler(this.DiaOutWavFileOk);
			// 
			// tbFeqShiftLow
			// 
			this.tbFeqShiftLow.Location = new System.Drawing.Point(94, 190);
			this.tbFeqShiftLow.Maximum = 3000;
			this.tbFeqShiftLow.Minimum = -3000;
			this.tbFeqShiftLow.Name = "tbFeqShiftLow";
			this.tbFeqShiftLow.Size = new System.Drawing.Size(339, 42);
			this.tbFeqShiftLow.TabIndex = 17;
			this.tbFeqShiftLow.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbFeqShiftLow.Scroll += new System.EventHandler(this.TbFeqShiftLowScroll);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(188, 210);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(155, 22);
			this.label6.TabIndex = 18;
			this.label6.Text = "Lowest Freq to Shift";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtFeqShiftLow
			// 
			this.txtFeqShiftLow.Location = new System.Drawing.Point(38, 190);
			this.txtFeqShiftLow.MaxLength = 5;
			this.txtFeqShiftLow.Name = "txtFeqShiftLow";
			this.txtFeqShiftLow.Size = new System.Drawing.Size(50, 20);
			this.txtFeqShiftLow.TabIndex = 19;
			this.txtFeqShiftLow.Text = "0";
			this.txtFeqShiftLow.Leave += new System.EventHandler(this.TxtFeqShiftLowLeave);
			this.txtFeqShiftLow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFeqShiftLowKeyPress);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(188, 292);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(155, 22);
			this.label7.TabIndex = 20;
			this.label7.Text = "Amplipude Cutoff Freq";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(188, 339);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(155, 23);
			this.label8.TabIndex = 21;
			this.label8.Text = "Frequency Cutoff Freq";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbACF
			// 
			this.tbACF.Location = new System.Drawing.Point(94, 272);
			this.tbACF.Maximum = 100000;
			this.tbACF.Name = "tbACF";
			this.tbACF.Size = new System.Drawing.Size(339, 42);
			this.tbACF.TabIndex = 22;
			this.tbACF.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbACF.Value = 100000;
			this.tbACF.Scroll += new System.EventHandler(this.TbACFScroll);
			// 
			// tbFCF
			// 
			this.tbFCF.Location = new System.Drawing.Point(94, 320);
			this.tbFCF.Maximum = 100000;
			this.tbFCF.Name = "tbFCF";
			this.tbFCF.Size = new System.Drawing.Size(339, 42);
			this.tbFCF.TabIndex = 23;
			this.tbFCF.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbFCF.Value = 100000;
			this.tbFCF.Scroll += new System.EventHandler(this.TbFCFScroll);
			// 
			// txtACF
			// 
			this.txtACF.Location = new System.Drawing.Point(38, 272);
			this.txtACF.MaxLength = 5;
			this.txtACF.Name = "txtACF";
			this.txtACF.Size = new System.Drawing.Size(50, 20);
			this.txtACF.TabIndex = 24;
			this.txtACF.Text = "0";
			this.txtACF.Leave += new System.EventHandler(this.TxtACFLeave);
			this.txtACF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtACFKeyPress);
			// 
			// txtFCF
			// 
			this.txtFCF.Location = new System.Drawing.Point(38, 314);
			this.txtFCF.MaxLength = 5;
			this.txtFCF.Name = "txtFCF";
			this.txtFCF.Size = new System.Drawing.Size(50, 20);
			this.txtFCF.TabIndex = 25;
			this.txtFCF.Text = "0";
			this.txtFCF.Leave += new System.EventHandler(this.TxtFCFLeave);
			this.txtFCF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFCFKeyPress);
			// 
			// DiaLiveWav
			// 
			this.DiaLiveWav.Filter = "WAV files|*.wav";
			this.DiaLiveWav.FileOk += new System.ComponentModel.CancelEventHandler(this.DiaLiveWavFileOk);
			// 
			// btnFileCsd
			// 
			this.btnFileCsd.Location = new System.Drawing.Point(444, 351);
			this.btnFileCsd.Name = "btnFileCsd";
			this.btnFileCsd.Size = new System.Drawing.Size(80, 41);
			this.btnFileCsd.TabIndex = 26;
			this.btnFileCsd.Text = "Go !";
			this.btnFileCsd.UseVisualStyleBackColor = true;
			this.btnFileCsd.Click += new System.EventHandler(this.BtnFileCsdClick);
			// 
			// txtBlurTime
			// 
			this.txtBlurTime.Location = new System.Drawing.Point(38, 227);
			this.txtBlurTime.MaxLength = 5;
			this.txtBlurTime.Name = "txtBlurTime";
			this.txtBlurTime.Size = new System.Drawing.Size(50, 20);
			this.txtBlurTime.TabIndex = 29;
			this.txtBlurTime.Text = "0";
			this.txtBlurTime.Leave += new System.EventHandler(this.TxtBlurTimeLeave);
			this.txtBlurTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBlurTimeKeyPress);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(188, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(155, 22);
			this.label5.TabIndex = 27;
			this.label5.Text = "Blurring Time";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbBlurTime
			// 
			this.tbBlurTime.Location = new System.Drawing.Point(94, 227);
			this.tbBlurTime.Maximum = 300000;
			this.tbBlurTime.Name = "tbBlurTime";
			this.tbBlurTime.Size = new System.Drawing.Size(339, 42);
			this.tbBlurTime.TabIndex = 28;
			this.tbBlurTime.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbBlurTime.Scroll += new System.EventHandler(this.TbBlurTimeScroll);
			// 
			// btnFilterA
			// 
			this.btnFilterA.Location = new System.Drawing.Point(444, 176);
			this.btnFilterA.Name = "btnFilterA";
			this.btnFilterA.Size = new System.Drawing.Size(80, 34);
			this.btnFilterA.TabIndex = 30;
			this.btnFilterA.Text = "Filter A >>";
			this.btnFilterA.UseVisualStyleBackColor = true;
			this.btnFilterA.Click += new System.EventHandler(this.BtnFilterAClick);
			// 
			// btnFilterB
			// 
			this.btnFilterB.Location = new System.Drawing.Point(444, 237);
			this.btnFilterB.Name = "btnFilterB";
			this.btnFilterB.Size = new System.Drawing.Size(80, 34);
			this.btnFilterB.TabIndex = 31;
			this.btnFilterB.Text = "Filter B >>";
			this.btnFilterB.UseVisualStyleBackColor = true;
			this.btnFilterB.Click += new System.EventHandler(this.BtnFilterBClick);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(188, 388);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(155, 22);
			this.label9.TabIndex = 129;
			this.label9.Text = "Output Amplitude Rescaling";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtOAR
			// 
			this.txtOAR.Location = new System.Drawing.Point(37, 368);
			this.txtOAR.MaxLength = 5;
			this.txtOAR.Name = "txtOAR";
			this.txtOAR.Size = new System.Drawing.Size(50, 20);
			this.txtOAR.TabIndex = 130;
			this.txtOAR.Text = "1";
			this.txtOAR.Leave += new System.EventHandler(this.TxtOARLeave);
			this.txtOAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOARKeyPress);
			// 
			// tbOAR
			// 
			this.tbOAR.Location = new System.Drawing.Point(94, 368);
			this.tbOAR.Maximum = 100000;
			this.tbOAR.Name = "tbOAR";
			this.tbOAR.Size = new System.Drawing.Size(338, 42);
			this.tbOAR.TabIndex = 128;
			this.tbOAR.Tag = "";
			this.tbOAR.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbOAR.Value = 10000;
			this.tbOAR.Scroll += new System.EventHandler(this.TbOARScroll);
			// 
			// btnTest
			// 
			this.btnTest.BackColor = System.Drawing.Color.YellowGreen;
			this.btnTest.Location = new System.Drawing.Point(546, 121);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(72, 267);
			this.btnTest.TabIndex = 131;
			this.btnTest.Text = "Testing";
			this.btnTest.UseVisualStyleBackColor = false;
			this.btnTest.Click += new System.EventHandler(this.BtnTestClick);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(444, 307);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(80, 27);
			this.btnReset.TabIndex = 132;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnEffect
			// 
			this.btnEffect.Location = new System.Drawing.Point(444, 121);
			this.btnEffect.Name = "btnEffect";
			this.btnEffect.Size = new System.Drawing.Size(80, 34);
			this.btnEffect.TabIndex = 133;
			this.btnEffect.Text = "Effect >>";
			this.btnEffect.UseVisualStyleBackColor = true;
			this.btnEffect.Click += new System.EventHandler(this.BtnEffectClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 432);
			this.Controls.Add(this.btnEffect);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtOAR);
			this.Controls.Add(this.tbOAR);
			this.Controls.Add(this.btnFilterB);
			this.Controls.Add(this.btnFilterA);
			this.Controls.Add(this.txtBlurTime);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbBlurTime);
			this.Controls.Add(this.btnFileCsd);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtFCF);
			this.Controls.Add(this.txtACF);
			this.Controls.Add(this.tbFCF);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtFeqShiftLow);
			this.Controls.Add(this.tbFeqShiftLow);
			this.Controls.Add(this.txtDur);
			this.Controls.Add(this.lblDur);
			this.Controls.Add(this.btnOutWav);
			this.Controls.Add(this.btnInWav);
			this.Controls.Add(this.txtFeqScale);
			this.Controls.Add(this.txtFeqShift);
			this.Controls.Add(this.tbFeqScale);
			this.Controls.Add(this.tbFeqShift);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtOutWav);
			this.Controls.Add(this.txtInWav);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tbACF);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SoundsCool";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbFeqShift)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFeqScale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFeqShiftLow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbACF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFCF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBlurTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbOAR)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Button btnEffect;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.TrackBar tbOAR;
		private System.Windows.Forms.TextBox txtOAR;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnFilterA;
		private System.Windows.Forms.Button btnFilterB;
		private System.Windows.Forms.TrackBar tbBlurTime;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBlurTime;
		private System.Windows.Forms.Button btnFileCsd;
		private System.Windows.Forms.ToolStripMenuItem liveWAVChangerToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog DiaLiveWav;
		private System.Windows.Forms.TextBox txtFCF;
		private System.Windows.Forms.TextBox txtACF;
		private System.Windows.Forms.TrackBar tbFCF;
		private System.Windows.Forms.TrackBar tbACF;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtFeqShiftLow;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TrackBar tbFeqShiftLow;
		private System.Windows.Forms.ToolStripMenuItem realTimeChangerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.Label lblDur;
		private System.Windows.Forms.SaveFileDialog DiaOutWav;
		private System.Windows.Forms.OpenFileDialog DiaInWav;
		private System.Windows.Forms.TextBox txtInWav;
		private System.Windows.Forms.TextBox txtOutWav;
		private System.Windows.Forms.TextBox txtDur;
		private System.Windows.Forms.Button btnOutWav;
		private System.Windows.Forms.Button btnInWav;
		private System.Windows.Forms.TextBox txtFeqScale;
		private System.Windows.Forms.TextBox txtFeqShift;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar tbFeqScale;
		private System.Windows.Forms.TrackBar tbFeqShift;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		
		void SettingToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			new FrmSetting(ref csound).ShowDialog();
		}
		
		void TbFeqScaleScroll(object sender, System.EventArgs e)
		{
			//txtFeqScale.Text = System.Math.Pow(2, tbFeqScale.Value).ToString();
			//txtFeqScale.Text = (System.Convert.ToDouble(tbFeqScale.Value)/1000).ToString();
			csound.setFeqScale(System.Convert.ToDouble(tbFeqScale.Value)/1000);
			txtFeqScale.Text = csound.getFeqScale().ToString();
		}
	}
}
