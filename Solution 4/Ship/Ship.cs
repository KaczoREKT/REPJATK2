using System.ComponentModel;
using Solution_4.Exceptions;
using Solution_4.Products;
using IContainer = Solution_4.Interfaces.IContainer;

namespace Solution_4.Ship;

public class Ship
{
    public List<Container> containerList = new List<Container>();

    public static GasContainer CreateGasContainer(int weight, int height, double cargoWeight, int deep, double maxLoad)
    {
        return new GasContainer(weight, height, cargoWeight, deep, maxLoad);
    }

    public static LiquidContainer CreateLiquidContainer(int weight, int height, double cargoWeight, int deep,
        double maxLoad)
    {
        return new LiquidContainer(weight, height, cargoWeight, deep, maxLoad);
    }

    public static RefrigeratedContainer CreateRefrigeratedContainer(int weight, int height, double cargoWeight,
        int deep, double maxLoad, string type, int temperature)
    {
        return new RefrigeratedContainer(weight, height, cargoWeight, deep, maxLoad, type, temperature);
    }


    public void LoadContainer(double cargoWeight, Product product, Container container)
    {
        switch (container)
        {
            case GasContainer gasContainer:
                gasContainer.Load(cargoWeight, product);
                break;
            case LiquidContainer liquidContainer:
                liquidContainer.Load(cargoWeight, product);
                break;
            case RefrigeratedContainer refrigeratedContainer:
                refrigeratedContainer.Load(cargoWeight, product);
                break;
        }
    }

    public void LoadShip(Container container)
    {
        containerList.Add(container);
    }

    public void LoadShipWithList(List<Container> containers)
    {
        containers.AddRange(containers);
    }

    public void DeleteContainer(Container container)
    {
        if (!containerList.Contains(container))
        {
            throw new NoCargoException("NO CARGO LIKE THAT ON THE LIST");
        }

        containerList.Remove(container);
    }

    public void Unload()
    {
        containerList = new List<Container>();
    }

    public void Replace(String serial1, Container newContainer)
    {
        foreach (Container container in containerList)
        {
            if (container.serial == serial1)
            {
                containerList.Remove(container);
                containerList.Add(newContainer);
                break;
            }
        }
    }

    public void swapCargo(Ship ship1, Ship ship2, string serial1, string serial2)
    {
        List<Container> tempContainersShip1 = new List<Container>();
        List<Container> tempContainersShip2 = new List<Container>();
        
        foreach (Container container in ship1.containerList)
        {
            if (container.serial == serial1 || container.serial == serial2)
            {
                tempContainersShip1.Add(container);
            }
        }
        
        foreach (Container container in ship2.containerList)
        {
            if (container.serial == serial1 || container.serial == serial2)
            {
                tempContainersShip2.Add(container);
            }
        }
        
        if (tempContainersShip1.Count == 1 && tempContainersShip2.Count == 1)
        {
            Container tempContainer = tempContainersShip1[0];
            tempContainersShip1[0] = tempContainersShip2[0];
            tempContainersShip2[0] = tempContainer;
            
            ship1.containerList.Remove(tempContainersShip1[0]);
            ship1.containerList.Add(tempContainersShip2[0]);

            ship2.containerList.Remove(tempContainersShip2[0]);
            ship2.containerList.Add(tempContainersShip1[0]);
        }
        else
        {
            throw new NoCargoException("NO CONTAINER LIKE THAT.");
        }
    }

    public void GetContainerInfo(Container container)
    {
        Console.WriteLine("CONTAINER INFO:");
        Console.WriteLine("SERIAL: " + container.serial);
        Console.WriteLine("WEIGHT: " + container.weight);
        Console.WriteLine("HEIGHT: " + container.height);
        Console.WriteLine("CARGO WEIGHT: " + container.cargoWeight);
        Console.WriteLine("DEPTH: " + container.deep);
        Console.WriteLine("MAXIMUM LOAD: " + container.maxLoad);
    }

    public void GetShipInfo (Ship ship)
    {
        Console.WriteLine("SHIP INFO:");
        Console.WriteLine("AVAILABLE CARGO:");
        foreach (Container container in containerList)
        {
            Console.WriteLine(container.serial);
        }
    }
}