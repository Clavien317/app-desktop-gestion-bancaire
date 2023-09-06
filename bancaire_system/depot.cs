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
    public partial class depot : Form
    {
        string path = "mydb.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\mydb.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public depot()
        {
            InitializeComponent();
        }

        public void vide()
        {
            numero_compte.Text = "";
            solde.Text = "";

        }


        private void btn_confirmSolde_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(numero_compte.Text))
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                try
                {
                    // Vérifier l'existence du compte
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

                    // Continuer avec le dépôt
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = "UPDATE client SET solde = solde + @solde WHERE num_compte = @numero";
                        cmd.Parameters.AddWithValue("@numero", numero_compte.Text);
                        cmd.Parameters.AddWithValue("@solde", solde.Text);
                        cmd.ExecuteNonQuery();

                        var add = new SQLiteCommand(con);
                        add.CommandText = "INSERT INTO depot (date_depot, num_compte, solde) VALUES (@date, @numCompte, @solde)";
                        add.Parameters.AddWithValue("@date", date_depot.Text);
                        add.Parameters.AddWithValue("@numCompte", numero_compte.Text);
                        add.Parameters.AddWithValue("@solde", solde.Text);
                        add.ExecuteNonQuery();

                        MessageBox.Show("Exécuté avec succès", "Succès");

                        // Reste du code pour l'impression et la réinitialisation des champs
                    }

                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument1;
                    DialogResult result = printDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                    vide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur d'exécution du dépôt : " + ex.Message);
                    MessageBox.Show("Une erreur s'est produite lors du dépôt", "Erreur");
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Information");
            }
        }



        /*private void btn_confirmSolde_Click(object sender, EventArgs e)
        {
            if(numero_compte.Text==null)
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                con.DefaultTimeout = 2000;
                var cmd = new SQLiteCommand(con);
                var add = new SQLiteCommand(con);

                add.CommandText = "INSERT INTO depot (date_depot,num_compte,solde) VALUES (@date,@numCompte,@solde)";
                add.Parameters.AddWithValue("@date", date_depot.Text);
                add.Parameters.AddWithValue("@numCompte", numero_compte.Text);
                add.Parameters.AddWithValue("@solde", solde.Text);
                add.ExecuteNonQuery();

                try
                {
                    cmd.CommandText = "UPDATE client SET solde=solde+@solde WHERE num_compte=@numero ";
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
                    Console.WriteLine("ERREUR DE D'EXECUTION DE DEPOT");
                    return;
                }
            }else
            {
                MessageBox.Show("Veillez remplir", "Information");
            }
        }*/

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("RECU DE DEPOT SUR BNI MADAGASCAR\n\n\n", new Font("Arial", 20, FontStyle.Bold), Brushes.Blue,new Point(10, 10));

            e.Graphics.DrawString($" \n\n\n Depot N° 004 le {date_depot.Text} \n sur la numero de compte de notre client {numero_compte.Text}\n somme d'argent {solde.Text} Ariary .", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }

        private void numero_compte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
