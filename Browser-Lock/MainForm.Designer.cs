//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace BrowserLock
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	internal partial class MainForm : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Button1 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.inPassword = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.CheckForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MakeASuggestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.VisitOurWebsiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.LikeUsOnFacebookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.VisitUsOnYoutubeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.UnlockThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.EnableBrowserLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DisableBrowserLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.CheckForUpdateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.MakeASuggestionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.VisitOurWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LikeUsOnFacebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.VisitUsOnYoutubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.rbNoTimeLimit = new System.Windows.Forms.RadioButton();
			this.Label2 = new System.Windows.Forms.Label();
			this.rbHours = new System.Windows.Forms.RadioButton();
			this.rbMinutes = new System.Windows.Forms.RadioButton();
			this.TrackBar1 = new System.Windows.Forms.TrackBar();
			this.btnExtend = new System.Windows.Forms.Button();
			this.MenuStrip1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.TrackBar1).BeginInit();
			this.SuspendLayout();
			//
			//Timer1
			//
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(174, 235);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(151, 27);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "Allow Internet Access";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label1.Location = new System.Drawing.Point(6, 130);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(91, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Master Password:";
			//
			//inPassword
			//
			this.inPassword.Location = new System.Drawing.Point(103, 125);
			this.inPassword.Name = "inPassword";
			this.inPassword.PasswordChar = (char)42;
			this.inPassword.Size = new System.Drawing.Size(194, 21);
			this.inPassword.TabIndex = 4;
			//
			//lblStatus
			//
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.lblStatus.ForeColor = System.Drawing.Color.Green;
			this.lblStatus.Location = new System.Drawing.Point(14, 38);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(190, 17);
			this.lblStatus.TabIndex = 4;
			this.lblStatus.Text = "Internet access is denied";
			//
			//MenuStrip1
			//
			this.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.MenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F);
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileToolStripMenuItem, this.OptionsToolStripMenuItem, this.AboutToolStripMenuItem, this.UnlockThisProgramToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.MenuStrip1.Size = new System.Drawing.Size(335, 24);
			this.MenuStrip1.TabIndex = 5;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//FileToolStripMenuItem
			//
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.FileToolStripMenuItem.Text = "File";
			//
			//ExitToolStripMenuItem
			//
			this.ExitToolStripMenuItem.Image = BrowserLock.Properties.Resources.x;
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.ExitToolStripMenuItem.Text = "Exit Program";
			//
			//OptionsToolStripMenuItem
			//
			this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ChangePasswordToolStripMenuItem});
			this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
			this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.OptionsToolStripMenuItem.Text = "Options";
			//
			//ChangePasswordToolStripMenuItem
			//
			this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
			this.ChangePasswordToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.ChangePasswordToolStripMenuItem.Text = "Change Password";
			//
			//AboutToolStripMenuItem
			//
			this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AboutThisProgramToolStripMenuItem, this.ToolStripSeparator3, this.CheckForUpdateToolStripMenuItem, this.MakeASuggestionToolStripMenuItem, this.ToolStripSeparator4, this.VisitOurWebsiteToolStripMenuItem1, this.LikeUsOnFacebookToolStripMenuItem1, this.VisitUsOnYoutubeToolStripMenuItem1});
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.AboutToolStripMenuItem.Text = "About";
			//
			//AboutThisProgramToolStripMenuItem
			//
			this.AboutThisProgramToolStripMenuItem.Image = BrowserLock.Properties.Resources.root;
			this.AboutThisProgramToolStripMenuItem.Name = "AboutThisProgramToolStripMenuItem";
			this.AboutThisProgramToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.AboutThisProgramToolStripMenuItem.Text = "About this program";
			//
			//ToolStripSeparator3
			//
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			this.ToolStripSeparator3.Size = new System.Drawing.Size(184, 6);
			//
			//CheckForUpdateToolStripMenuItem
			//
			this.CheckForUpdateToolStripMenuItem.Image = BrowserLock.Properties.Resources.check;
			this.CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem";
			this.CheckForUpdateToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.CheckForUpdateToolStripMenuItem.Text = "Check for update";
			//
			//MakeASuggestionToolStripMenuItem
			//
			this.MakeASuggestionToolStripMenuItem.Image = BrowserLock.Properties.Resources.email_icon_16x16;
			this.MakeASuggestionToolStripMenuItem.Name = "MakeASuggestionToolStripMenuItem";
			this.MakeASuggestionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.MakeASuggestionToolStripMenuItem.Text = "Make a suggestion";
			//
			//ToolStripSeparator4
			//
			this.ToolStripSeparator4.Name = "ToolStripSeparator4";
			this.ToolStripSeparator4.Size = new System.Drawing.Size(184, 6);
			//
			//VisitOurWebsiteToolStripMenuItem1
			//
			this.VisitOurWebsiteToolStripMenuItem1.Image = BrowserLock.Properties.Resources.TPD_Starburst_16x16;
			this.VisitOurWebsiteToolStripMenuItem1.Name = "VisitOurWebsiteToolStripMenuItem1";
			this.VisitOurWebsiteToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
			this.VisitOurWebsiteToolStripMenuItem1.Text = "Visit our website";
			//
			//LikeUsOnFacebookToolStripMenuItem1
			//
			this.LikeUsOnFacebookToolStripMenuItem1.Image = BrowserLock.Properties.Resources.Facebook_icon__1_;
			this.LikeUsOnFacebookToolStripMenuItem1.Name = "LikeUsOnFacebookToolStripMenuItem1";
			this.LikeUsOnFacebookToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
			this.LikeUsOnFacebookToolStripMenuItem1.Text = "Like us on Facebook";
			//
			//VisitUsOnYoutubeToolStripMenuItem1
			//
			this.VisitUsOnYoutubeToolStripMenuItem1.Image = BrowserLock.Properties.Resources.Youtube_icon;
			this.VisitUsOnYoutubeToolStripMenuItem1.Name = "VisitUsOnYoutubeToolStripMenuItem1";
			this.VisitUsOnYoutubeToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
			this.VisitUsOnYoutubeToolStripMenuItem1.Text = "Visit us on Youtube";
			//
			//UnlockThisProgramToolStripMenuItem
			//
			this.UnlockThisProgramToolStripMenuItem.Name = "UnlockThisProgramToolStripMenuItem";
			this.UnlockThisProgramToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
			this.UnlockThisProgramToolStripMenuItem.Text = "Get Full Version";
			//
			//NotifyIcon1
			//
			this.NotifyIcon1.ContextMenuStrip = this.ContextMenuStrip1;
			this.NotifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon1.Icon");
			this.NotifyIcon1.Visible = true;
			//
			//ContextMenuStrip1
			//
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.EnableBrowserLockToolStripMenuItem, this.DisableBrowserLockToolStripMenuItem, this.ToolStripSeparator1, this.CheckForUpdateToolStripMenuItem1, this.MakeASuggestionToolStripMenuItem1, this.ToolStripSeparator5, this.VisitOurWebsiteToolStripMenuItem, this.LikeUsOnFacebookToolStripMenuItem, this.VisitUsOnYoutubeToolStripMenuItem, this.ToolStripSeparator2, this.ExitProgramToolStripMenuItem});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.Size = new System.Drawing.Size(297, 198);
			//
			//EnableBrowserLockToolStripMenuItem
			//
			this.EnableBrowserLockToolStripMenuItem.Name = "EnableBrowserLockToolStripMenuItem";
			this.EnableBrowserLockToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
			this.EnableBrowserLockToolStripMenuItem.Text = "Disable Internet access";
			//
			//DisableBrowserLockToolStripMenuItem
			//
			this.DisableBrowserLockToolStripMenuItem.Name = "DisableBrowserLockToolStripMenuItem";
			this.DisableBrowserLockToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
			this.DisableBrowserLockToolStripMenuItem.Text = "Allow Internet access (Password Required)";
			//
			//ToolStripSeparator1
			//
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new System.Drawing.Size(293, 6);
			//
			//CheckForUpdateToolStripMenuItem1
			//
			this.CheckForUpdateToolStripMenuItem1.Image = BrowserLock.Properties.Resources.check;
			this.CheckForUpdateToolStripMenuItem1.Name = "CheckForUpdateToolStripMenuItem1";
			this.CheckForUpdateToolStripMenuItem1.Size = new System.Drawing.Size(296, 22);
			this.CheckForUpdateToolStripMenuItem1.Text = "Check for update";
			//
			//MakeASuggestionToolStripMenuItem1
			//
			this.MakeASuggestionToolStripMenuItem1.Image = BrowserLock.Properties.Resources.email_icon_16x16;
			this.MakeASuggestionToolStripMenuItem1.Name = "MakeASuggestionToolStripMenuItem1";
			this.MakeASuggestionToolStripMenuItem1.Size = new System.Drawing.Size(296, 22);
			this.MakeASuggestionToolStripMenuItem1.Text = "Make a suggestion";
			//
			//ToolStripSeparator5
			//
			this.ToolStripSeparator5.Name = "ToolStripSeparator5";
			this.ToolStripSeparator5.Size = new System.Drawing.Size(293, 6);
			//
			//VisitOurWebsiteToolStripMenuItem
			//
			this.VisitOurWebsiteToolStripMenuItem.Image = BrowserLock.Properties.Resources.TPD_Starburst_16x16;
			this.VisitOurWebsiteToolStripMenuItem.Name = "VisitOurWebsiteToolStripMenuItem";
			this.VisitOurWebsiteToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
			this.VisitOurWebsiteToolStripMenuItem.Text = "Visit our website";
			//
			//LikeUsOnFacebookToolStripMenuItem
			//
			this.LikeUsOnFacebookToolStripMenuItem.Image = BrowserLock.Properties.Resources.Facebook_icon__1_;
			this.LikeUsOnFacebookToolStripMenuItem.Name = "LikeUsOnFacebookToolStripMenuItem";
			this.LikeUsOnFacebookToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
			this.LikeUsOnFacebookToolStripMenuItem.Text = "Like us on Facebook";
			//
			//VisitUsOnYoutubeToolStripMenuItem
			//
			this.VisitUsOnYoutubeToolStripMenuItem.Image = BrowserLock.Properties.Resources.Youtube_icon;
			this.VisitUsOnYoutubeToolStripMenuItem.Name = "VisitUsOnYoutubeToolStripMenuItem";
			this.VisitUsOnYoutubeToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
			this.VisitUsOnYoutubeToolStripMenuItem.Text = "Visit us on Youtube";
			//
			//ToolStripSeparator2
			//
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			this.ToolStripSeparator2.Size = new System.Drawing.Size(293, 6);
			//
			//ExitProgramToolStripMenuItem
			//
			this.ExitProgramToolStripMenuItem.Image = BrowserLock.Properties.Resources.x;
			this.ExitProgramToolStripMenuItem.Name = "ExitProgramToolStripMenuItem";
			this.ExitProgramToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
			this.ExitProgramToolStripMenuItem.Text = "Exit Program";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.rbNoTimeLimit);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.rbHours);
			this.GroupBox1.Controls.Add(this.rbMinutes);
			this.GroupBox1.Controls.Add(this.TrackBar1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.inPassword);
			this.GroupBox1.ForeColor = System.Drawing.Color.Black;
			this.GroupBox1.Location = new System.Drawing.Point(15, 61);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(310, 168);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Allow Internet access for:";
			//
			//rbNoTimeLimit
			//
			this.rbNoTimeLimit.AutoSize = true;
			this.rbNoTimeLimit.Location = new System.Drawing.Point(174, 93);
			this.rbNoTimeLimit.Name = "rbNoTimeLimit";
			this.rbNoTimeLimit.Size = new System.Drawing.Size(89, 17);
			this.rbNoTimeLimit.TabIndex = 3;
			this.rbNoTimeLimit.Text = "No Time Limit";
			this.rbNoTimeLimit.UseVisualStyleBackColor = true;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(54, 58);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(203, 19);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "30";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//rbHours
			//
			this.rbHours.AutoSize = true;
			this.rbHours.Location = new System.Drawing.Point(110, 93);
			this.rbHours.Name = "rbHours";
			this.rbHours.Size = new System.Drawing.Size(53, 17);
			this.rbHours.TabIndex = 2;
			this.rbHours.Text = "Hours";
			this.rbHours.UseVisualStyleBackColor = true;
			//
			//rbMinutes
			//
			this.rbMinutes.AutoSize = true;
			this.rbMinutes.Checked = true;
			this.rbMinutes.Location = new System.Drawing.Point(35, 93);
			this.rbMinutes.Name = "rbMinutes";
			this.rbMinutes.Size = new System.Drawing.Size(62, 17);
			this.rbMinutes.TabIndex = 1;
			this.rbMinutes.TabStop = true;
			this.rbMinutes.Text = "Minutes";
			this.rbMinutes.UseVisualStyleBackColor = true;
			//
			//TrackBar1
			//
			this.TrackBar1.Location = new System.Drawing.Point(8, 20);
			this.TrackBar1.Maximum = 60;
			this.TrackBar1.Name = "TrackBar1";
			this.TrackBar1.Size = new System.Drawing.Size(294, 45);
			this.TrackBar1.SmallChange = 5;
			this.TrackBar1.TabIndex = 0;
			this.TrackBar1.TickFrequency = 5;
			this.TrackBar1.Value = 30;
			//
			//btnExtend
			//
			this.btnExtend.Location = new System.Drawing.Point(15, 235);
			this.btnExtend.Name = "btnExtend";
			this.btnExtend.Size = new System.Drawing.Size(153, 27);
			this.btnExtend.TabIndex = 6;
			this.btnExtend.Text = "Extend Time Period";
			this.btnExtend.UseVisualStyleBackColor = true;
			this.btnExtend.Visible = false;
			//
			//MainForm
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 15.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 274);
			this.Controls.Add(this.MenuStrip1);
			this.Controls.Add(this.btnExtend);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Button1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MainMenuStrip = this.MenuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ContextMenuStrip1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.TrackBar1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form1_FormClosing);
			base.Load += new System.EventHandler(Form1_Load);
			this.Resize += new System.EventHandler(Form1_Resize);
			Timer1.Tick += new System.EventHandler(Timer1_Tick);
			btnExtend.Click += new System.EventHandler(btnExtend_Click);
			Button1.Click += new System.EventHandler(Button1_Click);
			rbNoTimeLimit.CheckedChanged += new System.EventHandler(rbNoTimeLimit_CheckedChanged);
			TrackBar1.Scroll += new System.EventHandler(TrackBar1_Scroll);
			EnableBrowserLockToolStripMenuItem.Click += new System.EventHandler(EnableBrowserLockToolStripMenuItem_Click);
			ExitToolStripMenuItem.Click += new System.EventHandler(ExitToolStripMenuItem_Click);
			AboutThisProgramToolStripMenuItem.Click += new System.EventHandler(AboutThisProgramToolStripMenuItem_Click);
			CheckForUpdateToolStripMenuItem.Click += new System.EventHandler(CheckForUpdateToolStripMenuItem_Click);
			CheckForUpdateToolStripMenuItem1.Click += new System.EventHandler(CheckForUpdateToolStripMenuItem_Click);
			MakeASuggestionToolStripMenuItem.Click += new System.EventHandler(MakeASuggestionToolStripMenuItem_Click);
			MakeASuggestionToolStripMenuItem1.Click += new System.EventHandler(MakeASuggestionToolStripMenuItem_Click);
			UnlockThisProgramToolStripMenuItem.Click += new System.EventHandler(UnlockThisProgramToolStripMenuItem_Click);
			ChangePasswordToolStripMenuItem.Click += new System.EventHandler(ChangePasswordToolStripMenuItem_Click);
			ExitProgramToolStripMenuItem.Click += new System.EventHandler(ExitProgramToolStripMenuItem_Click);
			NotifyIcon1.DoubleClick += new System.EventHandler(NotifyIcon1_DoubleClick);
			DisableBrowserLockToolStripMenuItem.Click += new System.EventHandler(DisableBrowserLockToolStripMenuItem_Click);
			VisitOurWebsiteToolStripMenuItem.Click += new System.EventHandler(VisitOurWebsiteToolStripMenuItem_Click);
			VisitOurWebsiteToolStripMenuItem1.Click += new System.EventHandler(VisitOurWebsiteToolStripMenuItem1_Click);
			VisitUsOnYoutubeToolStripMenuItem.Click += new System.EventHandler(VisitUsOnYoutubeToolStripMenuItem_Click);
			VisitOurWebsiteToolStripMenuItem1.Click += new System.EventHandler(VisitUsOnYoutubeToolStripMenuItem_Click);
			LikeUsOnFacebookToolStripMenuItem.Click += new System.EventHandler(LikeUsOnFacebookToolStripMenuItem_Click);
			LikeUsOnFacebookToolStripMenuItem1.Click += new System.EventHandler(LikeUsOnFacebookToolStripMenuItem_Click);
		}
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox inPassword;
		internal System.Windows.Forms.Label lblStatus;
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AboutThisProgramToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CheckForUpdateToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem MakeASuggestionToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem UnlockThisProgramToolStripMenuItem;
		internal System.Windows.Forms.NotifyIcon NotifyIcon1;
		internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem EnableBrowserLockToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DisableBrowserLockToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripMenuItem CheckForUpdateToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem MakeASuggestionToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		internal System.Windows.Forms.ToolStripMenuItem ExitProgramToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.ToolStripMenuItem VisitOurWebsiteToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
		internal System.Windows.Forms.ToolStripMenuItem VisitOurWebsiteToolStripMenuItem1;
		internal System.Windows.Forms.RadioButton rbNoTimeLimit;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.RadioButton rbHours;
		internal System.Windows.Forms.RadioButton rbMinutes;
		internal System.Windows.Forms.TrackBar TrackBar1;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
		internal System.Windows.Forms.ToolStripMenuItem LikeUsOnFacebookToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem VisitUsOnYoutubeToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem LikeUsOnFacebookToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem VisitUsOnYoutubeToolStripMenuItem1;
		internal System.Windows.Forms.Button btnExtend;

	}

}