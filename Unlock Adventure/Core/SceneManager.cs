using System;
using UnlockAdventure.Scenes;

namespace UnlockAdventure.Core
{
    public class SceneManager
    {
        private static SceneManager instance;
        public static SceneManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new SceneManager();
                return instance;
            }
        }

        private IScene currentScene; // 필드로 선언
        public IScene CurrentScene
        {
            get { return currentScene; }
            private set { currentScene = value; }
        }

        private SceneType currentSceneType;

        public SceneType CurrentSceneType 
        {
            get { return currentSceneType; }
            private set { currentSceneType = value; }
        }

        public enum SceneType
        {
            LanguageSelect,
            Intro,
            Town,
            FirstMap,
            GameOver,
        }

        public void ChangeScene(SceneType newSceneType)
        {
            Console.Clear();  
            currentSceneType = newSceneType;
            currentScene?.Exit();
            currentScene = CreateScene(newSceneType);
            currentScene.Enter();
        }

        private IScene CreateScene(SceneType sceneType)
        {
            switch (sceneType)
            {
                case SceneType.LanguageSelect:
                    return new LanguageSelectScene();
                case SceneType.Intro:
                    return new IntroScene();
                case SceneType.GameOver:  
                    return new GameOverScene();
                default:
                    Environment.Exit(0);
                    throw new Exception("Invalid scene type");
            }
        }

        public void Initialize()
        {
            ChangeScene(SceneType.Intro);
        }

        public void Update()
        {
            currentScene?.Update();
        }
    }

    public interface IScene  
    {
        void Enter();
        void Update();
        void Exit();
    }
}