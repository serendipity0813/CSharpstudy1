using System;


namespace BasicAlgorithm
{
    public class QuickSortAlgorith
    {
        public static void StartQuickSort()
        {

            Console.WriteLine();
            Console.WriteLine("퀵정렬 : 피벗을 기준으로 작은 요소는 왼쪽, 큰 요소는 오른족으로 분할하고 이를 재귀적으로 정렬하는 방법 - 분할 정복 방법");
            Console.WriteLine("시간복잡도: 평균 0(n log n), 최악 0(n ^ 2)");
            Console.WriteLine("공간복잡도 : 평균 0(logn), 최악 : 0(n)");
            Console.WriteLine();

            int[] arr = new int[] { 5, 2, 4, 6, 1, 3 };     //무작위 배열 설정


            QuickSort(arr, 0, arr.Length - 1);      //퀵솔트 실행


            foreach (int num in arr)        //정렬된 배열 출력
            {
                Console.Write($" {num}");
            }
            Console.WriteLine();


        }


        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);

            }
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, right);

            return i + 1;
        }

        public static void Swap(int[] arr, int i, int j)        //기본적인 스왑 메소드
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


    }


}
