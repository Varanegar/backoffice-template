using Anatoli.DataAccess.Models.Identity;
using Loyalty.DataAccess.Interfaces.Account;
using Anatoli.Common.DataAccess.Repositories;

namespace Loyalty.DataAccess.Repositories.Account
{
    public class PrincipalPermissionCatalogRepository : BaseAnatoliRepository<PrincipalPermissionCatalog>, IPrincipalPermissionCatalogRepository
    {
        #region Ctors
        public PrincipalPermissionCatalogRepository() : this(new AnatoliDbContext()) { }
        public PrincipalPermissionCatalogRepository(AnatoliDbContext context)
            : base(context)
        {
        }
        #endregion

        //notice: new custom methods could be added in here
    }
}
