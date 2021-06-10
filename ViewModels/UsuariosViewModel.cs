using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Kalum21.DataContext;
using Kalum21.Models;
using Microsoft.EntityFrameworkCore;

namespace Kalum21.ViewModels
{
    public class UsuariosViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public UsuariosViewModel Instancia { get; set; }
        public Usuarios Seleccionado { get; set; }
        private ObservableCollection<Usuarios> _Usuarios;
        public ObservableCollection<Usuarios> Usuarios
        { 
            get
            {
                if(this._Usuarios == null)
                {
                    this._Usuarios = new ObservableCollection<Usuarios>(DbContext.Usuarios.ToList());
                }
                return this._Usuarios;
            } 
            set
            {
                this._Usuarios = value;
            } 
        }
        public KalumDBContext DbContext = new KalumDBContext();
        public UsuariosViewModel()
        {
            this.Instancia = this;
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            
        }
    }
}