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
    /// Interaction logic for editaddxaml.xaml
    /// </summary>
    public partial class editaddxaml : Page
    {
        private games _currentGame = new games();
        public editaddxaml()
        {
            InitializeComponent();
            
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                igraEntities.GetContext().SaveChanges();
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
