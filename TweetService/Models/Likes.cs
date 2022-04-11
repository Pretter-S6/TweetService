using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TweetService.Models
{
    public class Likes
    {
        [Key]
        public int LikeID { get; set; }
        public int TweetID { get; set; }
        public int UserID { get; set; }

    }
}
