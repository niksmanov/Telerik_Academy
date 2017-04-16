﻿namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(IList<T> collection, int left, int right)
        {
            if (left < right)
            {
                var next = Partition(collection, left, right);
                QuickSort(collection, left, next - 1);
                QuickSort(collection, next + 1, right);
            }
        }

        private int Partition(IList<T> input, int left, int right)
        {
            var pivot = input[right];
            var swapIndex = left;
            for (int i = left; i < right; i++)
            {
                if (input[i].CompareTo(pivot) <= 0)
                {
                    var temp = input[i];
                    input[i] = input[swapIndex];
                    input[swapIndex] = temp;
                    swapIndex++;
                }
            }

            input[right] = input[swapIndex];
            input[swapIndex] = pivot;

            return swapIndex;
        }
    }
}
