using MyLifeStory.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLifeStory.DAL.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly LifeStoryContext _dbContext;

        public BlogPostRepository(LifeStoryContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
