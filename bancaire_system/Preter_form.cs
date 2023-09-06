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
    public partial class Preter_form : Form
    {
        string path = "mydb.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\mydb.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Preter_form()
        {
            InitializeComponent();
        }

        public void vide()
        {
            numero_compte.Text = "";
            solde.Text = "";
        }

        private void btn_confirmPret_Click(object sender, EventArgs e)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                using (var checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM client WHERE num_compte = @numero", con))
                {
                    checkCmd.Parameters.AddWithValue("@numero", numero_compte.Text);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("Ce compte n'existe pas", "Information");
                        return;
                    }
                }
                con.DefaultTimeout = 2000;

                var c = new SQLiteCommand(con);

                c.CommandText = "SELECT max(solde) FROM depot WHERE num_compte = @numero";
                c.Parameters.AddWithValue("@numero", numero_compte.Text);
                c.ExecuteNonQuery();

                using (var dr = c.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        int somme = dr.GetInt32(0);

                        if(somme < Convert.ToInt32(solde.Text))
                        {
                            MessageBox.Show($"Demende refusée !! \n vous ne pouvez preter que {somme} ariary", "Avertissement !");
                        }
                        else
                        {
                            var add = new SQLiteCommand(con);
                            add.CommandText = "INSERT INTO emprunt (date_pret,numero_compte,solde) VALUES (@date,@numCompte,@solde)";
                            add.Parameters.AddWithValue("@date", date_pret.Text);
                            add.Parameters.AddWithValue("@numCompte", numero_compte.Text);
                            add.Parameters.AddWithValue("@solde", solde.Text);
                            add.ExecuteNonQuery();
                            vide();
                            MessageBox.Show("Emprunt fait avec succes", "Success");
                        }

                    }
                }

            }catch(Exception error)
            {
                MessageBox.Show("Demende refusée ", "Avertissement");
            }
        }

        private void Preter_form_Load(object sender, EventArgs e)
        {



        }
    }
}
