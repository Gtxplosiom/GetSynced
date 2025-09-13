using GetSynced.ViewModels.Commands;
using System.Windows.Input;

namespace GetSynced.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand AddFileCommand { get; }

        public MainPageViewModel()
        {
            AddFileCommand = new AddFileCommand();
        }
    }
}
