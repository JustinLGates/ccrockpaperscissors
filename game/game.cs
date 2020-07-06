using System;
using game.ai;
using System.Collections.Generic;
using game.models;
namespace game
{
  class Game
  {
    public Game()
    {
      Console.Clear();

      createChoices();
    }
    Computer computer = new Computer();
    Dictionary<string, string> choices = new Dictionary<string, string>();

    private void createChoices()
    {
      choices.Add("rock", "scissors");
      choices.Add("paper", "rock");
      choices.Add("scissors", "paper");
    }
    void checkWinner(string usersChoice, string computerChoice)
    {


      if (computerChoice == usersChoice)
      {
        Console.WriteLine(" YOU ALL DIED...");
        return;
      }
      bool userWon = false;
      if (choices[usersChoice] == computerChoice)
      {
        userWon = true;
      }

      if (userWon)
      {
        Console.WriteLine("YOU WIN! COMPUTER DIED");
        return;
      }
      Console.WriteLine("COMPUTER WINS YOU DIE!");
    }
    public void startRound(string input)
    {
      Console.WriteLine("Human choose " + input);
      string computerInput = computer.makeSelection();
      Console.WriteLine("Computer choose " + computerInput);
      checkWinner(input, computerInput);
    }
    public void invalidInputError()
    {
      Console.WriteLine("invalid choice YOU DIED!.");
    }
    bool running { get; set; }
    public void start()
    {
      running = true;
      while (running)
      {
        Console.WriteLine("make a choice {rock,paper,scissors}");
        string choice = Console.ReadLine();
        switch (choice)
        {
          case "rock":
          case "paper":
          case "scissors":
            Console.Clear();
            startRound(choice);
            break;
          default:
            Console.Clear();
            invalidInputError();
            break;
        }
      }
    }


  }
}