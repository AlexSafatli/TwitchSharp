using System;
using RestSharp.Deserializers;

namespace TwitchSharp {

	public abstract class TwitchAbstractStream {

		/* Model Fields */
		public TwitchAbstractUser Broadcaster { get; set; }
		public TwitchAbstractChannel Channel { get; set; }

		/* Meta Fields */
		[DeserializeAs(Name = "game")]
		public string GameName { get; set; }
		public int Viewers { get; set; }

		/* Operations */

	}

}

