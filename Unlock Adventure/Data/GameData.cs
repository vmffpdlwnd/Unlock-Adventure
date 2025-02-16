using System.Collections.Generic;
using UnlockAdventure.Core;

namespace UnlockAdventure.Data
{
    public static class GameData
    {
        private static Dictionary<string, Dictionary<LanguageSystem.Language, string>> textData;
        private static Dictionary<string, Dictionary<LanguageSystem.Language, string>> achieveData;

        static GameData()
        {
            InitTextData();
            InitAchieveData();
            // 추후 InitQuestData(), InitItemData() 등 추가
        }

        private static void InitTextData()
        {
            textData = new Dictionary<string, Dictionary<LanguageSystem.Language, string>>();

            Add("intro.title", "Unlock Adventure", "Unlock Adventure");
            Add("intro.opening", "어둠 속에서 빛나는 화면...", "A screen shining in darkness...");
            Add("intro.start", "새로운 시작이 당신을 기다립니다.", "A new beginning awaits you.");
            Add("presskey", "계속하려면 아무 키나 누르세요...", "Press any key to continue...");
            Add("gameover.message", "플레이 해주셔서 감사합니다.", "Thanks for playing.");
        }

        private static void InitAchieveData()
        {
            achieveData = new Dictionary<string, Dictionary<LanguageSystem.Language, string>>();

            Add("achieve.unlocked", "업적 달성", "Achievement Unlocked", achieveData);
            Add("achieve.realend", "진짜... 끝?", "Really... The End?", achieveData);
            Add("achieve.hint", "힌트: 모든 끝은 새로운 시작이 될 수 있습니다...", "Hint: Every end can be a new beginning...", achieveData);
        }

        private static void Add(string key, string kr, string en, Dictionary<string, Dictionary<LanguageSystem.Language, string>> target = null)
        {
            target = target ?? textData;
            target[key] = new Dictionary<LanguageSystem.Language, string>
            {
                [LanguageSystem.Language.Korean] = kr,
                [LanguageSystem.Language.English] = en
            };
        }

        public static string GetText(string key, LanguageSystem.Language lang)
        {
            if (textData.TryGetValue(key, out var translations) &&
                translations.TryGetValue(lang, out var text))
                return text;
            return $"Missing text: {key}";
        }

        public static string GetAchieve(string key, LanguageSystem.Language lang)
        {
            if (achieveData.TryGetValue(key, out var translations) &&
                translations.TryGetValue(lang, out var text))
                return text;
            return $"Missing achievement: {key}";
        }
    }
}