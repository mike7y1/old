// Decompiled with JetBrains decompiler
// Type: InvokedClient.Helper.DateTimeHelper
// Assembly: Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79DD3210-3359-47C5-932E-9352F2CB8134
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\client.exe

using System;


namespace InvokedClient.Helper
{
	public static class DateTimeHelper
	{
		public static string GetLocalTimeZone()
		{
			TimeZoneInfo local = TimeZoneInfo.Local;
			TimeSpan utcOffset = local.GetUtcOffset(DateTime.Now);
			string str = utcOffset >= TimeSpan.Zero ? "+" : "";
			return string.Format("{0} (UTC {1}{2}{3})", (object)(!local.SupportsDaylightSavingTime || !local.IsDaylightSavingTime(DateTime.Now) ? local.StandardName : local.DaylightName), (object)str, (object)utcOffset.Hours, utcOffset.Minutes != 0 ? (object)string.Format(":{0}", (object)Math.Abs(utcOffset.Minutes)) : (object)"");
		}
	}
}