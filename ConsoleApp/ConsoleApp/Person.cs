using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public partial class Person
    {
        public string Name;
        public string Lastname;
        public DateTime Birthday;

        public Person()
        {
            Console.WriteLine("insan yaradildi");
        }

        public Person(string name, string surname) 
        {
            Console.WriteLine($"{name} {surname}");
            //Name = name;
            //Lastname = surname;
        }
        //public Person(string name,string surname,DateTime birthday):this(name,surname)
        //{
        //    Console.WriteLine(birthday.Year);
        //    //Birthday = birthday;
        //}
    }

    public class Developer : Person
    {
        public string[] Languages;
        public int Experience;

        public void GetLanguages()
        {
            Console.WriteLine("Javani bilir");
        }

        public override string GetAllInfo()
        {
            return $"{base.GetAllInfo()} experience:{Experience} il";
        }
    }

    public class FullStack : Developer { }
}
