/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 2008-05-08
 * Time: 21:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace soundscool
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public bool debug;
		public Csound csound;
		public FrmTest frmTest;
		public FrmEffect frmEffect;
		public FrmFilterA frmFa;
		public FrmFilterB frmFb;
		
		public FrmHelp frmHelp;
		public MainForm()
		{
			debug = false;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			btnTest.Visible = debug;
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			csound = new Csound();
			//frmTest = new FrmTest(ref csound);
			frmTest = new FrmTest(ref csound);
			frmEffect = new FrmEffect(ref csound);
			frmFa = new FrmFilterA(ref csound);
			frmFb = new FrmFilterB(ref csound);
			frmHelp = new FrmHelp();
		}
		
				public void reset(){
			// interface look
			this.txtInWav.Enabled = false;
			this.txtOutWav.Enabled = false;
			
			
			// interface init values
			this.txtDur.Text = csound.getDestLength().ToString();
			
			this.txtFeqScale.Text = csound.getFeqScale().ToString();
			this.tbFeqScale.Value = (int)(csound.getFeqScale()*1000);
			
			this.txtFeqShift.Text = csound.getFeqShift().ToString();
			this.tbFeqShift.Value = csound.getFeqShift();
			
			this.txtFeqShiftLow.Text = csound.getFeqShiftLow().ToString();
			this.tbFeqShiftLow.Value = csound.getFeqShiftLow();
			
			this.txtBlurTime.Text = csound.getBlurTime().ToString();
			this.tbBlurTime.Value = (int)(csound.getBlurTime()*100000);
						
			this.txtACF.Text = csound.getAmpCF().ToString();
			this.tbACF.Value = (int)(csound.getAmpCF()*100000);
			
			this.txtFCF.Text = csound.getFeqCF().ToString();
			this.tbFCF.Value = (int)(csound.getFeqCF()*100000);
			
			this.txtOAR.Text = csound.getAmpScale().ToString();
			this.tbOAR.Value = (int)(csound.getAmpScale()*10000);
		}

		
		void AboutToolStripMenuItem1Click(object sender, EventArgs e)
		{
			new FrmAbout().ShowDialog();			
			
		}
		
		void CloseToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void TbFeqShiftScroll(object sender, EventArgs e)
		{
			csound.setFeqShift(tbFeqShift.Value);
			txtFeqShift.Text = csound.getFeqShift().ToString();
		}
		
		void TxtFeqScaleTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtFeqShiftTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtFeqShiftTabIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtFeqShiftLeave(object sender, EventArgs e)
		{
			//int tmp = tbFeqShift.Value;
			try{
				csound.setFeqShift(System.Convert.ToInt32(txtFeqShift.Text));
			}catch(Exception ){
				
			}
			txtFeqShift.Text = csound.getFeqShift().ToString();
			tbFeqShift.Value = csound.getFeqShift();
		}
		
		void TxtFeqScaleLeave(object sender, EventArgs e)
		{
			
			try{
				csound.setFeqScale(System.Convert.ToDouble(txtFeqScale.Text));
			}catch(Exception ){}
			
			txtFeqScale.Text = System.Convert.ToDouble(csound.getFeqScale()).ToString();
			tbFeqScale.Value = System.Convert.ToInt32(csound.getFeqScale()*1000);
		}
		

		
		void BtnInWavClick(object sender, EventArgs e)
		{
			//txtInWav.Text = csound.getOutWav();
			DiaInWav.ShowDialog();
		}
		
		void DiaInWavFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
			if(csound.setInWav(DiaInWav.FileName)){
				txtInWav.Text = DiaInWav.FileName;
				lblDur.Text = "(WAV File duration : " + csound.getWavLength().ToString() + " sec)";
				txtDur.Text = csound.getDestLength().ToString();
			}else{
				MessageBox.Show("WAV File format error!");
			}
			
			//MessageBox.Show(Csound.wavDuration(DiaInWav.FileName).ToString());
			
		}
		
		void BtnOutWavClick(object sender, EventArgs e)
		{
			DiaOutWav.ShowDialog();
		}
		
		void DiaOutWavFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//txtOutWav.Text = DiaOutWav.FileName;
			if(csound.setOutWav(DiaOutWav.FileName)){
				txtOutWav.Text = DiaOutWav.FileName;
			}
		}
		
		void TxtDurLeave(object sender, EventArgs e)
		{
			try{
			csound.setDestLength(System.Convert.ToDouble(txtDur.Text));
			}catch(Exception ){
			}
			txtDur.Text = csound.getDestLength().ToString();
		}
		
		void TxtFeqShiftLowLeave(object sender, EventArgs e)
		{
			try{
				csound.setFeqShiftLow(System.Convert.ToInt32(txtFeqShiftLow.Text));
			}catch(Exception ){}
			txtFeqShiftLow.Text = csound.getFeqShiftLow().ToString();
			tbFeqShiftLow.Value = csound.getFeqShiftLow();
		}
		
		void TbFeqShiftLowScroll(object sender, EventArgs e)			
		{
			csound.setFeqShiftLow(tbFeqShiftLow.Value);
			txtFeqShiftLow.Text = csound.getFeqShiftLow().ToString();
			tbFeqShiftLow.Value = csound.getFeqShiftLow();
		
		}
		
		void TbACFScroll(object sender, EventArgs e)
		{
			csound.setAmpCF(Convert.ToDouble(tbACF.Value)/100000);
			txtACF.Text = csound.getAmpCF().ToString();
		}
		
		void TbFCFScroll(object sender, EventArgs e)
		{
			csound.setFeqCF(System.Convert.ToDouble(tbFCF.Value)/100000);
			txtFCF.Text = csound.getFeqCF().ToString();
		}
		
		void TxtACFLeave(object sender, EventArgs e)
		{
			
			try{
				csound.setAmpCF(System.Convert.ToDouble(txtACF.Text));
			}catch(Exception ){}
			tbACF.Value = System.Convert.ToInt32(csound.getAmpCF() * 100000);
			txtACF.Text = csound.getAmpCF().ToString();
		}
		
		void TxtFCFLeave(object sender, EventArgs e)
		{
			try{
				csound.setFeqCF(System.Convert.ToDouble(txtFCF.Text));
			}catch(Exception ){}
			tbFCF.Value = System.Convert.ToInt32(csound.getFeqCF() * 100000);
			txtFCF.Text = csound.getFeqCF().ToString();			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			reset();
			
		}
		

		
		void DiaLiveWavFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			csound.runLiveWav(DiaLiveWav.FileName);
		}
		
		void LiveWAVChangerToolStripMenuItemClick(object sender, EventArgs e)
		{
			DiaLiveWav.ShowDialog();
		}
		
		void RealTimeChangerToolStripMenuItemClick(object sender, EventArgs e)
		{
			csound.runLive();
		}
		
		void BtnFileCsdClick(object sender, EventArgs e)
		{
			if(!csound.readyFile()){
				MessageBox.Show("Input/Output file not set!", "Error");
				return;
			}				
			
			btnFileCsd.Enabled = false;
			if (csound.runWavFile()){
				MessageBox.Show("Convertsion to \"" + csound.getOutWav() + "\" completed!", "Success!");
			}else{
				MessageBox.Show("Convertsion failed!", "Error!");
			}
			btnFileCsd.Enabled = true;
			
		}
		
		void TxtBlurTimeLeave(object sender, EventArgs e)
		{
			try{
				csound.setBlurTime(System.Convert.ToDouble(txtBlurTime.Text));
			}catch(Exception ){}
			tbBlurTime.Value = System.Convert.ToInt32(csound.getBlurTime() * 100000);
			txtBlurTime.Text = csound.getBlurTime().ToString();
		}
		
		void TbBlurTimeScroll(object sender, EventArgs e)
		{
			
			csound.setBlurTime(Convert.ToDouble(tbBlurTime.Value) / 100000);
			txtBlurTime.Text = csound.getBlurTime().ToString();	
			
		}
		
		void BtnFilterAClick(object sender, EventArgs e)
		{
			if(frmFa == null || frmFa.IsDisposed){
				frmFa = new FrmFilterA(ref csound);
			}			
			frmFa.Show();
			frmFa.Focus();
		}
		
		void BtnFilterBClick(object sender, EventArgs e)
		{
			if(frmFb == null || frmFb.IsDisposed){
				frmFb = new FrmFilterB(ref csound);
			}			
			frmFb.Show();
			frmFb.Focus();
		}
		
		void TxtOARLeave(object sender, EventArgs e)
		{
			try{
				csound.setAmpScale(System.Convert.ToDouble(txtOAR.Text));
			}catch(Exception ){}
			tbOAR.Value = System.Convert.ToInt32(csound.getAmpScale() * 10000);
			txtOAR.Text = csound.getAmpScale().ToString();
		}
		
		void TbOARScroll(object sender, EventArgs e)
		{
			csound.setAmpScale(Convert.ToDouble(tbOAR.Value) / 10000);
			txtOAR.Text = csound.getAmpScale().ToString();	
		}
		
		void BtnTestClick(object sender, EventArgs e)
		{
			if(frmTest == null || frmTest.IsDisposed){
				frmTest = new FrmTest(ref csound);
			}			
			frmTest.Show();
			frmTest.Focus();
		}
		
		void BtnResetClick(object sender, EventArgs e)
		{
			csound.reset();
			this.frmFa.reset();
			this.frmFb.reset();
			this.frmEffect.reset();
			reset();
		}
		

		
		void BtnEffectClick(object sender, EventArgs e)
		{
			if(frmEffect == null || frmEffect.IsDisposed){
				frmEffect = new FrmEffect(ref csound);
			}			
			frmEffect.Show();
			frmEffect.Focus();
		}
		
		void TxtFeqScaleKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtFeqScaleLeave(sender, e);
			}
		}
		
		void TxtFeqShiftKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtFeqShiftLeave(sender, e);
			}
		}
		
		void TxtFeqShiftLowKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtFeqShiftLowLeave(sender, e);
			}
		}
		
		void TxtBlurTimeKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtBlurTimeLeave(sender, e);
			}
		}
		
		void TxtACFKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtACFLeave(sender, e);
			}
		}
		
		void TxtFCFKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtFCFLeave(sender, e);
			}
		}
		
		void TxtOARKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtOARLeave(sender, e);
			}
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void HelpToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(frmHelp == null || frmHelp.IsDisposed){
				frmHelp = new FrmHelp();
			}			
			frmHelp.Show();
			frmHelp.Focus();
		}
	}
}
