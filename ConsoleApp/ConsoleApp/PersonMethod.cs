using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    partial class Person
    {
        
        public string Fullname()
        {
            return $"{Name} {Lastname}";
        }

        public int GetAge()
        {
            return DateTime.Now.Year - Birthday.Year;
        }

        public virtual string GetAllInfo()
        {
            return $"{Fullname()} {GetAge()}";
        }

        public static void Test()
        {
            Console.WriteLine("Static Method");
        }
    }
}
