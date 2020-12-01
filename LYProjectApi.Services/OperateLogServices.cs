using LYProjectApi.IRepository.Base;
using LYProjectApi.IServices;
using LYProjectApi.Model.Models;
using LYProjectApi.Services.BASE;

namespace LYProjectApi.Services
{
    public partial class OperateLogServices : BaseServices<OperateLog>, IOperateLogServices
    {
        IBaseRepository<OperateLog> _dal;
        public OperateLogServices(IBaseRepository<OperateLog> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
