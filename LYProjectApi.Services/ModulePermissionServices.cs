using LYProjectApi.Services.BASE;
using LYProjectApi.Model.Models;
using LYProjectApi.IRepository;
using LYProjectApi.IServices;
using LYProjectApi.IRepository.Base;

namespace LYProjectApi.Services
{	
	/// <summary>
	/// ModulePermissionServices
	/// </summary>	
	public class ModulePermissionServices : BaseServices<ModulePermission>, IModulePermissionServices
    {

        IBaseRepository<ModulePermission> _dal;
        public ModulePermissionServices(IBaseRepository<ModulePermission> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
