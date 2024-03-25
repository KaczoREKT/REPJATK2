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
    }

    public override void Load(double cargoWeight, Product product)
    {
        if (cargoWeight > maxLoad)
        {
            throw new OverfillException("Cargo weight exceeds container's maximum load capacity. DANGEROUS!!111");
        }

        if (product is LiquidProduct liquidProduct)
        {
            if (liquidProduct.IsHazardous)
            {
                base.Load(cargoWeight / 2, product);
                maxLoad /= 2;
            }
            else
            {
                base.Load(cargoWeight * 0.9, product);
                maxLoad *= 0.9;
            }
        }
        else
        {
            throw new WrongTypeException("This type of product can't be inserted into the container.");
        }
    }

    public override void Unload()
    {
        maxLoad = maxLoadPrimary;
        base.Unload();
    }
}