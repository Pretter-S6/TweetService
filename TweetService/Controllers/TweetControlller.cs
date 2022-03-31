using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TweetService.Models;

namespace TweetService
{
    [ApiController]
    [Route("/test")]
    public class TweetController : ControllerBase
    {
        private ITweetService iTweetService;
        private readonly ILogger<TweetController> _logger;

        public TweetController(ILogger<TweetController> logger)
        {
            _logger = logger;
            iTweetService = new TweetService();
        }

        [HttpGet]
        public ActionResult<List<Tweet>> getAll()
        {
            try
            {
                return Ok(iTweetService.getAll());
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
