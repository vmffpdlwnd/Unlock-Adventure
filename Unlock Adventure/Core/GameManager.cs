using System;
using System.Threading;

namespace UnlockAdventure.Core
{
    public class GameManager
    {
        private readonly SceneManager sceneManager;
        private readonly InputSystem inputSystem;

        public GameManager(SceneManager sceneManager, InputSystem inputSystem)
        {
            this.sceneManager = sceneManager;
            this.inputSystem = inputSystem;
        }

        public void Run()
        {
            while (true)
            {
                sceneManager.Update();
                inputSystem.HandleInput();
                Thread.Sleep(50);
            }
        }
    }
}