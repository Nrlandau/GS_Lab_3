using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            int number = 0;
            string name;
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
                number = int.Parse(System.Console.ReadLine());
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
