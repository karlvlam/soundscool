/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 2008-05-08
 * Time: 21:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace soundscool
{
	/// <summary>
	/// Description of FrmSetting.
	/// </summary>
	public partial class FrmSetting : Form
	{
		private Csound csound;
		public FrmSetting(ref Csound cs)			
		{
			csound = cs;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			txtCSound.Text = csound.getCsoundExe();
			button1.Enabled = false;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(csound.setCsoundExe(txtCSound.Text)){
				this.Close();
			}
		}
		
		void BtnCSoundClick(object sender, EventArgs e)
		{
			ofDialog.ShowDialog();			
			
		}
		
		void OfDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//csound.setCsoundExe();
			txtCSound.Text = ofDialog.FileName;
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			txtCSound.Text = csound.getCsoundExe();
			button1.Enabled = false;
		}
		
		void TxtCSoundTextChanged(object sender, EventArgs e)
		{
			button1.Enabled = true;
		}
		
		void FrmSettingLoad(object sender, EventArgs e)
		{
		
		}
		
		void FrmSettingResize(object sender, EventArgs e)
		{
			//this.Size = new Size(446,163);
		}
		
		void FrmSettingResizeBegin(object sender, EventArgs e)
		{
			return;
		}
	}
}
