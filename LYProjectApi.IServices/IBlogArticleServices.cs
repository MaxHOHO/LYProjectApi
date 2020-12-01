using LYProjectApi.IServices.BASE;
using LYProjectApi.Model.Models;
using LYProjectApi.Model.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LYProjectApi.IServices
{
    public interface IBlogArticleServices :IBaseServices<BlogArticle>
    {
        Task<List<BlogArticle>> GetBlogs();
        Task<BlogViewModels> GetBlogDetails(int id);

    }

}
