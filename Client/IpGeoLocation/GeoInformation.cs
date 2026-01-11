// Decompiled with JetBrains decompiler
// Type: InvokedClient.IpGeoLocation.GeoInformation
// Assembly: Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 79DD3210-3359-47C5-932E-9352F2CB8134
// Assembly location: C:\Users\ian\Downloads\Telegram Desktop\fein\client.exe


namespace InvokedClient.IpGeoLocation
{
	public class GeoInformation
	{
		public string IpAddress { get; set; }

		public string Country { get; set; }

		public string CountryCode { get; set; }

		public string Timezone { get; set; }

		public string Asn { get; set; }

		public string Isp { get; set; }

		public int ImageIndex { get; set; }
	}
}