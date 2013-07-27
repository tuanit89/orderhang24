using System;

namespace Models.Entity
{
    [Serializable]
    public class PartnerInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Alt { get; set; }

        public PartnerInfo()
        {
            Id = 0;
            Name = string.Empty;
            Link = string.Empty;
            Description = string.Empty;
            Image = string.Empty;
            Alt = string.Empty;
        }
    }
}
