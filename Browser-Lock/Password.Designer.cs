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
	internal partial class Password : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
			this.Label1 = new System.Windows.Forms.Label();
			this.inPassword = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.inRePassword = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(57, 55);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(64, 15);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Password:";
			//
			//inPassword
			//
			this.inPassword.Location = new System.Drawing.Point(129, 52);
			this.inPassword.Name = "inPassword";
			this.inPassword.PasswordChar = (char)42;
			this.inPassword.Size = new System.Drawing.Size(291, 21);
			this.inPassword.TabIndex = 0;
			//
			//Button1
			//
			this.Button1.Image = BrowserLock.Properties.Resources.save;
			this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button1.Location = new System.Drawing.Point(275, 112);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(146, 27);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Save Password";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(14, 85);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(105, 15);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Retype Password:";
			//
			//inRePassword
			//
			this.inRePassword.Location = new System.Drawing.Point(129, 82);
			this.inRePassword.Name = "inRePassword";
			this.inRePassword.PasswordChar = (char)42;
			this.inRePassword.Size = new System.Drawing.Size(291, 21);
			this.inRePassword.TabIndex = 1;
			//
			//Label3
			//
			this.Label3.Location = new System.Drawing.Point(14, 10);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(409, 38);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Please provide a master Browser Lock password. This password will be needed to ac" +
		"cess the Internet as well as close Browser Lock.";
			//
			//Password
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 15.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 152);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.inRePassword);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.inPassword);
			this.Controls.Add(this.Label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "Password";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			Button1.Click += new System.EventHandler(Button1_Click);
			base.Load += new System.EventHandler(frmPassword_Load);
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox inPassword;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox inRePassword;
		internal System.Windows.Forms.Label Label3;
	}

}