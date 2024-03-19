using Solution_4.Exceptions;
using Solution_4.Interfaces;

public abstract class Container : IContainer
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

    public Container(int weight, int height, int cargoWeight, int deep, int maxLoad)
    {
        this.weight = weight;
        this.height = height;
        this.cargoWeight = cargoWeight;
        this.deep = deep;
        num++;
        serial = "KON-" + "C-" + num;
        this.maxLoad = maxLoad;
    }
}