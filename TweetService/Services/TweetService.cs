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
using TweetService.DataAccess;

namespace TweetService
{

    public class TweetService : ITweetService
    {

        private readonly TweetContext _db;


        public TweetService(TweetContext db)
        {
            _db = db;
        }

        public List<Tweets> getAll()
        {
            var tweets = _db.tweets.ToList();
            return tweets;
        }


        public List<Tweets> getTweetsByUserID(int userID)
        {
            var tweets = _db.tweets.Where(x => x.ID == userID).ToList();
            return tweets;
        }


        //public List<Reactions> getReactionByTweetID(int tweetID)
        //{
        //    return null;
        //}

        public List<Tweets> getLikesByTweetID(int tweetID)
        {
            return null;
        }
    }
}

