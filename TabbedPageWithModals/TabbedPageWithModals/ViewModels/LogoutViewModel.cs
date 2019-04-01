using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace TabbedPageWithModals.ViewModels
{
    public class LogoutViewModel : BaseViewModel
    {
        public ICommand OpenWebCommand { get; }

        public LogoutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.google.com/")));
        }
    }
}
