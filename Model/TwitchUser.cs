using System;

namespace TwitchSharp
{
	public class TwitchUser : TwitchAbstractUser
	{

		public override System.Collections.Generic.List<TwitchAbstractUser> UsersBlocked (TwitchClient cl)
		{
			throw new NotImplementedException ();
		}

		public override void AddUserToBlocks (TwitchClient cl, TwitchAbstractUser user)
		{
			throw new NotImplementedException ();
		}

		public override void DeleteUserFromBlocks (TwitchClient cl, TwitchAbstractUser user)
		{
			throw new NotImplementedException ();
		}

		public override System.Collections.Generic.List<TwitchAbstractStream> StreamsFollowed (TwitchClient cl)
		{
			throw new NotImplementedException ();
		}

		public override System.Collections.Generic.List<TwitchAbstractVideo> VideosFollowed (TwitchClient cl)
		{
			throw new NotImplementedException ();
		}

	}
}

