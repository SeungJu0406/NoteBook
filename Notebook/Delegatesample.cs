namespace Notebook
{
    using System;

    namespace Delegate
    {
        public class Callback
        {
            /*******************************************************************************
             * 콜백함수
             * 
             * 델리게이트를 이용하여 특정조건에서 반응하는 함수를 구현
             * 함수의 호출(Call)이 아닌 역으로 호출받을 때 반응을 참조하여 역호출(Callback)
             *******************************************************************************/

            public static void Main11()
            {
                File file = new File();

                Button button = new Button();
                button.callback = file.Save; // button 인스턴스의 callback 델리게이트에 file.Save 함수 저장
                button.Click(); // button 인스턴스의 Click 함수: callback(델리게이트)에 저장된 함수 작동 -> file.Save 함수

                button.callback = file.Load;
                button.Click();

                Player player = new Player();
                button.callback = player.Jump;
                button.Click();
            }
            public class Player
            {
                public void Jump()
                {
                    Console.WriteLine("플레이어가 점프합니다!");
                }
            }
            public class Button
            {
                public Action callback; //callback 이라는 델리게이트 생성

                public void Click()
                {
                    callback();
                }
            }
            public class File
            {
                public void Save()
                {
                    Console.WriteLine("저장 합니다.");
                }

                public void Load()
                {
                    Console.WriteLine("불러오기 합니다.");
                }
            }
        }
    }

}
