﻿using System;
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

namespace demoekzam_405_maslennikov
{
    /// <summary>
    /// Interaction logic for CinemaPage.xaml
    /// </summary>
    public partial class CinemaPage : Page
    {
        public CinemaPage()
        {
            InitializeComponent();
            DGCinemas.ItemsSource = entity.GetContext().seances.ToList();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
