//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace BrowserLock
{
	internal partial class CheckForUpdate
	{

		public CheckForUpdate()
		{
			InitializeComponent();
		}

		private void frmCheckForUpdate_Load(object sender, System.EventArgs e)
		{
			this.Text = My.MyApplication.Application.AppInfo + " - Check For Update";
			LinkLabel1.Visible = false;
			Label2.Visible = false;
		}

		private void btnCheckForUpdate_Click(System.Object sender, System.EventArgs e)
		{
			Label2.Text = "Checking for updates...";
			Label2.Visible = true;
			Application.DoEvents();
			TheProDev.Common ws = new TheProDev.Common();
			string AppVer = My.MyApplication.Application.Info.Version.Major + My.MyApplication.Application.Info.Version.Minor + My.MyApplication.Application.Info.Version.Build;
			ws.CheckForUpdateCompleted += CheckForUpdateCompleted;
			ws.CheckForUpdateAsync(int.Parse(AppVer).ToString(), My.MyApplication.Application.ProgramID);
		}

		private void CheckForUpdateCompleted(object sender, TheProDev.CheckForUpdateCompletedEventArgs e)
		{
			if (e.Error == null)
			{
				if (e.Result == true)
				{
					LinkLabel1.Visible = true;
					Label2.Visible = false;
				}
				else
				{
					Label2.Visible = true;
					Label2.Text = "No update is available at this time.";
					LinkLabel1.Visible = false;
				}
			}
			else
			{
				Label2.Visible = true;
			}
			Application.DoEvents();
		}

		private void LinkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				FolderBrowserDialog fbd = new FolderBrowserDialog();

				fbd.ShowNewFolderButton = true;
				fbd.Tag = "Select the folder you wish to save this update too.";

				DialogResult dr = fbd.ShowDialog();

				if (dr == System.Windows.Forms.DialogResult.OK)
				{
					System.Net.WebClient wc = new System.Net.WebClient();
					System.Uri uri = new System.Uri("http://www.theprodev.com/files/trials/BLP-00.zip");
					wc.DownloadFileAsync(uri, fbd.SelectedPath + "/Browser Lock Update.zip");

					LinkLabel1.Visible = false;
					Label2.Visible = true;
					Label2.Text = "Downloading, Please wait, this may take a few minutes. A message will display when finished.";

					Application.DoEvents();

					while (wc.IsBusy == true)
					{
						System.Threading.Thread.Sleep(300);
					}

					Label2.Visible = false;
					MessageBox.Show("Your download is complete. Unzip and double click the install file to update.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (System.Net.WebException ex)
			{
				Label1.Visible = false;
				MessageBox.Show("Sorry, but we were unable to contact the download server. Please browse to http://www.theprodev.com and download the new Free Version", "Could not connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}