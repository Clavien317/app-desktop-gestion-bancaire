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
    public partial class Retirer : Form
    {
        string path = "mydb.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\mydb.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Retirer()
        {
            InitializeComponent();
        }

        public void vide()
        {
            numero_compte.Text = "";
            solde.Text = "";

        }

        private void btn_confirmRetrait_Click(object sender, EventArgs e)
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

            var stm = new SQLiteCommand(con);
            stm.CommandText = "SELECT solde FROM client WHERE num_compte=@numero";
            stm.Prepare();
            stm.Parameters.AddWithValue("@numero", numero_compte.Text);
            stm.ExecuteNonQuery();

            using (var dr = stm.ExecuteReader())
            {
                if (dr.Read())
                {
                    int soldeClient = dr.GetInt32(0);

                    if(soldeClient< Convert.ToInt32(solde.Text))
                    {
                        MessageBox.Show("Retrait impossible car solde est insuffisant", "Information");
                    }
                    else
                    { 
                        var cmd = new SQLiteCommand(con);
                        var add = new SQLiteCommand(con);

                        add.CommandText = "INSERT INTO retrait (num_compte,date_retrait,solde) VALUES (@numCompte,@date,@solde)";
                        add.Parameters.AddWithValue("@date", date_retrait.Text);
                        add.Parameters.AddWithValue("@numCompte", numero_compte.Text);
                        add.Parameters.AddWithValue("@solde", solde.Text);
                        add.ExecuteNonQuery();

                        try
                        {
                            cmd.CommandText = "UPDATE client SET solde=solde-@solde WHERE num_compte=@numero ";
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@numero", numero_compte.Text);
                            cmd.Parameters.AddWithValue("@solde", solde.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Executee avec succes", "Success");

                            PrintDialog printDialog = new PrintDialog();
                            printDialog.Document = printDocument1;
                            DialogResult result = printDialog.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                printDocument1.Print();
                            }
                            vide();

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("ERREUR DE D'EXECUTION DE RETRAIT");
                            return;
                        }
                    }
                }
            }

        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*var stm = new SQLiteCommand(con);
            stm.CommandText = "SELECT nom FROM client WHERE num_compte=@numero";
            stm.Prepare();
            stm.Parameters.AddWithValue("@numero", numero_compte.Text);
            stm.ExecuteNonQuery();*/


            e.Graphics.DrawString("RECU DE RETRAIT SUR BNI MADAGASCAR\n\n\n", new Font("Arial", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 10));
            Random random = new Random();

            int num = random.Next(0, 10);
            e.Graphics.DrawString($" \n\n\n Retrait N° 00{num} le {date_retrait.Text} \n sur la numero de compte de notre client {numero_compte.Text}\n somme d'argent {solde.Text} Ariary .", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }
    }
}
