using System.Data.SqlTypes;

namespace Notebook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Util.Monster orc1 = new Util.Monster("오크");
            Util.Monster orc2 = new Util.Monster("오크");
            if (Util.SameMonster(orc1, orc2)) 
            {
                Console.WriteLine("같은 몬스터입니다");
            }
            else
            {
                Console.WriteLine("다른 몬스터입니다");
            }
        }


    }
    public static class Util
    {
        public class Monster
        {
            public string name;
            public Monster(string name)
            {
                this.name = name;
            }
        }
        public static bool SameMonster<T>(T left, T right) where T : Monster
        {
            return left.name == right.name;
        }

    }
}
