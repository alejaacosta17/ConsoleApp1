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
            //WriteLine("no need to specify the systm.console "); //as static System.Console was specified
            //WriteLine("----------------------------------");
            //WriteLine("*          Name: Alejandra       *");
            //WriteLine("*          Faculty: CBA          *");
            //WriteLine("*          Age: 24               *");
            //WriteLine("----------------------------------");

            //WriteLine("How do you feel?");
            //string feeling = ReadLine();
            //WriteLine("I am feeling " +feeling +" Thanks for asking");
            //if (feeling == "good")
            //{
            //    WriteLine("I am so happy to hear that");
            //}
            //else if (feeling == "bad")
            //{
            //    WriteLine("I am so sorry");
            //}

            //WriteLine("Demo2: Getting user input");
            //Write("Enter your name: "); //no tiene salto de linea, el input se hace en la misma linea 
            //string userName = ReadLine();
            //Write(userName); //no new line, next command follows here

            Write("Please type your name?");
            string name = ReadLine();
            Write("Where are you from");
            string country = ReadLine();

            WriteLine("----------------------------------");
            WriteLine("*          Name:"+ name +"       *");
            WriteLine("*       Country:" + country +"   *");
            WriteLine("----------------------------------");

            WriteLine("Demo 3: Formatted output");
            string asterik = new string('*', 64);
            WriteLine(asterik);
            WriteLine("*{0, 20}: {1, -40}*", "Name", name);
            WriteLine("*{0, 20}: {1, -40}*", "Country", country);
        }
    }
}
