using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace bancaire_system
{
    public partial class Inscription : Form
    {
        string path = "mydb.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\mydb.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Inscription()
        {
            InitializeComponent();

            sexe.Items.Add("Homme");
            sexe.Items.Add("Femme");
            createDB();
        }

        public void vide()
        {
            nom_cli.Text = "";
            prenom_cli.Text = "";
            Numero_compte.Text = "";
            adresse_cli.Text = "";
            contact.Text = "";
            cin_cli.Text = "";
            solde.Text = "";

        }

        private void btn_confirm_inscrit_Click(object sender, EventArgs e)
        {
            string nom = nom_cli.Text;
            string prenom = prenom_cli.Text;
            string numComte = Numero_compte.Text;
            string adresse = adresse_cli.Text;
            string sex = sexe.SelectedItem.ToString();
            string cin = cin_cli.Text;
            string contacts = contact.Text;
            string capital = solde.Text;

            con = new SQLiteConnection(cs);
            con.Open();
            con.DefaultTimeout = 2000;
            cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO client (nom,prenom,num_compte,sexe,cin,contact,adresse,solde) VALUES (@nom,@prenom,@numComte,@sexe,@cin,@contacts,@adresse,@solde)";

            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@numComte", numComte);
            cmd.Parameters.AddWithValue("@sexe", sex);
            cmd.Parameters.AddWithValue("@cin", cin);
            cmd.Parameters.AddWithValue("@contacts", contacts);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@solde", capital);

            cmd.ExecuteNonQuery();
            vide();
            MessageBox.Show("Votre ajout est fait avec success", "Success");

            con.Close();
        }

        private void createDB()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);

                using (var sqlite = new SQLiteConnection(@"Data Source =" + path))
                {
                    sqlite.Open();

                    string sql = "CREATE TABLE client (nom varchar(60),prenom varchar(60),num_compte varchar(30),sexe varchar(20),cin varchar(15),contact varchar(60),adresse varchar(60), solde int) ";

                    SQLiteCommand comand = new SQLiteCommand(sql, sqlite);

                    comand.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("DATABASE CAN'T CREATE");
                return;
            }
        }
    }
}
