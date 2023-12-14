using System;


namespace BasicAlgorithm
{
    public class SelectSortAlgorith
    {

        public static void SelectSort()
        {
            Console.WriteLine();
            Console.WriteLine("선택정렬 : 배열에서 가장 작은 원소를 찾아 맨 앞의 원소와 위치를 변경하는 알고리즘");
            Console.WriteLine("시간복잡도: 평균 0(n ^ 2), 최악 0(n ^ 2) / 공간복잡도 : 0(1)");
            Console.WriteLine();

            int[] arr = new int[] { 5, 2, 4, 6, 1, 3 };     //무작위 배열 설정

            for (int i = 0; i < arr.Length-1; i++)      //첫 번째 숫자부터 마지막 바로 전 숫자까지 반복(마지막 숫자는 비교대상이 없으므로 진행 x)
            {
                int minIndex = i;       // i번째 숫자를 최소값으로 설정

                for(int j= i+1; j < arr.Length; j++)        //i+1 번째 숫자부터 마지막 숫자까지 반복
                {
                    if (arr[j] < arr[minIndex])     //j번째 숫자가 i번째 숫자보다 작은 경우 최소값 배열 번호로 설정
                    {
                        minIndex = j;
                    }    
                }

                int temp = arr[i];          //최소값을 가진 배열 번호와 i번째 배열 반호를 바꿈
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;

            }

            foreach (int num in arr)        //정렬된 배열 출력
            {
                Console.Write($" {num}");
            }
            Console.WriteLine();

        }           

   

    }
}
