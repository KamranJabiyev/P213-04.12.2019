using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region homework
            //first task quantity of spaces
            //string sent = "Salam Rafiq chik";
            //Console.WriteLine(countSpace(sent));

            //second task
            //string[] name = { "Memmed", "Rafiq", "miri" };
            //Console.WriteLine(Join(name));

            //Sozlerden ibaret bir array qebul eden metod yaz ve bu metod en uzun sozu qaytarsin.
            //Console.WriteLine(ReturnLongestWord("Memmed","Rafiq","Mirkazim","Shamsiyye","Safaralii"));
            #endregion

            //Person p = new Person("Rafiq","Qasimov",new DateTime(1997,7,21));
            //Console.WriteLine(p.GetAllInfo());

            Developer d = new Developer();
            d.Name = "Kamran";
            d.Lastname = "Jabiyev";
            d.Experience = 5;
            d.Birthday = new DateTime(1990, 4, 14);
            //d.GetLanguages();
            Console.WriteLine(d.GetAllInfo());

            //Person person = new Person();

            //FullStack fullStack = new FullStack();






            #region Class start
            //p.Name = "Rafiq";
            //p.Lastname = "Qasimov";
            //p.Birthday = new DateTime(1997, 7, 21);
            //Person p2 = new Person();
            //p2.Name = "Miri";
            //p2.Lastname = "DonmeGeri";
            //p2.Birthday = new DateTime(1999, 11, 8);
            //Console.WriteLine(p.GetAllInfo());
            //Console.WriteLine(p2.GetAllInfo());
            //Console.WriteLine($"{p.Birthday.Day}.{p.Birthday.Month}.{p.Birthday.Year}");
            //Person.Test();
            #endregion
        }
        #region homework
        #region task 3
        //static string ReturnLongestWord(params string[] arr)
        //{
        //    string longestWord = "";
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i].Length >=longestWord.Length)
        //        {
        //            longestWord = arr[i];
        //        }
        //    }
        //    return longestWord;
        //}
        #endregion

        #region task2
        //static StringBuilder Join(string[] arr)
        //{
        //    StringBuilder result = new StringBuilder();
        //    foreach (string item in arr)
        //    {
        //        result.Append(item);
        //        if(item != arr[arr.Length - 1])
        //            result.Append(',');
        //    }
        //    return result;
        //}
        #endregion

        #region 1 task
        //static int countSpace(string line)
        //{
        //    int count = 0;
        //    foreach (char l in line)
        //    {
        //        if(l == ' ')
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        #endregion
        #endregion
    }

    
}
