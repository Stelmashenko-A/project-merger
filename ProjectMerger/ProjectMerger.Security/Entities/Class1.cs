using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMerger.Security.Entities
{
    public class Client
    {
        
        public string Id { get; set; }
        
        public string Secret { get; set; }
        
        
        public string Name { get; set; }
        public ApplicationTypes ApplicationType { get; set; }
        public bool Active { get; set; }
        public int RefreshTokenLifeTime { get; set; }
        
        public string AllowedOrigin { get; set; }
    }

    public class RefreshToken
    {
        
        public string Id { get; set; }
 
        public string Subject { get; set; }

        public string ClientId { get; set; }
        public DateTime IssuedUtc { get; set; }
        public DateTime ExpiresUtc { get; set; }

        public string ProtectedTicket { get; set; }

    }

    public enum ApplicationTypes
    {
        JavaScript = 0,
        NativeConfidential = 1
    }
    public class UserModel
    {
      
        public string UserName { get; set; }

       
        public string Password { get; set; }

    
        public string ConfirmPassword { get; set; }
    }
}
