using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two4.SocialMedia.Providers.Twitter.Models
{
    /// <summary>
    /// domain for user that was the tweeter
    /// </summary>
    public class Tweeter 
    {
        public string RawSource { get; set; }
        public string ScreenName { get; }
        public string ProfileImageUrl { get; }
    }
}
