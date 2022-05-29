using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TweetService.DataAccess;
using TweetService.Models;

namespace TweetService.TweetController
{
    [ApiController]
    [Route("/tweets")]
    public class TweetController : ControllerBase
    {
        private readonly ILogger<TweetController> _logger;
        private readonly ITweetService _service;
        private readonly TweetContext _db;

        public TweetController(TweetContext db)
        {
            _db = db;
            _service = new TweetService(_db);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Tweets>> getAll()
        {

            //return Ok(_service.getAll());
            return Ok(_service.getAll());
        }
    }
}
