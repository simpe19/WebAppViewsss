using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Views.Repository
{
    public class TagRepository : Repo<TagEntity>
    {
        public TagRepository(DataContext context) : base(context)
        {
        }
    }
}
