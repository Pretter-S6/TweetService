using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TweetService.Models
{
    public class Tweets
    {
        [Key]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime UploadTime { get; set; }
        public int UserID { get; set; }

    }
}
