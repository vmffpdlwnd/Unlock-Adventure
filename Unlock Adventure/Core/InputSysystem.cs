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
            if (sceneManager.CurrentSceneType == SceneManager.SceneType.Intro)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    sceneManager.ChangeScene(SceneManager.SceneType.FirstMap);
                }
            }
        }
    }
}