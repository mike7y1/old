// Decompiled with JetBrains decompiler
// Type: InvokedServer.DataStructs.StealerLog
// Assembly: HQ, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C53BC0E5-A85B-41E9-8105-FC74ED122A9A
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\HQ.exe

using InvokedCommon.Structs;


namespace InvokedServer.DataStructs
{
	public class StealerLog
	{
		public ChromiumBrowser[] chromiumData { get; set; }

		public GeckoBrowser[] geckoData { get; set; }

		public AppsData appsData { get; set; }
	}
}