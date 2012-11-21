using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace ActividadesProgramadas.Movil
{
    public class Claseprincipal
    {
        private ObservableCollection<Actividad> lista = new ObservableCollection<Actividad>();

        public ObservableCollection<Actividad> Lista
        {
            get { return lista; }
            set { lista = value; }
        }
    }
}
