using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unlock_Adventure.Core;

namespace Unlock_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            // 각 매니저들 초기화
            SceneManager sceneManager = new SceneManager();
            InputSystem inputSystem = new InputSystem(sceneManager);
            GameManager gameManager = new GameManager(sceneManager, inputSystem);

            // 게임 시작
            sceneManager.ChangeScene(SceneManager.SceneType.Intro);
            gameManager.Run();
        }
    }
}
