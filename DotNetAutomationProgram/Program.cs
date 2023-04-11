// See https://aka.ms/new-console-template for more information
using DotNetAutomationBinding;
using System;

Console.WriteLine("Hello, World!");
namespace DotNetAutomationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Team 30 DotNetAutomationConsoleApp");


            Session theSession = Session.GetSession;

            Part thePart = theSession.MakePart("SomePart.prt");

            thePart.Save();
            Console.WriteLine("Part saved");
        }
    }
}

