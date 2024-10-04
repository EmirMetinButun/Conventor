using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Conventor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 'c' to use  the currency converter  or  anything else tempreture converter");
           
            string answer = Console.ReadLine();

            if (answer == "c")
            {
                Console.WriteLine("You have selected the currency converter");
                Console.WriteLine("Please enter 'a' to conver from pounds or  anything else to convert from euros");
                string choice = Console.ReadLine() ;


                if (choice == "a")
                {
                    Console.WriteLine("please enter your amount in pounds");
                    float pounds= float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;
                    Console.WriteLine("The amount in euros is" + euros.ToString("0.00"));

                }
                else
                {
                    Console.WriteLine("please enter your amount in euros");
                    float euros= float.Parse(Console.ReadLine());
                    float pounds = euros / 1.16f;
                    Console.WriteLine("The amount in Britsh poundS is" + euros.ToString("0.00"));
                }
            }
            else
            {
                Console.WriteLine("welcom to the tempreture converter ");
                Console.WriteLine("enter 'a' to convert  from celcius or anything else to convert  from farnheit");
                string choice = Console.ReadLine();
                if (choice == "a")
                {
                    Console.WriteLine("enter a temprreture in celcius  ");
                    float celcius = float.Parse(Console.ReadLine());
                    float fahrenheit = celcius * 1.18f + 32f;
                    Console.WriteLine("The tempreture in farenheit is" + fahrenheit);

                }
                else
                {
                    Console.WriteLine("enter a temprreture in farenheit  ");
                    float fahrenheit = float.Parse(Console.ReadLine());
                    float celcius = (fahrenheit - 32f) / 1.8f;
                    Console.WriteLine("The tempreture in celcuis is"+ celcius);

                }
            }

            Console.ReadKey();
           
        }
    }
}
