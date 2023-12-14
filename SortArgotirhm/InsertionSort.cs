using System;


namespace BasicAlgorithm
{
    public class InsertionSortAlgorith
    {
       
        public static void InsertionSort()
        {
            Console.WriteLine();
            Console.WriteLine("삽입정렬 : 정렬되지 않은 부분에서 요소를 가져와 정렬된 부분에 적절한 위치에 삽입");
            Console.WriteLine("시간복잡도: 평균 0(n), 최악 0(n ^ 2)");
            Console.WriteLine("공간복잡도 : 0(1)");
            Console.WriteLine();

            int[] arr = new int[] { 5, 2, 4, 6, 1, 3 };     //무작위 배열 설정 - 

            //배열의 2번째 숫자부터 배열 끝까지 반복 - 배열의 뒤쪽으로 하나씩 가면서 정렬된 앞쪽 숫자들 중 
            //본인보다 작은 숫자를 찾을때까지 반복 - 작은 숫자의 바로 뒷 자리에 본인이 들어가고 나머지 숫자들은 뒤로 한칸 밀어짐
            for (int i = 1; i < arr.Length; i++)       
            {
                int j = i - 1;           //바로 앞 숫자를 j로 설정       [맨 처음 값은 0]
                int key = arr[i];       //i번째 숫자를 key값으로 설정     [맨 처음 값은 ]

                while (j >= 0 && arr[j] > key)      //j가 0보다 크거나 같고 j번째 숫자가 키값보다 큰 경우 계속 반복 (배열 끝부터 배열 맨 앞 숫자까지 반복진행)
                {
                    arr[j + 1] = arr[j];            //j+1배열값에 j번 배열값을 저장 (배열을 뒤로 한칸 밀기)      [1번 배열에 5값을 저장]
                    j--;                            //j값 -1         [j값 1 감소하면서 while문 종료]
                }

                arr[j + 1] = key;                   //j+1배열값에 키 값을 저장       [0번 배열에 키 값인 2를 저장]
            }

            foreach (int num in arr)        
            {
                Console.Write($" {num}");
            }
            Console.WriteLine();


        }   

    }
}
