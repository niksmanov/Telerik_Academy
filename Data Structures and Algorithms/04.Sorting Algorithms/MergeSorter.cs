namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            T[] temp = new T[collection.Count];
            this.MergeSort(collection, temp, 0, collection.Count - 1);
        }

        private void Copy(IList<T> collection, T[] temp, int left, int right)
        {
            for (int i = left; i <= right; ++i)
            {
                collection[i] = temp[i];
            }
        }

        private void Merge(IList<T> collection, T[] temp, int left, int middle, int right)
        {
            int i = left;
            int j = middle + 1;
            int k = left;

            while (i <= middle || j <= right)
            {
                if (i <= middle && j <= right)
                {
                    if (collection[i].CompareTo(collection[j]) > 0)
                    {
                        temp[k++] = collection[j++];
                    }
                    else
                    {
                        temp[k++] = collection[i++];
                    }
                }
                else if (i == middle + 1)
                {
                    temp[k++] = collection[j++];
                }
                else if (j == right + 1)
                {
                    temp[k++] = collection[i++];
                }
            }

            this.Copy(collection, temp, left, right);
        }

        private void MergeSort(IList<T> collection, T[] temp, int start, int end)
        {
            if (end - start < 1)
            {
                return;
            }

            int middle = (start + end) / 2;

            this.MergeSort(collection, temp, start, middle);
            this.MergeSort(collection, temp, middle + 1, end);
            this.Merge(collection, temp, start, middle, end);
        }
    }
}
