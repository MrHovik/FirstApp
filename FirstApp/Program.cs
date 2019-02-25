using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, bio;
            int age, n;
            List<User> user = new List<User> ();
            n = Convert.ToInt32 (Console.ReadLine ());
            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                bio = Console.ReadLine();
                age = Convert.ToInt32(Console.ReadLine());
                user.Add(new User (name, age, bio));
            }
            foreach (var e in user)
            {
                e.GetInfo();
            }
            Console.ReadKey();
        }
    }
}
