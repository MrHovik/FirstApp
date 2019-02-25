using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class User
    {
        public string Name;
        public int Age;
        public string Bio;
        public User()
        {zxcvzcxv
            
        }
        public User(string name, int age, string bio)
        {
            Name = name;
            Age = age;
            Bio = bio;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Imya {Name}\nAge {Age}\nBio {Bio}\n");
        }
    }
}
