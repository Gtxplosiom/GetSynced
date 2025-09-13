using System.Diagnostics;

namespace GetSynced.ViewModels.Commands
{
    public class AddFileCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            Debug.WriteLine("AddFileCommand executed.");
        }
    }
}
