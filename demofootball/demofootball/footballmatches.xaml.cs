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

namespace demofootball
{
    /// <summary>
    /// Interaction logic for footballmatches.xaml
    /// </summary>
    public partial class footballmatches : Page
    {
        public footballmatches()
        {
            InitializeComponent();
            //FMDG.ItemsSource = demofootballEntities.GetContext().footballmatches.ToList();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addedit());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                demofootballEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                FMDG.ItemsSource = demofootballEntities.GetContext().footballmatches.ToList();
            }
        }
    }
}
