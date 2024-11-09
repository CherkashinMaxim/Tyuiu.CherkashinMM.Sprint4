using Tyuiu.CherkashinMM.Sprint4.Task3.V14.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task3.V14.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();

        int[,] arr = { { 3, 2, 3, 3, 5 }, { 2, 3, 3, 7, 3 }, { 7, 5, 2, 7, 3 }, { 4, 2, 7, 5, 2 }, { 3, 5, 4, 2, 6 } };
        int exp = 7;

        Assert.AreEqual(exp, ds.Calculate(arr));
   } 
} 
