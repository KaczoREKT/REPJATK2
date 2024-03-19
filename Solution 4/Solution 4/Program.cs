// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class Con
{
    private int weight { get; set; }
    private int height { get; set; }
    public int cargo_weight { get; set; }
    private int deep { get; set; }
    private String serial { get; set; }
    private static int num = 0;
    private int max_load { get; set; }

    public Con(int weight, int height, int cargoWeight, int deep, int max_load)
    {
        this.weight = weight;
        this.height = height;
        this.cargo_weight = cargoWeight;
        this.deep = deep;
        num++;
        serial = "KON-" + "C-" + num.ToString(); 
        this.max_load = max_load;
    }

    
}


