using MyLifeStory.Entities.Enums;

namespace MyLifeStory.Entities.BlogEntities
{
    public class UserSubscription: BaseEntity
    {
        public string UserId { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public string SubscriptionItemId { get; set; }
    }
}
