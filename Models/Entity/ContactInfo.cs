namespace Models.Entity
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public ContactInfo()
        {
            Id = 0;
            FullName = Email = Phone = Subject = Message = string.Empty;
        }
    }
}
