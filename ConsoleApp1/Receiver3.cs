public class Receiver3
{
    public bool? IsLightOn { get; set; }

    public void TurnOnLight()
    {
        Console.WriteLine("\nLight number 3 is turned on");

    }

    public void TurnOffLight()
    {
        Console.WriteLine("\nLight number 3 is turned off");
    }
}