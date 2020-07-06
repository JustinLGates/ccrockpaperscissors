using System;
using System.Collections.Generic;
namespace game.models
{
  class Choice
  {
    public string Name { get; set; }
    public string Beats { get; set; }
    public Choice(string name, string beats)
    {
      Name = name;
      Beats = beats;

    }

  }
}