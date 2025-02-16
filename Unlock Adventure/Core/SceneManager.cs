using System;
using System.Collections.Generic;

namespace UnlockAdventure.Core
{
    public class SceneManager
    {
        public enum SceneType
        {
            LanguageSelect,
            Intro,
            GameOver
        }

        private SceneType currentSceneType;
        public SceneType CurrentSceneType => currentSceneType;

        private readonly Dictionary<SceneType, IScene> scenes;

        public SceneManager()
        {
            scenes = new Dictionary<SceneType, IScene>
            {
                [SceneType.LanguageSelect] = new LanguageSelectScene(),
                [SceneType.Intro] = new IntroScene(),
                [SceneType.GameOver] = new GameOverScene()
            };
        }

        public void ChangeScene(SceneType newScene)
        {
            Console.Clear();
            currentSceneType = newScene;
            scenes[currentSceneType].Render();
        }

        public void RefreshCurrentScene()
        {
            Console.Clear();
            scenes[currentSceneType].Render();
        }

        public void Update()
        {
            // 현재는 필요한 기능이 없지만,
            // 씬 상태 업데이트가 필요할 경우를 위해 메서드는 유지
        }
    }
    public interface IScene
    {
        void Render();
    }
}