using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unlock_Adventure.Scene;

namespace Unlock_Adventure.Core
{
    public class SceneManager
    {
        // 현재 씬을 추적하는 속성
        private IScene currentScene;
        // 현재 씬의 타입을 추적할 속성 추가
        public SceneType CurrentSceneType { get; private set; }
        // 씬 타입을 정의하는 열거형
        public enum SceneType
        {
            Intro,
            Town,
            FirstMap,
            // 기타 다른 씬들
        }
        // 씬을 변경하는 메서드
        public void ChangeScene(SceneType newSceneType)
        {
            CurrentSceneType = newSceneType;
            // 현재 씬 종료
            currentScene?.Exit();
            // 새 씬으로 전환
            currentScene = CreateScene(newSceneType);
            // 새 씬 시작
            currentScene.Enter();
        }
        // 씬 타입에 따라 적절한 씬 객체를 생성하는 메서드
        private IScene CreateScene(SceneType sceneType)
        {
            switch (sceneType)
            {
                case SceneType.Intro:
                    return new IntroScene();
                default:
                    // 다음 씬이 없으면 프로그램 종료
                    Environment.Exit(0);
                    return null;
            }
        }
        // 초기 씬 설정
        public void Initialize()
        {
            // 게임 시작 시 초기 씬 설정
            ChangeScene(SceneType.Intro);
        }
        // 현재 씬 업데이트 (게임 루프에서 호출)
        public void Update()
        {
            currentScene?.Update();
        }
    }
    // 모든 씬이 구현해야 할 인터페이스
    public interface IScene
    {
        void Enter();   // 씬에 진입할 때
        void Update();  // 씬의 매 프레임(또는 입력) 처리
        void Exit();    // 씬에서 나갈 때
    }
}
