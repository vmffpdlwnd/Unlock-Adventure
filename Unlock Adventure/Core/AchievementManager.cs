using System.Collections.Generic;
using System.Threading;
using System;

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

            // 업적 출력 처리
            Thread.Sleep(1500);  // 1.5초 대기
            Console.WriteLine($"\n[{TextManager.Instance.GetText("achieve.unlocked")}]");
            Console.WriteLine(TextManager.Instance.GetText($"achieve.{key}"));

            // 힌트 출력
            if (!string.IsNullOrEmpty(TextManager.Instance.GetText($"achieve.{key}.hint")))
            {
                Thread.Sleep(800);   // 0.8초 대기
                Console.WriteLine(TextManager.Instance.GetText($"achieve.{key}.hint"));
            }
        }
    }

    public bool Has(string key)
    {
        return achievements.Contains(key);
    }
}