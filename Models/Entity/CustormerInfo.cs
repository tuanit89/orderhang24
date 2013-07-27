using System;

namespace Models.Entity
{
	[Serializable]
	public class CustormerInfo
	{
		public int id { get; set; }
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string Lastname { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public bool Active { get; set; }
		public DateTime CreateDate { get; set; }
		
	}
}
