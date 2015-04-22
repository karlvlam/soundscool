/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 11/5/2008
 * Time: 17:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace soundscool
{
	/// <summary>
	/// Description of FrmFilterB.
	/// </summary>
	public partial class FrmFilterB : Form
	{
		private Csound csound;
		
		public FrmFilterB(ref Csound cs)
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
		
		void FrmFilterBLoad(object sender, EventArgs e)
		{
			reset();
		}
		
		public void reset(){
			cbRing.Checked = csound.bRing;
			cbHP.Checked = csound.bHP;
			cbHPD.Checked = csound.bHPd;
			cbLP.Checked = csound.bLP;
			cbLPD.Checked = csound.bLPd;
			
			this.txtRing.Text = csound.getRingco().ToString();
			this.tbRing.Value = Convert.ToInt32(csound.getRingco() * 1000);
			
			this.txtHPFeq.Text = csound.getHpco().ToString();
			this.tbHPFeq.Value = Convert.ToInt32(csound.getHpco()*100);
			
			this.txtLPFeq.Text = csound.getLpco().ToString();
			this.tbLPFeq.Value = Convert.ToInt32(csound.getLpco()*100);
		}
		
		void CbRingCheckedChanged(object sender, EventArgs e)
		{
			csound.bRing = cbRing.Checked;
		}
		
		void CbHPCheckedChanged(object sender, EventArgs e)
		{
			csound.bHP = cbHP.Checked;
		}
		
		void CbHPDCheckedChanged(object sender, EventArgs e)
		{
			csound.bHPd = cbHPD.Checked;
		}
		
		void CbLPCheckedChanged(object sender, EventArgs e)
		{
			csound.bLP = this.cbLP.Checked;
		}
		
		void CbLPDCheckedChanged(object sender, EventArgs e)
		{
			csound.bLPd = this.cbLPD.Checked;
		}
		
		
		void TxtHPFeqLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;	
			try{
				csound.setHpco(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TxtLPFeqLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;	
			try{
				csound.setLpco(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TbRingScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setRingco(Convert.ToDouble(b.Value)/1000);
			reset();
		}
		
		void TbHPFeqScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setHpco(Convert.ToDouble(b.Value)/100);
			reset();
		}
		
		void TbLPFeqScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setLpco(Convert.ToDouble(b.Value)/100);
			reset();
		}
		
		
		void TxtRingLeave(object sender, EventArgs e)
		{
						TextBox t = (TextBox)sender;	
			try{
				csound.setRingco(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TxtRingKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtRingLeave(sender, e);
			}
		}
		
		void TxtHPFeqKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtHPFeqLeave(sender, e);
			}
		}
		
		void TxtLPFeqKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtLPFeqLeave(sender, e);
			}
		}
	}
}
