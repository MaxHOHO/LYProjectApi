using LYProjectApi.IRepository.Base;
using LYProjectApi.IServices;
using LYProjectApi.Model.Models;
using LYProjectApi.Services.BASE;

namespace LYProjectApi.Services
{
    public partial class TasksQzServices : BaseServices<TasksQz>, ITasksQzServices
    {
        IBaseRepository<TasksQz> _dal;
        public TasksQzServices(IBaseRepository<TasksQz> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
                    