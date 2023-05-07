using System;
using System.Collections.Generic;

namespace Homework_number_33
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "Exit";

            Dictionary<string, string> wordMeaning = new Dictionary<string, string>();
            bool isExit = false;
            string userInput;

            wordMeaning = FillDictionary(wordMeaning);

            Console.WriteLine("Для получения значения слов напишите слово и нажмите ентр \n" +
                              $"Для выхода напишите команду {CommandExit}");

            while (isExit == false)
            {
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandExit:
                        isExit = true;
                        break;

                    default:
                        DrawValues(wordMeaning, userInput);
                        break;
                }
            }
        }

        private static void DrawValues(Dictionary<string, string> wordMeaning, string key)
        {
            if (wordMeaning.ContainsKey(key.ToLower()))
            {
                Console.WriteLine($"Ответ на ваш запрос: {wordMeaning[key]}");
            }
            else
            {
                Console.WriteLine($"К сожалению у нас в базе нет ответа на ваш запрос:");
            }
        }

        private static Dictionary<string, string> FillDictionary(Dictionary<string, string> wordMeaning)
        {
            wordMeaning.Add("кринж", "Так или иначе, кринж — это нечто жуткое, отвратительное, то, что способно вызывать даже негативные эмоции, не оставляя равнодушными.");
            wordMeaning.Add("абьюзер", "Абьюзер – человек, который совершает насилие над своей жертвой. Им может оказаться кто угодно: близкий родственник, коллега на работе, друг. Как правило, насильник хорошо разбирается в людях и знает, как на них воздействовать, подавлять. Попасть в токсичные отношения просто, а выбраться бывает крайне тяжело.");
            wordMeaning.Add("вкус", "Одно из пяти внешних чувств, органом которого служит слизистая оболочка рта.");
            wordMeaning.Add("мир", "Совокупность всех форм материи в земном и космическом пространстве, вселенная.");

            return wordMeaning;
        }
    }
}
