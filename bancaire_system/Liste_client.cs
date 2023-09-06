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
    public partial class Liste_client : Form
    {

        string path = "mydb.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\mydb.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Liste_client()
        {
            InitializeComponent();
            //afficher();
            sexe_mod.Items.Add("Homme");
            sexe_mod.Items.Add("Femme");
            afficher_depot();

            panel_modifier.Visible = false;
        }


        private void afficher()
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM client";
                var cmd = new SQLiteCommand(stm, con);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    guna2DataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetInt32(7));
                }

                con.Close();
            }catch(Exception e)
            {
                Console.WriteLine("Erreur d'affichage data "+e.Message);
            }

        }


        private void afficher_depot()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            try
            {
                con.DefaultTimeout = 2000;
                string stm = $"SELECT date_depot,solde FROM depot WHERE num_compte={Numero_compte.Text}";
                var cmd = new SQLiteCommand(stm, con);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Table_depot.Rows.Insert(0, dr.GetString(0), dr.GetInt32(1));
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur d'affichage data au table depot" + e.Message);
            }
            con.Close();
        }

        private void afficher_retrait()
        {
            var conx = new SQLiteConnection(cs);
            conx.Open();
            try
            {
                conx.DefaultTimeout = 2000;
                string stm = $"SELECT date_retrait,solde FROM retrait WHERE num_compte={Numero_compte.Text}";
                var cmd = new SQLiteCommand(stm, conx);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Table_retrait.Rows.Insert(0, dr.GetString(0), dr.GetInt32(1));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur d'affichage data au table retrait" + e.Message);
            }
            conx.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_modifier.Visible = true;
            guna2DataGridView1.Visible = false;
            guna2DataGridView1.Rows.Add(8);
            string[] row = new string[] {};

            colonne.Hide();
            value_search.Hide();

            guna2DataGridView1.Rows.Add(row);

            if (guna2DataGridView1.Rows[e.RowIndex] != null)
            {
                guna2DataGridView1.CurrentRow.Selected = true;

                nom_mod.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Nom"].FormattedValue.ToString();
                prenom_mod.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Prenom"].FormattedValue.ToString();
                sexe_mod.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Sexe"].FormattedValue.ToString();
                Numero_compte.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Numero"].FormattedValue.ToString();
                adresse__mod.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Adresse"].FormattedValue.ToString();
                contact_mod.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Contact"].FormattedValue.ToString();
                Solde.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Capital"].FormattedValue.ToString();
                cin_mod.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Cin"].FormattedValue.ToString();

                afficher_depot();

                afficher_retrait();


                try
                {
                   /* using (var con = new SQLiteConnection(cs)) // Assurez-vous de remplacer "connection_string_here" par votre chaîne de connexion SQLite
                    {
                        con.Open(); // Ouvrir la connexion à la base de données

                        
                        using (var stm = new SQLiteCommand(con))
                        {
                            stm.CommandText = "SELECT solde,date_pret FROM emprunt WHERE numero_compte=@num";
                            stm.Parameters.AddWithValue("@num", Numero_compte.Text);
                            var dr = stm.ExecuteReader();
                            Console.WriteLine(dr+" oooooooooooooooo");


                            //somme_argent.Text = $"Ce compte n'est pas encore remboureser son pret {somme.ToString()} le ";
                            if (dr.Read())
                            {
                                int solde = dr.GetInt32(0);
                                string date = dr.GetString(1);

                                if(solde ==0)
                                {
                                    somme_argent.Text = "   ";
                                }
                                else
                                {
                                    somme_argent.Text = $"Ce compte n'est pas encore remboureser son pret {solde} Ariary le {date} ";
                                }
                            }
                            else
                            {
                                Console.WriteLine("----- Il y a de probleme -----");
                            }
                           
                        }

                        con.Close();
                    }*/

                }
                catch (Exception ed)
                {
                    Console.WriteLine("Erreur lors d'affichage effectif " + ed.Message);
                }
            }
        }

        private void Liste_client_Load(object sender, EventArgs e)
        {
            afficher();

            try
            {
                using (var conxx = new SQLiteConnection(cs) ) // Assurez-vous de remplacer "connection_string_here" par votre chaîne de connexion SQLite
                {
                    conxx.Open(); // Ouvrir la connexion à la base de données

                    using (var stm = new SQLiteCommand(conxx))
                    {
                        stm.CommandText = "SELECT COUNT(cin) FROM client";
                        int eff = Convert.ToInt32(stm.ExecuteScalar()); // Utiliser ExecuteScalar pour obtenir le résultat unique
                        Effectif.Text = eff.ToString(); // Mise à jour de l'UI avec l'effectif
                    }

                    conxx.Close();
                }
            }
            catch (Exception ed)
            {
                Console.WriteLine("Erreur lors d'affichage effectif " + ed.Message);
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            con.DefaultTimeout = 2000;
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "DELETE FROM client WHERE cin=@cin ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@cin", cin_mod.Text);
                cmd.ExecuteNonQuery();
                guna2DataGridView1.Rows.Clear();
                afficher();
                MessageBox.Show("Supprimee avec succes", "Success");
                panel_modifier.Hide();
            }
            catch (Exception)
            {
                Console.WriteLine("ERREUR DE SUPPRESSON....");
                return;
            }

            con.Close();
        }

        public void vide()
        {
            nom_mod.Text = "";
            prenom_mod.Text = "";
            contact_mod.Text = "";
            adresse__mod.Text = "";
            Numero_compte.Text = "";
            cin_mod.Text = "";
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SQLiteConnection(cs))
                using (var cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE client SET contact=@contact,adresse=@adresse,nom=@nom,prenom=@prenom,num_compte=@numero WHERE cin=@cin ";
                    cmd.Parameters.AddWithValue("@cin", cin_mod.Text);
                    cmd.Parameters.AddWithValue("@nom", nom_mod.Text);
                    cmd.Parameters.AddWithValue("@prenom", prenom_mod.Text);
                    cmd.Parameters.AddWithValue("@numero", Numero_compte.Text);
                    cmd.Parameters.AddWithValue("@contact", contact_mod.Text);
                    cmd.Parameters.AddWithValue("@adresse", adresse__mod.Text);

                    // Exécution de la commande à l'intérieur de la connexion ouverte
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Modifiée avec succès", "Success");
                    guna2DataGridView1.Rows.Clear();
                    afficher();

                    conn.Close();
                    vide();
                }

                
            }
            catch (Exception er)
            {
                Console.WriteLine("ERREUR DE MODIFICATION " + er);
            }
        }


        private void Table_depot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       /* private void value_search_TextChanged(object sender, EventArgs e)
        {

            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM client WHERE nom LIKE ";
                var cmd = new SQLiteCommand(stm, con);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    guna2DataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetInt32(7));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur d'affichage data " + ex.Message);
            }
        }*/

        private void Effectif_Click(object sender, EventArgs e)
        {

        }

        private void contact_mod_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_modifier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void value_search_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = $"SELECT * FROM client WHERE {colonne.Text} LIKE '%' || @searchValue || '%' ";
                var cmd = new SQLiteCommand(stm, con);

                cmd.Parameters.AddWithValue("@searchValue", value_search.Text);

                dr = cmd.ExecuteReader();

                guna2DataGridView1.Rows.Clear(); // Nettoyer les données précédentes

                Console.WriteLine($"{colonne.Text} et {value_search.Text}");
                while (dr.Read())
                {
                    object[] rowData = new object[dr.FieldCount];
                    dr.GetValues(rowData); // Récupérer les valeurs de la ligne actuelle

                    guna2DataGridView1.Rows.Add(rowData); // Ajouter une nouvelle ligne avec les valeurs
                }

                dr.Close(); // Fermer le DataReader
            }
            catch (Exception er)
            {
                Console.WriteLine("Erreur d'affichage data " + er.Message);
            }
        }


        private void colonne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
