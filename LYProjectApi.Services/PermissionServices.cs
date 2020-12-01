using LYProjectApi.IRepository.Base;
using LYProjectApi.IServices;
using LYProjectApi.Model.Models;
using LYProjectApi.Services.BASE;

namespace LYProjectApi.Services
{
    /// <summary>
    /// PermissionServices
    /// </summary>	
    public class PermissionServices : BaseServices<Permission>, IPermissionServices
    {

        IBaseRepository<Permission> _dal;
        public PermissionServices(IBaseRepository<Permission> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
