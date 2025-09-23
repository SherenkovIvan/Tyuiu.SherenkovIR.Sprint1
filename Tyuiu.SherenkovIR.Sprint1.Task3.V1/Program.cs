using Tyuiu.SherenkovIR.Sprint1.Task3.V1.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #1                                        *");
Console.WriteLine("* Тема: Организация ввода и вывода в консольных    *");
Console.WriteLine("* приложениях.                                     *");
Console.WriteLine("* Задание #3                                       *");
Console.WriteLine("* Вариант #1                                     *");
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

double r = 1.4142;
double h = 1;
Console.WriteLine("Сторона H цилиндра = " + h);
Console.WriteLine("Сторона R цилиндра = " + r);

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

Console.WriteLine("ОбЪем цилиндра = " + ds.CylinderVolume(r, h));
Console.ReadKey();
