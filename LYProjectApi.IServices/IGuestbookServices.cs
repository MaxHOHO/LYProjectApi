using LYProjectApi.IServices.BASE;
using LYProjectApi.Model;
using LYProjectApi.Model.Models;
using System.Threading.Tasks;

namespace LYProjectApi.IServices
{
    public partial interface IGuestbookServices : IBaseServices<Guestbook>
    {
        Task<MessageModel<string>> TestTranInRepository();
        Task<bool> TestTranInRepositoryAOP();
    }
}
