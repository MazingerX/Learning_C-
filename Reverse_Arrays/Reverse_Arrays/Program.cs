using System;

namespace ReverseArrayValues
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many values your array has?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"You enter " + num);

            int[] newArray = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the values");
                newArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You enter the following values");
            for (int i = 0; i < num; i++)
            {
                Console.Write(newArray[i] + " ");
            }

            Console.WriteLine("Do you want the values backwards? Y or N");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                int[] backArryas = new int[num];

                for (int i = 0; i < num; i++)
                {
                    backArryas[i] = newArray[num - i - 1];
                    Console.Write(backArryas[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}

