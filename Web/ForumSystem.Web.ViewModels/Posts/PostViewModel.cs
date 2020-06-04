namespace ForumSystem.Web.ViewModels.Posts
{
    using System;

    using ForumSystem.Data.Models;
    using ForumSystem.Services.Mapping;

    public class PostViewModel : IMapFrom<Post>
    {
        public DateTime CreatedOn { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string UserUserName { get; set; }
    }
}
