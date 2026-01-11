// Decompiled with JetBrains decompiler
// Type: InvokedServer.Controls.RegistryTreeView
// Assembly: HQ, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C53BC0E5-A85B-41E9-8105-FC74ED122A9A
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\HQ.exe

using System.Windows.Forms;


namespace InvokedServer.Controls
{
	public class RegistryTreeView : TreeView
	{
		public RegistryTreeView()
		{
			this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}
	}
}