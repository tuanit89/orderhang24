using System;

namespace Models.Entity
{
	[Serializable]
	public class SupportInfo
	{
		public int Id { get; set; }
		public string Yahoo { get; set; }
		public string Skype { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
		
		public SupportInfo()
		{
			Id = 0;
			Yahoo = string.Empty;
			Skype = string.Empty;
			Name = string.Empty;
			Phone = string.Empty;
		}
	}
}
