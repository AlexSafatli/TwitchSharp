using System;
using TwitchSharp;

namespace Tests {
	class MainClass {
		public static void Main (string[] args) {

			TwitchClient cl = new TwitchClient();
			TwitchChannel ch = cl.ChannelByName("amazhs");

		}
	}
}