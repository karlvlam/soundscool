/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 2008-05-08
 * Time: 21:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace soundscool
{
	/// <summary>
	/// Description of FrmAbout.
	/// </summary>
	public partial class FrmAbout : Form
	{
		public FrmAbout()
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
			this.Close();
		}
		
		void FrmAboutLoad(object sender, EventArgs e)
		{
			txtAbout.Text = "SoundsCool \r\n\r\n" +
				"Comp342 Project \r\n\r\n" +
				"Spring 2008 \r\n\r\n" +
							"Wun, Ka Wai 05610795 \r\n" +
							"Lam, Yuet Chung 05688041 \r\n" +
							"Lai, Ming Yui 05688534 \r\n" +
							"Lai, Chun Kin 06197180 \r\n";
		}
	}
}
