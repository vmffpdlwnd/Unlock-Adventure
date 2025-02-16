using System;
using UnlockAdventure.Core;

namespace UnlockAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 콘솔 환경 설정
            Console.Title = "Unlock Adventure";
            Console.CursorVisible = false;

            // 매니저 초기화
            var sceneManager = new SceneManager();
            var inputManager = new InputManager(sceneManager);
            var gameManager = new GameManager(sceneManager, inputManager);

            try
            {
                // 시작 씬 설정
                sceneManager.ChangeScene(SceneManager.SceneType.LanguageSelect);
                // 게임 실행
                gameManager.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}