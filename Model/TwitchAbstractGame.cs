using System.Collections.Generic;

namespace TwitchSharp {
	public abstract class TwitchAbstractGame : ITwitchEntity {

		/* Model Fields */

		/* Meta Fields */
		public string Name { get; set; }
		public List<string> Box { get; set; }
		public List<string> Logo { get; set; }
		public string ID { get; set; }

		/* Operations */

	}
}