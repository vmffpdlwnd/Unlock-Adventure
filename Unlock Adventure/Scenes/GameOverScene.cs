using System;
using UnlockAdventure.Core;

namespace UnlockAdventure.Scenes
{
    public class GameOverScene : IScene
    {
        public void Enter()
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("================================");
            Console.WriteLine("   " + LanguageSystem.Instance.GetText("gameover.message"));
            Console.WriteLine("================================");
            Console.WriteLine("\n" + LanguageSystem.Instance.GetText("presskey"));
        }

        public void Update()
        {
            // 입력 처리는 InputSystem에서
        }

        public void Exit()
        {
            // 씬 전환시 내용 지우기
        }
    }
}