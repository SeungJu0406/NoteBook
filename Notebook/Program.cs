namespace Notebook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Dungeon dungeon = new Dungeon();
            Chest chest = new Chest();
            Door door = new Door();

            player.Open(door);
            player.Open(chest);
            player.Enter(door);
            player.Enter(dungeon);
        }

        public interface IEnterable
        {
            public void Enter();
        }
        public interface IOpenable
        {
            public void Open();
        }
        public class Dungeon : IEnterable
        {
            public Dungeon()
            {
            }

            public void Enter()
            {
                Console.WriteLine("던전에 입장합니다");
            }
        }
        public class Chest : IOpenable
        {
            public void Open()
            {
                Console.WriteLine("상자를 엽니다");
            }
        }
        public class Door : IOpenable, IEnterable
        {
            public void Open()
            {
                Console.WriteLine("문을 엽니다");
            }
            public void Enter()
            {
                Console.WriteLine("문으로 들어갑니다");
            }
        }
        public class Player
        {
            public void Enter(IEnterable enterable)
            {
                enterable.Enter();
            }
            public void Open(IOpenable openable)
            {
                openable.Open();
            }
        }
        public interface IMove()
        {
            void Move();
        }
        public class Monster : IMove
        {
            public void Move()
            {
                throw new NotImplementedException();
            }
        }
    }
}
