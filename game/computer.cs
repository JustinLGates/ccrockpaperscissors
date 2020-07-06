using System;
namespace game.ai
{
  class Computer
  {
    public Computer()
    {
      Console.WriteLine("new computer");
    }

    public string makeSelection()
    {
      string choice = "";
      Random rand = new Random();
      switch (rand.Next(3))
      {
        case 0:
          choice = "rock";
          break;
        case 1:
          choice = "paper";
          break;
        case 2:
          choice = "scissors";
          break;
      }
      return choice;
    }
  }
}