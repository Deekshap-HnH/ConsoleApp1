using System;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            double a, b , c,d,e,f,j;

            Console.WriteLine("Enter The First Value");

            a = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter The Second Value");

            b = double.Parse(Console.ReadLine());

            c = Math.Sqrt(a * a + b * b);


            Console.WriteLine("The Number Is {0}" , c);

            Console.ReadLine();
        }
    }
}



































































































































//-------------------------------------Enter The name----------------------------------------
//Console.WriteLine("ENTER THE FIRST NAME OF STUDENT");

//a = Console.ReadLine();


//Console.WriteLine("ENTER THE LAST NAME OF STUDENT");

//b = Console.ReadLine();

//Console.WriteLine("*********************************************");

//Console.WriteLine("NAME OF STUDENT {0} {1}", a, b);