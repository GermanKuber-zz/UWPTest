using App7.Model;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TestUWPSolution.Common.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BindingPage : Page
    {
        public BindingModel ViewModel { get; set; } = new BindingModel();
        public BindingPage()
        {
            this.InitializeComponent();
            ViewModel.Nombre = "Holaa";
        }

        private void button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
