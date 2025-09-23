using Tyuiu.SherenkovIR.Sprint1.Task2.V13.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #1                                        *");
Console.WriteLine("* Тема: Арифметические операторы в C#              *");
Console.WriteLine("* Задание #2                                       *");
Console.WriteLine("* Вариант #13                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу, которая запрашивает у        *");
Console.WriteLine("* пользователя исходные данные, выполняет          *");
Console.WriteLine("* указанные расчеты и печатает результат на экране *");
Console.WriteLine("*                                                  *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");
int x;
Console.WriteLine("Введите значение X:");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

Console.WriteLine("Расстояние в милях (вещественное число) =          *");
Console.WriteLine( + ds.ConvertMilesToKm                             (x));
