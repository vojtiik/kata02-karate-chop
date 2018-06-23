using System;
using take_1;

public class BinaryChop : IChopper
{
    private int ChopSlice(int numberToFind, int[] array_of_int, int indexStart, int indexto)
    {
        var segment = new ArraySegment<int>(array_of_int, indexStart, indexto).ToArray();

        int segmentLength = segment.Length;
        var middleIndex = segmentLength / 2;
        int valueInTheMiddle = segment[middleIndex];
        if (valueInTheMiddle == numberToFind)
        {
            Console.WriteLine("found: " + numberToFind);
            return indexStart + middleIndex;
        }

        if (segmentLength == 1)
        {
            Console.WriteLine("not found: " + numberToFind);
            return -1;
        }

        if (numberToFind < valueInTheMiddle)
        {
            var index = ChopSlice(numberToFind, array_of_int, indexStart, segmentLength - middleIndex);
            return index;
        }
        else
        {
            var index = ChopSlice(numberToFind, array_of_int, indexStart + middleIndex, segmentLength - middleIndex);
            return index;
        }
    }

    public int Chop(int numberToFind, int[] array_of_int)
    {

        Console.WriteLine("looking for " + numberToFind);
        int length = array_of_int.Length;

        if (length == 0)
        {
            return -1;
        }

        if (length == 1)
        {
            if (array_of_int[0] == numberToFind)
            {
                Console.WriteLine("found: " + numberToFind);
                return 0;
            }

            Console.WriteLine("not found: " + numberToFind);
            return -1;
        }

        return ChopSlice(numberToFind, array_of_int, 0, length);
    }
}













