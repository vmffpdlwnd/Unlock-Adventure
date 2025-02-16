using System.Collections.Generic;
using System;
using UnlockAdventure.Core;

public class AchievementManager
{
    private static AchievementManager instance;
    public static AchievementManager Instance
    {
        get
        {
            if (instance == null)
                instance = new AchievementManager();
            return instance;
        }
    }

    private HashSet<string> achievements = new HashSet<string>();

    public void Unlock(string key)
    {
        if (!achievements.Contains(key))
        {
            achievements.Add(key);
            Console.WriteLine($"\n[{TextManager.Instance.GetText("achieve.unlocked")}]");
            Console.WriteLine(TextManager.Instance.GetText($"achieve.{key}"));
        }
    }

    public bool Has(string key)
    {
        return achievements.Contains(key);
    }
}