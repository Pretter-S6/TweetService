using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TweetService.Models;

namespace TweetService.DataAccess
{
    public class TweetContext : DbContext
    {
        public TweetContext(DbContextOptions options) : base(options) { }
        public DbSet<Tweets> tweets { get; set; }

        public DbSet<Reactions> reactions { get; set; }

        public DbSet<Likes> likes { get; set; }
    }
}