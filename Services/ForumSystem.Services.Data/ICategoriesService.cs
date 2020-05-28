using System.Collections.Generic;

namespace ForumSystem.Services.Data
{
    public interface ICategoriesService
    {
        IEnumerable<T> GetAll<T>(int? count = null);
    }
}
