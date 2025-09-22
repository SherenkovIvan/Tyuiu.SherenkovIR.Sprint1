using Tyuiu.SherenkovIR.Sprint1.Task0.V5.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #1| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
    // Длинна строки 75 символов
    Console.WriteLine("****************************************************");
    Console.WriteLine("* Спринт #1                                        *");
    Console.WriteLine("* Тема: Базовые навыки работы в C#    *");
    Console.WriteLine("* Задание #0                                       *");
    Console.WriteLine("* Вариант #5                                       *");
    Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
    Console.WriteLine("****************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                         *");
    Console.WriteLine("* Написать программу, которая вычисляет выражение  *");
    Console.WriteLine("* (1 + 2) * (1 + 9 / 3) и печатает результат на    *");
    Console.WriteLine("* экране.                                          *");
    Console.WriteLine("*                                                  *");
    Console.WriteLine("****************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
    Console.WriteLine("****************************************************");
    Console.WriteLine("* (1 + 2) * (1 + 9 / 3)                            *");
    Console.WriteLine("****************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
    Console.WriteLine("****************************************************");

    Console.WriteLine(ds.Calculate());

    Console.ReadLine();

}