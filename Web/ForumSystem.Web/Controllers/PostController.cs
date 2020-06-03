namespace ForumSystem.Web.Controllers
{
    using AspNetCore;
    using ForumSystem.Data.Common.Repositories;
    using ForumSystem.Data.Models;
    using ForumSystem.Web.ViewModels.Posts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class PostController : Controller
    {
        private readonly IDeletableEntityRepository<Post> postsRepository;

        public PostController(IDeletableEntityRepository<Post> postsRepository)
        {
            this.postsRepository = postsRepository;
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(PostCreateInputModel input)
        {
            if(!ModelState.IsValid)
            {

            return View(input);
            }

            var post = new Post
            {
                CategoryId = input.CategoryId,
                Content = input.Content,
                Title = input.Title,
                User=
            };

        }
    }
}