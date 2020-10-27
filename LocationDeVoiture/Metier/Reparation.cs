using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReparationPhone.Metier
{
    public class Reparation : BindableBase
    {
        private String nom;
        public String Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                SetProperty(ref this.nom, value);
            }
        }

        private String prenom;
        public String Prenom
        {
            get
            {
                return this.prenom;
            }
            set
            {
                SetProperty(ref this.prenom, value);
            }
        }

        private String email;
        public String Email
        {
            get
            {
                return this.email;
            }

            set
            {
                SetProperty(ref this.email, value);
            }
        }
        private String contact;
        public String Contact
        {
            get
            {
                return this.contact;
            }
            set
            {
                SetProperty(ref this.contact, value);
            }
        }

        private String modelPhone;
        public String ModelPhone
        {
            get { return this.modelPhone; }
            set { SetProperty(ref this.modelPhone, value); }
        }

        private DateTime receivedDate;
        public DateTime ReceivedDate
        {
            get
            {
                return this.receivedDate;
            }
            set
            {
                SetProperty(ref this.receivedDate, value);
            }
        }
        public DateTime ExpectedFinishDate { get; set; }
        private String description;
        public String Description
        {
            get { return this.description; }
            set { SetProperty(ref this.description, value); }
        }
        private int prix;
        public int Prix
        {
            get
            {
                return this.prix;
            }
            set
            {
                SetProperty(ref this.prix, value);
            }
        }
        public Reparation()
        {

        }
        public Reparation(string nom, string prenom,string contact, string email, string modelPhone, string description)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Email = email;
            this.Contact = contact;
            this.ModelPhone = modelPhone;
            this.ReceivedDate = DateTime.Now;
            this.ExpectedFinishDate = this.ReceivedDate.AddDays(15);
            this.Description = description;
        }

        public Reparation(String nom, String prenom, String contact, String email, String modelPhone, String description, int prix) : this(nom,prenom,contact,email,modelPhone,description)
        {
            this.Prix = prix;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
