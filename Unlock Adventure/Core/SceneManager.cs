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

        private IScene currentScene;
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