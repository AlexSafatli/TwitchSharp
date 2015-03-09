using System.Collections.Generic;
using RestSharp.Deserializers;

namespace TwitchSharp {
	public abstract class TwitchAbstractChannel : ITwitchEntity {
	
		/* Model Fields */
		public TwitchAbstractStream Stream { get; set;}
		public List<TwitchAbstractUser> Editors { get; set; }
		public List<TwitchAbstractVideo> Videos { get; set; }
		public List<TwitchAbstractUser> Follows { get; set; }
		public List<TwitchAbstractTeam> Teams { get; set; }
		public TwitchAbstractGame GameObject { get; set; }

		/* Meta Fields */
		[DeserializeAs(Name = "game")]
		public string GameName { get; set; }
		public string Mature { get; set; }
		public string Status { get; set; }
		public string BroadcasterLanguage { get; set; }
		public string Language { get; set; }
		public string DisplayName { get; set; }
		public string Name { get; set; }
		public string Logo { get; set; }
		public string Banner { get; set; }
		public string VideoBanner { get; set; }
		public string Background { get; set; }
		public string ProfileBanner { get; set; }
		public bool Partner { get; set; }
		public string URL { get; set; }
		public int Views { get; set; }
		public int Followers { get; set; }
		public float Delay { get; set; }
		public string ID { get; set; }

		/* Operations */
		public bool Equals(TwitchAbstractChannel obj) {
			return (URL.Equals(obj.URL) && Name.Equals(obj.Name));
		}
		public abstract bool updateStatus(TwitchClient client, string status);
		public abstract bool updateGame(TwitchClient client, TwitchGame game);
		public abstract bool updateDelay(TwitchClient client, int delay);

	}
}

