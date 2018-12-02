//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace BrowserLock
{
	internal partial class ErrorWindow
	{

		public ErrorWindow()
		{
			InitializeComponent();
		}

		internal Exception DataError {get; set;}

		private void Button1_Click(object sender, EventArgs e)
		{
			using (TheProDev.Common ws = new TheProDev.Common())
			{
				System.Net.IPAddress[] IP = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName());
				string IPAddresses = "";
//INSTANT C# NOTE: The ending condition of VB 'For' loops is tested only on entry to the loop. Instant C# has created a temporary variable in order to use the initial value of UBound(IP) for every iteration:
				int tempVar = IP.GetUpperBound(0);
				for (int i = 0; i <= tempVar; i++)
				{
					IPAddresses += IP[i].ToString();

					if (!(i == IP.GetUpperBound(0)))
					{
						IPAddresses += "<br />";
					}
				}
				ws.ReportErrorDesktopErrorAsync(DataError.Message + Environment.NewLine + inEmail.Text.Trim(), DataError.StackTrace, DataError.ToString(), My.Computer.Info.OSFullName, IPAddresses, My.MyApplication.Application.AppInfo);
			}
			MessageBox.Show("Thank you for reporting this error and helping us make our software better.", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Close();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Close();
		}

	}
}