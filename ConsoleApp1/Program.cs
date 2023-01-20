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
            //CHEATSHEET https://hackr.io/blog/c-sharp-cheat-sheet 
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

            //Write("Please type your name?");
            //string name = ReadLine();
            //Write("Where are you from");
            //string country = ReadLine();

            ////WriteLine("----------------------------------");
            ////WriteLine("*          Name:"+ name +"       *");
            ////WriteLine("*       Country:" + country +"   *");
            ////WriteLine("----------------------------------");

            //WriteLine("Demo 3: Formatted output");
            //string asterik = new string('*', 64); //64 times *
            //WriteLine(asterik);
            //WriteLine("*{0, 20}: {1, -40}*", "Name", name); //0 to the first "name" and 0 characters for second place thing defined
            //WriteLine("*{0, 20}: {1, -40}*", "Country", country);

            //WriteLine("Demo 4: getting numeric input");
            //Write("Enter grade 1: ");
            //int grade1 = int.Parse(ReadLine());
            //WriteLine("Grade 1 is " + grade1);

            //WriteLine("Enter number 1:");
            //int grade1 = int.Parse(ReadLine());

            //WriteLine("Enter number 2:");
            //int grade2 = int.Parse(ReadLine());

            //WriteLine("Enter number 3:");
            //int grade3 = int.Parse(ReadLine());
            //// Cast operator - convert one numeric data type to another
            //double avg = (grade1 + grade2 + grade3) / 3.0; //3.0 is to convert the int into a string so output is double too, not int as the other variables
            //WriteLine(" Average of the grades are: " + avg.ToString("F2"));

            //string asterix2 = new string('x', 50);

            //WriteLine(asterix2);

            // Post fix increment operator
            WriteLine("Enter you age");
            int age1 = int.Parse(ReadLine());
            WriteLine("Age with postfix increment operator is {0}", age1);
            WriteLine("Age after postfix increment operator is {0}", age1++);

            // Pre fix increment operator
            WriteLine("Enter you age");
            int age2 = int.Parse(ReadLine());
            WriteLine("Age with postfix increment operator is {0}", age2);
            WriteLine("Age after postfix increment operator is {0}", ++age2);



        }
    }
}
