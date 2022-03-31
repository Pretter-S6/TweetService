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

    public interface ITweetService 
    {
        List<Tweet> getTweetsByUserID(int userID);
        List<Tweet> getAll();
        List<Reaction> getReactionByTweetID(int tweetID);
        List<Like> getLikesByTweetID(int tweetID);
    }
}

