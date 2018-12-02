//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace BrowserLock
{
	internal partial class Suggestion
	{

		public Suggestion()
		{
			InitializeComponent();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (!(inSuggestion.Text.Length == 0))
			{
				Button1.Enabled = false;
				Application.DoEvents();
				using (TheProDev.Common ws = new TheProDev.Common())
				{
					string AppVer = My.MyApplication.Application.Info.Version.Major + My.MyApplication.Application.Info.Version.Minor + My.MyApplication.Application.Info.Version.Build;
					ws.MakeASuggestionCompleted += MakeSuggestionComplete;
					ws.MakeASuggestionAsync(AppVer, My.MyApplication.Application.Info.Title, string.Format("{0}<br />{1}", inSuggestion.Text.Trim(), inEmail.Text.Trim()), inName.Text.Trim());
				}
			}
			else
			{
				MessageBox.Show("You must provide a suggestion.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void MakeSuggestionComplete(object sender, TheProDev.MakeASuggestionCompletedEventArgs e)
		{
			inName.Text = "";
			inSuggestion.Text = "";
			Button1.Enabled = true;
			Application.DoEvents();
			MessageBox.Show("Thank you for your suggestion.", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void frmSuggestion_Load(object sender, EventArgs e)
		{
			Text = My.MyApplication.Application.AppInfo + " - Make A Suggestion";
		}

	}
}