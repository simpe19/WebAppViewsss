using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Views.Repository
{
    public class AdressRepository : Repository<AdressEntity>
    {
        public AdressRepository(IdentityContext context) : base(context)
        {
        }
    }
}
