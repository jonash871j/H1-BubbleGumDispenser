using System;

class Program
{
    static void Main(string[] args)
    {
        // Opgave 1
        Console.WriteLine(" - Opgave 1");
        BubbleGumDispenser bubbleGumDispenser = new BubbleGumDispenser(55);
        for (int i = 0; i < 8; i++)
        {
            BubbleGum bubbleGum = bubbleGumDispenser.Dispence();
            if (bubbleGum != null)
                Console.WriteLine("Kid-" + i + " got a " + bubbleGum.GetColor() + " colored bubblegum with " + bubbleGum.GetTaste() + " flavor");
            else
                Console.WriteLine("Kid-" + i + " got nothing!");
        }

        // Opgave 2
        Console.WriteLine("\n - Opgave 2");
        BubbleGumDispenserStatic.FillDispencer(55);
        for (int i = 0; i < 8; i++)
        {
            BubbleGum bubbleGum = BubbleGumDispenserStatic.Dispence();
            if (bubbleGum != null)
                Console.WriteLine("Kid-" + i + " got a " + bubbleGum.GetColor() + " colored bubblegum with " + bubbleGum.GetTaste() + " flavor");
            else
                Console.WriteLine("Kid-" + i + " got nothing!");
        }
    }
}
