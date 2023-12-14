using System;
using System.Collections.Generic;

namespace BasicAlgorithm
{
    internal class SearchAlgorithm
    {

        public static int LinearSearch(int[] arr, int target)
        {
            Console.WriteLine("선형 탐색은 가장 단순한 탐색 알고리즘입니다.");
            Console.WriteLine("배열의 각 요소를 하나씩 차례대로 검사하여 원하는 항목을 찾습니다.");


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    Console.WriteLine("target : {0} 은 배열의 {1}번째 숫자입니다.", target, i);
                    return i;
                }
            }

            return -1;
        }

        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }








    }
}
