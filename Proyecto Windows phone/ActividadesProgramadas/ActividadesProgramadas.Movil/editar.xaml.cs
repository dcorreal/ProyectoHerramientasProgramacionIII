using System;
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
    public partial class editar : PhoneApplicationPage
    {
        public editar()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/page1.xaml", UriKind.Relative));
        }

        private void guardar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("¿Desea guardar los cambios realizados?");
        }

        private void prueba_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/alertas.xaml", UriKind.Relative));
        }
    }
}