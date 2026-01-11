// Decompiled with JetBrains decompiler
// Type: InvokedClient.Extensions.ProcessExtensions
// Assembly: Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79DD3210-3359-47C5-932E-9352F2CB8134
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\client.exe

using InvokedClient.Utilities;
using System.Diagnostics;
using System.Text;


namespace InvokedClient.Extensions
{
	public static class ProcessExtensions
	{
		public static string GetMainModuleFileName(this Process proc)
		{
			uint lpdwSize = 260;
			StringBuilder lpExeName = new StringBuilder((int)lpdwSize);
			return !NativeMethods.QueryFullProcessImageName(proc.Handle, 0U, lpExeName, ref lpdwSize) ? (string)null : lpExeName.ToString();
		}
	}
}