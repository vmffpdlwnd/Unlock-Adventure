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

            // 각 매니저들 초기화
            var sceneManager = new SceneManager();
            var inputSystem = new InputSystem(sceneManager);
            var gameManager = new GameManager(sceneManager, inputSystem);

            try
            {
                // 게임 시작
                sceneManager.ChangeScene(SceneManager.SceneType.LanguageSelect);
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