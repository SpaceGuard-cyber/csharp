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
 
namespace demo2
{
    /// <summary>
    /// Interaction logic for clubs.xaml
    /// </summary>
    public partial class clubs : Page
    {
        public clubs()
        {
            InitializeComponent();
            //fitness_clubsDG.ItemsSource = demoEntities.GetContext().fintess_clubs.ToList();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addedit());
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                demoEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                fitness_clubsDG.ItemsSource = demoEntities.GetContext().fintess_clubs.ToList();
            }
        }
    }
}
