using System;
using System.Collections.Generic;
using Solution_4.Exceptions;
using Solution_4.Interfaces;

public abstract class Container : IContainer
{
    public int weight { get; set; }
    public int height { get; set; }
    public double cargoWeight { get; protected set; }
    public int deep { get; set; }
    public double maxLoad { get; set; }
    
    public String serial { get; set; }

    public virtual void Load(double cargoW, Product product)
    {
        if (this.cargoWeight + cargoW > maxLoad)
        {
            throw new OverfillException("Cargo weight exceeds container's maximum load capacity.");
        }
        this.cargoWeight += (int)cargoW;
        Console.WriteLine("LOADED: " + cargoW + " kg");
    }

    public virtual void Unload()
    {
        cargoWeight = 0;
        Console.WriteLine("UNLOADED CARGO");
    }

    public Container(int weight, int height, double cargoWeight, int deep, double maxLoad)
    {
        this.weight = weight;
        this.height = height;
        this.cargoWeight = cargoWeight;
        this.deep = deep;
        this.maxLoad = maxLoad;
    }
}