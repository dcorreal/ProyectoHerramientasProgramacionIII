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
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void editar_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/editar.xaml", UriKind.Relative));
        }

        private void eliminar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Desea eliminar el registro");
        }

        private void cancelar_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}