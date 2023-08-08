using System;

namespace Mine
{
  class Program
  {
    static void Main(string[] args)
    {
     int a = 2;
     int b = 2;
     int c = a + b;
    //  int myInt = 10;
      string txt = "Agust pliz  b nice ";

      Console.WriteLine(txt.ToUpper());

    //   Console.WriteLine(Convert.ToString(myInt));

      Console.WriteLine("Mine"); 

      Console.WriteLine( c );  
      //Conditional statements
      int o = 200;
      int k = 178;
      if (o> k) 
      {
      Console.WriteLine("x is greater than y");
      }

      int age = 3;
      if (age< 2)
      {
        Console.WriteLine("Ryna is Old");
    
      }
      else
      {
        Console.WriteLine("Ryna is young ");
      }

   //Switch statements
//     int color =  5;
//     switch (color);
//    {
//      case 1 :
//       Console.WriteLine("yellow");
//       break;
//     case 2 :
//       Console.WriteLine("pitch");
//     break;
//     case 3 :
//        Console.WriteLine("red");
//        break;
//     case 4 :
//     Console.WriteLine("black");
//       break;
//     case 5 :
//      Console.WriteLine("tebder");
//        break ; 
//     }

  

int day = 4;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
}
// Outputs "Thursday" (day 4)
     }
   }
 }
 ////METHODS
//Method is aline A method is a block of code which only runs when it is called.You can pass data, known as parameters, into a method.Methods are used to perform certain actions, and they are also known as functions.

static void Mymethod ();
{
    Console.WriteLine("Its hackthon");
}
static void Main(string[] arg)