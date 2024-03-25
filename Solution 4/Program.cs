using Solution_4.Exceptions;
using Solution_4.Products;

class Program
{
    static void Main(string[] args)
    {
        // Example usage of the LiquidContainer class
        LiquidContainer liquidContainer = new LiquidContainer(100, 50, 0, 30, 500);
        Console.WriteLine("Liquid Container created with serial number: " + liquidContainer.serial);
        GasContainer gasContainer = new GasContainer(100, 50, 0, 30, 500);
        Console.WriteLine("Liquid Container created with serial number: " + gasContainer.serial);
        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(100, 50, 0, 30, 500, "Nabiał", -2);
        Console.WriteLine("Liquid Container created with serial number: " + gasContainer.serial);
        // Example usage of loading and unloading containers
        try
        {
            liquidContainer.Load(400, new GasProduct("Mleko"));
        }
        catch (OverfillException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("Current cargo weight in Liquid Container: " + liquidContainer.cargoWeight);
        liquidContainer.Unload();
        Console.WriteLine("Cargo unloaded from Liquid Container. Current cargo weight: " + liquidContainer.cargoWeight);
    }
}