

using System;

namespace Models.Entity
{
	[Serializable]
	public class NewsCategoryInfo
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Link { get; set; }
		public int Sort { get; set; }
		public string Description { get; set; }
		public string MetaDescription { get; set; }
		public int ParentId { get; set; }
        public string CateType { get; set; }

        public NewsCategoryInfo()
        {
            Id = Sort =ParentId= 0;
            Name = Link = Description = MetaDescription = CateType = string.Empty;
        }
	}
}
