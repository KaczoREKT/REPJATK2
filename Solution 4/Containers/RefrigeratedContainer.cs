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
    }

    public override void Load(double cargoW, Product product)
    {
        if (cargoWeight + cargoW > maxLoad)
        {
            throw new OverfillException("Cargo weight exceeds container's maximum load capacity.");
        }

        if (product is RefrigeratedProduct refrigeratedProduct && refrigeratedProduct.MinTemperature >= temperature &&
            refrigeratedProduct.type == type)
        {
            base.Load(cargoWeight, product);
        }
        else
        {
            throw new WrongTypeException("This type of product can't be inserted into the container.");
        }
    }

    public void Notify(string serial)
    {
        Console.WriteLine("Hazardous situation detected in container with serial number: " + serial);
    }
}