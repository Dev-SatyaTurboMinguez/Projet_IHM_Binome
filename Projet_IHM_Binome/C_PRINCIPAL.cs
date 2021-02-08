using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace Projet_IHM_Binome
{
    public partial class Controle_JSON : Form
    {
        private C_BASE Ma_Base;
        public Controle_JSON()
        {
            InitializeComponent();

            Ma_Base = new C_BASE();

            Ma_Base.Les_Users.Add(new C_USER() { ID = 1, nom = "User 1", prenom = "Prenom  1", ID_Groupe = 10 });
            Ma_Base.Les_Users.Add(new C_USER() { ID = 2, nom = "User 2", prenom = "Prenom  2", ID_Groupe = 2 });
            Ma_Base.Les_Users.Add(new C_USER() { ID = 3, nom = "User 3", prenom = "Prenom  3", ID_Groupe = 1 });

            Ma_Base.Sauvegarde_Toi();

            Ma_Base.Charge_Toi();

            Listbox_Personnes.DataSource = Ma_Base.Les_Users;
            Listbox_Personnes.DisplayMember = "nom";

           
            Listbox_Personnes.DisplayMember = "prenom";



        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons boutons = MessageBoxButtons.YesNo;

            if (Bouton_sauvegarder.Enabled == true)
            {
                DialogResult Fermeture = MessageBox.Show("La base va etre sauvé si elle a été modifiée", "Quitter Programme ?", boutons);
                if(Fermeture == DialogResult.Yes)
                {
                    Close();
                }
                else
                {
                   
                }
            }

          
            
        }

        private void Bouton_ajouter_Click(object sender, EventArgs e)
        {
            C_USER Nouvelle_Personne = new C_USER();

            //Nouvelle_Personne.ID = Convert.ToInt32(Copie_ID.Text);
            if (textbox_ID.Text.All(char.IsDigit) == true)
            {
                Nouvelle_Personne.ID = Ma_Base.Les_Users.Count + 1;

            }

            Nouvelle_Personne.nom = Copie_Nom.Text;
            Nouvelle_Personne.prenom = Copie_Prenom.Text;
            Nouvelle_Personne.ID_Groupe = Convert.ToInt32(Copie_IDgroupe.Text);

            Ma_Base.Les_Users.Add(Nouvelle_Personne);

            Bouton_sauvegarder.Enabled = true;

            compteur.Text = Listbox_Personnes.Items.Count.ToString();

            


  
           
        }

        private void Bouton_Supprimer_Click(object sender, EventArgs e)
        {
            C_USER Supprimer_user = Listbox_Personnes.SelectedItem as C_USER;

            Ma_Base.Les_Users.Remove(Supprimer_user);
            
            Bouton_sauvegarder.Enabled = true;


        }

        private void Bouton_sauvegarder_Click(object sender, EventArgs e)
        {
            Ma_Base.Sauvegarde_Toi();
            Bouton_sauvegarder.Enabled = false;
        }

        private void Listbox_Personnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_USER User_selectionne = Listbox_Personnes.SelectedItem as C_USER;

            if (User_selectionne != null)
            {
               textbox_nom.Text = User_selectionne.nom;
                textbox_prenom.Text = User_selectionne.prenom;
                textbox_ID.Text = User_selectionne.ID.ToString();
                textbox_IDgroupe.Text = User_selectionne.ID_Groupe.ToString();
            }
        }

        private void label_IDgoupe_Click(object sender, EventArgs e)
        {
            
        }

        private void La_Checkbox_CheckedChanged(object sender, EventArgs e)
        {

            if (La_Checkbox.Checked == true)
            {
                textbox_ID.Enabled = true;
                textbox_IDgroupe.Enabled = true;
                textbox_prenom.Enabled = true;
                textbox_nom.Enabled = true;
            }
            else
            {
                textbox_ID.Enabled = false;
                textbox_IDgroupe.Enabled = false;
                textbox_prenom.Enabled = false;
                textbox_nom.Enabled = false;
            }
                


        }

        private void Bouton_modifier_Click(object sender, EventArgs e) //Seulement id groupe et prenom sont modifiables.
        {
            C_USER User_Select = Listbox_Personnes.SelectedItem as C_USER;

            User_Select.prenom = textbox_prenom.Text;

            User_Select.ID_Groupe = Convert.ToInt32(textbox_IDgroupe.Text);
            Bouton_sauvegarder.Enabled = true;
            La_Checkbox.Checked = false;
            Ma_Base.Sauvegarde_Toi();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Controle_JSON_Load(object sender, EventArgs e)
        {

        }

        private void Copie_ID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
