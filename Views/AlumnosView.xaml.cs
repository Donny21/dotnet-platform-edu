using Kalum21.ViewModels;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Kalum21.Views
{
    public partial class AlumnosView : MetroWindow
    {
        public AlumnosView()
        {
            InitializeComponent();
            AlumnosViewModel ModeloDatos = new AlumnosViewModel(DialogCoordinator.Instance);
            this.DataContext = ModeloDatos;
        }
    }
}