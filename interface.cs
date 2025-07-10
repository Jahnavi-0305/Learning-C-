/*

This is okay in C#! An interface says what a class must have. It does not say what a class must not have. A class in C# can even implement multiple 
Preview: Docs An interface is an abstract contract that defines methods and properties that must be implemented by any class that implements the interface.
interfaces
 by separating the interface names with a comma:

class Cat : IQuadruped, IFeline
{  
  // member implementation for both IQuadruped and IFeline
} 

*/

//Iautomobile.cs
using System;

namespace LearnInterfaces
{
  interface IAutomobile
  {
    string LicensePlate { get; }
    double Speed { get; }
    int Wheels { get; }
    void Honk();
  }
}


//Sedan.cs

using System;

namespace LearnInterfaces
{
  class Sedan : IAutomobile
  {
  	public string LicensePlate
    { get; }

    public double Speed
    { get; }

    public int Wheels
    { get; }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }
    
  }
}
