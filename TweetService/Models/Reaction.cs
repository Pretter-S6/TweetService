using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetService.Models
{
    public class Reaction
    {
        public Reaction()
        {

        }

        public int reactionID { get; set; }
        public int tweetID { get; set; }
        public int userID { get; set; }
        public string text { get; set; }


    }
}
