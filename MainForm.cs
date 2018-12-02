//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace BrowserLock
{
	/// <summary>
	/// � 2009 The Professional Developer
	/// http://www.theprodev.com
	/// </summary>
	/// <author>
	/// Jason Nowicki
	/// </author>
	/// <remarks>
	/// 7/12/2011 - Added links for youtube, facebook, twitter and changed time selector to slider control
	/// </remarks>
	internal partial class MainForm
	{

		public MainForm()
		{
			InitializeComponent();
		}

		private enum TimeSpanType
		{
			Minutes,
			Hours
		}

		private bool CurrentStatus = true;
		private bool CloseRequested;
		private int TimeLength;
		private TimeSpanType TimeSpan;

		private const string DenyAccess = "Disable Internet Access";
		private const string GrantAccess = "Allow Internet Access";
		private const string DenyInternetAccessMSG = "Internet access is not allowed";
		private const string GrantInternetAccessMSG = "Internet access is allowed";
		private const string InternetBlockedMessage = "If you would like to browse the Internet you will need to provide the master password. Just double click this icon.";

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!(e.CloseReason == CloseReason.WindowsShutDown))
			{
				if (TheProDev.clsRegistration.Registered == false)
				{
					if (TheProDev.Globals.TrialExpired == true)
					{
						return;
					}
				}

				if (CloseRequested == true)
				{
					// if current status = true then browser lock is locked so ask for password
					// if current status = false then browser lock is unlocked so just close program
					if (CurrentStatus == true)
					{
						if (ValidatePassword() == false)
						{
							MessageBox.Show(string.Format("You must provide the master password before you can close Browser Lock.{0}To do this type in your password and then click the Window close button or choose Exit Program from the right click menu on Browser Lock's sytem tray icon", Environment.NewLine), "Please allow Internet access", MessageBoxButtons.OK, MessageBoxIcon.Information);
							e.Cancel = true;
						}
					}
				}
				else
				{
					e.Cancel = true;
					WindowState = FormWindowState.Minimized;
					Visible = false;
					ShowUserMessage();
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Check to see if program is registered
			if (TheProDev.clsRegistration.Registered == false)
			{

				// Set form and notifyicon title
				Text = My.MyApplication.Application.AppInfo + " Trial Edition";
				NotifyIcon1.Text = My.MyApplication.Application.AppInfo + " Trial Edition";

				// Check to see if trial has expired
				if (TheProDev.Globals.TrialExpired == true)
				{
					// Trial has expired so pop open the purchase window.
					using (Purchase frm = new Purchase())
					{
						frm.ShowDialog();
					}

					// Exit application
					CurrentStatus = false;
					CloseRequested = true;
					Close();
				}
			}
			else
			{
				// Set form and notifyicon title
				Text = My.MyApplication.Application.AppInfo;
				NotifyIcon1.Text = My.MyApplication.Application.AppInfo;

				// User has full version so hide all trial items
				UnlockThisProgramToolStripMenuItem.Visible = false;
			}

			// Notify user that the program is running in the back ground
			ShowUserMessage();

		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				WindowState = FormWindowState.Minimized;
				Visible = false;
				CloseRequested = false;
				ShowUserMessage();
			}
		}

		private void ShowForm()
		{
			ShowInTaskbar = true;
			Visible = true;
			TopMost = true;
			WindowState = FormWindowState.Normal;
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (TheProDev.clsRegistration.Registered == false)
			{
				if (TheProDev.Globals.TrialExpired == true)
				{
					return;
				}
			}

			// if application is set to allow internet traffic then exit sub
			if (My.MyApplication.Application.NextRunDate == -1 && rbNoTimeLimit.Checked == true)
			{
				btnExtend.Visible = false;
				return;
			}

			// check to see if the program should lock itself back up.
			if (DateTime.Now.ToFileTime() >= My.MyApplication.Application.NextRunDate)
			{
				btnExtend.Visible = false;
				lblStatus.Text = DenyInternetAccessMSG;
				lblStatus.ForeColor = Color.Green;
				Button1.Text = GrantAccess;

				try
				{
					Process[] Proc = Process.GetProcesses();
					for (int i = 0; i < Proc.Length; i++)
					{

						switch (Proc[i].ProcessName.ToUpperInvariant())
						{
							case "IEXPLORE":
								Proc[i].Kill();
								ShowUserMessage(string.Format("Internet Explorer was blocked by {0}{1}{1}{2}", My.MyApplication.Application.Info.Title, Environment.NewLine, InternetBlockedMessage));
								UpdateStatus(true);
								break;
							case "FIREFOX":
								Proc[i].Kill();
								ShowUserMessage(string.Format("FireFox was blocked by {0}{1}{1}{2}", My.MyApplication.Application.Info.Title, Environment.NewLine, InternetBlockedMessage));
								UpdateStatus(true);
								break;
							case "OPERA":
								Proc[i].Kill();
								ShowUserMessage(string.Format("Opera was blocked by {0}{1}{1}{2}", My.MyApplication.Application.Info.Title, Environment.NewLine, InternetBlockedMessage));
								UpdateStatus(true);
								break;
							case "SAFARI":
								Proc[i].Kill();
								ShowUserMessage(string.Format("Safari was blocked by {0}{1}{1}{2}", My.MyApplication.Application.Info.Title, Environment.NewLine, InternetBlockedMessage));
								UpdateStatus(true);
								break;
							case "MOZILLA":
								Proc[i].Kill();
								ShowUserMessage(string.Format("Mozilla was blocked by {0}{1}{1}{2}", My.MyApplication.Application.Info.Title, Environment.NewLine, InternetBlockedMessage));
								UpdateStatus(true);
								break;
							case "CHROME":
								Proc[i].Kill();
								ShowUserMessage(string.Format("Google Chrome was blocked by {0}{1}{1}{2}", My.MyApplication.Application.Info.Title, Environment.NewLine, InternetBlockedMessage));
								UpdateStatus(true);
								break;
							case "TASKMGR":
								Proc[i].Kill();
								ShowUserMessage(string.Format("Task Manager has been disabled by {0}{1}{1}If you would like to use Task Manager you need to provide the master password. Just double click this icon.", My.MyApplication.Application.Info.Title, Environment.NewLine));
								UpdateStatus(true);
								break;
							default:
								// Do Nothing
							break;
						}

					}
				}
				catch (InvalidOperationException ex)
				{

				}
				catch (System.ComponentModel.Win32Exception ex)
				{

				}
			}
			else
			{

				// display message to user if time is within 5 mins, 3 mins, 30 sec.
				if (DateHelper.DateDiff(DateHelper.DateInterval.Second, DateTime.FromFileTime(DateTime.Now.ToFileTime()), DateTime.FromFileTime(My.MyApplication.Application.NextRunDate)) == 30)
				{
					ShowUserMessage(My.MyApplication.Application.Info.Title + " will be denying access to the Internet within 30 seconds");
				}
				else if (DateHelper.DateDiff(DateHelper.DateInterval.Second, DateTime.FromFileTime(DateTime.Now.ToFileTime()), DateTime.FromFileTime(My.MyApplication.Application.NextRunDate)) == 180)
				{
					ShowUserMessage(My.MyApplication.Application.Info.Title + " will be denying access to the Internet within 3 minutes");
				}
				else if (DateHelper.DateDiff(DateHelper.DateInterval.Second, DateTime.FromFileTime(DateTime.Now.ToFileTime()), DateTime.FromFileTime(My.MyApplication.Application.NextRunDate)) == 300)
				{
					ShowUserMessage(My.MyApplication.Application.Info.Title + " will be denying access to the Internet within 5 minutes");
				}
			}

		}

		private void btnExtend_Click(object sender, EventArgs e)
		{
			if (rbMinutes.Checked == true)
			{
				My.MyApplication.Application.NextRunDate = DateTime.FromFileTime(My.MyApplication.Application.NextRunDate).AddMinutes(TrackBar1.Value).ToFileTime();
				ShowUserMessage(string.Format("Internet access has been extended by {0} minutes", TrackBar1.Value));
			}
			else if (rbHours.Checked == true)
			{
				My.MyApplication.Application.NextRunDate = DateTime.FromFileTime(My.MyApplication.Application.NextRunDate).AddHours(TrackBar1.Value).ToFileTime();
				ShowUserMessage(string.Format("Internet access has been extended by {0} hours", TrackBar1.Value));
			}
		}

		private void ShowUserMessage()
		{
			ShowUserMessage("Browser Lock will continue to run in the background. If you need me just double click this icon.");
		}

		private void ShowUserMessage(string message)
		{
			NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
			NotifyIcon1.BalloonTipText = message;
			NotifyIcon1.BalloonTipTitle = My.MyApplication.Application.AppInfo;
			NotifyIcon1.ShowBalloonTip(3000);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (Button1.Text == DenyAccess)
			{
				btnExtend.Visible = false;
				UpdateStatus(true);
			}
			else
			{
				if (ValidatePassword() == true)
				{

					// Check to see if the user requested to close the program
					if (CloseRequested == true)
					{
						// Close program
						Application.Exit();
					}
					else
					{
						// User wants to unlock the program
						btnExtend.Visible = true;
						UpdateStatus(false);
					}

				}
				else
				{
					if (inPassword.Text.Trim().Length == 0)
					{
						MessageBox.Show(string.Format("Provide the master password, then click the {0} button again.", GrantAccess), "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Your password does not match the master password. Please try again.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
		}

		private void UpdateStatus(bool Status)
		{
			CurrentStatus = Status;

			if (Status == true)
			{
				rbNoTimeLimit.Checked = false;
				My.MyApplication.Application.NextRunDate = 0;
				lblStatus.Text = DenyInternetAccessMSG;
				lblStatus.ForeColor = Color.Green;
				Button1.Text = GrantAccess;
			}
			else
			{
				if (rbNoTimeLimit.Checked == true)
				{
					My.MyApplication.Application.NextRunDate = -1;
					ShowUserMessage("Access to the Internet has been granted until you decide to lock it down.");
				}
				else if (rbMinutes.Checked == true)
				{
					My.MyApplication.Application.NextRunDate = DateTime.Now.AddMinutes(Convert.ToDouble(TrackBar1.Value)).ToFileTime();
					ShowUserMessage(string.Format("Access to the Internet has been granted for the next {0} minutes.", TrackBar1.Value));
				}
				else if (rbHours.Checked == true)
				{
					My.MyApplication.Application.NextRunDate = DateTime.Now.AddHours(Convert.ToDouble(TrackBar1.Value)).ToFileTime();
					ShowUserMessage(string.Format("Access to the Internet has been granted for the next {0} hours.", TrackBar1.Value));
				}

				lblStatus.Text = GrantInternetAccessMSG;
				lblStatus.ForeColor = Color.Red;
				Button1.Text = DenyAccess;
			}

			inPassword.Text = "";
		}

		private void rbNoTimeLimit_CheckedChanged(object sender, EventArgs e)
		{
			if (rbNoTimeLimit.Checked == true)
			{
				TrackBar1.Enabled = false;
			}
			else
			{
				TrackBar1.Enabled = true;
			}
		}

		private bool ValidatePassword()
		{
			bool tempValidatePassword = false;
			if (string.Compare(inPassword.Text.Trim(), My.MyApplication.Application.ParentalPassKey, StringComparison.Ordinal) == 0)
			{
				tempValidatePassword = true;
			}
			return tempValidatePassword;
		}

		private void TrackBar1_Scroll(object sender, EventArgs e)
		{
			TimeLength = TrackBar1.Value;
			Label2.Text = TimeLength.ToString();
		}

		private void EnableBrowserLockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UpdateStatus(true);
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CloseRequested = true;
			Close();
		}

		private void AboutThisProgramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (About frm = new About())
			{
				frm.ShowDialog();
			}
		}

		private void CheckForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (CheckForUpdate frm = new CheckForUpdate())
			{
				frm.ShowDialog();
			}
		}

		private void MakeASuggestionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (Suggestion frm = new Suggestion())
			{
				frm.ShowDialog();
			}
		}

		private void UnlockThisProgramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (frmRegistration frm = new frmRegistration())
			{
				frm.ShowDialog();
			}
		}

		private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (ChangePassword frm = new ChangePassword())
			{
				frm.ShowDialog();
			}
		}

		private void ExitProgramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowForm();
			CloseRequested = true;
			Close();
		}

		private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			ShowForm();
		}

		private void DisableBrowserLockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowForm();
		}

		private void VisitOurWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("iexplore.exe", My.MyApplication.Application.GetSiteLink("ContextMenu"));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Visit us at www.theprodev.com for more information", "Error opening webpage", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void VisitOurWebsiteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("iexplore.exe", My.MyApplication.Application.GetSiteLink("MainMenu"));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Visit us at www.theprodev.com for more information", "Error opening webpage", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void VisitUsOnYoutubeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("iexplore.exe", My.MyApplication.Application.YoutubeLink);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Visit us at " + My.MyApplication.Application.YoutubeLink, "Error opening webpage", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void LikeUsOnFacebookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("iexplore.exe", My.MyApplication.Application.FacebookLink);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Like us on " + My.MyApplication.Application.FacebookLink, "Error opening webpage", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


		private static MainForm _DefaultInstance;
		public static MainForm DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
					_DefaultInstance = new MainForm();

				return _DefaultInstance;
			}
		}
	}
}