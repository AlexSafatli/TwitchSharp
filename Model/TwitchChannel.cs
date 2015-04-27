namespace TwitchSharp {
	public class TwitchChannel : TwitchAbstractChannel {

		public override bool updateStatus(TwitchClient client, string status) {
			if (client.Authenticated) {
				var r = client.MakePutRequest("channels/" + DisplayName, new { channel = new { Status = status } });
				client.Execute(r);
				return true;
			}
			return false;
		}

		public override bool updateGame(TwitchClient client, TwitchGame game) {
			if (client.Authenticated) {
				var r = client.MakePutRequest("channels/" + DisplayName, new { channel = new { Game = game } });
				client.Execute(r);
				return true;
			}
			return false;			
		}

		public override bool updateDelay(TwitchClient client, int delay) {
			if (client.Authenticated) {
				var r = client.MakePutRequest("channels/" + DisplayName, new { channel = new { Delay = delay } });
				client.Execute(r);
				return true;
			}
			return false;
		}
		public override bool startCommercial(TwitchClient client, int length) {
			if (client.Authenticated) {
				var r = client.MakePostRequest("channels/" + DisplayName + "/commercial", new { Length = length });
				client.Execute(r);
				return true;
			}
			return false;
		}

	}
}