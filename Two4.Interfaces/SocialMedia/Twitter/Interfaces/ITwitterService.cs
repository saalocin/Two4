using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two4.Interfaces.SocialMedia.Twitter.Interfaces
{
    public interface ITwitterService
    {
        GetTweetsForScreenNameResponse GetTweetsForScreenName(GetTweetsForScreenNameRequest request);
    }
}
