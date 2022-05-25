﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace PasswordGenerator
{
    public class PasswordGenerator
    {
        private static string DefaultAlphabet { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string NonAlphanumerics { get; } = "~`'!@#$%^&*()_-+={}[]|\\:\";<,>.?/";
        private static string NumberChars { get; } = "0123456789";
        private static string SimilarChars { get; } = "iIl1Lo0O";
        private static string AmbiguousChars { get; } = "{}[]()/\\'\"`~,;:.<>";
        public static List<LoginPassword> LoadedPasswords { get; set; } = new List<LoginPassword>();

        public static int GetNextPasswordId()
        {
            if (LoadedPasswords.Count == 0)
            {
                return 0;
            }
            return LoadedPasswords.Max(x => x.Id) + 1;
        }

        private Random Random { get; set; }
        public int PasswordLength { get; set; }
        public bool UseNonAlphanumeric { get; set; }
        public bool UseNumbers { get; set; }
        public bool UseLowerCase { get; set; }
        public bool UseUpperCase { get; set; }
        public bool ExcludeSimilar { get; set; }
        public bool ExcludeAmbiguous { get; set; }

        public PasswordGenerator(Random random = null)
            => Random = random ?? new Random(Guid.NewGuid().GetHashCode());

        public string Generate()
        {
            List<char> charSearchList = new List<char>();
            if (UseUpperCase)
            {
                charSearchList.AddRange(DefaultAlphabet);
            }
            if (UseLowerCase)
            {
                charSearchList.AddRange(DefaultAlphabet.ToLower());
            }
            if (UseNonAlphanumeric)
            {
                charSearchList.AddRange(NonAlphanumerics);
                if (ExcludeAmbiguous)
                {
                    foreach (char excludeChar in AmbiguousChars)
                    {
                        charSearchList.Remove(excludeChar);
                    }
                }
            }
            if (UseNumbers)
            {
                charSearchList.AddRange(NumberChars);
            }
            if (ExcludeSimilar)
            {
                foreach(char excludeChar in SimilarChars)
                {
                    charSearchList.Remove(excludeChar);
                }
            }

            StringBuilder passwordBuilder = new StringBuilder();
            for (int i = 0; i < PasswordLength; i++)
            {
                passwordBuilder.Append(charSearchList[Random.Next(0, charSearchList.Count())]);
            }
            return passwordBuilder.ToString();
        }

        public void SaveJson()
        {
            try
            {
                File.WriteAllText("generatorInfo.json", JsonConvert.SerializeObject(this));
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения найтроек генератора!", "Ошибка");
            }
        }
    }
}
