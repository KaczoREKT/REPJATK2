using Solution_4.Exceptions;
using Solution_4.Interfaces;

public class LiquidContainer : Container
{
    
    private static int num = 0;
    private double maxLoadPrimary = 0;

    public LiquidContainer(int weight, int height, double cargoWeight, int deep, double maxLoad)
        : base(weight, height, cargoWeight, deep, maxLoad)
    {
        num++;
        serial = "KON-L-" + num;
        maxLoadPrimary = maxLoad;
        Console.WriteLine("CREATED NEW CONTAINER: " + serial);
    }

    public override void Load(double cargoW, Product product)
    {
        

        if (product is LiquidProduct liquidProduct)
        {
            if (liquidProduct.IsHazardous)
            {
                maxLoad /= 2;
            }
            else
            {
                maxLoad *= 0.9;
            }
            if (cargoWeight + cargoW > maxLoad)
            {
                throw new OverfillException("EXCEEDS MAX LOAD. DANGEROUS!!111");
            }
            base.Load(cargoW, product);
            
        }
        else
        {
            throw new WrongTypeException("CAN'T INSERT THIS CONTAINER HERE");
        }
    }

    public override void Unload()
    {
        maxLoad = maxLoadPrimary;
        base.Unload();
    }
}