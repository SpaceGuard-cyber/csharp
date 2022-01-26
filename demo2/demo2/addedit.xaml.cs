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
    /// Interaction logic for addedit.xaml
    /// </summary>
    public partial class addedit : Page
    {
        private fintess_clubs _currentFC = new fintess_clubs();
        public addedit()
        {
            InitializeComponent();
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

            _currentFC.start_work = Convert.ToDateTime(_datetime.Text.Trim());
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentFC.id_fitness_club == 0)
                demoEntities.GetContext().fintess_clubs.Add(_currentFC);
            try
            {
                demoEntities.GetContext().SaveChanges();
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
