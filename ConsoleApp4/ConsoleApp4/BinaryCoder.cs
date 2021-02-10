using System;

namespace BinaryCoder
{
    class BinaryCoder
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write number to convert in binary(max number is between –2147483648 and 2147483647)");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your binary number is: " + Convert.ToString(code, 2));
            }
            catch(OverflowException)
            {
                Console.WriteLine("Error: Your number is too big.");
            }
        }
    }
}
