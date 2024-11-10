using Tyuiu.CherkashinMM.Sprint4.Task6.V26.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task6.V26; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Черкашин М. М. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема: Массивы                                                        *"); 
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #26                                                          *"); 
        Console.WriteLine("* Выполнил: Черкашин Максим Михайлович | ИИПб-24-1                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("* Дан строковый массив данных, используя класс Array, выведите         *"); 
        Console.WriteLine("* элементы массива, длина которых больше 5 символов.                   *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("* Массив: [\"Тюмень\", \"Тамбов\", \"Томск\", \"Омск\", \"Орёл\"]      *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        string[] arr = { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
        string[] res = ds.Calculate(arr);

        foreach (string s in res) Console.WriteLine(s);
    } 
} 
