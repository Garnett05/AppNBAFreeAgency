﻿using AppNBAFreeAgency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNBAFreeAgency.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerInformation : ContentPage
    {
        public PlayerInformation(Player player)
        {
            InitializeComponent();

            BindingContext = player;
            shootThrees.Text = (player.ThreePointShooter == true) ? "Shoot Threes? No" : "Shoot Threes? Yes";
        }
    }
}