using System;
using UnlockAdventure.Core;

public class GameOverScene : IScene
{
    public void Render()
    {
        var textManager = TextManager.Instance;
        Console.WriteLine("\n");
        Console.WriteLine("================================");
        Console.WriteLine("   " + textManager.GetText("gameover.message"));
        Console.WriteLine("================================");
        Console.WriteLine("\n" + textManager.GetText("presskey"));

        // 업적 달성만 호출
        AchievementManager.Instance.Unlock("realend");
    }
}