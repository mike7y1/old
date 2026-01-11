// Decompiled with JetBrains decompiler
// Type: InvokedClient.IpGeoLocation.Time
// Assembly: Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79DD3210-3359-47C5-932E-9352F2CB8134
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\client.exe

using System.Runtime.Serialization;


namespace InvokedClient.IpGeoLocation
{
	[DataContract]
	public class Time
	{
		[DataMember(Name = "utc")]
		public string UTC { get; set; }
	}
}