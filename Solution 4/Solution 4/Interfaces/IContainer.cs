using Solution_4.Exceptions;

namespace Solution_4;

public interface IContainer
{
    void Unload();

    void Load(double cargoWeight);
}