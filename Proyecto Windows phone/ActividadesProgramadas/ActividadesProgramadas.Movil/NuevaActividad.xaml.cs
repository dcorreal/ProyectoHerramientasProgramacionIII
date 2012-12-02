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
    public partial class NuevaActividad : PhoneApplicationPage
    {   
        public NuevaActividad()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(
            new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void guardar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("¿Desea guardar la información?"); 
        }

        private void email_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/mail.xaml", UriKind.Relative));
        }


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {


        }

        private void borrar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Esta acción borrará los registros");
        }
    }
}