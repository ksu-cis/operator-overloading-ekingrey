using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(0, 0, 0);
            Vector3 two = new Vector3(4, 8, 0);
            Vector3 three = new Vector3(3, 4, 5);

            Console.WriteLine($"Static method Add: {Vector3.Add(one, two)}");
            Console.WriteLine($"object method Add: {one.Add(two)}");

            Console.WriteLine($"Operator: {one + two}");

            Console.WriteLine($"Operator sub: {one - two}");

            Console.WriteLine($"Operator mult: {2 * one}");

            Console.WriteLine($"Operator mult: {two * 5}");

            Console.WriteLine($"equal: {one == three}");
            Console.WriteLine($"not equal: {one == two}");

            Console.WriteLine($"increment: {one++}");

            Console.WriteLine($"magnitude: {~one}");

            Console.WriteLine($"false: {one}");

            if (one)
            {
                Console.WriteLine($"truthy: {one}");
            }
            else
            {
                Console.WriteLine($"falsey: {one}");
            }
            
        }
    }
}
