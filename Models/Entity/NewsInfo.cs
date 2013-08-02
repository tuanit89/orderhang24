

using System;

namespace Models.Entity
{
	[Serializable]
	public class NewsInfo
	{
		public int Id { get; set; }
		public int CateId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Content { get; set; }
		public string Image { get; set; }
		public string AltImage { get; set; }
		public DateTime CreateDate { get; set; }
		public string Link { get; set; }
		public string MetaDescription { get; set; }
		public bool IsAttach { get; set; }
        public int Sort { get; set; }
        public string Tags { get; set; }
        public int PageVisitor { get; set; }
        public NewsInfo()
        {
            Id = CateId = Sort = 0;
            Title = Description = MetaDescription = Content = Image = AltImage = Link = Tags = string.Empty;
            IsAttach = false;
            CreateDate = DateTime.Now;
            PageVisitor = 20;
        }
	}
}
