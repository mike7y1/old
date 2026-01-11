// Decompiled with JetBrains decompiler
// Type: InvokedClient.Setup.ClientSetupBase
// Assembly: Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79DD3210-3359-47C5-932E-9352F2CB8134
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\client.exe

using InvokedClient.User;


namespace InvokedClient.Setup
{
	public abstract class ClientSetupBase
	{
		protected UserAccount UserAccount;

		protected ClientSetupBase() => this.UserAccount = new UserAccount();
	}
}