using System;
using UnlockAdventure.Data;

public class TextManager
{
    private static TextManager instance;
    public static TextManager Instance
    {
        get
        {
            if (instance == null)
                instance = new TextManager();
            return instance;
        }
    }

    public enum Language
    {
        Korean,
        English
    }

    private Language currentLanguage = Language.Korean;
    private int selectedIndex = 0;
    private readonly string[] languages = { "한국어", "English" };

    public void DecreaseLanguageSelection()
    {
        selectedIndex = Math.Max(0, selectedIndex - 1);
    }

    public void IncreaseLanguageSelection()
    {
        selectedIndex = Math.Min(languages.Length - 1, selectedIndex + 1);
    }

    public Language GetSelectedLanguage()
    {
        return selectedIndex == 0 ? Language.Korean : Language.English;
    }

    public void SetLanguage(Language language)
    {
        currentLanguage = language;
    }

    public string GetText(string key)
    {
        return GameData.GetText(key, currentLanguage);
    }

    public string[] GetLanguages() => languages;
    public int GetSelectedIndex() => selectedIndex;
}