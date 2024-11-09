using Tyuiu.CherkashinMM.Sprint4.Task1.V9.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task1.V9; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService dataService = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема: Массивы                                                        *"); 
        Console.WriteLine("* Задание #1                                                           *"); 
        Console.WriteLine("* Вариант #9                                                           *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный      *"); 
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 8 подсчитать             *"); 
        Console.WriteLine("* произведение четных элементов массива.                               *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите количество элементов массива:"); 
        int len = int.Parse(Console.ReadLine()!);
        int[] arr = new int[len];

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine($"Введите {i} элемент:");
            arr[i] = int.Parse(Console.ReadLine()!);
        }
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine(dataService.Calculate(arr)); 
        Console.ReadKey();
    } 
} 
