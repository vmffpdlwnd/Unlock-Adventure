using System;
using UnlockAdventure.Core;

namespace UnlockAdventure.Scenes
{
    public class IntroScene : IScene
    {
        public void Enter()
        {
            Console.WriteLine(@"
================================");
            Console.WriteLine("   " + LanguageSystem.Instance.GetText("intro.title"));
            Console.WriteLine("================================");
            Console.WriteLine(LanguageSystem.Instance.GetText("intro.opening"));
            Console.WriteLine(LanguageSystem.Instance.GetText("intro.start"));
            Console.WriteLine("\n" + LanguageSystem.Instance.GetText("intro.presskey"));
        }

        public void Update()
        {
            // 입력 대기는 InputSystem에서 처리
        }

        public void Exit()
        {
            // 씬 전환시 내용 지우기
        }
    }
}