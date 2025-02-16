// Core/LanguageSystem.cs
using System;
using System.Collections.Generic;
using UnlockAdventure.Data;

namespace UnlockAdventure.Core
{
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

        public enum Language
        {
            Korean,
            English
        }

        public string GetText(string key)
        {
            return TextData.GetText(key, currentLanguage);
        }

        public void ChangeLanguage(Language language)
        {
            currentLanguage = language;
        }
    }
}