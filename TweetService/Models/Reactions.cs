using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TweetService.Models
{
    public class Reactions
    {
        [Key]
        public int ReactionID { get; set; }
        public int TweetID { get; set; }
        public int UserID { get; set; }
        public String Reaction { get; set; }

    }
}
