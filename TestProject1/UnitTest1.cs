namespace TestProject1;
using ConsoleApp1;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;


[TestFixture]
public class Receiver1Tests
{
    //Here we test if the invoker sends the proper commands to the receiver to turn on light 1
    [Test]
    public void TurnOnLight_ShouldPrintCorrectMessage()
    {
        // Arrange
        var invoker1 = new Invoker();
        var receiver1 = new Receiver1();
        ICommand command1 = new ConcreteCommand1(receiver1);

        var expectedOutput = "\nLight number 1 is turned on" + Environment.NewLine;

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            invoker1.SetCommand(command1); // Set the command for turning on the light
            invoker1.ExecuteCommand();
            string actualOutput = sw.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput, "TurnOnLight should print the correct message");
        }
    }

    [Test]
    public void TurnOffLight_ShouldPrintCorrectMessage()
    {
        var invoker1 = new Invoker();
        var receiver1 = new Receiver1();
        ICommand command1 = new ConcreteCommand1(receiver1);
        var expectedOutput = "\nLight number 1 is turned off" + Environment.NewLine;

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            receiver1.TurnOffLight();
            string actualOutput = sw.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput, "TurnOffLight should print the correct message");
        }
    }

    [Test]
    //We test if the light number two is working
    
    public void TurnOnLight2_ShouldPrintCorrectMessage()
    {
        // we call all the elements in the chain of events

        var invoker1 = new Invoker();
        var receiver2 = new Receiver2();
        ICommand command1 = new ConcreteCommand2(receiver2);

        var expectedOutput = "\nLight number 2 is turned on" + Environment.NewLine;

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            invoker1.SetCommand(command1); // Set the command for turning on the light
            invoker1.ExecuteCommand();
            string actualOutput = sw.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput, "TurnOnLight should print the correct message");
        }
    }


    [Test]
    public void TurnOffLight2_ShouldPrintCorrectMessage()
    {
        // we call all the elements in the chain of events

        var invoker1 = new Invoker();
        var receiver2 = new Receiver2();
        ICommand command1 = new ConcreteCommand2(receiver2);
        var expectedOutput = "\nLight number 2 is turned off" + Environment.NewLine;

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            receiver2.TurnOffLight();
            string actualOutput = sw.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput, "TurnOffLight should print the correct message");
        }
    }



    //We test if the light number three is working

    [Test]

    public void TurnOnLight3_ShouldPrintCorrectMessage()
    {
        // we call all the elements in the chain of events
        var invoker1 = new Invoker();
        var receiver3 = new Receiver3();
        ICommand command1 = new ConcreteCommand3(receiver3);

        var expectedOutput = "\nLight number 3 is turned on" + Environment.NewLine;

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            invoker1.SetCommand(command1); // Set the command for turning on the light
            invoker1.ExecuteCommand();
            string actualOutput = sw.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput, "TurnOnLight should print the correct message");
        }
    }

}






