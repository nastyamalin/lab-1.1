//Написати програму згідно отриманого завдання використовуючи колекції C#.
//    Заданий файл з текстом англійською мовою. Виділити всі різні слова. Слова, що відрізняються тільки регістром літер, вважати однаковими.
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText("lab(1.1).txt");
        string[] wordsArray = text.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' });
        Dictionary<string, int> Words = new Dictionary<string, int>();

        foreach (string word in wordsArray)
        {
            string R_Word = word.ToLower(); 
            if (Words.ContainsKey(R_Word))
            {
                Words[R_Word]++;
            }
            else
            {
                Words[R_Word] = 1;
            }
        }

        foreach (var count in Words)
        {
            if (count.Value == 1)
            {
                Console.WriteLine(count.Key);
            }
        }
    }
}