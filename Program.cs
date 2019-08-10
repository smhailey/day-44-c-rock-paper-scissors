using System;

namespace day_44_c_rock_paper_scissors
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.Write("Type your weapon! (r for rock, p for paper, s for scissors, or q to quit): ");
        string playerWeapon = Console.ReadLine().ToLower();
        if (playerWeapon == "q")
        {
          System.Console.WriteLine("Come back anytime");
          break;
        }
        string cpuWeapon = "";
        if (String.Compare(playerWeapon, "r") == 0 || String.Compare(playerWeapon, "p") == 0 || String.Compare(playerWeapon, "s") == 0)
        {
          if (playerWeapon == "r")
          {
            System.Console.WriteLine("You chose rock");
          }
          if (playerWeapon == "p")
          {
            System.Console.WriteLine("You chose paper");
          }
          if (playerWeapon == "s")
          {
            System.Console.WriteLine("You chose scissors");
          }
          Random rng = new Random();
          int randomNumber = rng.Next(3);
          // System.Console.WriteLine($"random number = { randomNumber}");
          if (randomNumber == 0)
          {
            cpuWeapon = "r";
            System.Console.WriteLine("CPU chose rock");
          }
          if (randomNumber == 1)
          {
            cpuWeapon = "p";
            System.Console.WriteLine("CPU chose paper");
          }
          if (randomNumber == 2)
          {
            cpuWeapon = "s";
            System.Console.WriteLine("CPU chose scissors");
          }
          if (playerWeapon == cpuWeapon)
          {
            System.Console.WriteLine("Tie");
          }
          if (playerWeapon == "r" && cpuWeapon == "s")
          {
            System.Console.WriteLine("You win");
          }
          if (playerWeapon == "p" && cpuWeapon == "r")
          {
            System.Console.WriteLine("You win");
          }
          if (playerWeapon == "s" && cpuWeapon == "p")
          {
            System.Console.WriteLine("You win");
          }
          if (cpuWeapon == "r" && playerWeapon == "s")
          {
            System.Console.WriteLine("You lose");
          }
          if (cpuWeapon == "p" && playerWeapon == "r")
          {
            System.Console.WriteLine("You lose");
          }
          if (cpuWeapon == "s" && playerWeapon == "p")
          {
            System.Console.WriteLine("You lose");
          }
        }
        else
        {
          System.Console.WriteLine("Invalid choice");
        }
      }
    }
  }
}
