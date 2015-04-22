/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 9/5/2008
 * Time: 17:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace soundscool
{
	/// <summary>
	/// Description of FrmTest.
	/// </summary>
	public partial class FrmTest : Form
	{
		private Csound csound;
		
		public FrmTest(ref Csound cs){
			csound = cs;
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			txtTest.Text = Csound.wavDuration(@"d:\sound\song.wav").ToString();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			csound.setOutWav(@"d:\soundd\ddd.wav");
		}
		
		void FrmTestLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
		
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			txtTest.Text = csound.genLiveCSD();
			//csound.runLiveWav(@"d:\sound\song.wav");
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			txtTest.Text = "lowpass " + csound.bLP.ToString() + Csound.NL +
				"lowpass-d " + csound.bLPd.ToString() + Csound.NL + Csound.NL +
				"highpass " + csound.bHP.ToString() + Csound.NL +
				"highpass-d " + csound.bHPd.ToString() + Csound.NL + Csound.NL +
				"delay " + csound.bDelay.ToString() + Csound.NL+ Csound.NL +
				"distort " + csound.bDistort.ToString() + Csound.NL+ Csound.NL +
				"ring " + csound.bRing.ToString() + Csound.NL ;
		}
	}
}
