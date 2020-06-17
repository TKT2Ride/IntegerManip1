using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerManip
{
    class Program
    {
        //As a team, write a project to prompt the user for up to 20 integers.  
        //The user will be allowed to choose from the following menu options until they decide to quit:
        //• Display the whole list of input
        //• Display every even number
        //• Display every odd number
        //• Display every 5th number
        //• Display the sum of the integers
        //• Display every number divisible by 3
        //• Quit
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you like to enter (max. 20):");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + num + " numbers:");
            ArrayList myArrayList = new ArrayList();
            for (int i = 0; i < num; i++)
            {
                int temp = Convert.ToInt32(Console.ReadLine());
                myArrayList.Add(temp);
            }

            while (true)
            {
                Console.WriteLine("1: Display the whole list of input");
                Console.WriteLine("2: Display every even number");
                Console.WriteLine("3: Display every odd number");
                Console.WriteLine("4: Display every 5th number");
                Console.WriteLine("5: Display the sum of the integers");
                Console.WriteLine("6: Display every number divisible by 3");
                Console.WriteLine("7: Quit");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 7)
                {
                    break;
                } else if (choice == 1)
                {
                    display(myArrayList);
                } else if (choice == 2)
                {
                    displayEven(myArrayList);
                } else if (choice == 3)
                {
                    displayOdd(myArrayList);
                } else if (choice == 4)
                {
                    //
                } else if (choice == 5)
                {
                    sum(myArrayList);
                } else if (choice == 6)
                {
                    divisibleByThree(myArrayList);
                }

            }
        }

        public static void display(ArrayList AL)
        {

            foreach (int i in AL)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
        public static void displayEven(ArrayList AL)
        {
            foreach (int i in AL)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }
        }
        public static void displayOdd(ArrayList AL)
        {
            foreach (int i in AL)
            {
                if (!((i % 2) == 0))
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public static void sum (ArrayList AL) {
            int g = 0;
            foreach (int i in AL)
            {
                 g+=i;
            }
            Console.WriteLine("The Sum Is "+g);
            Console.WriteLine();
        }
        
        public static void divisibleByThree(ArrayList AL)
        {
            foreach (int i in AL)
            {
                if ((i%3)==0)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }
        }

          public static void everyFifth (ArrayList AL)
        {
            foreach (int i in AL)
            {
                int num = AL.IndexOf(i);
                if (num == 4 || num == 9 || num == 14 || num == 19 )
                {
                    Console.Write(i);
                    Console.Read();
                }
            }
           
        }
          
        public static void quit()
        {
            Console.Write("Program has ended");
            Console.Read();
        }
    }
}
