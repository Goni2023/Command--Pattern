using ConsoleApp1;
using System;

// Your existing ICommand, ConcreteCommand, Receiver, and Invoker classes go here

class Program
{
    static void Main()
    {
        // Create instances of receivers and commands
        Receiver1 receiver1 = new Receiver1();
        Receiver2 receiver2 = new Receiver2();
        Receiver3 receiver3 = new Receiver3();

        ICommand command1 = new ConcreteCommand1(receiver1);
        ICommand command2 = new ConcreteCommand2(receiver2);
        ICommand command3 = new ConcreteCommand3(receiver3);



        // Creating an Invoker object
        Invoker invoker = new Invoker();

        Console.WriteLine("Press 'Q' to turn on light 1, Press 'W' to turn off light 1," +
            "\nPress 'E' to turn on light 2, Press 'R' to turn off light 2 " + "\nPress 'T' to turn on light 3, press 'Y' to turn off light 3"+
            "\nPress 'U' to turn on all the lights \nPress 'I' to turn off all lights \nPress any other key to exit.");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.Q:
                    invoker.SetCommand(command1); // Set the command for turning on the light
                    invoker.ExecuteCommand();
                    break;

                case ConsoleKey.W:
                    invoker.SetCommand(command1); // Set the command for turning off the light
                    invoker.UndoCommand();
                    break;

                case ConsoleKey.E:
                    invoker.SetCommand(command2); // Set the command for turning on the light
                    invoker.ExecuteCommand();
                    break;

                case ConsoleKey.R:
                    invoker.SetCommand(command2); // Set the command for turning off the light
                    invoker.UndoCommand();
                    break;

                case ConsoleKey.T:
                    invoker.SetCommand(command3); // Set the command for turning on the light
                    invoker.ExecuteCommand();
                    break;

                case ConsoleKey.Y:
                    invoker.SetCommand(command3); // Set the command for turning off the light
                    invoker.UndoCommand();
                    break;

                case ConsoleKey.U:
                    invoker.SetCommand(command1);
                    invoker.ExecuteCommand();
                    invoker.SetCommand(command2);
                    invoker.ExecuteCommand();
                    invoker.SetCommand(command3);
                    invoker.ExecuteCommand();
                    break;

                case ConsoleKey.I:
                    invoker.SetCommand(command1);
                    invoker.UndoCommand();
                    invoker.SetCommand(command2);
                    invoker.UndoCommand(); 
                    invoker.SetCommand(command3);
                    invoker.UndoCommand();

                    break;





                default:
                    return; // Exit the program for any other key
            }
        }
    }
}
