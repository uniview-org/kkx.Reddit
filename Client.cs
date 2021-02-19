using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace kkx.Reddit {
	public class RedditClient {
		const string BASE_URL = "https://oauth.reddit.com/";

		readonly IRestClient _client;
		public string Token { get; set; }
		public string RefreshToken { get; set; }
		public string ClientId { get; set; }
		public string ClientSecret { get; set; }
		public string UserAgent { get; set; }

		public RedditClient(string token, string refreshToken, string clientId, string clientSecret = "", string userAgent = "kkx.Reddit") {
			_client = new RestClient(BASE_URL);
			Token = token;
			RefreshToken = refreshToken;
			ClientId = clientId;
			ClientSecret = clientSecret;
			UserAgent = userAgent;
		}

		public async Task<T> ExecuteAsync<T>(RestRequest request) where T : new() {
			request.AddHeader("Authorization", "bearer " + Token);
			var response = await _client.ExecuteAsync<T>(request);
			// TODO: Error handling, refresh token if expired
			/* switch (response.StatusCode) {
				case HttpStatusCode.OK:
					break;
				case HttpStatusCode.Unauthorized:
					// await refreshAccessToken(request);
					break;
				default:
					throw response.ErrorException;
			} */
			return response.Data;
		}

		// TODO:
		private async Task<RestRequest> refreshAccessToken(RestRequest request) {
			var refreshClient = new RestClient();
			refreshClient.Authenticator = new HttpBasicAuthenticator(ClientId, ClientSecret);
			var refreshRequest = new RestRequest();

			refreshRequest.AddHeader("Authorization", "Basic ");
			refreshRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");

			await refreshClient.ExecuteAsync(refreshRequest);
			return request;
		}
	}
}
