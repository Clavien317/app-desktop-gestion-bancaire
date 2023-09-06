using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancaire_system
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();

            btn_inscrir.Hide();
            liste_client.Hide();
            btn_preter.Hide();
            btn_rembourse.Hide();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            btn_menu.Hide();
            btn_inscrir.Show();
            liste_client.Show();
            btn_preter.Show();
            btn_rembourse.Show();
        }


        private void btn_inscrir_Click_1(object sender, EventArgs e)
        {
            Inscription form = new Inscription();

            form.Show();
        }

        private void liste_client_Click_1(object sender, EventArgs e)
        {
            Liste_client liste = new Liste_client();

            liste.Show();
        }

        private void depot_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            depot depot = new depot();
            depot.Visible = true;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Retirer retire = new Retirer();

            retire.Show();
        }

        private void btn_preter_Click(object sender, EventArgs e)
        {
            Preter_form pret = new Preter_form();
            pret.Show();
        }

        private void btn_rembourse_Click(object sender, EventArgs e)
        {
            Rembourse rembourse = new Rembourse();
            rembourse.Show();
        }
    }
}
