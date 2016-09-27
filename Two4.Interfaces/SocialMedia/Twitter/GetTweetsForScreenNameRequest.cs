using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two4.Interfaces.SocialMedia.Twitter
{
    /// <summary>
    /// represents a request to get tweets for a screen name
    /// </summary>
    public class GetTweetsForScreenNameRequest
    {
        public string ScreenName { get; set; }
    }
}
