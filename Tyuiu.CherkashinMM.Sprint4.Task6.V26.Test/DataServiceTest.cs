using Tyuiu.CherkashinMM.Sprint4.Task6.V26.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint4.Task6.V26.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();

        string[] arr = { "������", "������", "�����", "����", "���" };
        string[] exp = { "������", "������" };

        CollectionAssert.AreEqual(exp, ds.Calculate(arr));
   } 
} 
