//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

namespace BrowserLock
{
	namespace TheProDev
	{
		internal static class Globals
		{

			private static bool _TrialExpired;

			internal static bool TrialExpired
			{
				get
				{
					return _TrialExpired;
				}
			}

			private static byte[] KEY_192 = {24, 164, 79, 111, 40, 143, 111, 133, 202, 40, 89, 211, 156, 126, 135, 16};
			private static byte[] IV_192 = {166, 129, 143, 139, 114, 198, 3, 20, 108, 193, 190, 143, 14, 20, 190, 86};

			internal static void SetInitValue()
			{
				using (Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(My.MyApplication.Application.RegKey, true))
				{
					reg.SetValue("FTR", EncryptAES(DateTime.Now.ToFileTime().ToString()));
				}
			}

			internal static void IsTrialExpired()
			{
				Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(My.MyApplication.Application.RegKey, true);
				DateTime installdate = DateTime.FromFileTime(long.Parse(DecryptAES(reg.GetValue("FTR").ToString())));
				DateTime ExpireDate = installdate.AddDays(7);

				// Todays date is greater than the expire date.
				if (DateTime.Now >= ExpireDate)
				{
					_TrialExpired = true;
				}
			}


			/// <summary>
			/// Provides Standard 192 bit (AES) Encryption with a ramdomly selected key, and Initialization Vector
			/// </summary>
			/// <param name="Value">The value you want to Encrypt</param>
			/// <returns></returns>
			/// <remarks></remarks>
			internal static string EncryptAES(string Value)
			{
				string str = "";
				if (Value.Length > 0)
				{

					RijndaelManaged AES = new RijndaelManaged();
					MemoryStream ms = new MemoryStream();
					CryptoStream cs = new CryptoStream(ms, AES.CreateEncryptor(KEY_192, IV_192), CryptoStreamMode.Write);
					StreamWriter sw = new StreamWriter(cs);

					sw.Write(Value);
					sw.Flush();
					cs.FlushFinalBlock();
					ms.Flush();

					str = Convert.ToBase64String(ms.GetBuffer(), 0, Convert.ToInt32(ms.Length));
				}
				return str;
			}

			/// <summary>
			/// Provides Standard 192 bit (AES) Decryption with a ramdomly selected key, and Initialization Vector
			/// </summary>
			/// <param name="Value">The value you want to Decrypt</param>
			/// <returns></returns>
			/// <remarks></remarks>
			internal static string DecryptAES(string Value)
			{
				string str = "";
				if (Value.Length > 0)
				{

					RijndaelManaged AES = new RijndaelManaged();
					byte[] buffer = Convert.FromBase64String(Value);
					MemoryStream ms = new MemoryStream(buffer);
					CryptoStream cs = new CryptoStream(ms, AES.CreateDecryptor(KEY_192, IV_192), CryptoStreamMode.Read);
					StreamReader sr = new StreamReader(cs);
					str = sr.ReadToEnd();
					sr.Close();
				}
				return str;
			}

		}
	}

}