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

            var introTitle = new Dictionary<LanguageSystem.Language, string>();
            introTitle.Add(LanguageSystem.Language.Korean, "어둠 속에서 빛나는 화면...");
            introTitle.Add(LanguageSystem.Language.English, "A screen shining in darkness...");
            textData.Add("intro.title", introTitle);

            var introStart = new Dictionary<LanguageSystem.Language, string>();
            introStart.Add(LanguageSystem.Language.Korean, "새로운 시작이 당신을 기다립니다.");
            introStart.Add(LanguageSystem.Language.English, "A new beginning awaits you.");
            textData.Add("intro.start", introStart);

            var introPressKey = new Dictionary<LanguageSystem.Language, string>();
            introPressKey.Add(LanguageSystem.Language.Korean, "아무 키를 입력해 주세요");
            introPressKey.Add(LanguageSystem.Language.English, "Press any key to start");
            textData.Add("intro.presskey", introPressKey);
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