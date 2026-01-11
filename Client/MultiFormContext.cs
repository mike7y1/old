// Decompiled with JetBrains decompiler
// Type: InvokedClient.MultiFormContext
// Assembly: Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79DD3210-3359-47C5-932E-9352F2CB8134
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\client.exe

using System.Threading;
using System.Windows.Forms;


namespace InvokedClient
{
	public class MultiFormContext : ApplicationContext
	{
		private int openForms;

		public MultiFormContext(params Form[] forms)
		{
			this.openForms = forms.Length;
			foreach (Form form in forms)
			{
				form.FormClosed += (FormClosedEventHandler)((s, args) =>
				{
					if (Interlocked.Decrement(ref this.openForms) != 0)
						return;
					this.ExitThread();
				});
				form.Show();
			}
		}
	}
}