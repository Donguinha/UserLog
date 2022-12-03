using System;
using System.Collections.Generic;

namespace LogUser
{
    public class Users : IComparable
    {
        public string username { get; set; }
        public DateTime dateacess { get; set; }

        public Users(string username, DateTime dateacess)
        {
            this.username = username;
            this.dateacess = dateacess;
        }

        public override int GetHashCode()
        {
            return username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Users))
            {
                return false;
            }

            Users user = (Users)obj;

            return username.Equals(user.username);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Users))
            {
                throw new ArgumentException("Error: is not a User");
            }
            Users user10 = (Users)obj;
            return username.CompareTo(user10.username);
        }

        public override string ToString()
        {
            return $"{username} {dateacess}";
        }
    }
}
