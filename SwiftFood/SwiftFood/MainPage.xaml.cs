using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwiftFood
{
    public partial class MainPage : FlyoutPage
    {

        FlyoutMenu flyoutmenu;

        public MainPage()
        {
            InitializeComponent();

            //Initialise and set flyout menu page and browse page as detail page
            flyoutmenu = new FlyoutMenu();
            Flyout = flyoutmenu;
            Detail = new NavigationPage(new Checkout());

        }
    }
}
