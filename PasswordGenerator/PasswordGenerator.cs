using Newtonsoft.Json;
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

        private List<char> GetListOfPermittedSymbols()
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
            }
            if (UseNumbers)
            {
                charSearchList.AddRange(NumberChars);
            }
            if (ExcludeSimilar)
            {
                foreach (char excludeChar in SimilarChars)
                {
                    charSearchList.Remove(excludeChar);
                }
            }
            if (ExcludeAmbiguous)
            {
                foreach (char excludeChar in AmbiguousChars)
                {
                    charSearchList.Remove(excludeChar);
                }
            }
            return charSearchList;
        }

        public string Generate()
        {
            if (!(UseLowerCase || UseNonAlphanumeric || UseNumbers || UseUpperCase))
            {
                return string.Empty;
            }
            List<char> searchList = GetListOfPermittedSymbols();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < PasswordLength; i++)
            {
                builder.Append(searchList[Random.Next(0, searchList.Count())]);
            }

            string analyzeString = builder.ToString();
            //Определяем разрешённые для вставки символы
            string permittedUpperCase = DefaultAlphabet;
            string permittedLowerCase = DefaultAlphabet.ToLower();
            string permittedNumbers = NumberChars;
            string permittedSymbols = NonAlphanumerics;
            if (ExcludeSimilar)
            {
                foreach (char excludeChar in SimilarChars)
                {
                    permittedUpperCase = permittedUpperCase.Replace(excludeChar.ToString(), "");
                    permittedLowerCase = permittedLowerCase.Replace(excludeChar.ToString(), "");
                    permittedNumbers = permittedNumbers.Replace(excludeChar.ToString(), "");
                }
            }
            if (ExcludeAmbiguous)
            {
                foreach (char excludeChar in AmbiguousChars)
                {
                    permittedSymbols = permittedSymbols.Replace(excludeChar.ToString(), "");
                }
            }
            //Определяем, надо ли производить дополнительные изменения
            bool upperCaseNotUsed = UseUpperCase && !builder.ToString().Any(x => permittedUpperCase.Contains(x));
            bool lowerCaseNotUsed = UseLowerCase && !builder.ToString().Any(x => permittedLowerCase.Contains(x));
            bool numbersNotUsed = UseNumbers && !builder.ToString().Any(x => permittedNumbers.Contains(x));
            bool symbolsNotUsed = UseNonAlphanumeric && !builder.ToString().Any(x => permittedSymbols.Contains(x));
            if (upperCaseNotUsed || lowerCaseNotUsed || numbersNotUsed || symbolsNotUsed)
            {
                //Определяем список позиций в строке, заместо которых будем вставлять
                bool upperFound = false;
                bool lowerFound = false;
                bool numberFound = false;
                bool symbolFound = false;
                List<int> possiblePositions = new List<int>();
                for (int i = 0; i < builder.Length; i++)
                {
                    if (!upperFound && UseUpperCase && permittedUpperCase.Contains(analyzeString[i]))
                    {
                        upperFound = true;
                        continue;
                    }
                    if (!lowerFound && UseLowerCase && permittedLowerCase.Contains(analyzeString[i]))
                    {
                        lowerFound = true;
                        continue;
                    }
                    if (!numberFound && UseNumbers && permittedNumbers.Contains(analyzeString[i]))
                    {
                        numberFound = true;
                        continue;
                    }
                    if (!symbolFound && UseNonAlphanumeric && permittedSymbols.Contains(analyzeString[i]))
                    {
                        symbolFound = true;
                        continue;
                    }
                    possiblePositions.Add(i);
                }

                int replacePosition = 0; //Переменная для замены позиций, которую далее будем использовать
                //Если надо вставить Верхний регистр
                if (upperCaseNotUsed)
                {
                    replacePosition = possiblePositions[Random.Next(0, possiblePositions.Count)];
                    possiblePositions.Remove(replacePosition);
                    builder.Remove(replacePosition, 1);
                    builder.Insert(replacePosition, permittedUpperCase[Random.Next(0, permittedLowerCase.Length)]);
                }
                //Если надо вставить нижний регистр
                if (lowerCaseNotUsed)
                {
                    replacePosition = possiblePositions[Random.Next(0, possiblePositions.Count)];
                    possiblePositions.Remove(replacePosition);
                    builder.Remove(replacePosition, 1);
                    builder.Insert(replacePosition, permittedLowerCase[Random.Next(0, permittedLowerCase.Length)]);
                }
                //Если надо вставить цифру
                if (numbersNotUsed)
                {
                    replacePosition = possiblePositions[Random.Next(0, possiblePositions.Count)];
                    possiblePositions.Remove(replacePosition);
                    builder.Remove(replacePosition, 1);
                    builder.Insert(replacePosition, permittedNumbers[Random.Next(0, permittedNumbers.Length)]);
                }
                //Если надо вставить символ
                if (symbolsNotUsed)
                {
                    replacePosition = possiblePositions[Random.Next(0, possiblePositions.Count)];
                    possiblePositions.Remove(replacePosition);
                    builder.Remove(replacePosition, 1);
                    builder.Insert(replacePosition, permittedSymbols[Random.Next(0, permittedSymbols.Length)]);
                }
            }

            return builder.ToString();
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
