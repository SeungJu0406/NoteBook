namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10, [10, 10,1]));
        }
        public static long solution(int n, int[] works)
        {
            //1.배열 역순 정렬
            Array.Sort(works);
            Array.Reverse(works);
            int nowIndex = 0;
            int nowValue = works[0];
            int nextIndex;
            int nextValue;
            //2. n값이 0이 될때까지 제거
            while (n > 0)
            {
                //2-1.가장 앞쪽부터 다음 숫자랑 같게하고 해당 숫자의 차 만큼 n값에서 제거
                //2-2.다음숫자가 같다면 그 다음 숫자와 비교 계속 내려감
                //2-3.마지막 숫자까지 왔다면 더이상 내려가지 않음            
                if (nowIndex + 1 == works.Length)
                { // 다음 인덱스가 없는가?
                    for (int i = 0; i <= nowIndex; i++)
                    {
                        works[i]--;
                        n--;
                        if (n == 0)
                            break;                       
                    }
                }
                else
                {
                    nextIndex = nowIndex + 1;
                    nextValue = works[nextIndex];
                    if (nowValue > nextValue)
                    {
                        for (int i = 0; i <= nowIndex; i++)
                        {
                            works[i]--;
                            nowValue--;
                            n--;
                            if (n == 0)
                                break;
                        }
                    }
                    else
                    {
                        nowIndex = nextIndex;
                        continue;
                    }
                }
            }
            long[] answer = new long[works.Length];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = Pow(works[i]);
            }
            return answer.Sum();
        }

        public static long Pow(int n)
        {
            if (n < 0)
                return 0;
            return n * n;
        }

    }
}

