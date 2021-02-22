using RestSharp;
using kkx.Reddit.Types.Responses;
using System.Threading.Tasks;
using RestSharp.Authenticators;

namespace kkx.Reddit {
	public partial class RedditApi {
		// TODO: Refresh with client secret and refresh token
		public async Task<AccessTokenResponse> RefreshAccessToken() {
			var refreshClient = new RestClient();
			refreshClient.Authenticator = new HttpBasicAuthenticator(ClientId, ClientSecret);

			var refreshRequest = new RestRequest("https://www.reddit.com/api/v1/access_token", Method.POST);
			refreshRequest.AddParameter("grant_type", "https://oauth.reddit.com/grants/installed_client", ParameterType.GetOrPost);
			refreshRequest.AddParameter("device_id", DeviceId, ParameterType.GetOrPost);
			refreshRequest.AddHeader("User-Agent", UserAgent);

			var response = await refreshClient.ExecuteAsync<AccessTokenResponse>(refreshRequest);
			return response.Data;
		}
	}
}
