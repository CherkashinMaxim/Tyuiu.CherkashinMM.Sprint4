using Tyuiu.CherkashinMM.Sprint4.Task0.V9.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task0.V9.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();

        int[] arr = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
        int exp = 38;

        Assert.AreEqual(exp, ds.GetSumEvenArrEl(arr));
   } 
} 
