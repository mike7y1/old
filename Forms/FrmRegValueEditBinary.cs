// Decompiled with JetBrains decompiler
// Type: InvokedServer.Forms.FrmRegValueEditBinary
// Assembly: HQ, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C53BC0E5-A85B-41E9-8105-FC74ED122A9A
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\HQ.exe

using System;
using System.Windows.Forms;
using InvokedCommon.Models;
using InvokedServer.Registry;


namespace InvokedServer.Forms
{
	public partial class FrmRegValueEditBinary : Form
	{
		private readonly RegValueData _value;
		private const string INVALID_BINARY_ERROR = "The binary value was invalid and could not be converted correctly.";

		public FrmRegValueEditBinary(RegValueData value)
		{
			this._value = value;
			this.InitializeComponent();
			this.valueNameTxtBox.Text = RegValueHelper.GetName(value.Name);
			this.hexEditor.HexTable = value.Data;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			byte[] hexTable = this.hexEditor.HexTable;
			if (hexTable != null)
			{
				try
				{
					this._value.Data = hexTable;
					this.DialogResult = DialogResult.OK;
					this.Tag = (object)this._value;
				}
				catch
				{
					this.ShowWarning("The binary value was invalid and could not be converted correctly.", "Warning");
					this.DialogResult = DialogResult.None;
				}
			}
			this.Close();
		}

		private void ShowWarning(string msg, string caption)
		{
			MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}
}