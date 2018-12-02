//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

[assembly: CLSCompliant(true)]

namespace BrowserLock
{
	namespace My
	{

		internal partial class MyApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
		{

			internal string KeyCode {get; set;}
			internal long NextRunDate {get; set;}

			internal string RegKey
			{
				get
				{
					return "Software\\TPD\\BLP";
				}
			}

			internal string ParentalPassKey
			{
				get
				{
					Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKey, true);
					return TheProDev.Globals.DecryptAES(Convert.ToString(reg.GetValue("PPK")));
				}
			}

			internal string AppInfo
			{
				get
				{
					return string.Format("{0} v{1}.{2}.{3}", My.MyApplication.Application.Info.Title, My.MyApplication.Application.Info.Version.Major, My.MyApplication.Application.Info.Version.Minor, My.MyApplication.Application.Info.Version.Build);
				}
			}

			internal string YoutubeLink
			{
				get
				{
					return "http://www.youtube.com/aptbid2007";
				}
			}

			internal string FacebookLink
			{
				get
				{
					return "http://www.facebook.com/pages/TPD-Browser-Lock/122096044529321";
				}
			}

			internal int ProgramID
			{
				get
				{
					return 26;
				}
			}

			internal string GetSiteLink(string Location)
			{
				return string.Format("http://www.theprodev.com/26/tpd-browser-lock.aspx?ref={0}&Ver={1}{2}{3}", Location, My.MyApplication.Application.Info.Version.Major, My.MyApplication.Application.Info.Version.Minor, My.MyApplication.Application.Info.Version.Build);
			}

			private void MyApplication_Startup(object sender, Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e)
			{
				LoadSettings();
				TheProDev.clsRegistration.ValidateRegistration();
			}

			private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
			{
				if (e.Exception != null)
				{
					e.ExitApplication = false;
					ErrorWindow.DefaultInstance.DataError = e.Exception;
					ErrorWindow.DefaultInstance.ShowDialog();
				}
			}

			private void LoadSettings()
			{

				using (Microsoft.Win32.RegistryKey oreg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true))
				{
					if (oreg.GetValue("Browser Lock") == null)
					{
						oreg.SetValue("Browser Lock", System.Windows.Forms.Application.StartupPath + "\\BrowserLock.exe");
					}
					oreg.Close();
				}

				Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKey, true);

				if (reg == null)
				{
					reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegKey, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
				}

				if (reg.GetValue("PPK") == null)
				{
					using (Password frm = new Password())
					{
						frm.ShowDialog();
					}
				}

				if (reg.GetValue("FTR") == null)
				{
					TheProDev.Globals.SetInitValue();
				}

				// Key Code
				if (reg.GetValue("KeyCode") == null)
				{
					reg.SetValue("KeyCode", "");
					KeyCode = "";
				}
				else
				{
					KeyCode = reg.GetValue("KeyCode").ToString();
				}

				TheProDev.Globals.IsTrialExpired();
			}


			private static MyApplication MyApp;
			internal static MyApplication Application
			{
				get
				{
					return MyApp;
				}
			}

			[STAThread]
			static void Main(string[] args)
			{
				System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
				MyApp = new MyApplication();
				MyApp.Run(args);
			}


//INSTANT C# NOTE: Converted event handler wireups:
			private bool EventsSubscribed = false;
			private void SubscribeToEvents()
			{
				if (EventsSubscribed)
					return;
				else
					EventsSubscribed = true;

				this.Startup += MyApplication_Startup;
				this.UnhandledException += MyApplication_UnhandledException;
			}

		}

	}
}