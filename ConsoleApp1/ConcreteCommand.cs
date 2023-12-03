namespace ConsoleApp1
{


    public class ConcreteCommand1 : ICommand
    {
        private Receiver1 _receiver1;

        public ConcreteCommand1(Receiver1 receiver1)
        {
            _receiver1 = receiver1;

        }

        public bool Executed { get; private set; }

        public void Execute()
        {
            _receiver1.TurnOnLight();
            Executed = true;
        }

        public void Undo()
        {
            _receiver1.TurnOffLight();
            Executed = false;
        }

    }

    public class ConcreteCommand2 : ICommand
    {
        private Receiver2 _receiver2;

        public ConcreteCommand2(Receiver2 receiver2)
        {
            _receiver2 = receiver2;

        }
        public void Execute()
        {
            _receiver2.TurnOnLight();
        }
        public void Undo()
        {
            _receiver2.TurnOffLight();
        }

    }




    public class ConcreteCommand3 : ICommand
    {
        readonly Receiver3 _receiver3;

        public ConcreteCommand3(Receiver3 receiver3)
        {
            _receiver3 = receiver3;

        }
        public void Execute()
        {
            _receiver3.TurnOnLight();
        }
        public void Undo()
        {
            _receiver3.TurnOffLight();
        }

    }



     

    

}

