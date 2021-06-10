using Kalum21.ViewModels;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Kalum21.Views
{
    public partial class ClasesView : MetroWindow
    {
        public ClasesView()
        {
            InitializeComponent();
            ClasesViewModel Modelo = new ClasesViewModel(DialogCoordinator.Instance);
            this.DataContext = Modelo;
        }
    }
}