/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 2008-05-13
 * Time: 10:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace soundscool
{
	/// <summary>
	/// Description of FrmHelp.
	/// </summary>
	public partial class FrmHelp : Form
	{
		public FrmHelp()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnOKClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void FrmHelpLoad(object sender, EventArgs e)
		{
			txtHelp.Text = "Usage:" + Csound.NL + Csound.NL +
				"1.) Set the Csound exe file at \"Options -> Settings\" "+ Csound.NL +Csound.NL +
				"2.a) Test your voice at \"Tools -> Real Voice Changer\" "+ Csound.NL +Csound.NL +
				"2.b) Test WAV file at \"Tools -> Live WAV Changer\" "+ Csound.NL +Csound.NL +
				"3) Input the Input/Output WAV file at the main window "+ Csound.NL +
				"   -> tune the settings of the filter/effect panels"+ Csound.NL +
				"   -> press \"Go!\" button to get the output WAV file"+ Csound.NL + Csound.NL +
				"P.S. As Csound only support ASCII character, please make sure the Input/Output file paths are all ASCII :p"+ Csound.NL + Csound.NL +
				 ""+ Csound.NL;
		}
	}
}
