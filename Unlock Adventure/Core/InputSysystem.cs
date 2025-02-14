using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unlock_Adventure.Core
{
    public class InputSystem
    {
        SceneManager sceneManager;
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
