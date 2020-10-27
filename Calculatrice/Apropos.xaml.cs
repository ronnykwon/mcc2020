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

namespace Calculatrice
{
    /// <summary>
    /// Interaction logic for Apropos.xaml
    /// </summary>
    public partial class Apropos : Window
    {
        private MainWindow main;
        public Apropos(MainWindow mw)
        {
            InitializeComponent();
            this.main = mw;
        }

        public ItemCollection GetHistory()
        {
            return this.History.Items;
        }

        public ListBox GetHistoryListBox()
        {
            return this.History;
        }

        private void History_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.main.UpdateHistorySelectedLabel(this.History.SelectedItem.ToString());
        }
    }
}
