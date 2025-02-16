using System;
using UnlockAdventure.Core;

namespace UnlockAdventure.Scenes
{
    public class LanguageSelectScene : IScene
    {
        private readonly string[] languages = { "한국어", "English" };
        private int selectedIndex = 0;

        public void Enter()
        {
            DrawLanguageSelect();
        }

        private void HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex = Math.Max(0, selectedIndex - 1);
                    DrawLanguageSelect();
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex = Math.Min(languages.Length - 1, selectedIndex + 1);
                    DrawLanguageSelect();
                    break;
                case ConsoleKey.Enter:
                    SelectLanguage();
                    break;
            }
        }

        private void DrawLanguageSelect()
        {
            Console.Clear();
            Console.WriteLine("\n\n   Select Language / 언어 선택\n");
            
            for (int i = 0; i < languages.Length; i++)
            {
                if (i == selectedIndex)
                    Console.Write(" > ");
                else
                    Console.Write("   ");
                
                Console.WriteLine(languages[i]);
            }
        }

        private void SelectLanguage()
        {
            LanguageSystem.Instance.ChangeLanguage(selectedIndex == 0 ? 
                LanguageSystem.Language.Korean : 
                LanguageSystem.Language.English);

            SceneManager.Instance.ChangeScene(SceneManager.SceneType.Intro);
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