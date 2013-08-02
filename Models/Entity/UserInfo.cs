using System;

namespace Models.Entity
{
    [Serializable]
    public class UserInfo
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public short Status { get; set; }

        public UserInfo()
        {
            Id = 0;
            Username = string.Empty;
            Password = string.Empty;
            Fullname = string.Empty;
            Status = 0;
        }
    }

}
