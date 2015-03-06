using NUnit.Framework;
using System;
using TwitchSharp;

namespace Tests {

	[TestFixture ()]
	public class Test {

		public TwitchClient client { get; private set; }

		public Test() {
			client = new TwitchClient();
		}

		[Test ()]
		public void TestCase () {
			TwitchChannel ch = client.ChannelByName("amazhs");
			Assert.NotNull(ch);
			Assert.NotNull(ch.Name);
			Assert.NotNull(ch.GameName);
		}

	}
}
