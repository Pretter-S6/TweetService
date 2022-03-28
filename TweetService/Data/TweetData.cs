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

namespace API_Gateway.Controllers
{

    public class TweetData : ControllerBase
    {

        public TweetData()
        {

        }

        public IConfigurationRoot GetConnection()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();
            return builder;
        }

        public List<Tweet> getTweetsByUserID(int userID)
        {
            List<Tweet> userTweets = new List<Tweet>();
            foreach(Tweet t in getAll())
            {
                if (t.user.userID == userID)
                {
                    userTweets.Add(t);
                }
            }
            return userTweets;
        }


        public List<Tweet> getAll()
        {
            List<Tweet> tweets = new List<Tweet>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnection().GetSection("ConnectionStrings").GetSection("Connectionstring").Value))
                {
                    connection.Open();

                    String sql = "SELECT * from Tweets";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Tweet t = new Tweet();
                                t.tweetID = reader.GetInt32(0);
                                t.text = reader.GetString(1);
                                t.uploadTime = reader.GetDateTime(2);
                                t.user.userID = reader.GetInt32(3);
                                t.reactions = getReactionByTweetID(t.tweetID);
                                t.likes = getLikesByTweetID(t.tweetID);
                                tweets.Add(t);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return tweets;
        }

        public List<Reaction> getReactionByTweetID(int tweetID)
        {
            List<Reaction> reactions = new List<Reaction>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnection().GetSection("ConnectionStrings").GetSection("Connectionstring").Value))
                {
                    connection.Open();

                    String sql = "SELECT * from Reactions where TweetID = " + tweetID;

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Reaction r = new Reaction();
                                r.reactionID = reader.GetInt32(0);
                                r.tweetID = reader.GetInt32(1);
                                r.userID = reader.GetInt32(2);
                                r.text = reader.GetString(3);
                                reactions.Add(r);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return reactions;
        }

        public List<Like> getLikesByTweetID(int tweetID)
        {
            List<Like> likes = new List<Like>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnection().GetSection("ConnectionStrings").GetSection("Connectionstring").Value))
                {
                    connection.Open();

                    String sql = "SELECT * from Likes where TweetID = " + tweetID;

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Like l = new Like();
                                l.likeID = reader.GetInt32(0);
                                l.tweetID = reader.GetInt32(1);
                                l.userID = reader.GetInt32(2);
                                likes.Add(l);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return likes;
        }
    }
}

