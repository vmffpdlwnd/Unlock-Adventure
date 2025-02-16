using System.Threading;

namespace UnlockAdventure.Core
{
    public class GameManager
    {
        private readonly SceneManager sceneManager;
        private readonly InputManager inputManager;
        private readonly TextManager textManager;
        private readonly AchievementManager achievementManager;

        public GameManager(SceneManager sceneManager, InputManager inputManager)
        {
            this.sceneManager = sceneManager;
            this.inputManager = inputManager;
            this.textManager = TextManager.Instance;
            this.achievementManager = AchievementManager.Instance;
        }

        public void Run()
        {
            while (true)
            {
                // 각 매니저들의 업데이트 순서 관리
                inputManager.HandleInput();     // 입력 처리
                sceneManager.Update();         // 씬 상태 업데이트
                Thread.Sleep(50);             // 프레임 제어
            }
        }
    }
}