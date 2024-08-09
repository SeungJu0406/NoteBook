namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10, [10, 1, 10]));
        }

        public static long solution(int n, int[] works)
        {
            //정렬 후 
            Array.Sort(works);
            //모든 배열값 합치고 n값으로 뺌
            int arrSum = works.Sum() - n;
            //뺀값을 배열 크기의 값으로 나눠서 몫과 나머지를 구함
            int size = works.Length;
            int[] result = new int[size];
            int index = 0;
            //결과 인덱스에 0번부터 몫만큼 대입
            while (true)
            {
                int share = arrSum / size;
                int remain = arrSum % size;
                //만약 앞의 배열값보다 몫이 더 크다면
                if (share >= works[index])
                {
                    int minNum = works[index];
                    //해당 원본 배열값만큼만 추가 후 나머지에 몫- 앞의 배열값 을 합함
                    for (int i = index; i < works.Length; i++)
                    {
                        remain += share - minNum;
                        result[i] += minNum;
                        // 그리고 index값을 1 증가하고 , size 값을 1 감소한다
                        if (result[i] == works[i])
                        {
                            index++;
                            size--;
                        }
                    }
                }
                //몫이 더작다면 몫만큼 추가
                else
                {
                    for (int i = index; i < works.Length; i++)
                    {
                        result[i] += share;
                    }
                }
                // 나머지가 현재 size보다 크면 완성되지 않은 원소 개수만큼 나눠서 몫과 나머지 구함
                if (remain > size)
                {
                    arrSum = remain;
                    continue;
                }
                // 나머지가 현재 size보다 작으면 나머지가 0이 될때까지 뒤에서부터 추가해서 넣음
                else
                {
                    for (int i = works.Length - 1; i > works.Length - 1 - remain; i--)
                    {
                        result[i]++;
                    }
                }
                break;
            }
            // 이후 모든 배열에 n*n 값을 해준뒤 합한 값을 리턴
            long answer = 0;
            for (int i = 0; i < result.Length; i++)
            {
                answer += result[i] * result[i];
            }
            return answer;
        }
    }
}

