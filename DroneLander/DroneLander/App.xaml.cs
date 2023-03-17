﻿using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DroneLander
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel { get; set; }

        public static Services.IAuthenticationService Authenticator { get; private set; }

        public static void InitializeAuthentication(Services.IAuthenticationService authenticator)
        {
            Authenticator = authenticator;
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DroneLander.MainPage());
        }

        protected override void OnStart()
        {
            MobileCenter.Start($"android={Common.MobileCenterConstants.AndroidAppId};" +
                 $"ios={Common.MobileCenterConstants.iOSAppId}",
                 typeof(Analytics), typeof(Crashes));

            MobileCenter.LogLevel = LogLevel.Verbose;
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}