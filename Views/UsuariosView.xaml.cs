using Kalum21.ViewModels;
using MahApps.Metro.Controls;

namespace Kalum21.Views
{
    public partial class UsuariosView : MetroWindow
    {
        public UsuariosView()
        {
            InitializeComponent();
            UsuariosViewModel ModeloDatos = new UsuariosViewModel();
            this.DataContext = ModeloDatos;
        }
        
    }
}