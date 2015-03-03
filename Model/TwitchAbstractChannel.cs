using System.Collections.Generic;

namespace TwitchSharp {
	public abstract class TwitchAbstractChannel {
	
		/* Model Fields */
		public TwitchStream Stream { get; }
		public List<TwitchUser> Editors { get; }
		public List<TwitchVideo> Videos { get; }
		public List<TwitchUser> Followers { get; }
		public List<TwitchTeam> Teams { get; }
		public TwitchGame Game { get; }

		/* Meta Fields */
		public string Mature { get; }
		public string Status { get; }
		public string Language { get; }
		public string DisplayName { get; }
		public string Logo { get; }
		public string Banner { get; }
		public string ProfileBanner { get; }
		public bool Partner { get; }
		public string URL { get; }
		public int Views { get; }
		public int Follows { get; }
		public float Delay { get; }

		/* Operations */
		public abstract void refresh();
		public abstract bool updateStatus(string status);
		public abstract bool updateGame(TwitchGame game);
		public abstract bool updateDelay(int delay);

	}
}

