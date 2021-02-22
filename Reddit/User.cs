using RestSharp;
using kkx.Reddit.Types.Responses;
using System.Threading.Tasks;

namespace kkx.Reddit {
	public partial class RedditApi {
		public async Task<Listing<Post>> GetUserPosts(string username) {
			return await ExecuteAsync<Listing<Post>>(new RestRequest($"user/{username}"));
		}
		public async Task<UserAbout> GetUserAbout(string username) {
			return await ExecuteAsync<UserAbout>(new RestRequest($"user/{username}/about"));
		}
	}
}
