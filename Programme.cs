//Print Alex! in the console - The command Console.WriteLine() prints text to the console.

using System;


namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Alex!");    
     }
  }
};


//Console logging and returning an age based on input in the console - The command Console.ReadLine() captures user input in the console.


namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}

/* Data types 
int(4637): whole integer number 
string (kangaroo): a piece of text
bool (true): represents the logical idea of true or false */



/*

 2 ways of delcaring variables
int myAge;
myAge = 27;

string countryName = "England";

int evenNumber = 4;
int oddNumber = 1;

Console.WriteLine(evenNumber - oddNumber);

*/

//Once a vriable is defined it can be used throught the programme.
//YOU HAVE TO DECLARE VARIABLES AS IT IS A STRONGLY TYPED LANGUAGE.

namespace Form
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create Variables
      string name = "Shadow";
      string breed = "Golden Retriever";
      int age = 5;
      double weight = 65.22;
      bool spayed = true;

      // Print variables to the console
      Console.WriteLine(name);
      Console.WriteLine(breed);
      Console.WriteLine(age);
      Console.WriteLine(weight);
      Console.WriteLine(spayed);
    }
  }
}


/* to change data we need a DATA TYPE CONVERSION!
to do this in C# we cannot lose any data so can go from int to double but not double to int

Implicit conversion happens automatically if on data will be lost
Explicit conversion requires a cast operator for the conversion e.g. operator (int) 

Also could use Convert.ToString() method */

//Convert a string to an int using Convert.ToInt32().

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      // Turn that answer into an int

      int faveNumber = Convert.ToInt32(Console.ReadLine());


    }
  }
}

//Working with numbers using arithmetic operators and built-in methods.

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of pizza shops
      int pizzaShops = 4332;

      // Number of employees
      int totalEmployees = 86928;

      // Revenue
      double revenue = 390819.28;

      // Log the values to the console:

      Console.WriteLine(pizzaShops);
      Console.WriteLine(totalEmployees);
      Console.WriteLine(revenue);

   	}
  }
}

// Using Operators

namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {  
      // Your Age
int userAge = 27;

      // Length of years on Jupiter (in Earth years)
double jupiterYears = 11.86;

      // Age on Jupiter
double jupiterAge = userAge / jupiterYears;

      // Time to Jupiter
double journeyToJupiter = 6.142466;

      // New Age on Earth
double newEarthAge = userAge + journeyToJupiter;

      // New Age on Jupiter
double newJupiterAge = newEarthAge / jupiterYears;

      // Log calculations to console

Console.WriteLine(userAge);
Console.WriteLine(jupiterAge);
Console.WriteLine(newEarthAge);
Console.WriteLine(newJupiterAge);

    }
  }
}


