using App7.Model;
using Windows.UI.Xaml.Controls;

namespace App7.View
{

    public sealed partial class Binding : Page
    {
        public BindingModel ViewModel { get; set; }
        public Binding()
        {
            this.InitializeComponent();
        
        }
    }
}
