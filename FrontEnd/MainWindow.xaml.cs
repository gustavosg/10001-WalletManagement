using System.Windows;
using FrontEnd.ViewModels.Cadastros;
using Library.Basis.LogGenerator;


namespace FrontEnd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            Log.Info(this.Title, "Iniciando aplicação");
        }

        private void Contas_Click(object sender, RoutedEventArgs e)
        {
            Contas c = new Contas();
            frame1.Navigate(c);


        }


    }
}
