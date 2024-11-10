using Tyuiu.CherkashinMM.Sprint4.Task4.V18.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task4.V18.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();

        int[,] arr = { { 4, 7, 4, 5, 4 }, { 4, 4, 5, 6, 7 }, { 7, 5, 6, 6, 6 }, { 6, 7, 6, 6, 4 }, { 5, 6, 6, 6, 5 } };
        int[,] exp = { { 4, 0, 4, 0, 4 }, { 4, 4, 0, 6, 0 }, { 0, 0, 6, 6, 6 }, { 6, 0, 6, 6, 4 }, { 0, 6, 6, 6, 0 } };

        CollectionAssert.AreEqual(exp, ds.Calculate(arr));
    } 
} 
