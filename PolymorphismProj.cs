using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
  class Program
  {
    static void Main(string[] args)
    {
      //*********************************
      //******* Task 3 Test Code ********
      //*********************************
      Employee hrRep = new HR();

      hrRep.ClockIn();
      hrRep.Work();
      hrRep.SubmitDailyReport();
      Console.WriteLine(); //Line break
      //*********************************
      //******* Task 3 End **************
      //*********************************

      //*********************************
      //******* Task 5 Begin ************
      //*********************************
      Employee employee1 = new Engineer();
      employee1.SubmitDailyReport();
      Console.WriteLine();
      //*********************************
      //******* Task 5 End **************
      //*********************************

      //*********************************
      //******* Task 7 Begin ************
      //*********************************
      Employee employee2 = new Manager();
      Employee employee3 = new Intern();

      employee2.ClockIn();
      employee2.Work();
      employee2.SubmitDailyReport();
      Console.WriteLine();

      employee3.ClockIn();
      employee3.Work();
      employee3.SubmitDailyReport();
      Console.WriteLine();
      //*********************************
      //******* Task 7 End **************
      //*********************************

      //*********************************
      //******* Task 10 Begin ***********
      //*********************************
      Engineer engineer1 = employee1 as Engineer;
      if (engineer1 != null)
      {
        engineer1.SubmitDailyReport();
      }
      else
      {
        Console.WriteLine("Downcast failed.");
      }
      Console.WriteLine();
      //*********************************
      //******* Task 10 End *************
      //*********************************

      //*********************************
      //******* Task 11 Begin ***********
      //*********************************
      List<Employee> employees = new List<Employee>();
      employees.Add(employee1);
      employees.Add(employee2);
      employees.Add(employee3);
      employees.Add(hrRep);
      //*********************************
      //******* Task 11 End *************
      //*********************************

      //*********************************
      //******* Task 12 Begin ***********
      //*********************************
      foreach (Employee emp in employees)
      {
        emp.ClockIn();
        emp.Work();
        emp.SubmitDailyReport();
        Console.WriteLine();
      }
      //*********************************
      //******* Task 12 End *************
      //*********************************

      //*********************************
      //******* Task 13 Begin ***********
      //*********************************
      foreach (Employee emp in employees)
      {
        if (emp is Engineer)
        {
          Console.WriteLine("This is an Engineer.");
        }
        else if (emp is Intern)
        {
          Console.WriteLine("This is an Intern.");
        }
        else if (emp is Manager)
        {
          Console.WriteLine("This is a Manager.");
        }
        else if (emp is HR)
        {
          Console.WriteLine("This is an HR.");
        }
        Console.WriteLine();
      }
      //*********************************
      //******* Task 13 End *************
      //*********************************
    }
  }
}
