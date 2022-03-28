using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TweetService.Models;

namespace API_Gateway.Controllers
{
    [ApiController]
    [Route("/test")]
    public class TweetController : ControllerBase
    {

        private readonly ILogger<TweetController> _logger;

        public TweetController(ILogger<TweetController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Tweet> getAll()
        {
            TweetData t = new TweetData();
            return t.getAll();
        }
    }
}
