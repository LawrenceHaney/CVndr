using System;
using CVnder;
using CVndr.Service;

namespace CVndr.Controller
{
  class CVndrController
  {
    private CVndrService _service {get; set;} = new CVndrService();
    public bool running = true;
    public void Run()
    {
      while(running)
      {
        GetUserImput();
      }
    }

    private void GetUserImput()
    {
      Utils.DrawLogo();
      System.Console.WriteLine("Inset (Q)uarter to continue");
      string input = Console.ReadLine().ToLower();
      switch(input)
      {
        case "q":
          Console.Beep();
          Selection();
          break;
        default:
          Console.WriteLine("Didn't quite get that");
          break;
      }
    }

    private void Selection()
    {
      _service.GetItems();
    }
  }
}