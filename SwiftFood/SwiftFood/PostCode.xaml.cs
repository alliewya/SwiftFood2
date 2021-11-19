﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwiftFood
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostCode : ContentPage
    {
        public PostCode()
        {
           
            InitializeComponent();
            Logo.Source = "swiftfoodsmall.png";
            
        }

        private async void Find_Clicked(object sender, EventArgs e)
        {
            string postcode = PC.Text;
            if (postcode != null)
            {
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Error", "Please enter a postcode ", "OK");
            }
        }
        public ICommand GotoLogin => new Command(Gotopage);
        private async void Gotopage()
        {
            await DisplayAlert("Hello", "You clicked!", "OK");
        }

    }
}