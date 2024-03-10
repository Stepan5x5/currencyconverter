using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СurrencyСonverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollar, euro, ruble;
            Console.WriteLine("Введите количество рублей которые хотите конвертировать в другие валюты:");
            ruble = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество долларов которые хотите конвертировать в другие валюты:");
            dollar = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество евро которые хотите конвертировать в другие валюты:");
            euro = double.Parse(Console.ReadLine());
            //Рубли
            double dollarTorubleResult = (ruble / 90);
            double euroTorubleResult = (ruble / 95);
            //Доллары
            double rubleTodollarResult = (dollar * 90);
            double euroTodollarResult = (dollar * 0.75);
            //Евро
            double dollarToeuroResult = (euro * 1.25);
            double rubleToeuroResult = (euro * 95);

            Console.WriteLine("Конвертированные рубли:" + "В Доллары: " + dollarTorubleResult + " В Евро: " + euroTorubleResult);
            Console.WriteLine("Конвертированные доллары:" + "В Евро: " + euroTodollarResult + " В Рубли: " + rubleTodollarResult);
            Console.WriteLine("Конвертированные евро:" + "В Доллары: " + dollarToeuroResult + " В Рубли: " + rubleToeuroResult);
            Console.ReadLine();
        }
    }
}
