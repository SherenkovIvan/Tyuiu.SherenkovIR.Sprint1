using Tyuiu.SherenkovIR.Sprint1.Task5.V1.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #1| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #1                                        *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert       *");
Console.WriteLine("* Задание #5                                       *");
Console.WriteLine("* Вариант #1                                       *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу, которая следующую задачу     *");
Console.WriteLine("* Найти расстояние между двумя точками с заданными *");
Console.WriteLine("* координатами (x, y). Ответ привести к целому     *");
Console.WriteLine("* с помощью класса Convert.                        *");
Console.WriteLine("*                                                  *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

Console.WriteLine("Введите значение x1:");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y1:");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение x2:");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y2:");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
Console.WriteLine(res);

Console.ReadKey();
