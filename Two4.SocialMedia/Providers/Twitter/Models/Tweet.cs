using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two4.SocialMedia.Providers.Twitter.Models
{
    /// <summary>
    /// domain for a tweet
    /// </summary>
    public class Tweet
    {
        public Author Author { get; set; }

        public User User { get; set; }
        public string Text { get; set; }

        public string TextAsHtml { get; set; }

        public DateTime CreatedDate { get; set; }

        public long Id { get; set; }
    }
}
