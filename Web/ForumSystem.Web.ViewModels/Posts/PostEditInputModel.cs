namespace ForumSystem.Web.ViewModels.Posts
{
    using System.ComponentModel.DataAnnotations;

    public class PostEditInputModel
    {

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
