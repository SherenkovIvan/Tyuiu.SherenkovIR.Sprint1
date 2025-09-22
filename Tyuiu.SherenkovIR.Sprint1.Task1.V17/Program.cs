using Tyuiu.SherenkovIR.Sprint1.Task1.V17.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #1| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #1                                        *");
Console.WriteLine("* Тема: Организация ввода и вывода в консольных    *");
Console.WriteLine("* приложениях.                                     *");
Console.WriteLine("* Задание #1                                       *");
Console.WriteLine("* Вариант #17                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу, которая запрашивает у        *");
Console.WriteLine("* пользователя исходные данные, вычисляет          *");
Console.WriteLine("* результат по формуле x * y * (5 - x) и печатает  *");
Console.WriteLine("* его на экране.                                   *");
Console.WriteLine("*                                                  *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
double x, y;
Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                         ");
Console.WriteLine("****************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadLine();


