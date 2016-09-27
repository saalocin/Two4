using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two4.Interfaces.SocialMedia.Twitter
{
    /// <summary>
    /// represents the response that will be send to the front end for tweets for a screen name
    /// </summary>
    public class GetTweetsForScreenNameResponse
    {
        public ICollection<Tweet> Tweets { get; set; }

        public class Tweet
        {
            public Author Author { get; set; }

            public User User { get; set; }

            public string TextAsHtml { get; set; }
        }

        public class Author
        {
            public string ProfileImageUrl { get; set; }

            public string ScreenName { get; set; }
        }

        public class User
        {
            public string ScreenName { get; set; }

            public string Description { get; set; }

            public int FollowersCount { get; set; }

            public string Name { get; set; }

            public string Location { get; set; }

            public string ProfileImageUrl { get; set; }
        }
    }
}
