// See https://aka.ms/new-console-template for more information

using Solution_4;
using Solution_4.Exceptions;


public abstract class Con : IContainer
{
    private int weight { get; set; }
    private int height { get; set; }
    public int cargoWeight { get; set; }
    private int deep { get; set; }
    private String serial { get; set; }
    private static int num = 0;
    private int maxLoad { get; set; }
    public virtual void Load(double cargoWeight)
    {
        throw new OverfillException();
    }

    public virtual void Unload()
    {
        throw new OverfillException();
    }

    protected Con(int weight, int height, int cargoWeight, int deep, int maxLoad)
    {
        this.weight = weight;
        this.height = height;
        this.cargoWeight = cargoWeight;
        this.deep = deep;
        num++;
        serial = "KON-" + "C-" + num.ToString(); 
        this.maxLoad = maxLoad;
    }

    
}


