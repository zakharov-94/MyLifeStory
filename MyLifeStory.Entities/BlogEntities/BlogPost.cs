using MyLifeStory.Entities.Enums;
using System;

namespace MyLifeStory.Entities.BlogEntities
{
    public class BlogPost: BaseEntity
    {
        public Guid AuthorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid PostThemeId { get; set; }
        public PostContentType ContentType { get; set; }
        public bool CommentsAllowed { get; set; } = false;
    }
}
