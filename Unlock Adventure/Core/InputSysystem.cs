using System;
namespace UnlockAdventure.Core
{
    public class InputSystem
    {
        private readonly SceneManager sceneManager;
        public InputSystem(SceneManager sceneManager)
        {
            this.sceneManager = sceneManager;
        }

        public void HandleInput()
        {
            if (sceneManager.CurrentSceneType == SceneManager.SceneType.LanguageSelect)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    HandleLanguageSelect(key.Key);
                }
            }
            else if (sceneManager.CurrentSceneType == SceneManager.SceneType.Intro)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    sceneManager.ChangeScene(SceneManager.SceneType.FirstMap);
                }
            }
        }

        private void HandleLanguageSelect(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    // 현재 선택된 언어 변경
                    break;
                case ConsoleKey.DownArrow:
                    // 현재 선택된 언어 변경
                    break;
                case ConsoleKey.Enter:
                    sceneManager.ChangeScene(SceneManager.SceneType.Intro);
                    break;
            }
        }
    }
}