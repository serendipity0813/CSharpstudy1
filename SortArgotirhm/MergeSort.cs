using System;


namespace BasicAlgorithm
{
    public class MergeSortAlgorithm
    {
        public static void StartMergeSort()
        {
            Console.WriteLine();
            Console.WriteLine("병합정렬 : 배열을 반으로 나누고, 각 부분을 재귀적으로 정렬한 후 병합하는 방법 - 분할 정복 방법");
            Console.WriteLine("시간복잡도: 모든 경우에 대해 0(n log n)");
            Console.WriteLine("공간복잡도 : 0(n) - 정렬을 위한 임시 배열");
            Console.WriteLine();

            int[] arr = new int[] { 5, 2, 4, 6, 1, 3 };     //무작위 배열 설정


            MergeSort(arr, 0, arr.Length - 1);      //배열, 번호 맨 왼쪽 번호, 가장 오른쪽 번호를 매개변수로 하여 정렬 실행

            foreach (int num in arr)        //정렬된 배열 출력
            {
                Console.Write($" {num}");
            }
            Console.WriteLine();

        }
        public static void MergeSort(int[] arr, int left, int right)        //편의를 위해 배열 번호 = 번호, 배열 값 = 값이라고 작성
        {
            if (left < right)       //왼쪽 번호가 오른쪽 번호보다 작은 경우
            {
                int mid = (left + right) / 2;       //두 숫자를 더한 후 2로 나눠서 중간값 설정

                MergeSort(arr, left, mid);          //배열, 왼쪽 번호, 중간 번호로 정렬 실행
                MergeSort(arr, mid + 1, right);     //배열, 중간+1 번호, 오른쪽 번호로 정렬 실행
                Merge(arr, left, mid, right);       //배열, 좌측 번호, 중간 번호, 우측 번호로 merge실행
            }
        }

        public static void Merge(int[] arr, int left, int mid, int right)       //배열을 계속 2등분 하여 조각조각으로 나눈 후 정렬하고 병합
        {
            int[] temp = new int[arr.Length];   //정렬을 위한 임시 배열 생성

            int i = left;       //좌측 번호 저장
            int j = mid + 1;        //중간+1 번호 저장
            int k = left;       //좌측 번호 저장

            while (i <= mid && j <= right)      //i값이 중간 번호 보다 작고 j값이 오른쪽 번호보다 작으면 실행
            {
                if (arr[i] <= arr[j])           //i번째 값이 j번째 값보다 작으면
                {
                    temp[k++] = arr[i++];       
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }

            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            while (j <= right)
            {
                temp[k++] = arr[j++];
            }

            for (int l = left; l <= right; l++)
            {
                arr[l] = temp[l];
            }
        }

    
    }
}
