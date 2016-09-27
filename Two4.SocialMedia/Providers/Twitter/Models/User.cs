using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two4.SocialMedia.Providers.Twitter.Models
{
    /// <summary>
    /// domain model for a twitter user
    /// </summary>
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
