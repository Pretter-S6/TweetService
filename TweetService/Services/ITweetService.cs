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
        List<Tweets> getTweetsByUserID(int userID);
        List<Tweets> getAll();
        //List<Reactions> getReactionByTweetID(int tweetID);
        List<Tweets> getLikesByTweetID(int tweetID);
    }
}

