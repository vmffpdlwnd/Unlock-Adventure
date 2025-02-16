using System;
using UnlockAdventure.Data;

public class LanguageSystem
{
    private static LanguageSystem instance;
    public static LanguageSystem Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new LanguageSystem();
            }
            return instance;
        }
    }

    private Language currentLanguage = Language.Korean;
    private int selectedIndex = 0;
    private readonly string[] languages = { "한국어", "English" };

    public enum Language
    {
        Korean,
        English
    }

    public string GetText(string key)
    {
        return GameData.GetText(key, currentLanguage);
    }
    public void ChangeLanguage(Language language)
    {
        currentLanguage = language;
    }

    public void MoveSelection(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
                selectedIndex = Math.Max(0, selectedIndex - 1);
                break;
            case ConsoleKey.DownArrow:
                selectedIndex = Math.Min(languages.Length - 1, selectedIndex + 1);
                break;
            case ConsoleKey.Enter:
                ChangeLanguage(selectedIndex == 0 ? Language.Korean : Language.English);
                break;
        }
    }

    public string[] GetLanguages() => languages;
    public int GetSelectedIndex() => selectedIndex;
}