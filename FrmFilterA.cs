/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 11/5/2008
 * Time: 17:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace soundscool
{
	/// <summary>
	/// Description of FrmFilterA.
	/// </summary>
	public partial class FrmFilterA : Form
	{
		private Csound csound;
		public FrmFilterA(ref Csound cs)
		{
			csound = cs;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmFilterALoad(object sender, EventArgs e)
		{
			reset();
		}
		
		public void reset(){
			cbDelay.Checked = csound.bDelay;
			cbDistort.Checked = csound.bDistort;
			
			this.txtDelayTime.Text = csound.getDelayTime().ToString();
			this.tbDelayTime.Value = Convert.ToInt32(csound.getDelayTime() * 100000);
			
			this.txtDelayDwMix.Text = csound.getDelayDWM().ToString();
			this.tbDelayDwMix.Value = Convert.ToInt32(csound.getDelayDWM() * 100000);
			
			this.txtDelayFreeback.Text = csound.getDelayFB().ToString();
			this.tbDelayFreeback.Value = Convert.ToInt32(csound.getDelayFB() * 100000);
			
			this.txtPregain.Text = csound.getDistPregain().ToString();
			this.tbPregain.Value = Convert.ToInt32(csound.getDistPregain() * 1000);
			
			this.txtPostgain.Text = csound.getDistPostgain().ToString();
			this.tbPostgain.Value = Convert.ToInt32(csound.getDistPostgain() * 1000);
			
			this.txtSPS.Text = csound.getDistPS().ToString();
			this.tbSPS.Value = Convert.ToInt32(csound.getDistPS() * 100000);
			
			this.txtSNS.Text = csound.getDistNS().ToString();
			this.tbSNS.Value = Convert.ToInt32(csound.getDistNS() * 100000);
			
		}
		
		void CheckEnter(KeyEventArgs e){
			if(e.KeyCode == Keys.Enter){
				reset();
			}
		}
		
		void CbDelayCheckedChanged(object sender, EventArgs e)
		{
			csound.bDelay = this.cbDelay.Checked;
		}
		
		void CbDistortCheckedChanged(object sender, EventArgs e)
		{
			csound.bDistort = this.cbDistort.Checked;
		}
		
		void TxtDelayTimeLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			try{
				csound.setDelayTime(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();

		}
		
		void TbDelayTimeScroll(object sender, EventArgs e)
		{
			
			TrackBar b = (TrackBar)sender;
			csound.setDelayTime(Convert.ToDouble(b.Value)/100000);
			
			reset();
			
		}
		
		void TxtDelayDwMixLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			try{
			csound.setDelayDWM(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TxtDelayFreebackLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;		
			try{
			csound.setDelayFB(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TbDelayDwMixScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;						
			csound.setDelayDWM(Convert.ToDouble(b.Value)/100000);
			reset();
		}
		
		void TbDelayFreebackScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setDelayFB(Convert.ToDouble(b.Value)/100000);
			reset();
		}
		
		void TxtPregainLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;	
			try{
			csound.setDistPregain(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TbPregainScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setDistPregain(Convert.ToDouble(b.Value)/1000);
			reset();
		}
		
		void TxtPostgainLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;	
			try{
				csound.setDistPostgain(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TbPostgainScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setDistPostgain(Convert.ToDouble(b.Value)/1000);
			reset();
		}
		


		
		void TxtSPSLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;	
			try{
				csound.setDistPS(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TbSPSScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setDistPS(Convert.ToDouble(b.Value)/100000);
			reset();
		}
		
		void TxtSNSLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;		
			try{
			csound.setDistNS(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TbSNSScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setDistNS(Convert.ToDouble(b.Value)/100000);
			reset();
		}
		
		

		
		
		void TxtDelayDwMixKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtDelayDwMixLeave(sender, e);
			}
		}
		
		void TxtDelayTimeKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtDelayTimeLeave(sender, e);
			}
		}
		
		void TxtDelayFreebackKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtDelayFreebackLeave(sender, e);
			}
		}
		
		void TxtPregainKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtPregainLeave(sender, e);
			}
		}
		
		void TxtSPSKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtSPSLeave(sender, e);
			}
		}
		
		void TxtSNSKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtSNSLeave(sender, e);
			}
		}
		
		void TxtPostgainKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtPostgainLeave(sender, e);
			}
		}
	}
}
