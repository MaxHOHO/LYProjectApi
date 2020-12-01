using LYProjectApi.IRepository.Base;
using LYProjectApi.IServices;
using LYProjectApi.Model.Models;
using LYProjectApi.Services.BASE;

namespace LYProjectApi.Services
{
    /// <summary>
    /// ModuleServices
    /// </summary>	
    public class ModuleServices : BaseServices<Modules>, IModuleServices
    {

        IBaseRepository<Modules> _dal;
        public ModuleServices(IBaseRepository<Modules> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
