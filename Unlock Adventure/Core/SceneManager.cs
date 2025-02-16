using System;
using UnlockAdventure.Scenes;

namespace UnlockAdventure.Core
{
    public class SceneManager
    {
        private IScene currentScene;
        public SceneType CurrentSceneType { get; private set; }

        public enum SceneType
        {
            Intro,
            Town,
            FirstMap,
        }

        public void ChangeScene(SceneType newSceneType)
        {
            CurrentSceneType = newSceneType;
            currentScene?.Exit();
            currentScene = CreateScene(newSceneType);
            currentScene.Enter();
        }

        private IScene CreateScene(SceneType sceneType)
        {
            switch (sceneType)
            {
                case SceneType.Intro:
                    return new IntroScene();
                default:
                    Environment.Exit(0);
                    return null;
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