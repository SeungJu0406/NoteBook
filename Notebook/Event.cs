using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleGate
{
    public class Event
    {
        public static void Main()
        {
            Player player = new Player();
            UI ui = new UI();
            Sound sound = new Sound();
            player.Ondied += ui.GameOverUI;
            player.Ondied += sound.DeadSound;

            player.Die();
        }

        public class Player
        {
            public event Action Ondied;
            public void Die()
            {
                // 나 주거따!!
                Console.WriteLine("플레이어가 죽었습니다");
                // >>
                if(Ondied != null)
                {
                    Ondied(); // 일련이 사건이 발생했을떄 이벤트 발생
                }
                // 음악실행
                // 게임오버 UI
                // 등등 효과
            }
        }
        
        public class UI
        {
            public void GameOverUI()
            {
                Console.WriteLine("게임오버");
            }
        }
        public class Sound
        {
            public void DeadSound()
            {
                Console.WriteLine("슬픈 bgm");
            }
        }
    }
}
