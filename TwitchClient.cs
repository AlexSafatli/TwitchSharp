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
			return ((RestResponse<List<TwitchChannel>>)Execute<List<TwitchChannel>>(request)).Data;
		}
		public List<TwitchStream> SearchForStreams(string searchQuery) {
			RestRequest request = TwitchGetRequest(string.Format("search/streams?q={0}",searchQuery));
			return ((RestResponse<List<TwitchStream>>)Execute<List<TwitchStream>>(request)).Data;
		}
		public List<TwitchGame> SearchForGames(string searchQuery) {
			RestRequest request = TwitchGetRequest(string.Format("search/games?q={0}",searchQuery));
			return ((RestResponse<List<TwitchGame>>)Execute<List<TwitchGame>>(request)).Data;
		}

		/* Objects By Name */
		public TwitchChannel ChannelByName(string channelName) {
			RestRequest request = TwitchGetRequest(string.Format("channels/{0}",channelName));
			RestResponse<TwitchChannel> response = (RestResponse<TwitchChannel>)
				Execute<TwitchChannel>(request);
			return response.Data;
		}


	}
}

