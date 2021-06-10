using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Kalum21.DataContext;
using Kalum21.Models;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Kalum21.ViewModels
{
    public class NAlumnosViewModel : INotifyPropertyChanged, ICommand
    {
        public string Carnet { get; set; }
        public string NoExpediente { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }

        //RELACIONAMOS CON LA BBDD
        private KalumDBContext DbContext;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public NAlumnosViewModel Instancia { get; set; }
        public AlumnosViewModel AlumnosViewModel { get; set; }
        //public Alumnos Seleccionado { get; set; }
        private IDialogCoordinator dialogCoordinator { get; set; }
        public string Titulo { get; set; }        

        public NAlumnosViewModel(AlumnosViewModel AlumnosViewModel, IDialogCoordinator instance)
        {
            this.Instancia = this;
            this.DbContext = new KalumDBContext();
            this.AlumnosViewModel = AlumnosViewModel;
            this.dialogCoordinator = instance;

            if(this.AlumnosViewModel.Seleccionado != null)
            {
                this.Carnet = this.AlumnosViewModel.Seleccionado.Carnet;
                this.NoExpediente = this.AlumnosViewModel.Seleccionado.NoExpediente;
                this.Apellidos = this.AlumnosViewModel.Seleccionado.Apellidos;
                this.Nombres = this.AlumnosViewModel.Seleccionado.Nombres;
                this.Email = this.AlumnosViewModel.Seleccionado.Email;
                this.Titulo = "Nuevo Registro";
            }
            else if(this.AlumnosViewModel.Seleccionado == null)
            {
                this.Titulo = "Modificar Registro";
            }
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public async void Execute(object parametro)
        {
            if (parametro.Equals("Guardar"))
            {
                try
                {
                    if(this.AlumnosViewModel.Seleccionado == null)
                    {
                        var ApellidosParamenter = new SqlParameter("@Apellidos", this.Apellidos);
                        var NombresParameter = new SqlParameter("@Nombres", this.Nombres);
                        var EmailParameter = new SqlParameter("@Email", this.Email);
                        var Resultado = this.DbContext
                                            .Alumnos
                                            .FromSqlRaw("sp_registar_alumno @Apellidos, @Nombres, @Email", ApellidosParamenter, NombresParameter, EmailParameter)
                                              .ToList();
                        foreach(object registro in Resultado)
                        {
                            this.AlumnosViewModel.Alumnos.Add((Alumnos)registro);
                        }
                        await dialogCoordinator.ShowMessageAsync(this, "Alumnos", "Registro Almacenado!!!");

                        
                    }
                    else if(this.AlumnosViewModel.Seleccionado != null)
                    {
                        int posicion = this.AlumnosViewModel.Alumnos.IndexOf(this.AlumnosViewModel.Seleccionado);
                        Alumnos temporal = new Alumnos();
                        temporal.Carnet = this.AlumnosViewModel.Seleccionado.Carnet;
                        temporal.NoExpediente = this.NoExpediente;
                        temporal.Apellidos = this.Apellidos;
                        temporal.Nombres = this.Nombres;
                        temporal.Email = this.Email;

                        this.DbContext.Entry(temporal).State = EntityState.Modified;
                        this.AlumnosViewModel.Alumnos.RemoveAt(posicion);
                        this.AlumnosViewModel.Alumnos.Insert(posicion,temporal);
                        this.DbContext.SaveChanges();
                        await dialogCoordinator.ShowMessageAsync(this, "Alumnos", "Registro Actualizado!!!");
                    }
                    
                    //((Window)parametro).Close();
                }
                catch(Exception e)
                {
                    await dialogCoordinator.ShowMessageAsync(this, "Error", e.Message);
                }
            }
        }
    }
}