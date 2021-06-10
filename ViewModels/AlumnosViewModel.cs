using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Kalum21.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Kalum21.DataContext;
using Kalum21.Views;
using MahApps.Metro.Controls.Dialogs;

namespace Kalum21.ViewModels
{
    public class AlumnosViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public AlumnosViewModel Instancia { get; set; }
        public Alumnos Seleccionado { get; set; }
        private IDialogCoordinator dialogCoordinator { get; set; }
        private ObservableCollection<Alumnos> _Alumnos;
        public ObservableCollection<Alumnos> Alumnos
        {
            get
            {
                if(this._Alumnos == null)
                {
                    this._Alumnos = new ObservableCollection<Alumnos>(DbContext.Alumnos.ToList());
                }
                return this._Alumnos;
            }
            set
            {
                this._Alumnos = value;
            }
        }
        public KalumDBContext DbContext = new KalumDBContext();

        public AlumnosViewModel(IDialogCoordinator instance)
        {
            this.Instancia = this;
            this.dialogCoordinator = instance;
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public async void Execute(object parametro)
        {
            if(parametro.Equals("Nuevo"))
            {
                this.Seleccionado = null;
                NAlumnosView ventanaAlumnos = new NAlumnosView(this.Instancia);
                ventanaAlumnos.ShowDialog();
            }
            else if(parametro.Equals("Modificar"))
            {
                if(this.Seleccionado == null)
                {
                    await this.dialogCoordinator.ShowMessageAsync(this, "Alumnos","Debe seleccionar un elemento",MessageDialogStyle.Affirmative);
                }
                else 
                {
                    NAlumnosView ventanaAlumnos = new NAlumnosView(this.Instancia);
                    ventanaAlumnos.ShowDialog();
                }
            }
            else if(parametro.Equals("Eliminar"))
            {
                if(this.Seleccionado == null)
                {
                    await this.dialogCoordinator.ShowMessageAsync(this, 
                    "Alumnos","Debe seleccionar un elemento",
                    MessageDialogStyle.Affirmative);

                }
                else
                {
                    MessageDialogResult resultado = await this.dialogCoordinator.ShowMessageAsync(this, 
                    "Eliminar", "Esta seguro de eliminar el registro", 
                    MessageDialogStyle.AffirmativeAndNegative);
                    if(resultado == MessageDialogResult.Affirmative)
                    {
                        try
                        {
                            int posicion = this.Alumnos.IndexOf(this.Seleccionado);
                            this.DbContext.Remove(this.Seleccionado);
                            this.DbContext.SaveChanges();
                            this.Alumnos.RemoveAt(posicion);
                            await this.dialogCoordinator.ShowMessageAsync(this, "Alumnos","Registro Eliminado");
                        }
                        catch(Exception e)
                        {
                            await this.dialogCoordinator.ShowMessageAsync(this, "Error", e.Message);
                        }                        
                    }
                }
            }
        }
    }
}