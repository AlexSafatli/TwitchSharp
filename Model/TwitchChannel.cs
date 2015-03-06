namespace TwitchSharp {
	public class TwitchChannel : TwitchAbstractChannel {

		public override void refresh (TwitchClient client)
		{
			throw new System.NotImplementedException ();
		}

		public override bool updateStatus (TwitchClient client, string status)
		{
			throw new System.NotImplementedException ();
		}

		public override bool updateGame (TwitchClient client, TwitchGame game)
		{
			throw new System.NotImplementedException ();
		}

		public override bool updateDelay (TwitchClient client, int delay)
		{
			throw new System.NotImplementedException ();
		}

	}
}
