using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Duke.Owin.VkontakteMiddleware.Provider;

namespace ProjectMerger.Security
{
    public class VkAuthProvider : VkAuthenticationProvider
    {
        public override Task Authenticated(VkAuthenticatedContext context)
        {
            context.Identity.AddClaim(new Claim("ExternalAccessToken", context.AccessToken));
            return Task.FromResult<object>(null);
        }
    }
}
