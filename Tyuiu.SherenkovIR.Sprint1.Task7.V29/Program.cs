using Tyuiu.SherenkovIR.Sprint1.Task7.V29.Lib;
DataService ds =  new DataService();
Console.Title = "Спринт #1| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #1                                        *");
Console.WriteLine("* Тема: Добавление к решению итоговых              *");
Console.WriteLine("* проектов по спринту.                             *");
Console.WriteLine("* Задание #7                                       *");
Console.WriteLine("* Вариант #29                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу, которая вычисляет            *");
Console.WriteLine("* математическое выражение по исходным значениям   *");
Console.WriteLine("* данных, вводимых пользователем.                  *");

Console.WriteLine(" x - (Math.Cos(Math.Pow(x, 3)) / (x * y - 3))       ");
Console.WriteLine(" + (Math.Sin(Math.Pow(x, 5)) / (x * y + 5))         ");

Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

double x, y;

Console.WriteLine("Ведите значение X:");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ведите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

Console.WriteLine(ds.Calculate(x,y));
Console.ReadKey();
