using LYProjectApi.IServices.BASE;
using LYProjectApi.Model.Models;
using System.Threading.Tasks;

namespace LYProjectApi.IServices
{	
	/// <summary>
	/// RoleServices
	/// </summary>	
    public interface IRoleServices :IBaseServices<Role>
	{
        Task<Role> SaveRole(string roleName);
        Task<string> GetRoleNameByRid(int rid);

    }
}
