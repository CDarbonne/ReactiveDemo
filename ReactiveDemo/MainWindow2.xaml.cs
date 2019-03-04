using System.Windows;

namespace ReactiveDemo
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
            DataContext = new AppViewModel();
        }
    }
}
