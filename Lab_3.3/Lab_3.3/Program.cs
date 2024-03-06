using System;
using System.Collections.Generic;

//Написати програму згідно отриманого завдання використовуючи лише LINQ методи. В кінці завдання в дужках наведена 
//підказка, які методи LINQ могли б вам допомогти у розв'язанні задачі
//Програма створює словник даних Dictionary продуктів харчування: ключ - товар, значення - ціна.
//Створити дві цінові групи: товари дорожче і дешевше 100 гривень (1) (3)
// First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault (поелементні операції)
// Count, Sum, Average, Max, Min, Aggregate (агрегування); • Range(генерування послідовностей).
//Select, SelectMany, Where
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        Dictionary<string, double> products = new Dictionary<string, double>()
        {
            { "Хліб", 25 },
            { "Молоко", 30 },
            { "Яйця", 20 },
            { "Сир", 80 },
            { "М'ясо", 150 },
            { "Сік", 40 },
            { "Печиво", 15 }
        };

        var expensiveProducts = products.Where(p => p.Value > 100);
        var cheapProducts = products.Where(p => p.Value <= 100);
        int expensiveCount = expensiveProducts.Count();
        Console.WriteLine($"Кількість дорогих товарів: {expensiveCount}");
        Console.WriteLine("Дорогі товари:");
        foreach (var product in expensiveProducts)
        {
            Console.WriteLine($"{product.Key}: {product.Value} грн");
        }
        int cheapCount = cheapProducts.Count();
        Console.WriteLine($"Кількість дешевих товарів: {cheapCount}");
        Console.WriteLine("Дешеві товари:");
        foreach (var product in cheapProducts)
        {
            Console.WriteLine($"{product.Key}: {product.Value} грн");
        }

    }
}