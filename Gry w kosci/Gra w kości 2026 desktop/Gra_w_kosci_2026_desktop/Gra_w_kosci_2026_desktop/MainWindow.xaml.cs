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

namespace Gra_w_kosci_2026_desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Kosc[] kosci;

        private Image[] obrazyKosci;

        public MainWindow()
        {
            InitializeComponent();

            kosci = new Kosc[5];

            for (int i = 0; i < 5; i++)
            {
                kosci[i] = new Kosc(0);
            }

            obrazyKosci = new Image[]
            {
                Koscc1,
                Koscc2,
                Koscc3,
                Koscc4,
                Koscc5
            };

        }
        
        
               

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int suma = 0;

            for (int i = 0; i < 5; i++)
            {
                kosci[i].Rzut();

                suma += kosci[i].LiczbaOczek;

                UstawObrazKosci(i);
            }

            TekstWynik.Text = suma.ToString();
        }







        private void UstawObrazKosci(int numerKosci)
        {
            string nazwaPliku = kosci[numerKosci].Obrazy[kosci[numerKosci].IdentyfikatorPliku];

            obrazyKosci[numerKosci].Source = new BitmapImage(new Uri("/Images/" + nazwaPliku,UriKind.Relative));

            if (kosci[numerKosci].CzyDostepna)
            {
                obrazyKosci[numerKosci].Opacity = 1.0;
            }
            else
            {
                obrazyKosci[numerKosci].Opacity = 0.5;
            }
        }

        private void KlikniecieKosci(int numerKosci)
        {
            if (kosci[numerKosci].CzyDostepna)
            {
                kosci[numerKosci].Blokuj();
                obrazyKosci[numerKosci].Opacity = 0.5;
            }
            else
            {
                kosci[numerKosci].CzyDostepna = true;
                obrazyKosci[numerKosci].Opacity = 1.0;
            }
        }


        private void Koscc5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KlikniecieKosci(4);
        }

        private void Koscc4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KlikniecieKosci(3);

        }

        private void Koscc3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KlikniecieKosci(2);
        }

        private void Koscc2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KlikniecieKosci(1);
        }

        private void Koscc1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KlikniecieKosci(0);
        }
    }
    }
