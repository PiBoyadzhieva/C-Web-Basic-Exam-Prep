using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Andreys.Data;
using Andreys.Models;
using SIS.MvcFramework;

namespace Andreys.Services
{
    public class UsersService : IUsersService
    {
        private readonly AndreysDbContext db;

        public UsersService(AndreysDbContext db)
        {
            this.db = db;
        }

        public string GetUserId(string username, string password)
        {
            var hashPassword = this.Hash(password);
            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == hashPassword);
            if (user == null)
            {
                return null;
            }

            return user.Id;
        }

        public void Register(string username, string email, string password)
        {
            var user = new User
            {
                Role = IdentityRole.User,
                Username = username,
                Email = email,
                Password = this.Hash(password),
            };

            this.db.Users.Add(user);
            this.db.SaveChanges();
        }

        public bool UsernameExists(string username)
        {
            return this.db.Users.Any(x => x.Username == username);
        }

        public bool EmailExists(string email)
        {
            return this.db.Users.Any(x => x.Email == email);
        }

        public string GetUsername(string id)
        {
            //var username = this.db.Users.Where(x => x.Id == id).Select(x => x.Username).FirstOrDefault();
            var user = this.db.Users.FirstOrDefault(x => x.Id == id);
            return user?.Username;
        }

        private string Hash(string input)
        {
            if (input == null)
            {
                return null;
            }

            var crypt = new SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(input));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }

            return hash.ToString();
        }
    }
}
