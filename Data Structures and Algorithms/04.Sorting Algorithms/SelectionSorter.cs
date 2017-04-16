namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection) 
        {

            var minElement = 0;

            for (int i = 0; i < collection.Count - 1; i++)
            {
                minElement = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if ((collection[j].CompareTo(collection[minElement])) < 0)
                    {
                        minElement = j;
                    }
                }

                if (i != minElement)
                {
                    var swap = collection[i];
                    collection[i] = collection[minElement];
                    collection[minElement] = swap;
                }
            }
        }
    }
}
