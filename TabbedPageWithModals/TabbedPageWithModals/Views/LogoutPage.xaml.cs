using System;
using System.Collections.Generic;
using TabbedPageWithModals.ViewModels;
using Xamarin.Forms;

namespace TabbedPageWithModals.Views
{
    public partial class LogoutPage : ContentPage
    {
        public LogoutPage()
        {
            InitializeComponent();
        }

        async void OnStartClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new ModalPage());

            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                Navigation.PopModalAsync();
                return true;
            });
        }
    }
}
