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

namespace demolast
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
            var _currentfitness = demofitnessEntities.GetContext().fitness_clubs.ToList();
            
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new addedit((sender as Button).DataContext as fitness_clubs));
        }


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addedit(null));
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            var fitness_clubsforRemoving = fitness_clubsDG.SelectedItems.Cast<fitness_clubs>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {fitness_clubsforRemoving.Count()} элементов?", "Вниание",
                MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    demofitnessEntities.GetContext().fitness_clubs.RemoveRange(fitness_clubsforRemoving);
                    demofitnessEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    
                    fitness_clubsDG.ItemsSource = demofitnessEntities.GetContext().fitness_clubs.ToList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                demofitnessEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                fitness_clubsDG.ItemsSource = demofitnessEntities.GetContext().fitness_clubs.ToList();
            }
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            fitness_clubsDG.ItemsSource = demofitnessEntities.GetContext().fitness_clubs.ToList().Where(a => a.name.ToLower().Contains(Search.Text.ToLower()));
            
        }
    }
}
