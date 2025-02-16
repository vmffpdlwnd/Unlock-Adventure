using System;
using UnlockAdventure.Core;

namespace UnlockAdventure.Scenes
{
    public class TestScene : IScene
    {
        public void Render()
        {
            var textManager = TextManager.Instance;

            // 테스트용 메시지 출력
            Console.WriteLine("\n====== TEST SCENE ======");
            Console.WriteLine("이곳은 테스트 씬입니다.");

            // 'realend' 업적이 달성되었는지 확인
            if (AchievementManager.Instance.Has("realend"))
            {
                Console.WriteLine("\n[업적 달성] 'realend' 업적이 달성되었습니다!");
            }
            else
            {
                Console.WriteLine("\n[업적 미달성] 'realend' 업적이 아직 달성되지 않았습니다.");
            }

            // 키 입력을 기다리며 게임을 종료하기 위한 안내
            Console.WriteLine("\n게임을 종료하려면 아무 키나 누르세요.");
        }
    }
}
