using Tyuiu.CherkashinMM.Sprint4.Task1.V9.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task1.V9.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();

        int[] arr = { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };
        int exp = 4608;
        Assert.AreEqual(exp, ds.Calculate(arr));
   } 
} 
