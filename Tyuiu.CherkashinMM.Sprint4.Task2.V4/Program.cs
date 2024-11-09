using Tyuiu.CherkashinMM.Sprint4.Task2.V4.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task2.V4; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Random rand = new Random();

        Console.Title = "Спринт #4 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема: Массивы                                                        *"); 
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #4                                                           *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный      *"); 
        Console.WriteLine("* случайными в диапазоне от 2 до 9 подсчитать сумму нечетных           *"); 
        Console.WriteLine("* элементов массива.                                                   *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Введите количество элементов массива:");
        int len = int.Parse(Console.ReadLine()!);
        int[] arr = new int[len];

        Console.WriteLine("Массив:");
        for (int i = 0; i < len; i++)
        {
            arr[i] = rand.Next(2, 9);
            Console.WriteLine(arr[i]);
        }

        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine(ds.Calculate(arr)); 
    } 
} 
