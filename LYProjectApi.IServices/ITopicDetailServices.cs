using LYProjectApi.IServices.BASE;
using LYProjectApi.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LYProjectApi.IServices
{
    public interface ITopicDetailServices : IBaseServices<TopicDetail>
    {
        Task<List<TopicDetail>> GetTopicDetails();
    }
}
