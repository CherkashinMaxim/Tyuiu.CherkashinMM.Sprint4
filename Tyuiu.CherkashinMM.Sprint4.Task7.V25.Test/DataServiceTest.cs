using Tyuiu.CherkashinMM.Sprint4.Task7.V25.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task7.V25.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();
        
        int rows = 4;
        int cols = 3;
        string value = "348561792486";
        int exp = 38;
        Assert.AreEqual(exp, ds.Calculate(rows, cols, value));
   } 
} 
