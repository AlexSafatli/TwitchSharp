using RestSharp;
using System.Collections.Generic;

namespace TwitchSharp {

	public class TwitchClient : RestClient, ITwitchClient {
	
		private static readonly string apiUrl = "https://api.twitch.tv/kraken";
		private static readonly string apiAcceptHeader = "application/vnd.twitchtv.v3+json";

		public TwitchClient() : base(apiUrl) { }

		/* Boilerplate Request Code */
		private RestRequest TwitchGetRequest(string requestUrl) {
			RestRequest request = new RestRequest(requestUrl,Method.GET);
			request.AddHeader("Accept",apiAcceptHeader);
			return request;
		}

		/* Searching */
		public List<TwitchChannel> SearchForChannels(string searchQuery) {
			RestRequest request = TwitchGetRequest(string.Format("search/channels?q={0}",searchQuery));
			var search = ((RestResponse<TwitchSearch>)Execute<TwitchSearch>(request)).Data;
			return search.Channels;
		}
		public List<TwitchStream> SearchForStreams(string searchQuery) {
			RestRequest request = TwitchGetRequest(string.Format("search/streams?q={0}",searchQuery));
			var search = ((RestResponse<TwitchSearch>)Execute<TwitchSearch>(request)).Data;
			return search.Streams;
		}
		public List<TwitchGame> SearchForGames(string searchQuery) {
			RestRequest request = TwitchGetRequest(string.Format("search/games?q={0}&type=suggest",searchQuery));
			var search = ((RestResponse<TwitchSearch>)Execute<TwitchSearch>(request)).Data;
			return search.Games;
		}

		/* Objects By Name */
		public TwitchChannel ChannelByName(string channelName) {
			RestRequest request = TwitchGetRequest(string.Format("channels/{0}",channelName));
			var response = (RestResponse<TwitchChannel>)Execute<TwitchChannel>(request);
			var ch = response.Data;
			if (ch != null) {
				RestRequest streamRequest = TwitchGetRequest(string.Format("streams/{0}",channelName));
				var stream = (RestResponse<TwitchChannelStream>)Execute<TwitchChannelStream>(streamRequest);
				if (stream != null) {
					ch.Stream = stream.Data.Stream;
				}
			}
			return ch;
		}
		public TwitchUser UserByName(string userName) {
			RestRequest request = TwitchGetRequest(string.Format("users/{0}",userName));
			var response = (RestResponse<TwitchUser>)Execute<TwitchUser>(request);
			return response.Data;
		}
		public List<TwitchGame> TopGames() {
			RestRequest request = TwitchGetRequest("games/top");
			var response = (RestResponse<List<TwitchGame>>)Execute<List<TwitchGame>>(request);
			return response.Data;
		}

	}
}

