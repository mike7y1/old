// Decompiled with JetBrains decompiler
// Type: InvokedClient.Utilities.SingleInstanceMutex
// Assembly: Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79DD3210-3359-47C5-932E-9352F2CB8134
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\client.exe

using System;
using System.Threading;


namespace InvokedClient.Utilities
{
	public class SingleInstanceMutex : IDisposable
	{
		private readonly Mutex _appMutex;

		public bool CreatedNew { get; }

		public bool IsDisposed { get; private set; }

		public SingleInstanceMutex(string name)
		{
			bool createdNew;
			this._appMutex = new Mutex(false, "Local\\" + name, out createdNew);
			this.CreatedNew = createdNew;
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize((object)this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (this.IsDisposed)
				return;
			if (disposing)
				this._appMutex?.Dispose();
			this.IsDisposed = true;
		}
	}
}