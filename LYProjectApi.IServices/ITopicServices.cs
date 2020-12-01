using LYProjectApi.IServices.BASE;
using LYProjectApi.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LYProjectApi.IServices
{
    public interface ITopicServices : IBaseServices<Topic>
    {
        Task<List<Topic>> GetTopics();
    }
}
