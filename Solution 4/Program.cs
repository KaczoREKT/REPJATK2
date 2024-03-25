using Solution_4.Exceptions;
using Solution_4.Products;
using Solution_4.Ship;

class Program
{
    static void Main(string[] args)
    {
        LiquidContainer liquidContainer = new LiquidContainer(100, 50, 0, 30, 500);
        GasContainer gasContainer = new GasContainer(100, 50, 0, 30, 500);
        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(100, 50, 0, 30,
            500, "Nabiał", -2);
        Ship Gigantic = new Ship();
        Gigantic.LoadShip(gasContainer);
        Gigantic.GetShipInfo();
        Gigantic.Unload();
        try
        {
            liquidContainer.Load(400, new LiquidProduct("Woda", false));
            gasContainer.Load(400, new GasProduct("Hel"));
        }
        catch (OverfillException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}