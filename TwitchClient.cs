using RestSharp;
using System.Collections.Generic;

namespace TwitchSharp {

	public class TwitchClient : RestClient, ITwitchClient {
	
		private static readonly string apiUrl = "https://api.twitch.tv/kraken";
		private static readonly string apiAcceptHeader = "application/vnd.twitchtv.v3+json";
		private static readonly string oauthToken;
		public bool Authenticated { get; private set; }

		public TwitchClient() : base(apiUrl) { 
			Authenticated = false; // Not authenticated.
		}

		public TwitchClient(string oauthToken) {
			Authenticate(oauthToken); // Construct and authenticate.
		}
			
		/* Authentication Code */
		public void Authenticate(string token) {
			// TODO Test authentication.
			Authenticated = true; // Toggle as authenticated.
			oauthToken = token;
		}

		/* Boilerplate Request Code */
		private RestRequest MakeRequest(string requestUrl, Method method) {
			var request = new RestRequest(requestUrl,method);
			request.AddHeader("Accept",apiAcceptHeader);
			if (Authenticated) {
				request.AddHeader("Authorization","OAuth " + oauthToken);
			}
			return request;
		}
		public RestRequest MakeGetRequest(string requestUrl) {
			return MakeRequest(requestUrl,Method.GET);
		}
		public RestRequest MakePutRequest(string requestUrl,object jsonObject) {
			var request = MakeRequest(requestUrl,Method.PUT);
			request.AddJsonBody(jsonObject);
			return request;
		}
		public RestRequest MakePostRequest(string requestUrl,object jsonObject) {
			var request = MakeRequest(requestUrl,Method.POST);
			request.AddJsonBody(jsonObject);
			return request;
		}

		/* Searching */
		public List<TwitchChannel> SearchForChannels(string searchQuery) {
			RestRequest request = MakeGetRequest(string.Format("search/channels?q={0}",searchQuery));
			var search = ((RestResponse<TwitchSearch>)Execute<TwitchSearch>(request)).Data;
			return search.Channels;
		}
		public List<TwitchStream> SearchForStreams(string searchQuery) {
			RestRequest request = MakeGetRequest(string.Format("search/streams?q={0}",searchQuery));
			var search = ((RestResponse<TwitchSearch>)Execute<TwitchSearch>(request)).Data;
			return search.Streams;
		}
		public List<TwitchGame> SearchForGames(string searchQuery) {
			RestRequest request = MakeGetRequest(string.Format("search/games?q={0}&type=suggest",searchQuery));
			var search = ((RestResponse<TwitchSearch>)Execute<TwitchSearch>(request)).Data;
			return search.Games;
		}

		/* Objects By Name */
		public TwitchChannel ChannelByName(string channelName) {
			RestRequest request = MakeGetRequest(string.Format("channels/{0}",channelName));
			var response = (RestResponse<TwitchChannel>)Execute<TwitchChannel>(request);
			var ch = response.Data;
			if (ch != null) {
				RestRequest streamRequest = MakeGetRequest(string.Format("streams/{0}",channelName));
				var stream = (RestResponse<TwitchChannelStream>)Execute<TwitchChannelStream>(streamRequest);
				if (stream != null) {
					ch.Stream = stream.Data.Stream;
				}
			}
			return ch;
		}
		public TwitchUser UserByName(string userName) {
			RestRequest request = MakeGetRequest(string.Format("users/{0}",userName));
			var response = (RestResponse<TwitchUser>)Execute<TwitchUser>(request);
			return response.Data;
		}
		public List<TwitchGame> TopGames() {
			RestRequest request = MakeGetRequest("games/top");
			var response = (RestResponse<List<TwitchGame>>)Execute<List<TwitchGame>>(request);
			return response.Data;
		}

	}
}

