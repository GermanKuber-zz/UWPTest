using App7.Utiles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new BindingTest();
            ViewModel.Dato1 = "Primer Dato";
            ListViewModel = new ObservableCollection<BindingTest> { new BindingTest { Dato1 = "Primero" }, new BindingTest { Dato1 = "Segundo" }, new BindingTest { Dato1 = "Tercero" } };
            CancellationTokenSource cancellation = new CancellationTokenSource(TimeSpan.FromSeconds(8));
            var count = 0;
            RepeatActionEvery(() => {
                this.ViewModel.Dato1 = count.ToString();
                ++count;
            }, TimeSpan.FromSeconds(1), cancellation.Token);
        }
        public static async Task RepeatActionEvery(Action action, TimeSpan interval, CancellationToken cancellationToken)
        {
            while (true)
            {
                action();
                Task task = Task.Delay(interval, cancellationToken);

                try
                {
                    await task;
                }

                catch (TaskCanceledException)
                {
                    return;
                }
            }
        }

        public BindingTest ViewModel { get; set; }
        public ObservableCollection<BindingTest> ListViewModel { get; set; }
        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            ListViewModel.Add(new BindingTest { Dato1 = txtDatos3.Text });
            txtDatos3.Text = "";
        }
    }

    public class BindingTest : BindableBase
    {
        private string _dato1;
        public string Dato1
        {
            get { return this._dato1; }
            set
            {

                SetProperty(ref _dato1, value);
                this._dato1 = value;

            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.

            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
