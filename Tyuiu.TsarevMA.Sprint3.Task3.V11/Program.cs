using Tyuiu.TsarevMA.Sprint3.Task3.V11.Lib;
namespace Tyuiu.TsarevMA.Sprint3.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Царев М. А. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Царев М. А. | СМАРТб-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Используя цикл foreach заменить буквы q на цифру 7 в строке:             *");
            Console.WriteLine("* sqwreq vqwqq q                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "sqwreq vqwqq q";
            char chr = 'q';
            char rep = '7';

            Console.WriteLine("Исходная строка: " + str);
            Console.WriteLine("Заменяемый символ: " + chr);
            Console.WriteLine("Символ на замену: " + rep);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.ReplaceCharOnNum(str, chr, rep);

            Console.WriteLine("Результат: " + res);

            Console.ReadKey();
        }
    }
}
