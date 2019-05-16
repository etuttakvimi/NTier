using NTier.Core.Entities;

namespace NTier.Entities
{
    public class Category : CoreEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
