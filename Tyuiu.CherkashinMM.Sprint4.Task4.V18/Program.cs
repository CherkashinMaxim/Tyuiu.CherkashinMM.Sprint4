using Tyuiu.CherkashinMM.Sprint4.Task4.V18.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task4.V18; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема: Массивы                                                        *"); 
        Console.WriteLine("* Задание #4                                                           *"); 
        Console.WriteLine("* Вариант #18                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный     *"); 
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 7.                       *"); 
        Console.WriteLine("* Заменить нечетные элементы массива на 0.                             *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите размер массива (NxN):"); 
        int n = int.Parse(Console.ReadLine()!); 
        
        int[,] arr = new int[n, n];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine($"Введите числа {i+1} строки:");
            for (int j = 0; j < arr.GetLength(1); j++)
                arr[i, j] = int.Parse(Console.ReadLine()!);
        }
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");

        int[,] res = ds.Calculate(arr);
        Console.WriteLine(res);
    } 
} 
