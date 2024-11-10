using Tyuiu.CherkashinMM.Sprint4.Task7.V25.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task7.V25; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема: Массивы                                                        *"); 
        Console.WriteLine("* Задание #7                                                           *"); 
        Console.WriteLine("* Вариант #25                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Дана строка из одноразрядных цифр. Преобразуйте ее в                 *"); 
        Console.WriteLine("* матрицу 4 на 3 и подсчитайте сумму четных чисел.                     *");  
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("* Cтрока из одноразрядных цифр: \"348561792486\"                       *"); 
        Console.WriteLine("************************************************************************");

        int n = 4;
        int m = 3;
        string value = "348561792486";

        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine(ds.Calculate(n, m, value)); 
    } 
} 
