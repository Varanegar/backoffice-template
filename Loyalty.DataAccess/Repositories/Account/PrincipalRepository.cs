using Anatoli.Common.DataAccess.Repositories;
using Loyalty.DataAccess.Interfaces;
using Anatoli.DataAccess.Models.Identity;

namespace Loyalty.DataAccess.Repositories
{
    public class PrincipalRepository : BaseAnatoliRepository<Principal>, IPrincipalRepository
    {
        public PrincipalRepository() : this(new AnatoliDbContext()) { }
        public PrincipalRepository(AnatoliDbContext context)
            : base(context)
        {
        }
    }
}
