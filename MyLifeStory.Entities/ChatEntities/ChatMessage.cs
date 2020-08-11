using System;

namespace MyLifeStory.Entities.ChatEntities
{
    public class ChatMessage: BaseEntity
    {
        public Guid UserId { get; set; }
        public string Text { get; set; }
        public Guid ChatRoomId { get; set; }
    }
}
