using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using davidharveysblog.Services;
using ViewModels = davidharveysblog.ViewModels;

namespace davidharveysblog.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        private DavidHarveysBlogRepository _Repository;

        public BlogController()
        {
            // Just so you are aware, I wouldn't normally do this!
            // Usually dependency injection via the constructor would allow me to mock out my repository using NSubstitute.
            // This would allow me to have dependency free tests! 
            // To be fixed/re-written with tests.

            _Repository = new DavidHarveysBlogRepository(new DavidHarveysBlogContext());
        }

        [HttpGet("[action]")]
        public IEnumerable<ViewModels.Blog> Fetch()
        {
            var blogEntries = new List<ViewModels.Blog>();

            foreach (var blogEntry in _Repository.GetAll<Blog>(orderBy: b => b.OrderByDescending(x => x.CreatedDate)).ToList())
            {
                blogEntries.Add(new ViewModels.Blog()
                {
                    ID = blogEntry.ID.ToString(),
                    Title = blogEntry.Title,
                    Content = blogEntry.Content,
                    Description = blogEntry.Description,
                    CreatedDate = blogEntry.CreatedDate
                });
            }

            return blogEntries;
        }

        [HttpGet("[action]/{id}")]
        public ViewModels.Blog FetchBlog(string id)
        {
            var blogEntry = _Repository.GetById<Blog>(new Guid(id));

            var blog = new ViewModels.Blog
            {
                ID = blogEntry.ID.ToString(),
                Title = blogEntry.Title,
                Content = blogEntry.Content,
                Description = blogEntry.Description,
                CreatedDate = blogEntry.CreatedDate
            };

            return blog;
        }
    }
}
