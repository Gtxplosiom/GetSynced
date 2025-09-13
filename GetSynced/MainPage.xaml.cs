using GetSynced.ViewModels;

namespace GetSynced
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();

            BindingContext = mainPageViewModel;
        }
    }
}
