// See https://aka.ms/new-console-template for more information

using CodingChallenges.Global;
using CodingChallenges.RailFence;

StartApplication();
string? line;

while ((line = Console.ReadLine()) != "xx")
{
    if (line?.ToLower() == TestList.RailFence.ToLower())
    {
        RailFenceCommand.Start();
    }

    StartApplication();
}

void StartApplication()
{
    Console.WriteLine("please choose your coding challenge ");
    Console.WriteLine("For rail fence enter " + TestList.RailFence);
    Console.WriteLine("To exit please enter xx");
}