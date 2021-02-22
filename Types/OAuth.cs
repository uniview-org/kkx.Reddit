using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kkx.Reddit.Types.Responses {
	public class AccessTokenResponse {
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }
		[JsonProperty("refresh_token")]
		public string RefreshToken { get; set; }
		[JsonProperty("token_type")]
		public string TokenType { get; set; }
		[JsonProperty("device_id")]
		public string DeviceId { get; set; }
		[JsonProperty("expires_in")]
		public int ExpiresIn { get; set; }
		[JsonProperty("scope")]
		public string Scope { get; set; }
	}
}
