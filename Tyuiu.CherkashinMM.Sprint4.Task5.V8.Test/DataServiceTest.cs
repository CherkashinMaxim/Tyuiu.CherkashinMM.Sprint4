using Tyuiu.CherkashinMM.Sprint4.Task5.V8.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task5.V8.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();

        int[,] arr = { { 1, 1, -1, 1, 1 }, { 1, 1, -1, -1, 1 }, { 1, -1, -1, -1, 1 }, { -1, 1, -1, 1, -1 }, { -1, -1, -1, -1, -1 } };
        int[,] exp = { { 1, 1, 0, 1, 1 }, { 1, 1, 0, 0, 1 }, { 1, 0, 0, 0, 1 }, { 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0 } };

        CollectionAssert.AreEqual(exp, ds.Calculate(arr));
    } 
} 
