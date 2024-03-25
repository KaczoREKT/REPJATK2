namespace Solution_4.Interfaces;

public interface IContainer
{
    void Unload();
    void Load(double cargoWeight, Product product);
}