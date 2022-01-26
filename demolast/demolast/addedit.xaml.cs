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
    /// Interaction logic for addedit.xaml
    /// </summary>
    public partial class addedit : Page
    {
        private fitness_clubs _currentFC = new fitness_clubs();
        public addedit(fitness_clubs selectedfitness_club)
        {
            InitializeComponent();
            if(selectedfitness_club != null)
                _currentFC = selectedfitness_club;
            DataContext = _currentFC;
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentFC.name))
                errors.AppendLine("Укажите имя фитнес клуба");
            if (string.IsNullOrWhiteSpace(_currentFC.address))
                errors.AppendLine("Укажите адресс фитнес клуба");
            if (string.IsNullOrWhiteSpace(_currentFC.number))
                errors.AppendLine("Укажите номер фитнес клуба");
            if (string.IsNullOrWhiteSpace(_currentFC.waterpool))
                errors.AppendLine("Укажите есть ли бассейн");
            if (string.IsNullOrWhiteSpace(_currentFC.web_site))
                errors.AppendLine("Укажите веб-сайт");
            if (string.IsNullOrWhiteSpace(_currentFC.start_work))
                errors.AppendLine("Укажите дату начала работы");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentFC.id_fitness_club == 0)

                demofitnessEntities.GetContext().fitness_clubs.Add(_currentFC);
            try
            {
                demofitnessEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
