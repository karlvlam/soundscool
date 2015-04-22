/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 12/5/2008
 * Time: 17:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace soundscool
{
	/// <summary>
	/// Description of FrmEffect.
	/// </summary>
	public partial class FrmEffect : Form
	{
		
		private Csound csound;
		public FrmEffect(ref Csound cs)
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
		
		public void reset(){
			
			this.txtArpDepth.Text = csound.getArpDepth().ToString();
			this.tbArpDepth.Value = Convert.ToInt32(csound.getArpDepth() * 100000);
			
			this.txtArpGain.Text = csound.getArpGain().ToString();
			this.tbArpGain.Value = Convert.ToInt32(csound.getArpGain() * 100000);
			
			this.txtFOD.Text = csound.getLfoDepth().ToString();
			this.tbFOD.Value = Convert.ToInt32(csound.getLfoDepth() * 100000);
			
			this.txtFOS.Text = csound.getLfoSpeed().ToString();
			this.tbFOS.Value = Convert.ToInt32(csound.getLfoSpeed() * 1000);
			
			this.txtFOO.Text = csound.getLfoOffset().ToString();
			this.tbFOO.Value = Convert.ToInt32(csound.getLfoOffset() * 100000);
		}
		
		
		
		void FrmEffectLoad(object sender, EventArgs e)
		{
			reset();
		}
		
		void TxtArpDepthLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			try{
				csound.setArpDepth(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TxtArpGainLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			try{
				csound.setArpGain(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TxtFODLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			try{
				csound.setLfoDepth(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TxtFOSLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			try{
				csound.setLfoSpeed(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TxtFOOLeave(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			try{
				csound.setLfoOffset(Convert.ToDouble(t.Text));
			}catch(Exception){}
			reset();
		}
		
		void TbArpDepthScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setArpDepth(Convert.ToDouble(b.Value)/100000);
			
			reset();
		}
		
		void TbArpGainScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setArpGain(Convert.ToDouble(b.Value)/100000);
			
			reset();
		}
		
		void TbFODScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setLfoDepth(Convert.ToDouble(b.Value)/100000);
			
			reset();
		}
		
		void TbFOSScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setLfoSpeed(Convert.ToDouble(b.Value)/1000);
			
			reset();
		}
		
		void TbFOOScroll(object sender, EventArgs e)
		{
			TrackBar b = (TrackBar)sender;
			csound.setLfoOffset(Convert.ToDouble(b.Value)/100000);
			
			reset();
		}
		
		void TxtArpDepthKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtArpDepthLeave(sender, e);
			}
		}
		
		void TxtArpGainKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtArpGainLeave(sender, e);
			}
		}
		
		void TxtFODKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtFODLeave(sender, e);
			}
		}
		
		void TxtFOSKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtFOSLeave(sender, e);
			}
		}
		
		void TxtFOOKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Enter){
				TxtFOOLeave(sender, e);
			}
		}
	}
}
