// See https://aka.ms/new-console-template for more information

using CodingChallenges.RailFence;

Console.WriteLine("please enter the d to decode and e to encode - enter xx to exit");
string line;
while((line = Console.ReadLine()) != "xx")
{
    Console.WriteLine("please enter the key ");
    var key = Console.ReadLine();

    Console.WriteLine("please enter the text ");
    var text = Console.ReadLine();
    
    
    if (line == "d")
    {
        if (key != null)
        {
            string? result = RailFence.Decode(int.Parse(key), text);
            Console.WriteLine(result);
        }
    }

    if (line == "e")
    {
        if (key != null)
        {
            string? result = RailFence.Encode(int.Parse(key), text);
            Console.WriteLine(result);
        }
    }
    
    Console.WriteLine("please enter the d to decode and e to encode - enter xx to exit");
}