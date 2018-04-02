using System;
using System.Collections.Generic;
using elves.Models;

namespace elves
{
  class Program
  {
    static void Main(string[] args)
    {
      Elf jingle = new Elf("Jingle", 6, 10, 18);
      Elf dash = new Elf("Dash", 7, 10, 1);
      Elf bubbles = new Elf("Bubbles", 8, 12, 10);
      Elf sparkle = new Elf("Sparkle", 10, 11, 17);
      Elf cookie = new Elf("Cookie", 11, 16, 4);
      Elf frosty = new Elf("Frosty", 11, 14, 8);
      Elf twinkle = new Elf("Twinkle", 13, 14, 22);
      Elf jangle = new Elf("Jangle", 13, 18, 15);
      Elf spunky = new Elf("Spunky", 15, 22, 1);
      Elf sunny = new Elf("Sunny", 14, 20, 12);
      Elf happy = new Elf("Happy", 16, 19, 13);

      List<Elf> elves = new List<Elf>() { jingle, dash, bubbles, sparkle, cookie, frosty, twinkle, jangle, spunky, sunny, happy };
      int outCandy = 0;
      int peakOut = 0;
      int peakHour = 0;
      for (int i = 6; i < 22; i++)
      {
        foreach (Elf elf in elves)
        {
          if (elf.TimeIn == i)
          {
            //add to current outCandy
            outCandy += elf.CandyConsumed;
          }
          if (elf.TimeOut == i)
          {
            //decrement outCandy
            outCandy -= elf.CandyConsumed;
          }
        }
        System.Console.WriteLine("At " + i + " there is " + outCandy + " pieces of candy out");
        if (outCandy > peakOut)
        {
          peakOut = outCandy;
          peakHour = i;
    
        }
      }
    System.Console.WriteLine(peakOut + " candy out at " + peakHour);
    }
  }
}
