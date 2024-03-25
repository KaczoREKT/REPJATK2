using Solution_4.Interfaces;

namespace Solution_4.Containers;

public class LiquidContainer : Container
{
    public String serial { get; set; }
    private static int num = 0;
    
    public LiquidContainer(int weight, int height, int cargoWeight, int deep, int maxLoad)
        : base(weight, height, cargoWeight, deep, maxLoad)
    {
        num++;
        serial = "KON-" + "L-" + num;
    }

    public override void Load(double cargoWeight)
    {
        
    }

    public override void Unload()
    {
    }
}