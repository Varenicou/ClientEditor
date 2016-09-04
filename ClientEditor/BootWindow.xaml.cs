﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace ClientEditor
{
    /// <summary>
    /// Interaction logic for BootWindow.xaml
    /// </summary>
    public partial class BootWindow : Window
    {
        private DirectoryInfo num2;
        public BootWindow()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo num = Directory.GetParent(path);
            this.num2 = Directory.GetParent(num.ToString());  
        }

        private void editorChoiceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BitmapImage pic = new BitmapImage();
            try
            {
                pic.BeginInit();
                switch (editorChoiceComboBox.SelectedIndex)
                {
                    case 0:
                        pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "01_CharColor.png");
                        break;
                    case 1: pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "02_Classbase.png");
                        break;
                }
                pic.EndInit();
                editorImage.Source = pic;
                editorImage.Stretch = Stretch.Fill;
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("Something went wrong loading the image.");
            }      
        }

        private void launchButton_Click(object sender, RoutedEventArgs e)
        {
            switch(editorChoiceComboBox.SelectedIndex)
            {
                case 0:
                    MainWindow w = new MainWindow();
                    w.Show();
                    this.Hide();
                    break;
                case 1:
                    ClassBaseEditor cbe = new ClassBaseEditor();
                    cbe.Show();
                    this.Hide();
                    break;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var bericht = MessageBox.Show("Are you sure that you want to quit?", "Quit?", MessageBoxButton.YesNo);
            if(bericht == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
