using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class ArrayManipulation
    {

        public static bool IsArraySorted(double[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1]) return false;
            }
            return true;
        }
        private static void Swap(ref double[] array, int i, int j)
        {
            double tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
        public static void InsertionSort(ref double[] array)
        {
            if (IsArraySorted(array)) return;
            for(int i = 1; i < array.Length; i++)
            {
                double elem = array[i];
                int tmpIndex = i - 1;

                while(tmpIndex >= 0 && elem < array[tmpIndex])
                {
                    Swap(ref array, tmpIndex + 1, tmpIndex);
                    tmpIndex--;
                }
            }
        }

        public static int BinarySearch(double[] array, double requestedElement)
        {
            const double epsilon = 0.0001;
            int left = 0, right = array.Length - 1;
            while(left < right)
            {
                int mid = left + (right - left) / 2;
                if (Math.Abs(array[mid] - requestedElement) < epsilon) return mid + 1;
                if (array[mid] < requestedElement) left = mid + 1;
                else right = mid - 1;
            }

            if (Math.Abs(array[left] - requestedElement) < epsilon) return left + 1;
            return -1;
        }
    }
}
