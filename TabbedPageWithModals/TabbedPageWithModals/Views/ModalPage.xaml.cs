using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithModals.Views
{
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.iOS) Padding = new Thickness(0, 30, 0, 0);
        }
    }
}
