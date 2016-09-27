using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Two4.Interfaces.SocialMedia.Twitter;
using Two4.Interfaces.SocialMedia.Twitter.Interfaces;

namespace Two4.Practical.Controllers
{
    public class SocialMediaApiController : ApiController
    {
        private ITwitterService TwitterService { get; set; }

        public SocialMediaApiController(ITwitterService twitterService)
        {
            TwitterService = twitterService;
        }

        /// <summary>
        /// API call to get tweets for a screen name
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult GetTweetsForScreenName(GetTweetsForScreenNameRequest request)
        {
            var response = TwitterService.GetTweetsForScreenName(request);

            return Json(response);
        }
    }
}
