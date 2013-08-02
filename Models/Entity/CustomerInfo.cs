using System;

namespace Models.Entity
{
    [Serializable]
    public class CustomerInfo 
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int PaidMethod { get; set; }
        public string PaidMethodName { get; set; }
    }
}
