using System;

class Hurricane {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter wind speed(mph):");
    int windSpeed=int.Parse(Console/.ReadLine);
    if(windSpeed>=157)
    {
      //if windSpeed is greater that 157 miles per  hour
      Console.WriteLine("Category 5 hurricane");
      }
    else if(windSpeed>=130&&windSpeed<157)
    {
      //if windSpeed is greater or equal to 130 mph and less than 157 mph
      Console.WriteLine("Category 4 hurricane");
      }
    else if(windSpeed>=111&&windSpeed<130)
    {
      //if windSpeed is greater or equal to 111 and less than 130 mph
      Console.WriteLine("Category 3 hurricane");
      }
    else if(windSpeed>=96&&windSpeed<111)
    {
      //if windSpeed is greater or equal to 96 and less than 111 mph
      Console.WriteLine("Category 2 hurricane");
      }
    else if(windSpeed>=74&&windSpeed<96)
    {
      //if windSpeed is greater or equal to 74 and less than 96 mph
      Console.WriteLine("Category 1 hurricane");
      }
    else
    {
      //when WindSpeed is less than 74 mph
      Console.WriteLine("Not a hurricane");
      }
    Console.Readkey();
    }
  }
}