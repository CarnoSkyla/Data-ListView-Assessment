﻿using FlagData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlagFacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllFlagsPage : ContentPage
    {
        public AllFlagsPage()
        {
            InitializeComponent();
            BindingContext = DependencyService.Get<FlagDetailsViewModel>();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await this.Navigation.PushAsync(new FlagDetailsPage());
        }
    }
}