using System.Net;
using System.Threading.Tasks;
using kkx.Reddit.Types.Responses;
using RestSharp;
using RestSharp.Authenticators;

namespace kkx.Reddit {
	public partial class RedditApi {
		const string BASE_URL = "https://oauth.reddit.com";

		public string Token { get; set; }
		public string RefreshToken { get; set; }
		public string ClientId { get; set; }
		public string ClientSecret { get; set; }
		public string UserAgent { get; set; } = "kkx.Reddit";

		readonly IRestClient _client;
		public RedditApi() {
			_client = new RestClient(BASE_URL);
		}

		public async Task<T> ExecuteAsync<T>(RestRequest request) where T : new() {
			// Request application only oauth token
			if (string.IsNullOrWhiteSpace(Token) && !string.IsNullOrWhiteSpace(ClientId)) {
				Token = (await RefreshAccessToken()).AccessToken;
			}

			request.AddHeader("User-Agent", UserAgent);
			request.AddHeader("Authorization", $"bearer {Token}");

			var response = await _client.ExecuteAsync<T>(request);

			switch (response.StatusCode) {
				case HttpStatusCode.OK:
					return response.Data;
				case HttpStatusCode.Unauthorized:
					var refreshResponse = await RefreshAccessToken();
					Token = refreshResponse.AccessToken;
					return await ExecuteAsync<T>(request);
				default:
					throw response.ErrorException;
			}
		}
	}
}
