using System;
using System.Collections.Generic;
using System.IO;

namespace LogUser
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Users> userlog = LerArquivo();

            foreach (Users each in userlog)
            {
                Console.WriteLine(each);
            }

            Console.WriteLine("users number: " + userlog.Count); 
        }

        static SortedSet<Users> LerArquivo()
        {
            SortedSet<Users> user1 = new SortedSet<Users>();
            try
            {
                string path = @"c:\code\LogUser\in.txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] str1 = sr.ReadLine().Split(' ');
                        DateTime date = DateTime.Parse(str1[1]);

                        user1.Add(new Users(str1[0], date));
                    }
                }
                return user1;
            }
            catch (IOException excpetion)
            {
                Console.WriteLine("Reading error");
                return null;
            }
        }
    }
}