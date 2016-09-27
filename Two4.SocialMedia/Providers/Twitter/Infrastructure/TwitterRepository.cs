using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using AutoMapper;
using Newtonsoft.Json.Linq;
using TweetSharp;
using Two4.SocialMedia.Providers.Twitter.Models;

namespace Two4.SocialMedia.Providers.Twitter.Infrastructure
{
    public class TwitterRepository
    {
        private readonly string _consumerKey = "29L5ejE4m8ZrGlnxiER2QbUki";
        private readonly string _consumerSecret = "3NDT6DrOhplRLq5WZDbADFmIbTDstXSwEHzc4DNK1X9NSITGJd";

        private readonly string _accessToken = "45563755-GszaYS8JSRhIPzeCW4zNMLvpVYL0998MclEaUKb0W";
        private readonly string _accessTokenSecret = "rwpI5Ky95661RHBJHRmHpJ1yao1rBTC8tUyREWaPQSzJz";

        public ICollection<Tweet> GetTweetsForScreenName(string screenName)
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);
            var currentTweets = service.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions()
            {
                ScreenName = screenName
            });

            var result = MapTweetResult(currentTweets);

            return result;
        }

        private ICollection<Tweet> MapTweetResult(IEnumerable<TwitterStatus> twitterStatuses)
        {
            var result = new List<Tweet>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TwitterStatus, Tweet>();
                cfg.CreateMap<ITweeter, Author>();
                cfg.CreateMap<TwitterUser, User>();
            });

            var mapper = new Mapper(config);

            foreach (var twitterStatus in twitterStatuses)
            {
                var tweet = mapper.DefaultContext.Mapper.Map<Tweet>(twitterStatus);

                result.Add(tweet);
            }

            return result;
        }
    }
}
