using System;
using System.Collections.Generic;

namespace UnlockAdventure.Core
{
    public class AchieveSystem
    {
        private static AchieveSystem instance;
        public static AchieveSystem Instance
        {
            get
            {
                if (instance == null)
                    instance = new AchieveSystem();
                return instance;
            }
        }

        private HashSet<string> achieves;

        private AchieveSystem()
        {
            achieves = new HashSet<string>();
        }

        public void Unlock(string key)
        {
            if (!achieves.Contains(key))
            {
                achieves.Add(key);
                Console.WriteLine($"\n[{LanguageSystem.Instance.GetText("achieve.unlocked")}]");
                Console.WriteLine(LanguageSystem.Instance.GetText($"achieve.{key}"));
            }
        }

        public bool Has(string key)
        {
            return achieves.Contains(key);
        }
    }
}