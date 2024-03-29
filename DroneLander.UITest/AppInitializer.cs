﻿using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DroneLander.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android) 
            {
                return ConfigureApp
                    .Android
                    .EnableLocalScreenshots()
                    .InstalledApp("com.traininglabs.dronelander")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

