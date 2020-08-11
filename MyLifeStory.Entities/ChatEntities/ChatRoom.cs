using MyLifeStory.Entities.Enums;

namespace MyLifeStory.Entities.ChatEntities
{
    public class ChatRoom: BaseEntity
    {
        public string RoomTitle { get; set; }
        public RoomType RoomType { get; set; }
    }
}
