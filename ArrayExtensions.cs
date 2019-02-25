using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
        int length = array.Length;
        double[] leftSums = new double[length];
        leftSums[0] = 0;
        for (int i = 1; i < length; i++)
            leftSums[i] = leftSums[i - 1] + array[i - 1];
        double rightSum = 0;
        for (int i = length - 1; i > 0; i--) {
            if (Math.Abs(rightSum - leftSums[i]) < accuracy)
                return i;
            rightSum += array[i];
         }
        return null;        }
    }
}
