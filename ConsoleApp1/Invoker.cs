namespace ConsoleApp1
{
    //The invoker class is high level wrapper that gives the first commands
    public class Invoker
    {
        private ICommand? _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }

        public void UndoCommand()
        {
            _command.Undo();
        }

     
    }


   
}
