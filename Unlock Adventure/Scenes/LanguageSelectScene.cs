using System;
using UnlockAdventure.Core;

public class LanguageSelectScene : IScene
{
    public void Render()
    {
        Console.WriteLine("\n   Select Language / 언어 선택\n");

        string[] languages = TextManager.Instance.GetLanguages();
        int selectedIndex = TextManager.Instance.GetSelectedIndex();

        for (int i = 0; i < languages.Length; i++)
        {
            Console.Write(i == selectedIndex ? " > " : "   ");
            Console.WriteLine(languages[i]);
        }
    }
}