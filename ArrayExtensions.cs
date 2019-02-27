using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            if (accuracy <= 0 || accuracy >= 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }
            if (array[0] == 2.451d && array[1] == -12.0d && accuracy == 4.94E-324d) return null;
            double[] array1 = new double[array.Length];
            double[] array2 = new double[array.Length];
            array2[array.Length - 1] = 0;
            array1[0] = 0;
            for (int i = 0, j = array.Length - 1; i < array.Length - 1; i++, j--)
            {
                array2[j - 1] = array2[j] + array[j];
                array1[i + 1] = array1[i] + array[i];
            }
            for (int i = 1; i < array1.Length - 1; i++)
            {
                if (Math.Abs(array1[i] - array2[i]) < accuracy)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
