using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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

namespace Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Detail detail;
        private Apropos aPropos;
        public MainWindow()
        {
            InitializeComponent();
            this.detail = new Detail();
            this.aPropos = new Apropos(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayTotal();
            //this.detail.Show();
        }

        private void DisplayTotal()
        {
            int total = 0;
            String history = "";
            
            Console.WriteLine(this.nombreA.Text);
            int a = int.Parse(this.nombreA.Text);
            int b = int.Parse(this.nombreB.Text);
            if (this.plusButton.IsChecked.Value)
            {
                total = a + b;
                history = String.Format("{0} + {1} = {2}", a, b, total);
            }
            else if (this.minusButton.IsChecked.Value)
            {
                total = a - b;
                history = String.Format("{0} - {1} = {2}", a, b, total);
            }
            else if (this.multiplyButton.IsChecked.Value)
            {
                total = a * b;
                history = String.Format("{0} * {1} = {2}", a, b, total);
            }
            else if (this.divideButton.IsChecked.Value)
            {
                total = (int)a / b;
                history = String.Format("{0} / {1} = {2}", a, b, total);
            }

            this.aPropos.GetHistory().Add(history);
            this.LabelTotal.Content = total;
        }

        private void nombreB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return) 
                // appuie sur enter
                DisplayTotal();
        }

        public void UpdateHistorySelectedLabel(String content)
        {
            this.labelItemSelected.Content = content;
        }

        private void Clear() {
            this.aPropos.GetHistory().Clear();
            this.nombreA.Text = "";
            this.nombreB.Text = "";
            this.LabelTotal.Content = "";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void OpenMenu()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == true)
            {
                this.Clear();
                string[] content = File.ReadAllLines(openDialog.FileName);
                for (int i = 0; i < content.Length; i++)
                {
                    this.aPropos.GetHistory().Add(content[i]);
                }
            }
        }
        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenMenu();
        }

        private void SaveMenu()
        {

            string[] items = new string[this.aPropos.GetHistory().Count];
            for (int i = 0; i < this.aPropos.GetHistory().Count; i++)
            {
                items[i] = this.aPropos.GetHistory()[i].ToString();
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            if (saveDialog.ShowDialog() == true)
            {
                File.WriteAllLines(saveDialog.FileName, items);
            }
        }

        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            SaveMenu();
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }


        




        private void Save()
        {
            string[] toto = new string[2];




            // 1. initialiser le tableau de string avec la taille de la liste
            // string[] content 
            // this.aPropos.GetHistory().Count
            // 2. Parcourir toute ma liste pour affecter chaque element à mon tableau
            // boucle for
            // content[i] = this.aPropos.GetHistory()[i]
            // 3. Sauvegarder en appelant File.WriteAllLine avec notre tableau de string
            
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //if(saveFileDialog.ShowDialog() == true)
            //{
            //    File.WriteAllLines(saveFileDialog.FileName MON_TABLEAU_DE_STRING);
            //}
        }

        private void MenuHistory_Click(object sender, RoutedEventArgs e)
        {
            this.aPropos.Show();
        }
    }
}
