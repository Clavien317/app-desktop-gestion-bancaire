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
    public partial class Rembourse : Form
    {
        string path = "mydb.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\mydb.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Rembourse()
        {
            InitializeComponent();
        }

        public void vide()
        {
            numero_compte.Text = "";
            solde.Text = "";
        }

        private void btn_confirmRembourse_Click(object sender, EventArgs e)
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
            var cmd = new SQLiteCommand(con);
            var add = new SQLiteCommand(con);

            add.CommandText = "UPDATE emprunt SET date_pret=@date, solde=solde-@solde WHERE numero_compte=@numCompte";
            add.Parameters.AddWithValue("@date", date_rembourse.Text);
            add.Parameters.AddWithValue("@numCompte", numero_compte.Text);
            add.Parameters.AddWithValue("@solde", solde.Text);
            add.ExecuteNonQuery();
            vide();
            MessageBox.Show("Votre remboursement est fait avec succes", "Success");

            con.DefaultTimeout = 2000;
            var xd = new SQLiteCommand(con);

            xd.CommandText = "DELETE FROM emprunt WHERE solde<=0";
            xd.ExecuteNonQuery();
        }
    }
}
