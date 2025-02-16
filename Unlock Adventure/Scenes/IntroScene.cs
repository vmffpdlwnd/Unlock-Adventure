using System;
using UnlockAdventure.Core;

public class IntroScene : IScene
{
    public void Render()
    {
        var textManager = TextManager.Instance;
        Console.WriteLine("================================");
        Console.WriteLine("   " + textManager.GetText("intro.title"));
        Console.WriteLine("================================");
        Console.WriteLine(textManager.GetText("intro.opening"));
        Console.WriteLine(textManager.GetText("intro.start"));
        Console.WriteLine("\n" + textManager.GetText("presskey"));
    }
}