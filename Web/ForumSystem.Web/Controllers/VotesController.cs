﻿namespace ForumSystem.Web.Controllers
{
    using ForumSystem.Services.Data;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class VotesController : ControllerBase
    {
        private readonly IVotesService votesService;

        public VotesController(IVotesService votesService)
        {
            this.votesService = votesService;
        }

        [HttpPost]
        public ActionResult Post()
        {
            // TODO:
            return this.Ok();
        }
    }
}
