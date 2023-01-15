using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace DMSmain.BL
{
    public class MUser
    {
        public MUser(string username)
        {
            this.username = username;
        }
        public MUser(string name,string username, string password, string role)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public MUser(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public MUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public MUser()
        {
            username = "";
            password = "";
            role = "";
        }

        public static bool operator == (MUser user1 ,MUser user2)
        {
            if (object.ReferenceEquals(user1, null) || object.ReferenceEquals(user2, null))
                return false;
            return user1.Username == user2.Username && user1.Password == user2.Password;
        }
        public static bool operator !=(MUser user1, MUser user2)
        {
            if (object.ReferenceEquals(user1, null) && object.ReferenceEquals(user2, null))
                return true ;
            return false;
        }
        protected string username;
        protected string password;
        protected string role;
        protected string name;
        protected string CNIC;
        protected string phoneNumber;
        protected string email;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public bool isAdmin()
        {
            if (role == "ADMIN") return true;
            return false;
        }
        public bool isRider()
        {
            if (role == "RIDER") return true;  
            return false;
        }
        
    }
}
