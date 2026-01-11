// Decompiled with JetBrains decompiler
// Type: InvokedServer.Controls.AeroListView
// Assembly: HQ, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C53BC0E5-A85B-41E9-8105-FC74ED122A9A
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\HQ.exe

using InvokedCommon.Helpers;
using InvokedServer.Helper;
using InvokedServer.Utilities;
using System;
using System.Collections;
using System.Windows.Forms;


namespace InvokedServer.Controls
{
	internal class AeroListView : ListView
	{
		private const uint WM_CHANGEUISTATE = 295;
		private const short UIS_SET = 1;
		private const short UISF_HIDEFOCUS = 1;
		private readonly IntPtr _removeDots = new IntPtr(NativeMethodsHelper.MakeWin32Long((short)1, (short)1));

		public ListViewColumnSorter LvwColumnSorter { get; set; }

		public AeroListView()
		{
			this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.LvwColumnSorter = new ListViewColumnSorter();
			this.ListViewItemSorter = (IComparer)this.LvwColumnSorter;
			this.View = View.Details;
			this.FullRowSelect = true;
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			if (PlatformHelper.RunningOnMono)
				return;
			if (PlatformHelper.VistaOrHigher)
				NativeMethods.SetWindowTheme(this.Handle, "explorer", null);
			if (!PlatformHelper.XpOrHigher)
				return;
			NativeMethods.SendMessage(this.Handle, 295U, this._removeDots, IntPtr.Zero);
		}

		protected override void OnColumnClick(ColumnClickEventArgs e)
		{
			base.OnColumnClick(e);
			if (e.Column == this.LvwColumnSorter.SortColumn)
			{
				this.LvwColumnSorter.Order = this.LvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
			}
			else
			{
				this.LvwColumnSorter.SortColumn = e.Column;
				this.LvwColumnSorter.Order = SortOrder.Ascending;
			}
			if (this.VirtualMode)
				return;
			this.Sort();
		}
	}
}