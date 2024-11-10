using tyuiu.cources.programming.interfaces.Sprint4; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task6.V26.Lib;

public class DataService : ISprint4Task6V26
{
    public string[] Calculate(string[] array)
    {
        int count = array.Count(s => s.Length > 5);

        string[] res = new string[count];
        int i = 0;
        foreach (var item in array)
        {
            if (item.Length > 5)
            {
                res[i++] = item;
            }
        }
        return res;
    }
} 
