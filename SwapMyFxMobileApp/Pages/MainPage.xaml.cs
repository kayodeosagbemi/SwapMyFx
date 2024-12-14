using SwapMyFxMobileApp.Models;
using SwapMyFxMobileApp.PageModels;

namespace SwapMyFxMobileApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}