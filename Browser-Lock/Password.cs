//INSTANT C# NOTE: Formerly VB project-level imports:
using System;

namespace BrowserLock
{
	internal partial class Password
	{

		public Password()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (string.Compare(inPassword.Text.Trim(), inRePassword.Text.Trim(), StringComparison.Ordinal) == 0)
			{
				using (Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(My.MyApplication.Application.RegKey, true))
				{
					reg.SetValue("PPK", TheProDev.Globals.EncryptAES(inRePassword.Text.Trim()));
				}
				MessageBox.Show("Your password has been saved. Please keep this password safe as you will need it when you want to browse the Internet", "Password Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = System.Windows.Forms.DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Your passwords do not match please try again.", "Check Your Passwords", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void frmPassword_Load(object sender, EventArgs e)
		{
			Text = My.MyApplication.Application.AppInfo + " - Create Master Password";
		}

	}
}