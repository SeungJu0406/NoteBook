namespace PriorityQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue queue = new PriorityQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(6);
            queue.Enqueue(4);
            queue.Enqueue(5);
            for (int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine((queue.queue[i]));
            }
            Console.WriteLine();
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            queue.Dequeue();


        }
    }
    //최대 힙 제작
    public class PriorityQueue
    {
        public int[] queue { get; private set; }
        public int Count;
        public int Capacity;
        public PriorityQueue()
        {
            Count = 0;
            Capacity = 1;
            queue = new int[2];
            // 인덱스 0은 사용 안할거임
        }
        public PriorityQueue(int capacity)
        {
            Count = 0;
            Capacity = capacity;
            queue = new int[capacity];
        }

        public void Enqueue(int value)
        {
            if (Count >= Capacity)
                Extend();
            //삽입하고 부모 노드와 비교해서 더 크면 교환
            queue[Count]=value;
            Count++;

            int now = Count - 1; // 교체 진행 할 원소 저장
            int parent = (now - 1) / 2;
            while (queue[now] > queue[parent])
            {
                if (queue[now] > queue[parent])
                {
                    // 조건에 맞으면 교환
                    int temp = queue[now];
                    queue[now] = queue[parent];
                    queue[parent] = temp;
                    now = parent; // 인덱스 교체
                }
            }
        }
        public int Dequeue()
        {
            if (Count <= 0)
                throw new IndexOutOfRangeException();
            int result = queue[0];
            queue[0] = queue[Count - 1]; // 마지막과 교체
            queue[Count - 1] = default(int);
            Count--;
            int now = 0; // 현재 인덱스
            while (now <= Count) //더 이상 내려갈 수 없을 때
            {
                int next = now; // next: 교체 할 자식노드 인덱스
                int left = next * 2 + 1;
                int right = next * 2 + 2;
                if (queue[now] <= queue[left])// 좌측 자식노드보다 작을때
                {
                    next = left; // 왼쪽 자식노드선택
                }
                else if (queue[now] <= queue[right])// 우측 자식노드보다 작을때
                {
                    next = right; // 오른쪽 자식노드 선택
                }
                else
                    break;
                int temp = queue[now];
                queue[now] = queue[next];
                queue[next] = temp;
                //현재 위치 갱신
                now = next;
            }
            return result;
        }
        public int Peek()
        {
            return queue[0];
        }

        private void Extend()
        {
            int[] newQueue = new int[Capacity * 2];
            for(int i = 0; i <Count; i++)
            {
                newQueue[i] = queue[i];
            }
            queue = newQueue;
            Capacity *= 2;
        }
    }
}