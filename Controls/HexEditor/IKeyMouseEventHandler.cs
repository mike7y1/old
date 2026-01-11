// Decompiled with JetBrains decompiler
// Type: InvokedServer.Controls.HexEditor.IKeyMouseEventHandler
// Assembly: HQ, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C53BC0E5-A85B-41E9-8105-FC74ED122A9A
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\HQ.exe

using System;
using System.Windows.Forms;


namespace InvokedServer.Controls.HexEditor
{
	public interface IKeyMouseEventHandler
	{
		void OnKeyPress(KeyPressEventArgs e);

		void OnKeyDown(KeyEventArgs e);

		void OnKeyUp(KeyEventArgs e);

		void OnMouseDown(MouseEventArgs e);

		void OnMouseDragged(MouseEventArgs e);

		void OnMouseUp(MouseEventArgs e);

		void OnMouseDoubleClick(MouseEventArgs e);

		void OnGotFocus(EventArgs e);
	}
}