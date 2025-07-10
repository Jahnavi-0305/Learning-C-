// Downcasting 
using System;

namespace PolymorphismBasics
{
  public class Employee
  {
    public virtual void MakeHRRequest()
    {
      Console.WriteLine("Employee makes an HR request.");
    }
  }

  public class Manager : Employee
  {
    public override void MakeHRRequest()
    {
      Console.WriteLine("Manager makes an HR request.");
    }
            
    public void MoveToOffice()
    {
      Console.WriteLine("Manager moves to office.");
    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      Employee myEmployeeManager = new Manager();
      // Downcasting
      Manager myManager = (Manager)myEmployeeManager;
      myManager.MoveToOffice();
    }
  }
}





