
using Solution_4.Exceptions;
using Solution_4.Interfaces;
using Solution_4.Products;

public class GasContainer : Container, IHazardNotifier
{
    
    private static int num = 0;

    public GasContainer(int weight, int height, double cargoWeight, int deep, double maxLoad)
        : base(weight, height, cargoWeight, deep, maxLoad)
    {
        num++;
        serial = "KON-G-" + num;
    }

    public override void Load(double cargoW, Product product)
    {
        if (cargoWeight + cargoW > maxLoad)
        {
            throw new OverfillException("Cargo weight exceeds container's maximum load capacity.");
        }

        if (product is not GasProduct)
        {
            throw new WrongTypeException("This type of product can't be inserted into the container.");
        }
        else
        {
            base.Load(cargoW, product);
        }
       
    }

    public override void Unload()
    {
        cargoWeight *= 0.05;
    }

    public void Notify(string serial)
    {
        Console.WriteLine("HAZARD HAZARD IN: " + serial);
    }
}