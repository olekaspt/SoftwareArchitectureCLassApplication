// See https://aka.ms/new-console-template for more information
using DotNetAutomationBinding;
using System;

namespace DotNetAutomationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World from DotNetAutomationConsoleApp, .Net integration !");

            Session theSession = Session.GetSession;

            Part thePart = theSession.MakePart("SomePart.prt");

            thePart.Save();
        }
    }
}