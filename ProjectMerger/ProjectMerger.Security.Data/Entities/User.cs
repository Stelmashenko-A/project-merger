using System;

namespace ProjectMerger.Security
{
    public class User
    {
        public Guid ID { get; set; }
        public SocialCredentials SocialCredentials { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}