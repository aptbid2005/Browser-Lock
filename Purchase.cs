//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace BrowserLock
{
	internal partial class Purchase
	{

		public Purchase()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("iexplore.exe", My.MyApplication.Application.GetSiteLink("BuyNow"));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Visit us at www.theprodev.com for more information", "Error opening webpage", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			frmRegistration frm = new frmRegistration();
			DialogResult dr = frm.ShowDialog();

			if (dr == System.Windows.Forms.DialogResult.OK)
			{
				MessageBox.Show("Please close and restart this program for the unlock to finish", "Unlocking...", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
		}

	}
}