using System;
using System.Configuration;
using NUnit.Framework;
using RestSharp;
using Twitch.Net.Clients;
using Twitch.Net.Helpers;

namespace Twitch.Net.Tests.Integration
{
    [TestFixture(Category = "Integration")]
    public class DynamicClientTests
    {
        private RestClient _restClient;
        private TwitchReadOnlyClient _twitchClient;
        private readonly string _twitchApiUrl = ConfigurationManager.AppSettings["TwitchAPIUrl"];
        private readonly string _twitchAcceptHeader = ConfigurationManager.AppSettings["TwitchAPIAcceptHeader"];
        private readonly string _twitchUser = ConfigurationManager.AppSettings["TwitchUser"];
        private readonly string _twitchChannel = ConfigurationManager.AppSettings["TwitchChannel"];
        private readonly string _twitchStream = ConfigurationManager.AppSettings["TwitchStream"];
        private readonly string _twitchTeam = ConfigurationManager.AppSettings["TwitchTeam"];
        private readonly string _twitchVideo = ConfigurationManager.AppSettings["TwitchVideo"];
        private readonly string _twitchSearchStream = ConfigurationManager.AppSettings["TwitchSearchStream"];
        private readonly string _twitchSearchGame = ConfigurationManager.AppSettings["TwitchGameStream"];

        [SetUp]
        public void Setup()
        {
            _restClient = new RestClient(_twitchApiUrl);
            _restClient.AddHandler("application/json", new DynamicJsonDeserializer());
            _restClient.AddDefaultHeader("Accept", _twitchAcceptHeader);
            Func<string, Method, IRestRequest> requestFunc = (url, method) => new RestRequest(url, method);
            _twitchClient = new TwitchReadOnlyClient(_restClient, requestFunc);
        }
        [Test]
        public void Can_Retrieve_User()
        {
            var user = _twitchClient.GetUser(_twitchUser);
            Assert.That(user != null);
        }

        [Test]
        public void Can_Retrieve_Channel()
        {
            var channel = _twitchClient.GetChannel(_twitchChannel);
            Assert.That(channel != null);
        }

        [Test]
        public void Can_Retrieve_Channel_Videos()
        {
            var videos = _twitchClient.GetChannelVideos(_twitchChannel);
            Assert.That(videos != null);
        }

        [Test]
        public void Can_Retrieve_Chat_Links()
        {
            var chatLinks = _twitchClient.GetChatLinks(_twitchChannel);
            Assert.That(chatLinks != null);
        }

        [Test]
        public void Can_Retrieve_Emoticons()
        {
            var emoticons = _twitchClient.GetEmoticons();
            Assert.That(emoticons != null);
        }

        [Test]
        public void Can_Retrieve_Channel_Followers()
        {
            var followers = _twitchClient.GetChannelFollowers(_twitchChannel);
            Assert.That(followers != null);
        }

        [Test]
        public void Can_Retrieve_User_Followers()
        {
            var followers = _twitchClient.GetUserFollows(_twitchUser);
            Assert.That(followers != null);
        }

        [Test]
        public void Can_Retrieve_User_Following_Channels()
        {
            var follows = _twitchClient.GetUserFollowingChannel(_twitchUser, _twitchChannel);
            Assert.That(follows != null);
        }

        [Test]
        public void Can_Retrieve_Top_Games()
        {
            var games = _twitchClient.GetTopGames();
            Assert.That(games != null);
        }

        [Test]
        public void Can_Retrieve_Ingests()
        {
            var ingests = _twitchClient.GetIngests();
            Assert.That(ingests != null);
        }

        [Test]
        public void Can_Retrieve_Root()
        {
            var root = _twitchClient.GetRoot();
            Assert.That(root != null);
        }

        [Test]
        public void Can_Retrieve_Search_Results_For_Streams()
        {
            var results = _twitchClient.SearchStreams(_twitchSearchStream);
            Assert.That(results != null);
            Assert.IsTrue(results.streams.Count > 0);
        }

        [Test]
        public void Can_Retrieve_Search_Results_For_Games()
        {
            var results = _twitchClient.SearchGames(_twitchSearchGame);
            Assert.That(results != null);
            Assert.That(results.games.Count > 0);
        }

        [Test]
        public void Can_Retrieve_Stream()
        {
            var stream = _twitchClient.GetStream(_twitchStream);
            Assert.That(stream != null);
        }

        [Test]
        public void Can_Retrieve_Streams()
        {
            var streams = _twitchClient.GetStreams(_twitchSearchStream);
            Assert.That(streams != null);
        }

        [Test]
        public void Can_Retrieve_Streams_Paged()
        {
            var streams = _twitchClient.GetStreams(_twitchSearchStream, pagingInfo: new PagingInfo { Page = 2, PageSize = 50 });
            Assert.That(streams != null);
        }

        [Test]
        public void Can_Retrieve_Featured_Streams()
        {
            var streams = _twitchClient.GetFeaturedSteams();
            Assert.That(streams != null);
        }

        [Test]
        public void Can_Retrieve_Stream_Summary()
        {
            var streams = _twitchClient.GetStreamSummary();
            Assert.That(streams != null);
            Assert.That(streams.channels != null);
        }

        [Test]
        public void Can_Retrieve_Team()
        {
            var team = _twitchClient.GetTeam(_twitchTeam);
            Assert.That(team != null);
            Assert.That(team.name == _twitchTeam);
        }

        [Test]
        public void Can_Retrieve_Teams()
        {
            var teams = _twitchClient.GetTeams();
            Assert.That(teams != null);
        }

        [Test]
        public void Can_Retrieve_Video()
        {
            var video = _twitchClient.GetVideo(_twitchVideo);
            Assert.That(video != null);
            Assert.That(video._id == _twitchVideo);
        }

        [Test]
        public void Can_Retrieve_Videos()
        {
            var videos = _twitchClient.GetTopVideos();
            Assert.That(videos != null);
        }

    }
}
