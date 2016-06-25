using System;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ProjectMerger.Security.Entities;
using Raven.Client;
using Raven.Client.Document;

namespace ProjectMerger.Security
{
    public class AuthRepository : IDisposable
    {
        private IDocumentStore store;

        //private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            store = new DocumentStore
            {
                Url = "http://localhost:8081/", // server URL
                DefaultDatabase = "authtest" // default database
            };
            store.Initialize();
            // _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>());
        }

        public IdentityUser RegisterUser(UserModel userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.UserName
            };
            using (IDocumentSession session = store.OpenSession()) // opens a session that will work in context of 'DefaultDatabase'
            {
               

                session.Store(user); // stores employee in session, assigning it to a collection `Employees`
               

                session.SaveChanges(); // sends all changes to server

                // Session implements Unit of Work pattern,
                // therefore employee instance would be the same and no server call will be made
              
            }
          

            return user;
        }

        public IdentityUser FindUser(string userName, string password)
        {
            IdentityUser result;
            using (IDocumentSession session = store.OpenSession()) // opens a session that will work in context of 'DefaultDatabase'
            {
                

                // Session implements Unit of Work pattern,
                // therefore employee instance would be the same and no server call will be made
                Helper h = new Helper();

              result = session.Query<IdentityUser>().FirstOrDefault(item => item.UserName == userName);
              
            }
            return result;
        }

        public Client FindClient(string clientId)
        {

            Client result;
            using (IDocumentSession session = store.OpenSession()) // opens a session that will work in context of 'DefaultDatabase'
            {


                // Session implements Unit of Work pattern,
                // therefore employee instance would be the same and no server call will be made
                Helper h = new Helper();

                result = session.Query<Client>().FirstOrDefault(item => item.Id == clientId);

            }
            return result;

           
        }

      

       


       

       

        public void Dispose()
        {
            store.Dispose();
        }
    }
}
