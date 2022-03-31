using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text;
using TweetService.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TweetService
{

    public class TweetService : ITweetService
    {
        private TweetData tweetData;

        public TweetService()
        {
            tweetData = new TweetData();
        }


        public List<Tweet> getTweetsByUserID(int userID)
        {
            return tweetData.getTweetsByUserID(userID);
        }


        public List<Tweet> getAll()
        {
            return tweetData.getAll();
        }

        public List<Reaction> getReactionByTweetID(int tweetID)
        {
            return tweetData.getReactionByTweetID(tweetID);
        }

        public List<Like> getLikesByTweetID(int tweetID)
        {
            return tweetData.getLikesByTweetID(tweetID);
        }
    }
}

