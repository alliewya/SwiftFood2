﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;


// Importing Custom Fonts
[assembly: ExportFont("BentonSans Bold.otf", Alias = "BentonBold")]
[assembly: ExportFont("BentonSans Medium.otf", Alias = "BentonMedium")]
[assembly: ExportFont("BentonSans Regular.otf", Alias = "BentonRegular")]


namespace SwiftFood
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GenerateTestRestaurants();

            MainPage = new MainPage();
            //MainPage = new NavigationPage( new MainPage());
        }

        public Order ActiveBasket;

        public ObservableCollection<Restaurant> ActiveRestaurants;

        private void GenerateTestRestaurants()
        {
            ActiveRestaurants = new ObservableCollection<Restaurant>();
            Restaurant pizza = new Restaurant();
            pizza.RestName = "Pizza Allegro";
            pizza.RestRating = 5;
            pizza.RestAddress = "23 Fort Road, Townland";
            pizza.RestDescription = "Real Italian Pizza";
            pizza.RestImageSource = "pizza.jpg";
            pizza.RestOpeningHours = "1pm - 11pm";
            pizza.Menu.Add(new Food("Four Cheese Pizza", (decimal)11.99, "Mozzarella, Gorgonzola, Fontina and Parmigiano. Pizza quattro formaggi Italian: (four cheese pizza) is a variety of pizza in Italian cuisine that is topped with a combination of four kinds of cheese, usually melted together, with (rossa, red) or without (bianca, white) tomato sauce."));
            pizza.Menu.Add(new Food("Pasta Parcel", (decimal)8.99, "Pasta is a type of food typically made from an unleavened dough of wheat flour mixed with water or eggs, and formed into sheets or other shapes"));
            ActiveRestaurants.Add(pizza);
            ActiveRestaurants.Add(pizza);
            ActiveRestaurants.Add(pizza);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

