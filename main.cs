using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter your weight in pounds: ");

// This will have the user input
    string userWeight = Console.ReadLine();
    int intUserWeight = Convert.ToInt32(userWeight);
// This will have the users weight in kilograms
    double Kilograms = userWeight;
    Console.WriteLine ("Your weight in kilograms is ");
    Console.WriteLine (intUserWeight / 2.2046);
// This will have the users weight in Newtons
    Console.WriteLine ("Your weight in Newtons is ");
    Console.WriteLine (intUserWeight * 4.4482);




  }
}