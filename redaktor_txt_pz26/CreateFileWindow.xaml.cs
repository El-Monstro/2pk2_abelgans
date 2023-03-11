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
using System.Windows.Shapes;

namespace redaktor_txt_pz26
{
    /// <summary>
    /// Логика взаимодействия для CreateFileWindow.xaml
    /// </summary>
    public partial class CreateFileWindow : Window
    {
        public CreateFileWindow()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        public string FileName
        {
            get { return fileNameBox.Text; }
        }
    }
}
