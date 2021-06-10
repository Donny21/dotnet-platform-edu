using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Kalum21.DataContext;
using Kalum21.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Kalum21.ViewModels
{
    public class RolesViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public RolesViewModel Instancia { get; set; }
        public Roles Seleccionado { get; set; }

        private ObservableCollection<Roles> _Roles;
        public ObservableCollection<Roles> Roles
        {
            get
            {
                if(this._Roles == null)
                {
                    this._Roles = new ObservableCollection<Roles>(DbContext.RolesApp.ToList());
                }
                return this._Roles;
            }
            set
            {
                this._Roles = value;
            }
        }
        public KalumDBContext DbContext = new KalumDBContext();

        public RolesViewModel()
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