using LYProjectApi.IServices.BASE;
using LYProjectApi.Model.Models;
using System.Threading.Tasks;

namespace LYProjectApi.IServices
{	
	/// <summary>
	/// UserRoleServices
	/// </summary>	
    public interface IUserRoleServices :IBaseServices<UserRole>
	{

        Task<UserRole> SaveUserRole(int uid, int rid);
        Task<int> GetRoleIdByUid(int uid);
    }
}

