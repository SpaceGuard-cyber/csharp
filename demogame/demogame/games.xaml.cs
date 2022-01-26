using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace demogame
{
    /// <summary>
    /// Interaction logic for games.xaml
    /// </summary>
    public partial class games : Page
    {
        public games()
        {
            InitializeComponent();
            gamesDG.ItemsSource = igraEntities.GetContext().game.ToList();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
                
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new editaddxaml());
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
