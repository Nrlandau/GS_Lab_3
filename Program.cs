using System;
using System.Text.RegularExpressions;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            Regex Reg_Number = new Regex("^[-1234567890][1234567890]*$");
            int number = 0;
            string name;
            string str_Number;
            //input
            System.Console.WriteLine("What is your name?");
            name = System.Console.ReadLine();
            while(name.Length == 0)
            {
                System.Console.WriteLine("Enter a Name:");
                name = System.Console.ReadLine();
            }

            do
            {
                System.Console.WriteLine("Input a number between 1 and 100 or -1 to quit, {0}.", name);
                str_Number = System.Console.ReadLine();
                if(str_Number.Length == 0 || !Reg_Number.IsMatch(str_Number))
                {
                    System.Console.WriteLine("Enter a Number");
                    continue;
                }
                number = int.Parse(str_Number);
                
                //magic and output
                if(number == -1)
                    continue;
                if (number < 1 || number > 100) 
                {
                    System.Console.WriteLine("That number is not between 1 and 100, {0}",name);
                    continue;
                }

                if(number % 2 == 1)//odd
                {
                    if(number > 60)
                        System.Console.WriteLine("{0} is Odd, {1}",number,name);
                    else
                        System.Console.WriteLine("{0} is Odd, {1}",number,name);
                }

                else//even
                {
                    if( number < 25)
                        System.Console.Write("That number is less than 25 and ");
                    else if(number > 60 )
                        System.Console.Write("{0} is ",number);
                    System.Console.WriteLine("Even, {0}",name);
                }

            }while(number != -1);
        }
    }
}
