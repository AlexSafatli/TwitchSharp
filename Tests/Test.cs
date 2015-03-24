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
		public void Test_UserByName() {
			TwitchUser us = client.UserByName("amazhs");
			Assert.NotNull(us);
			Assert.NotNull(us.DisplayName);
			Assert.AreEqual("amazhs",us.DisplayName.ToLower());
		}

		[Test()]
		public void Test_ChannelSearch() {
			List<TwitchChannel> ch = client.SearchForChannels("amaz");
			Assert.NotNull(ch);
			Assert.IsNotEmpty(ch);
		}

		[Test()]
		public void Test_GameSearch() {
			List<TwitchGame> gm = client.SearchForGames("League of Legends");
			Assert.NotNull(gm);
			Assert.IsNotEmpty(gm);
			TwitchGame leagueGame = gm[0];
			Assert.NotNull(leagueGame.Name);
			Assert.AreEqual(leagueGame.Name, "League of Legends");
		}

		[Test()]
		public void Test_TopGames() {
			List<TwitchGame> gm = client.TopGames();
			Assert.NotNull(gm);
			Assert.IsNotEmpty(gm);
		}

	}
}