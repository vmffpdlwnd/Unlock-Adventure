using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unlock_Adventure.Core
{
    public class GameManager
    {
        private SceneManager sceneManager;
        private InputSystem inputSystem;

        public GameManager(SceneManager sceneManager, InputSystem inputSystem)
        {
            this.sceneManager = sceneManager;
            this.inputSystem = inputSystem;
        }

        public void Run()
        {
            // 게임 루프
            while (true)
            {
                // 현재 씬 업데이트 (한 번만)
                sceneManager.Update();

                // 입력 처리
                inputSystem.HandleInput();

                // 화면 깜박임 방지를 위해 약간의 대기 시간 추가
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
