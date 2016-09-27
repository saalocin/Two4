using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TweetSharp;
using Two4.Interfaces.SocialMedia.Twitter;
using Two4.SocialMedia.Providers.Twitter.Infrastructure;
using Two4.SocialMedia.Providers.Twitter.Models;

namespace Two4.SocialMedia.Providers.Twitter.Application
{
    /// <summary>
    /// Twitter service is the application layer for the twitter integration
    /// </summary>
    public class TwitterService : Interfaces.SocialMedia.Twitter.Interfaces.ITwitterService
    {
        /// <summary>
        /// Get tweets for screen name
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetTweetsForScreenNameResponse GetTweetsForScreenName(GetTweetsForScreenNameRequest request)
        {
            var twitterRepo = new TwitterRepository();

            var tweets = twitterRepo.GetTweetsForScreenName(request.ScreenName);

            var result = MapTweets(tweets);

            return result;
        }

        #region Mappers

        /// <summary>
        /// Auto mapper method to map to response object
        /// </summary>
        /// <param name="tweets"></param>
        /// <returns></returns>
        private GetTweetsForScreenNameResponse MapTweets(ICollection<Tweet> tweets)
        {
            var result = new GetTweetsForScreenNameResponse();
            result.Tweets = new List<GetTweetsForScreenNameResponse.Tweet>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Tweet, GetTweetsForScreenNameResponse.Tweet>();
                cfg.CreateMap<Author, GetTweetsForScreenNameResponse.Author>();
                cfg.CreateMap<User, GetTweetsForScreenNameResponse.User>();
            });

            var mapper = new Mapper(config);

            foreach (var tweet in tweets)
            {
                var tweetResponse = mapper.DefaultContext.Mapper.Map<GetTweetsForScreenNameResponse.Tweet>(tweet);

                result.Tweets.Add(tweetResponse);
            }

            return result;
        }

        #endregion
    }
}
