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

namespace Finder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var _imgFileBackPath = "shenhe.png";
            var _relativeImgFileBackPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _imgFileBackPath);

            IMG_Background.Source = new BitmapImage(new Uri(_relativeImgFileBackPath));
            
            var _imgFileFirstLvlPath = "cryo.png";
            var _relativeImgFileFirstLvlPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _imgFileFirstLvlPath);

            var _imgFileSecLvlPath = "electro.png";
            var _relativeImgFileSecLvlPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _imgFileSecLvlPath);

            var _imgFileThirdLvlPath = "pyro.png";
            var _relativeImgFileThirdLvlPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _imgFileThirdLvlPath);

            IMG_Cryo.Source = new BitmapImage(new Uri(_relativeImgFileFirstLvlPath));
            IMG_Electro.Source = new BitmapImage(new Uri(_relativeImgFileSecLvlPath));
            IMG_Pyro.Source = new BitmapImage(new Uri(_relativeImgFileThirdLvlPath));
        }

        private void BN_CryoElement_Click(object sender, RoutedEventArgs e)
        {
            LB_Items.Items.RemoveAt(LB_Items.Items.IndexOf(LI_CryoEye));

            MessageBox.Show("You find first eye");

            BN_CryoElement.Visibility= Visibility.Hidden;
            IMG_Cryo.Visibility= Visibility.Hidden;

            BN_ElectroElement.Visibility = Visibility.Visible;
            IMG_Electro.Visibility = Visibility.Visible;

            var _imgFileBackPath = "keqing.png";
            var _relativeImgFileBackPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _imgFileBackPath);

            IMG_Background.Source = new BitmapImage(new Uri(_relativeImgFileBackPath));
        }

        private void BN_ElectroElement_Click(object sender, RoutedEventArgs e)
        {
            LB_Items.Items.RemoveAt(LB_Items.Items.IndexOf(LI_ElectroEye));

            MessageBox.Show("You find second eye");

            BN_ElectroElement.Visibility = Visibility.Hidden;
            IMG_Electro.Visibility = Visibility.Hidden;

            BN_PyroElement.Visibility = Visibility.Visible;
            IMG_Pyro.Visibility = Visibility.Visible;

            var _imgFileBackPath = "klee.png";
            var _relativeImgFileBackPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _imgFileBackPath);

            IMG_Background.Source = new BitmapImage(new Uri(_relativeImgFileBackPath));
        }

        private void BN_PyroElement_Click(object sender, RoutedEventArgs e)
        {
            LB_Items.Items.RemoveAt(LB_Items.Items.IndexOf(LI_PyroEye));

            MessageBox.Show("You find all eyes");

            BN_PyroElement.Visibility = Visibility.Hidden;
            IMG_Pyro.Visibility = Visibility.Hidden;
        }
    }
}