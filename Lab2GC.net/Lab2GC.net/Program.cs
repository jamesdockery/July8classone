using System;

namespace Lab2GC.net
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double length;
            double width;
            String decision;

            Console.WriteLine("Hello user welcome to the Grand Circus room calculator!");
            Console.WriteLine("Please enter the length and width you'd like to be calculated");
            bool co = true;
            while (co)
            {

                Console.Write("Length: ");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Width:");
                width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Area:" + length * width);
                Console.WriteLine("Perimeter:" + ((2 * length) + (2 * width)));


                Console.WriteLine("Would you like to continue?");
                Console.Write("T or F:");
                decision = Console.ReadLine();

                if (decision == "T".ToLower())
                {

                    co = true;
                }
                else
                {
                    co = false;
                    Console.WriteLine("Goodbye");
                }
            }

        }
    }
}
