﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ActividadesProgramadas.Movil
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/NuevaActividad.xaml", UriKind.Relative));
        }

        private void buscar_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate( 
                new Uri("/Page1.xaml", UriKind.Relative));
        }

        private void alerta_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/alertas.xaml", UriKind.Relative));
        }

    }
}