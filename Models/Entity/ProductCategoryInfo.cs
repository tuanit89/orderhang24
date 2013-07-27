

using System;

namespace Models.Entity
{
    [Serializable]
    public class ProductCategoryInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int Sort { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public int ParentId { get; set; }
        public string Image { get; set; }

        public ProductCategoryInfo()
        {
            Id =Sort= 0;
            Name = Link = Description = MetaDescription = Image = string.Empty;
        }
    }
}
