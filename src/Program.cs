using System;
using System.Collections.Generic;

namespace take_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Chop");

            IChopper chopper = new BinaryChop();

            Console.WriteLine(">>>>{ 1 }");
            assert_equal(-1, chopper.Chop(3, new int[] { }));
            assert_equal(-1, chopper.Chop(3, new int[] { 1 }));
            assert_equal(0, chopper.Chop(1, new[] { 1 }));
            Console.WriteLine(">>>>{ 1, 3, 5 }");
            assert_equal(0, chopper.Chop(1, new int[] { 1, 3, 5 }));
            assert_equal(1, chopper.Chop(3, new int[] { 1, 3, 5 }));
            assert_equal(2, chopper.Chop(5, new int[] { 1, 3, 5 }));
            assert_equal(-1, chopper.Chop(0, new int[] { 1, 3, 5 }));
            assert_equal(-1, chopper.Chop(2, new int[] { 1, 3, 5 }));
            assert_equal(-1, chopper.Chop(4, new int[] { 1, 3, 5 }));
            assert_equal(-1, chopper.Chop(6, new int[] { 1, 3, 5 }));
            Console.WriteLine(">>>>{ 1, 3, 5, 7 }");
            assert_equal(0, chopper.Chop(1, new int[] { 1, 3, 5, 7 }));
            assert_equal(1, chopper.Chop(3, new int[] { 1, 3, 5, 7 }));
            assert_equal(2, chopper.Chop(5, new int[] { 1, 3, 5, 7 }));
            assert_equal(3, chopper.Chop(7, new int[] { 1, 3, 5, 7 }));
            assert_equal(-1, chopper.Chop(0, new int[] { 1, 3, 5, 7 }));
            assert_equal(-1, chopper.Chop(2, new int[] { 1, 3, 5, 7 }));
            assert_equal(-1, chopper.Chop(4, new int[] { 1, 3, 5, 7 }));
            assert_equal(-1, chopper.Chop(6, new int[] { 1, 3, 5, 7 }));
            assert_equal(-1, chopper.Chop(8, new int[] { 1, 3, 5, 7 }));

            var loong = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                loong.Add(i);
            }

            assert_equal(734, chopper.Chop(734, loong.ToArray()));
            assert_equal(124, chopper.Chop(124, loong.ToArray()));
            assert_equal(-1, chopper.Chop(1001, loong.ToArray()));

            loong.Remove(734);
            loong.ToArray();
            assert_equal(-1, chopper.Chop(1001, loong.ToArray()));


        }

        public static void assert_equal(int expected, int actual)
        {
            if (expected != actual)
            {
                Console.WriteLine($"Expected index: {expected} returned: {actual} >> FAILED");
            }
        }
    }

    public interface IChopper
    {
        int Chop(int numberToFind, int[] array_of_int);
    }


}
