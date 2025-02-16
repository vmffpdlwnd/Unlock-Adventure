using System;
using UnlockAdventure.Scenes;
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
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);

                if (sceneManager.CurrentSceneType == SceneManager.SceneType.LanguageSelect)
                {
                    LanguageSystem.Instance.MoveSelection(key.Key);
                    sceneManager.ChangeScene(SceneManager.SceneType.LanguageSelect); // 화면 갱신

                    if (key.Key == ConsoleKey.Enter)
                        sceneManager.ChangeScene(SceneManager.SceneType.Intro);
                }
                else if (sceneManager.CurrentSceneType == SceneManager.SceneType.Intro)
                {
                    sceneManager.ChangeScene(SceneManager.SceneType.GameOver);
                }
                else if (sceneManager.CurrentSceneType == SceneManager.SceneType.GameOver)
                {
                    // 게임 종료
                    Environment.Exit(0);
                }
            }
        }
    }
}
