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

namespace WPF___Dane_w_XML
{
    /// <summary>
    /// Logika interakcji dla klasy OknoRodzaju.xaml
    /// </summary>
    public partial class OknoRodzaju : Window
    {
        //public object Dane;
        public OknoRodzaju()
        {
            InitializeComponent();
        }
        public OknoRodzaju(object wybranyRodzaj):this()
        {
            this.DataContext = wybranyRodzaj;
            //this.listaRodzajów.ItemsSource = (System.Collections.IEnumerable) wybranyRodzaj;
        }
    }
}
