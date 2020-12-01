using AutoMapper;
using LYProjectApi.Model.Models;
using LYProjectApi.Model.ViewModels;

namespace LYProjectApi.AutoMapper
{
    public class CustomProfile : Profile
    {
        /// <summary>
        /// 配置构造函数，用来创建关系映射
        /// </summary>
        public CustomProfile()
        {
            CreateMap<BlogArticle, BlogViewModels>();
            CreateMap<BlogViewModels, BlogArticle>();
        }
    }
}
