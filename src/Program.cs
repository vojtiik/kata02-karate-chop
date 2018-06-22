using System;

namespace take_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Chop");

            IChopper chopper = new BinaryChop();

            assert_equal(-1, chopper.Chop(3, new int[] { }));
            assert_equal(-1, chopper.Chop(3, new int[] { 1 }));
            assert_equal(0, chopper.Chop(1, new[] { 1 }));
            assert_equal(0, chopper.Chop(1, new int[] { 1, 3, 5 }));
            assert_equal(1, chopper.Chop(3, new int[] { 1, 3, 5 }));
            assert_equal(2, chopper.Chop(5, new int[] { 1, 3, 5 }));
            assert_equal(-1, chopper.Chop(0, new int[] { 1, 3, 5 }));
            assert_equal(-1, chopper.Chop(2, new int[] { 1, 3, 5 }));
            assert_equal(-1, chopper.Chop(4, new int[] { 1, 3, 5 }));
            assert_equal(-1, chopper.Chop(6, new int[] { 1, 3, 5 }));
            assert_equal(0, chopper.Chop(1, new int[] { 1, 3, 5, 7 }));
            assert_equal(1, chopper.Chop(3, new int[] { 1, 3, 5, 7 }));
            assert_equal(2, chopper.Chop(5, new int[] { 1, 3, 5, 7 }));
            assert_equal(3, chopper.Chop(7, new int[] { 1, 3, 5, 7 }));
            assert_equal(-1, chopper.Chop(0, new int[] { 1, 3, 5, 7 }));
            assert_equal(-1, chopper.Chop(2, new int[] { 1, 3, 5, 7 }));
            assert_equal(-1, chopper.Chop(4, new int[] { 1, 3, 5, 7 }));
            assert_equal(-1, chopper.Chop(6, new int[] { 1, 3, 5, 7 }));
            assert_equal(-1, chopper.Chop(8, new int[] { 1, 3, 5, 7 }));

        }


        public static void assert_equal(int expected, int actual)
        {
            Console.WriteLine($"{expected}:{actual} >> {expected == actual}");
        }
    }

    public interface IChopper
    {
        int Chop(int numberToFind, int[] array_of_int);
    }

    public class BinaryChop : IChopper
    {
        public int Chop(int numberToFind, int[] array_of_int)
        {

            return -1;
        }
    }
}
