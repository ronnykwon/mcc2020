using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
using ReparationPhone.Metier;
using ReparationPhone.UI;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReparationPhone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        
        public MainWindow()
        {
            InitializeComponent();
            

            Refresh();

        }

        private void MenuAjouter_Click(object sender, RoutedEventArgs e)
        {
            //APropos nouvelleFenetre = new APropos();
            //nouvelleFenetre.ShowDialog();
            AddReparation reparation = new AddReparation();
            reparation.ShowDialog();
        }

        private void MenuPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printer = new PrintDialog();
            if (printer.ShowDialog() == true)
            {
                printer.PrintVisual(this.lbReparation, "Test");
            }
        }

        private void lbReparation_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int index = this.lbReparation.SelectedIndex;


            AddReparation reparationUi = new AddReparation((Reparation)this.lbReparation.SelectedItem, this) ;
            reparationUi.ShowDialog();
            
        }

        public void Refresh()
        {
            this.lbReparation.ItemsSource = null;
            this.lbReparation.ItemsSource = Business.Reparations;
        }

        private void MenuItemEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            if(saveDialog.ShowDialog() == true)
            {
                String output = Business.Reparations.ToCsv();
                //ExportData.ExportCsv<Reparation>(Business.Reparations.ToList(), saveDialog.FileName);
            }
        }
    }
}
