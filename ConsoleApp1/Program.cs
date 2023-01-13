using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //Console is a static class

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("no need to specify the systm.console "); //as static System.Console was specified
            WriteLine("----------------------------------");
            WriteLine("*          Name: Alejandra       *");
            WriteLine("*          Faculty: CBA          *");
            WriteLine("*          Age: 24               *");
            WriteLine("----------------------------------");

            WriteLine("How do you feel?");
            string feeling = Console.ReadLine();
            WriteLine("I am feeling " +feeling +" Thanks for asking");
            if (feeling == "good")
            {
                WriteLine("I am so happy to hear that");
            }
            else if (feeling == "bad")
            {
                WriteLine("I am so sorry");
            }
        }
    }
}
