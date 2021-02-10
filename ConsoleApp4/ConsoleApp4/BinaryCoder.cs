using System;

namespace BinaryCoder
{
    class BinaryCoder
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write number to convert in binary(max number is 4294967295)");
                uint code = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Your binary number is: " + Convert.ToString(code, 2));
            }
            catch(OverflowException Exception)
            {
                Console.WriteLine("Error: Your number is too big, or it's less than 1.");
            }
        }
    }
}
