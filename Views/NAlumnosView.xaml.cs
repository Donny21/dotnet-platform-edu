using Kalum21.ViewModels;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Kalum21.Views
{
    public partial class NAlumnosView: MetroWindow
    {
        private AlumnosViewModel AlumnosViewModel { get; set; }
        public NAlumnosView(AlumnosViewModel AlumnosViewModel)
        {
            InitializeComponent();
            this.AlumnosViewModel = AlumnosViewModel;
            NAlumnosViewModel Modelo = new NAlumnosViewModel(AlumnosViewModel, DialogCoordinator.Instance);
            this.DataContext = Modelo;
        }
    }
}