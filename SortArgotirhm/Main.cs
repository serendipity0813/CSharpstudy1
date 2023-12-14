using System;
using System.Collections.Generic;

namespace BasicAlgorithm
{
    internal class Algorithm
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 2, 8, 5, 7 };
            //sort();
            //SelectSortAlgorith.SelectSort();
            //InsertionSortAlgorith.InsertionSort();
            //QuickSortAlgorith.StartQuickSort();
            //MergeSortAlgorithm.StartMergeSort();
            //SearchAlgorithm.LinearSearch(arr, 7);
            Graph.MakeGraph();
            DijkstraAlgorithm.Shortestpath();
        }

        public static void sort()
        {
            int[] numbers = { 5, 2, 8, 3, 1, 9, 4, 6, 7 };
            Array.Sort(numbers);
            Console.WriteLine(string.Join(", ", numbers));

            // 문자열 리스트 정렬 예제
            List<string> names = new List<string> { "John", "Alice", "Bob", "Eve", "David" };
            names.Sort();
            Console.WriteLine(string.Join(", ", names));
        }


    }
}
