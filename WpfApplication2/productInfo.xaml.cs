/*
* Filename    : productInfo.xaml.cs
* Project name: WpfApplication 02
* Author      : Monira Sultana (7308182)
* Date        : October 01/2016
* Description : This file includes information about the application.
*Function includes:   bttOK_click, Function: Close the WPF window.                  
*/


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
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for productInfo.xaml
    /// </summary>
    public partial class productInfo : Window
    {
        public productInfo()
        {
            InitializeComponent();
        }
        private void bttOK_click(object sender, RoutedEventArgs e)
        {
            Close();
            
            
        }
    }
}
