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
    /// Interaction logic for addedit.xaml
    /// </summary>
    public partial class addedit : Page
    {
        private footballmatches _currentfootballmatch = new footballmatches();
        public addedit()
        {
            InitializeComponent();

            DataContext = _currentfootballmatch;
/*
            city1.ItemsSource = demofootballEntities.GetContext().teams.ToList();
            city2.ItemsSource = demofootballEntities.GetContext().teams.ToList();
            team1.ItemsSource = demofootballEntities.GetContext().footballplayers.ToList();
            team2.ItemsSource = demofootballEntities.GetContext().footballplayers.ToList(); */
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentfootballmatch.date_footballmatch))
                errors.AppendLine("Вы не ввели дату проведения матча");
            if (string.IsNullOrWhiteSpace(_currentfootballmatch.name_comand))
                errors.AppendLine("Вы не ввели название первой команды");
            if (string.IsNullOrWhiteSpace(_currentfootballmatch.name_comand2))
                errors.AppendLine("Вы не ввели название второй команды");
            if (string.IsNullOrWhiteSpace(_currentfootballmatch.point))
                errors.AppendLine("Вы не ввели счет с которыем матч окончился");
            if (string.IsNullOrWhiteSpace(_currentfootballmatch.place_footballmatch))
                errors.AppendLine("Вы не ввели место проведения матча");
/*            if (_currentfootballmatch.teams.city == null)
                errors.AppendLine("Вы не выбрали город для первой команды");
            if (_currentfootballmatch.teams.city == null)
                errors.AppendLine("Вы не выбрали город для второй команды");
            if (_currentfootballmatch.footballplayers.FIO == null)
                errors.AppendLine("Вы не выбрали игроков для первой команды");
            if (_currentfootballmatch.footballplayers.FIO == null)
                errors.AppendLine("Вы не выбрали игроков для второй команды");*/

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentfootballmatch.id_footballmatches == 0)
                demofootballEntities.GetContext().footballmatches.Add(_currentfootballmatch);
            try 
            { 
                demofootballEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.GoBack();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
              
        }
    }
}
