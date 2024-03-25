public class LiquidProduct : Product
{
    public bool IsHazardous { get; }

    public LiquidProduct(string name, bool isHazardous) : base(name)
    {
        IsHazardous = isHazardous;
    }
}