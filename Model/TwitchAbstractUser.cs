using System.Collections.Generic;

namespace TwitchSharp {

	public abstract class TwitchAbstractUser : ITwitchEntity {

		/* Model Fields */

		/* Meta Fields */
		public string UserName { get; set; }
		public string DisplayName { get; set; }
		public string Logo { get; set; }
		public string Bio { get; set; }
		public string ID { get; set; }

		/* Operations */
		public abstract List<TwitchAbstractStream> StreamsFollowed();
		public abstract List<TwitchAbstractVideo> VideosFollowed();

	}
}

