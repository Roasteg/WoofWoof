﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Plugin.SimpleAudioPlayer;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace MasterDetail.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class dog1 : ContentPage
    {
        public dog1()
        {
            InitializeComponent();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            eskimo.GestureRecognizers.Add(tap);

        }

        private async void Tap_Tapped(object sender, EventArgs e)
        {
            var wiki = await DisplayAlert("Внимание!", "Сейчас будет открыта википедия, продолжить?", "Да", "Нет");
            if (wiki == true)
            {
                await Browser.OpenAsync("https://ru.wikipedia.org/wiki/Вельш-корги", BrowserLaunchMode.SystemPreferred);
            }
        }

        private void bark_Pressed(object sender, EventArgs e)
        {
            new StreamSound("EskimoBarking.mp3");
        }
    }
}