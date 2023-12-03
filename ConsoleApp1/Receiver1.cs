

namespace ConsoleApp1
{
    //the Receiver class is often associated with the object that performs the real work when a command is executed
    public class Receiver1
    {
        public void TurnOnLight()
        {
            Console.WriteLine("\nLight number 1 is turned on");

        }
        public void TurnOffLight()
        {
            Console.WriteLine("\nLight number 1 is turned off");
        }
    }
}
