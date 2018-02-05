using System;

public class PingPong
{
  public static void Main()
  {
    Console.WriteLine("Pick any number");
    string submitNumber = Console.ReadLine();
    int numberInt = int.Parse(submitNumber);

    for (int index = 0; index <= numberInt; index ++)
    {
      if (index % 3 == 0 && index % 5 == 0);
      {
        return "ping-pong";
      }
      else if (index % 3 == 0);
      {
        return "ping";
      }
      else if (index % 5 == 0);
      {
        return "pong";
      }
      else
      {
        return index;
      }
    Console.WriteLine(index);
  }
}
