using Tyuiu.TsarevMA.Sprint3.Task7.V7.Lib;
namespace Tyuiu.TsarevMA.Sprint3.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = cos(x) + cos(x)/(x+2) - 3x                                       *");
            Console.WriteLine("* Диапазон [-5; 5] с шагом 1. Проверка деления на ноль (при x = -2 -> 0).   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("********************************-------------------------------------------");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   F(x)   |");
            Console.WriteLine("+----------+----------+");

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);
            for (int i = 0; i < valueArray.Length; i++)
            {
                Console.WriteLine("| {0,8:d} | {1,8:f2} |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}