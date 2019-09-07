﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace KennewickConnect.Droid
{
    [Activity(Label = "KennewickConnect",MainLauncher =true,Theme ="@style/Theme.Splash", Icon = "@drawable/icon")]
    public class SplashScreenActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            StartActivity(typeof(MainActivity));
        }
    }
}