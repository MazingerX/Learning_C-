using System;

namespace Symmetric_Array_Checking
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many values your Array has?");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("You enter " + num);
            Console.WriteLine("Enter your values: ");

            int[] newArray = new int[num];
            for(int i = 0; i < num; i++)
            {
                newArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("You enter ");
            for (int i = 0; i < num; i++)
            {
                Console.Write(" " + newArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Want to check if its symmetric? Y or N");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                bool arraySym = true;

                for (int i = 0; i < num/2; i++)
                {
                    if (newArray[i] != newArray[num - i - 1])
                    {
                        arraySym = false;
                        break;
                    }
                }

                if (arraySym)
                {
                    Console.WriteLine("Array is Symmetric!");
                }
                else
                {
                    Console.WriteLine("Array is not Symmetric!");
                }
            }
            
        }
    }
}
