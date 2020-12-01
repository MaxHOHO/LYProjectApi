using LYProjectApi.IRepository.Base;
using LYProjectApi.Model.IDS4DbModels;
using LYProjectApi.Services.BASE;

namespace LYProjectApi.IServices
{
    public class ApplicationUserServices : BaseServices<ApplicationUser>, IApplicationUserServices
    {

        IBaseRepository<ApplicationUser> _dal;
        public ApplicationUserServices(IBaseRepository<ApplicationUser> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}