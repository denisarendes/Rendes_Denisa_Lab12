﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rendes_Denisa_Lab12.Data;

namespace Rendes_Denisa_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());

            //InitializeComponent();

            //MainPage = new MainPage();
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
