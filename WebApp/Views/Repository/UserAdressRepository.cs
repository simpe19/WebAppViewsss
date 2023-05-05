using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Views.Repository
{
    public class UserAdressRepository : Repository<UserAdressEntity>
    {
        public UserAdressRepository(IdentityContext context) : base(context)
        {
        }
    }
}
