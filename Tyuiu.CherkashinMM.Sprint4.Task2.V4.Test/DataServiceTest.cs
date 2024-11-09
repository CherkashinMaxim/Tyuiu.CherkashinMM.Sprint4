using Tyuiu.CherkashinMM.Sprint4.Task2.V4.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task2.V4.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService dataService = new DataService();

        int[] arr = { 1, 2, 3, 4, 5, 6, 6, 6, 6, 6, 6, 6, 6 };
        int exp = 9;

        Assert.AreEqual(exp, dataService.Calculate(arr));
   } 
} 
