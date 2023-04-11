// See https://aka.ms/new-console-template for more information

using DotNetAutomationBinding;

static void main()
{

    Console.WriteLine("Hello, World!");


    Session theSession = Session.GetSession;

    Part thePart = theSession.MakePart("SomePart.prt");

    thePart.Save();
    Console.Write("Successfully Saved Part");
}
