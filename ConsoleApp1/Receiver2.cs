namespace ConsoleApp1 { 
public class Receiver2
{
        public bool IsLightOn { get; set; }

        public void TurnOnLight()
    {
        Console.WriteLine("\nLight number 2 is turned on");

    }
        public void TurnOffLight()
        {
            Console.WriteLine("\nLight number 2 is turned off");
        }
    }
}