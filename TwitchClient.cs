using RestSharp;
using System.Configuration;

namespace TwitchSharp {

	public class TwitchClient : RestClient {

		private static readonly string apiUrl = "https://api.twitch.tv/kraken";
		private static readonly string apiAcceptHeader = "application/vnd.twitchtv.v3+json";

		public TwitchClient() : base(apiUrl) {
		}

		private RestRequest TwitchGetRequest(string requestUrl) {
			RestRequest request = new RestRequest(requestUrl,Method.GET);
			request.AddHeader("Accept",apiAcceptHeader);
			return request;
		}

		public TwitchChannel ChannelByName(string channelName) {
			RestRequest request = TwitchGetRequest(string.Format("channels/{0}",channelName));
			RestResponse<TwitchChannel> response = (RestResponse<TwitchChannel>)
				Execute<TwitchChannel>(request);
			return response.Data;
		}

	}
}

