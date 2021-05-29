using DirencNetClone.Model;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirencNetClone.Services
{
    public class UserService
    {
        FirebaseClient client;
        public UserService()
        {
            client = new FirebaseClient("https://direncnetclone-default-rtdb.firebaseio.com/");
        }
        public async Task<bool> IsUserExists(string uemail)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.UserEmail == uemail).FirstOrDefault();
            return (user != null);
        }
        public async Task<bool> RegisterUser(string uemail, string passwd)
        {
            if (await IsUserExists(uemail) == false)
            {
                await client.Child("Users").PostAsync(new User()
                {
                    UserEmail = uemail,
                    Password = passwd
                }

                 );
                return true;

            }
            else
            {
                return false;
            }

        }
        public async Task<bool> LoginUser(string uemail, string passwd)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.UserEmail == uemail)
                .Where(u => u.Object.Password == passwd).FirstOrDefault();
            return (user != null);

        }
    }
}
