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
		public abstract List<TwitchAbstractUser> UsersBlocked(TwitchClient cl);
		public abstract void AddUserToBlocks(TwitchClient cl, TwitchAbstractUser user);
		public abstract void DeleteUserFromBlocks(TwitchClient cl, TwitchAbstractUser user);
		public abstract List<TwitchAbstractStream> StreamsFollowed(TwitchClient cl);
		public abstract List<TwitchAbstractVideo> VideosFollowed(TwitchClient cl);

	}
}

