using System.Windows.Input;

namespace GetSynced.ViewModels.Commands
{
    public class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual void Execute(object? parameter)
        {
            // Base implementation (if any)
        }
        public virtual bool CanExecute(object? parameter)
        {
            return true; // Default to true
        }
    }
}
