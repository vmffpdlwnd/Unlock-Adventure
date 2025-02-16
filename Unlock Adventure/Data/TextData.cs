// Data/TextData.cs
using System.Collections.Generic;
using UnlockAdventure.Core;

namespace UnlockAdventure.Data
{
    public static class TextData
    {
        private static readonly Dictionary<string, Dictionary<LanguageSystem.Language, string>> textData;

        static TextData()
        {
            textData = new Dictionary<string, Dictionary<LanguageSystem.Language, string>>();

            var title = new Dictionary<LanguageSystem.Language, string>();
            title.Add(LanguageSystem.Language.Korean, "Unlock Adventure");
            title.Add(LanguageSystem.Language.English, "Unlock Adventure");
            textData.Add("intro.title", title);

            var opening = new Dictionary<LanguageSystem.Language, string>();
            opening.Add(LanguageSystem.Language.Korean, "어둠 속에서 빛나는 화면...");
            opening.Add(LanguageSystem.Language.English, "A screen shining in darkness...");
            textData.Add("intro.opening", opening);

            var start = new Dictionary<LanguageSystem.Language, string>();
            start.Add(LanguageSystem.Language.Korean, "새로운 시작이 당신을 기다립니다.");
            start.Add(LanguageSystem.Language.English, "A new beginning awaits you.");
            textData.Add("intro.start", start);

            var pressKey = new Dictionary<LanguageSystem.Language, string>();
            pressKey.Add(LanguageSystem.Language.Korean, "아무 키나 눌러 시작하세요...");
            pressKey.Add(LanguageSystem.Language.English, "Press any key to start...");
            textData.Add("intro.presskey", pressKey);

            var gameoverMessage = new Dictionary<LanguageSystem.Language, string>();
            gameoverMessage.Add(LanguageSystem.Language.Korean, "플레이 해주셔서 감사합니다.");
            gameoverMessage.Add(LanguageSystem.Language.English, "Thanks for playing.");
            textData.Add("gameover.message", gameoverMessage);
        }

        public static string GetText(string key, LanguageSystem.Language language)
        {
            Dictionary<LanguageSystem.Language, string> translations;
            string text;
            
            if (textData.TryGetValue(key, out translations) && 
                translations.TryGetValue(language, out text))
            {
                return text;
            }
            return string.Format("Missing text: {0}", key);
        }
    }
}