
/*
* Filename    : MainWindow.xaml.cs
* Project name: WpfApplication 02
* Author      : Monira Sultana (7308182)
* Date        : October 01/2016
* Description : This file includes all WPF functions for creating WPF Notepad application
*               Functions include:   
                      new_click, Function: Open a new file
                      open_click, Function: Open a file 
                      save_click, Function: Save the existing file
                      editBox1_TextChanged, Function: Calculaate the number of character in the text box.
  
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;


namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Notepad  : Window          

    {
        private string currentFileName = "Untitled";
        private bool SaveNeeded = false;
        public Notepad()
        {
            InitializeComponent();
            UpdateWPFText();
        }
        private void UpdateWPFText()
        {
                      
            string tmp = currentFileName + " - Notepad";
            
            this.Title = tmp;
            
        }
        private void new_click(object sender, RoutedEventArgs e)
        {

            if (SaveNeeded==true)
            {
                open();
                SaveNeeded = false;
                
            }
            else
            {
                //editBox1.Clear();
                editBox1.Text = "";

            }
           

        }
        private void open_click(object sender, RoutedEventArgs e)
        {
            if (SaveNeeded == true)
            {
                open();
                
            }
            else
            {
                // Create an instance of the open file dialog box.
                Microsoft.Win32.OpenFileDialog file = new Microsoft.Win32.OpenFileDialog();
               // currentFileName = file.FileNames.ToString();
                file.DefaultExt = ".txt";                 // Default file extension

                file.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";    // Filter files by extension

                // Show open file dialog box
                Nullable<bool> result = file.ShowDialog();

                //currentFileName = file.FileNames.ToString();
                if (result == true)
                {

                    editBox1.Text = File.ReadAllText(file.FileName);  // Open document
                    

                }

            }
            
        }
        private void save_click(object sender, RoutedEventArgs e)
        {
            
            save();
            SaveNeeded = false;

        }
        private void close_click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }
        private void about_click(object sender, RoutedEventArgs e)
        {
            

            productInfo  aboutInfo = new productInfo();
            aboutInfo.ShowDialog();

        }
        
        private void editBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveNeeded = true;
            wordCount.Text = editBox1.Text.Length.ToString();
        }



        void save()                           
        {
            Microsoft.Win32.SaveFileDialog saveFile = new Microsoft.Win32.SaveFileDialog();
            
            saveFile.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFile.ShowDialog() == true)               
            {
                
                currentFileName = saveFile.SafeFileName;                    
                
                UpdateWPFText();
                File.WriteAllText(currentFileName, editBox1.Text);
                SaveNeeded = false;
            }
            


        }
        void open()
        {
           
                const string message = "Do you want to save the changes?";
                const string caption = "Form Closing";
                MessageBoxButton button = MessageBoxButton.YesNoCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = MessageBox.Show(message, caption, button, icon);

                // Process message box results
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        // User pressed Yes button
                        save();
                        SaveNeeded = false;          //does not  makee any change
                        break;
                    case MessageBoxResult.No:
                        // User pressed No button
                        editBox1.Text = "";
                        break;
                    case MessageBoxResult.Cancel:
                        // User pressed Cancel button do nothing

                        break;
                }
            
        }
           
    }
}
