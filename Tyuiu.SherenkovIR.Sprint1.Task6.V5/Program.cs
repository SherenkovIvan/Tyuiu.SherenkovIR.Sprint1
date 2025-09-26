using Tyuiu.SherenkovIR.Sprint1.Task6.V5.Lib;
DataService ds =  new DataService();
Console.Title = "Спринт #1| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #1                                        *");
Console.WriteLine("* Тема: Работа со строками класс String            *");
Console.WriteLine("* Задание #6                                       *");
Console.WriteLine("* Вариант #5                                       *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу: пользователь вводит текст.   *");
Console.WriteLine("* Напечатать те слова, которые являются            *");
Console.WriteLine("* симметричными.                                   *");
Console.WriteLine("*                                                  *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

Console.WriteLine("Введите строку:");
string str  = Console.ReadLine();

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

Console.WriteLine(ds.CheckSymmetricalWords(str));
Console.ReadKey();


