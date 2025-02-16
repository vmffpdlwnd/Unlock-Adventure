using static UnlockAdventure.Core.SceneManager;
using System;
using UnlockAdventure.Data;

namespace UnlockAdventure.Core
{
    public class InputManager
    {
        private readonly SceneManager sceneManager;

        public InputManager(SceneManager sceneManager)
        {
            this.sceneManager = sceneManager;
        }

        public void HandleInput()
        {
            if (!Console.KeyAvailable) return;
            var key = Console.ReadKey(true);

            switch (sceneManager.CurrentSceneType)
            {
                case SceneType.LanguageSelect:
                    HandleLanguageSelectInput(key);
                    break;
                case SceneType.Intro:
                    HandleIntroInput(key);
                    break;
                case SceneType.GameOver:
                    HandleGameOverInput(key);
                    break;
            }
        }

        private void HandleLanguageSelectInput(ConsoleKeyInfo key)
        {
            var textManager = TextManager.Instance;
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    textManager.DecreaseLanguageSelection();
                    sceneManager.RefreshCurrentScene();
                    break;
                case ConsoleKey.DownArrow:
                    textManager.IncreaseLanguageSelection();
                    sceneManager.RefreshCurrentScene();
                    break;
                case ConsoleKey.Enter:
                    textManager.SetLanguage(textManager.GetSelectedLanguage());
                    sceneManager.ChangeScene(SceneType.Intro);
                    break;
            }
        }

        private void HandleIntroInput(ConsoleKeyInfo key)
        {
            sceneManager.ChangeScene(SceneType.GameOver);
        }

        private void HandleGameOverInput(ConsoleKeyInfo key)
        {
            Environment.Exit(0);
        }
    }
}