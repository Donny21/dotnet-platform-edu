
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Kalum21.DataContext;
using Kalum21.Models;
using MahApps.Metro.Controls.Dialogs;
using System.Linq;

namespace Kalum21.ViewModels
{
    public class ClasesViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public ClasesViewModel Instancia { get; set; }
        public Clases Seleccionado { get; set; }
        private IDialogCoordinator DialogCoordinator { get; set; }
        public KalumDBContext DBContext = new KalumDBContext();
        private ObservableCollection<Clases> _Clases;
        public ObservableCollection<Clases> Clases
        {
            get
            {
                if(this._Clases == null)
                {
                    this._Clases = new ObservableCollection<Clases>(DBContext.Clases.ToList());
                }
                return this._Clases;
            }
            set
            {
                this._Clases = value;
            }
        }

        public ClasesViewModel(IDialogCoordinator DialogCoordinator)
        {
            this.Instancia = Instancia;
            this.DialogCoordinator = DialogCoordinator;
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