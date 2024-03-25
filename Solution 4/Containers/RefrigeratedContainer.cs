using Solution_4.Exceptions;
using Solution_4.Interfaces;

public class RefrigeratedContainer : Container, IHazardNotifier
{
    
    private static int num = 0;
    public string type { get; private set; }
    public int temperature { get; private set; }

    public RefrigeratedContainer(int weight, int height, double cargoWeight, int deep, double maxLoad, string type,
        int temperature)
        : base(weight, height, cargoWeight, deep, maxLoad)
    {
        num++;
        serial = "KON-R-" + num;
        this.type = type;
        this.temperature = temperature;
        Console.WriteLine("CREATED NEW CONTAINER: " + serial);
    }

    public override void Load(double cargoW, Product product)
    {
        if (cargoWeight + cargoW > maxLoad)
        {
            throw new OverfillException("EXCEEDS MAX LOAD. DANGEROUS!!!");
        }

        if (product is RefrigeratedProduct refrigeratedProduct && refrigeratedProduct.MinTemperature >= temperature &&
            refrigeratedProduct.type == type)
        {
            base.Load(cargoWeight, product);
        }
        else
        {
            throw new WrongTypeException("CAN'T INSERT THIS CONTAINER HERE");
        }
    }

    public void Notify(string serial)
    {
        Console.WriteLine("HAZARD HAZARD! " + serial);
    }
}