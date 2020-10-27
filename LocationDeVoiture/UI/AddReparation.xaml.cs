using ReparationPhone.Metier;
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

namespace ReparationPhone.UI
{
    /// <summary>
    /// Interaction logic for AddReparation.xaml
    /// </summary>
    public partial class AddReparation : Window
    {
        private MainWindow main;
        private Mode mode;
        private Reparation reparation;
        public AddReparation()
        {
            InitializeComponent();
            
        }

        public AddReparation(Reparation r, MainWindow mw) : this()
        {
            this.main = mw;
            FeedUi(r);
            this.reparation = r;
            this.mode = Mode.Edit;
            this.DataContext = this.reparation;
        }

        private void FeedUi(Reparation r)
        {
            //this.tbNom.Text = r.Nom;
            this.tbPrenom.Text = r.Prenom;
            this.tbMobile.Text = r.Contact;
            this.tbModel.Text = r.ModelPhone;
            this.tbEmail.Text = r.Email;
            this.tbDescription.Text = r.Description;
        }

        public void Record_Reparation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(this.mode == Mode.Edit)
                {
                    this.reparation.Nom = this.tbNom.Text;
                    //this.main.Refresh();
                }else { 
                    Reparation rep = new Reparation(this.tbNom.Text, this.tbPrenom.Text, this.tbMobile.Text, this.tbEmail.Text, this.tbModel.Text, this.tbDescription.Text);
                    Business.Reparations.Add(rep);
                }

                
                this.Close();
                MessageBox.Show("Le téléphone a bien été enregistré", "toto", MessageBoxButton.OK);
            }catch(Exception ex)
            {

            }

        }

        public void ShowEditDialog(Reparation r)
        {
            this.mode = Mode.Edit;
            this.tbNom.Text = r.Nom;
            this.ShowDialog();

        }
    }
}
