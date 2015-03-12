using System.Collections.Generic;

namespace TwitchSharp {

	public struct TwitchEmoticonImage {
		public int emoticon_set;
		public int height;
		public int width;
		public string url;
	}

	public class TwitchEmoticon : ITwitchEntity {

		/* Model Fields */
		/* Meta Fields */
		public string ID { get; set; }
		public string Regex { get; set; }
		public List<TwitchEmoticonImage> Images { get; set; }

		/* Operations */

	}

}
