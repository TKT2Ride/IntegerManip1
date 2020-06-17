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
            Console.WriteLine("How many numbers would you like to enter (max. 20):";
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

            }
        }
        public static void sum (IList<int> AL) {
            int g = 0;
            for(int i=0; i < AL.Count; i++)
            {
                 g+= AL[i];
            }
            Console.Write("The Sum Is "+g);
            Console.ReadLine();
        }
        public static void display(IList<int> AL)
        {
            for (int i=0; i<AL.Count; i++)
            {
                Console.Write(AL[i]);
                Console.ReadLine();
            }
        }
        public static void divisibleByThree(IList<int> AL)
        {
            for (int i = 0; i < AL.Count; i++)
            {
                if ((AL[i]%3)==0)
                {
                    Console.Write(AL[i]);
                    Console.ReadLine();
                }
            }
        }
    }
}
