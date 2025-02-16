using System;
using UnlockAdventure.Core;

public class LanguageSelectScene : IScene
{
    public void Enter()
    {
        Console.Clear();
        Console.WriteLine("\n\n   Select Language / 언어 선택\n");

        string[] languages = LanguageSystem.Instance.GetLanguages();
        int selectedIndex = LanguageSystem.Instance.GetSelectedIndex();

        for (int i = 0; i < languages.Length; i++)
        {
            Console.Write(i == selectedIndex ? " > " : "   ");
            Console.WriteLine(languages[i]);
        }
    }

    public void Update()
    {
        // 입력 대기는 InputSystem에서 처리
    }
    public void Exit()
    {
        // 씬 전환시 내용 지우기
    }
}