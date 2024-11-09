using Tyuiu.CherkashinMM.Sprint4.Task0.V9.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task0.V9; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #4 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема: Массивы                                                        *"); 
        Console.WriteLine("* Задание #0                                                           *"); 
        Console.WriteLine("* Вариант #9                                                           *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный      *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму       *");
        Console.WriteLine("* четных элементов массива.                                            *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("* Массив: {4 ,6 ,2 ,8 ,4 ,5 ,6 ,9 ,8 ,7}                               *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");

        int[] arr = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

        DataService ds = new DataService();

        Console.WriteLine(ds.GetSumEvenArrEl(arr)); 
    } 
} 
