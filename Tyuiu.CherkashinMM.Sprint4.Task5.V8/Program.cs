using Tyuiu.CherkashinMM.Sprint4.Task5.V8.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task5.V8; 
 
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
        Console.WriteLine("* Задание #5                                                           *"); 
        Console.WriteLine("* Вариант #8                                                           *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный     *"); 
        Console.WriteLine("* случайными значениями в диапазоне от -3 до 4.                        *"); 
        Console.WriteLine("* Заменить отрицательные элементы на 0.                                *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите размер массива (NxN):"); 
        int n = int.Parse(Console.ReadLine()!);

        int[,] arr = new int[n, n];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
                arr[i, j] = rand.Next(-3, 4);
        }

        Console.WriteLine("Массив:");
        for (int i = 0;i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(0); j++)
            {
                Console.Write($"{arr[i, j]}, ");
            }
            Console.WriteLine();
        }
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************"); 
        
        int[,] res = ds.Calculate(arr);
        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(0); j++)
            {
                Console.Write($"{res[i, j]}, ");
            }
            Console.WriteLine();
        }
    } 
} 
