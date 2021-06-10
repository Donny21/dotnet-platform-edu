using System;
using System.ComponentModel;
using System.Windows.Input;
using Kalum21.Views;

namespace Kalum21.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public string Fondo { get; set; } = $"{Environment.CurrentDirectory}\\Images\\fondo3.jpg";
        public MainViewModel Instancia { get; set; }

        public MainViewModel()
        {
            this.Instancia = this;
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if(parametro.Equals("Alumnos"))
            {
                AlumnosView ventanaAlumnos = new AlumnosView();
                ventanaAlumnos.ShowDialog();
            }
            else if(parametro.Equals("Usuarios"))
            {
                UsuariosView ventanaUsuarios = new UsuariosView();
                ventanaUsuarios.ShowDialog();
            }
            else if(parametro.Equals("Roles"))
            {
                RolesView ventanaRoles = new RolesView();
                ventanaRoles.ShowDialog();
            }
            else if(parametro.Equals("Clases"))
            {
                ClasesView ventanaClases = new ClasesView();
                ventanaClases.ShowDialog();
            }
        }
    }
}