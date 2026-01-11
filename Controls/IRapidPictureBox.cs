// Decompiled with JetBrains decompiler
// Type: InvokedServer.Controls.IRapidPictureBox
// Assembly: HQ, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C53BC0E5-A85B-41E9-8105-FC74ED122A9A
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\HQ.exe

using System.Drawing;


namespace InvokedServer.Controls
{
	public interface IRapidPictureBox
	{
		bool Running { get; set; }

		Image GetImageSafe { get; set; }

		void Start();

		void Stop();

		void UpdateImage(Bitmap bmp, bool cloneBitmap = false);
	}
}
