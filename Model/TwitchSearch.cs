using System.Collections.Generic;

namespace TwitchSharp {
	public class TwitchSearch {

		/* Model Fields */
		public List<TwitchGame> Games { get; set; }
		public List<TwitchStream> Streams { get; set; }
		public List<TwitchChannel> Channels { get; set; }

		/* Meta Fields */
		public int Total { get; set; }
		public List<string> Links { get; set; }

		/* Operations */

	}
}