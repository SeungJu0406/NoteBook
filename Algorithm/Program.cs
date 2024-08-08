using System.Collections;
using System.ComponentModel.Design;
using System.Text;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] test = { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } };
            solution(3, test);
        }
        public static int solution(int n, int[,] computers)
        {
            //리스트로 교체     
            List<int[]> computer = new List<int[]>();
            int result = 0;
            for(int i = 0; i < n; i++)
            {
                computer.Add(new int[n]);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    computer[i][j] = computers[i, j];
                }
            }
            for (int i = 0; i < computer.Count; i++)
            {
                computer[i][i] = 0;
            }
            //computers 리스트에 남은것이 없을때 까지 반복
            while (computer.Count > 0)
            {
                for (int i = 0; i < computer.Count; i++)
                {
                    //첫번째와 연결된것을 제거
                    if (computer[0][i] == 1)
                        computer.RemoveAt(i);
                }
                //첫번째 본인도 제거
                computer.RemoveAt(0);
                result++; // 반복전 결과값 1추가
            }
            return result;
        }

    }
}

