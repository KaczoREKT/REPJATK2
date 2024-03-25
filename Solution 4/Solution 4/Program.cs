// See https://aka.ms/new-console-template for more information

using Solution_4.Containers;
using Solution_4.Exceptions;
using Solution_4.Interfaces;


class Program {
    static void Main(string[] args)
    {
        // Example usage of the Con class
        LiquidContainer container = new LiquidContainer(100, 50, 0, 30, 500);
        Console.WriteLine("Container created with serial number: " + container.serial);
        LiquidContainer container2 = new LiquidContainer(100, 50, 0, 30, 500);
        Console.WriteLine("Container created with serial number: " + container2.serial);
        
    }
}


