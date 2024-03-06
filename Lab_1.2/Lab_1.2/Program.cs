//Написати програму згідно отриманого завдання використовуючи словники Dictionary в C#. 
//Якщо результатом виконання програми є словник, зберегти цей результат у JSON файл
//Дано кілька словників з різними значеннями ключів цілих чисел. Вивести один словник, значення ключів якого складатимуть суму цих значень вхідних словників.

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {       //вхідні словники
        List<Dictionary<string, int>> inputDictionaries = new List<Dictionary<string, int>>
        {
            new Dictionary<string, int> { { "item1", 400 }, { "item2", 0 } },
            new Dictionary<string, int> { { "item1", 0 }, { "item2", 300 } },
            new Dictionary<string, int> { { "item1", 750 }, { "item2", 0 } }
        };

        Dictionary<string, int> resultDictionary = CalculateSum(inputDictionaries);
        Console.WriteLine("Результат:");
        foreach (var kvp in resultDictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        string jsonResult = JsonConvert.SerializeObject(resultDictionary);
        File.WriteAllText("result.json", jsonResult);
    }

    static Dictionary<string, int> CalculateSum(List<Dictionary<string, int>> dictionaries)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var d in dictionaries)
        {
            foreach (var c in d)
            {
                if (result.ContainsKey(c.Key))
                {
                    result[c.Key] += c.Value;
                }
                else
                {
                    result[c.Key] = c.Value;
                }
            }
        }

        return result;
    }
}