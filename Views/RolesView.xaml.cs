using Kalum21.ViewModels;
using MahApps.Metro.Controls;

namespace Kalum21.Views
{
    public partial class RolesView : MetroWindow
    {
        public RolesView()
        {
            InitializeComponent();
            RolesViewModel ModeloDatos = new RolesViewModel();
            this.DataContext = ModeloDatos;
        }
    }
}