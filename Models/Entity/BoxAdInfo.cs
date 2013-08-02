using System;
using Models.DataAccess;

namespace Models.Entity
{
    [Serializable]
    public class BoxAdInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public int Sort { get; set; }
        public string Location { get; set; }
        public BoxAdInfo()
        {
            Id = 0;
            Name = string.Empty;
            Description = string.Empty;
            Link = string.Empty;
            Image = string.Empty;
            Sort = 0;
            Location = string.Empty;
        }
    }

}
