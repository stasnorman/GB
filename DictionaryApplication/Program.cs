using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

namespace DictionaryApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestClass test = new TestClass("Я тоже хочу в память");
            //test.ViewMessage();

            //Data();

            StringData();
            GC.Collect();
            ReadKey();
        }

        public static void Data() => new TestClass("Я - строка");
        public static void StringData()
        {
            UserData get = new UserData("asdasd");
            get.MethodUpper();
            
        }

    }
}
