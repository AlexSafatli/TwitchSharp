using NUnit.Framework;
using System.Collections.Generic;
using TwitchSharp;
using System;

namespace Tests {

	[TestFixture ()]
	public class Test {

		public TwitchClient client { get; private set; }

		public Test() {
			client = new TwitchClient();
		}

		[Test()]
		public void Test_ChannelByName() {
			TwitchChannel ch = client.ChannelByName("amazhs");
			Assert.NotNull(ch);
			Assert.NotNull(ch.Name);
			Assert.NotNull(ch.GameName);
		}

		[Test()]
		public void Test_ChannelSearch() {
			List<TwitchChannel> ch = client.SearchForChannels("amaz");
			Assert.NotNull(ch);
			Console.Error.WriteLine(ch);
		}

	}
}
