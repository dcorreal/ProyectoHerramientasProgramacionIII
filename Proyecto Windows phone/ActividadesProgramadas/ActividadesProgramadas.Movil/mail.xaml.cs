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
    public partial class mail : PhoneApplicationPage
    {
        public mail()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("El correo electrónico fue enviado exitosamente!");
        }
    }
}