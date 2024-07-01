using PasswordValidatorMvvm.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordValidatorMvvm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ValidatorViewModel _validatorViewModel;
        public MainWindow()
        {
            InitializeComponent();
            _validatorViewModel = new ValidatorViewModel();
            DataContext = _validatorViewModel;
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}