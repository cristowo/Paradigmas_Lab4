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

namespace view
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, RoutedEventArgs e)
        {

        }
        //-------------------parte inicial--------------------------------------------
        private void Iniciar_Juego_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window1();
            window.Show();
            this.Close();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CPU_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("En este modo podras observar el transcurso del juego, mientras 2 CPU juegan con una probabilidad de acierto del 66%");
            Window window = new datosdemo();
            window.Show();
            this.Close();
        }


        //----------------------------------------------------------------------------
    }
}
