using System.Collections.Generic;
using RestSharp.Deserializers;

namespace TwitchSharp {

	public abstract class TwitchAbstractVideo : ITwitchEntity {

		/* Model Fields */
		public TwitchAbstractChannel Channel { get; set; }

		/* Meta Fields */
		public string Title { get; set; }
		public string Description { get; set; }
		public int BroadcastID { get; set; }
		public string ID { get; set; }
		public List<string> TagList { get; set; }
		public int Length { get; set; }
		public string Preview { get; set; }
		public string URL { get; set; }
		public int Views { get; set; }
		public string BroadcastType { get; set; }

		/* Operations */

	}

}


