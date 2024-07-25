namespace Additional
{
    public class Property
    {
        public static void Main11()
        {
            Player player = new Player();
            player.MP = 5;
            Console.WriteLine(player.MP);
            player.ap = 10;
            Console.WriteLine(player.ap);
        }
        public class Player
        {
            private int hp;
            public int GetHp() // 값을 읽기만 하는 함수
            {
                return hp;
            }
            private void SetHp(int hp) // 값을 수정만 하는 함수
            {
                this.hp = hp;
            }
            public int mp;
            public int MP
            {
                get { return mp; }
                set { mp = value; }
            }
            public int ap { get; set; }
            private float rate;
            public int TotalDamage => (int)(ap * (1 + rate));
        }

    }
}
