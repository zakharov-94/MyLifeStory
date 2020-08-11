using System;

namespace MyLifeStory.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool IsDeleted { get; set; } = false;

        public BaseEntity()
        {
            Id = new Guid();
            CreateDate = DateTime.UtcNow;
        }

        public BaseEntity(string id)
        {
            Id = Guid.Parse(id);
            CreateDate = DateTime.UtcNow;
        }
    }
}
