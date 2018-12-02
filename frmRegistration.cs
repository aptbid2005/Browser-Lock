//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace BrowserLock
{
	internal partial class frmRegistration
	{

		public frmRegistration()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
			Close();
		}

		private void btnUnlock_Click(object sender, EventArgs e)
		{
			using (TheProDev.Common ws = new TheProDev.Common())
			{
				btnUnlock.Enabled = false;
				btnCancel.Enabled = false;
				ws.ActivateProductV2Completed += ActivateProductComplete;
				ws.ActivateProductV2Async(inEmailAddress.Text.Trim(), inOrderNumber.Text.Trim(), My.MyApplication.Application.ProgramID.ToString());
			}
		}

		private void ActivateProductComplete(object sender, TheProDev.ActivateProductV2CompletedEventArgs e)
		{
			if (e.Error == null)
			{
				TheProDev.clsActivation b = e.Result;
				btnUnlock.Enabled = true;
				btnCancel.Enabled = true;

				if (b.OrderValid == 1)
				{
					if (b.Activate == true)
					{
						using (Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(My.MyApplication.Application.RegKey, true))
						{
							reg.SetValue("KeyCode", b.RegistrationKey.Trim());
						}
						MessageBox.Show(string.Format("{0}{1}{1}PLEASE RESTART THIS PROGRAM TO COMPLETE THE UNLOCK.", b.Message, Environment.NewLine), "Program Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Close();
					}
					else
					{
						MessageBox.Show(b.Message, "Unable to unlock program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					MessageBox.Show(b.Message, "Unable to unlock program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				MessageBox.Show("Could not connect to the Internet. Please make sure your connection is on and active and firewalls will allow our program through.", "No Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("iexplore.exe", My.MyApplication.Application.GetSiteLink("Registration"));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please visit www.theprodev.com for more information", "Error opening webpage", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void frmRegistration_Load(object sender, EventArgs e)
		{
			ToolTip1.ToolTipTitle = My.MyApplication.Application.AppInfo;
		}

	}
}