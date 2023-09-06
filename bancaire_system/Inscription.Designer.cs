namespace bancaire_system
{
    partial class Inscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nom_cli = new Guna.UI2.WinForms.Guna2TextBox();
            this.prenom_cli = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_confirm_inscrit = new Guna.UI2.WinForms.Guna2Button();
            this.adresse_cli = new Guna.UI2.WinForms.Guna2TextBox();
            this.cin_cli = new Guna.UI2.WinForms.Guna2TextBox();
            this.contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.solde = new Guna.UI2.WinForms.Guna2TextBox();
            this.sexe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Numero_compte = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Blue;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(60, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1341, 73);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(544, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSCRIPTION";
            // 
            // nom_cli
            // 
            this.nom_cli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom_cli.DefaultText = "";
            this.nom_cli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom_cli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom_cli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom_cli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom_cli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom_cli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom_cli.ForeColor = System.Drawing.Color.Black;
            this.nom_cli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom_cli.Location = new System.Drawing.Point(217, 116);
            this.nom_cli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nom_cli.Name = "nom_cli";
            this.nom_cli.PasswordChar = '\0';
            this.nom_cli.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nom_cli.PlaceholderText = "Nom du client";
            this.nom_cli.SelectedText = "";
            this.nom_cli.Size = new System.Drawing.Size(474, 62);
            this.nom_cli.TabIndex = 1;
            // 
            // prenom_cli
            // 
            this.prenom_cli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prenom_cli.DefaultText = "";
            this.prenom_cli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prenom_cli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prenom_cli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom_cli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom_cli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom_cli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prenom_cli.ForeColor = System.Drawing.Color.Black;
            this.prenom_cli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom_cli.Location = new System.Drawing.Point(741, 116);
            this.prenom_cli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prenom_cli.Name = "prenom_cli";
            this.prenom_cli.PasswordChar = '\0';
            this.prenom_cli.PlaceholderForeColor = System.Drawing.Color.Black;
            this.prenom_cli.PlaceholderText = "Prenom";
            this.prenom_cli.SelectedText = "";
            this.prenom_cli.Size = new System.Drawing.Size(498, 62);
            this.prenom_cli.TabIndex = 2;
            // 
            // btn_confirm_inscrit
            // 
            this.btn_confirm_inscrit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm_inscrit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm_inscrit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirm_inscrit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirm_inscrit.FillColor = System.Drawing.Color.Blue;
            this.btn_confirm_inscrit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_confirm_inscrit.ForeColor = System.Drawing.Color.White;
            this.btn_confirm_inscrit.Location = new System.Drawing.Point(507, 536);
            this.btn_confirm_inscrit.Name = "btn_confirm_inscrit";
            this.btn_confirm_inscrit.Size = new System.Drawing.Size(401, 68);
            this.btn_confirm_inscrit.TabIndex = 3;
            this.btn_confirm_inscrit.Text = "Confirmer";
            this.btn_confirm_inscrit.Click += new System.EventHandler(this.btn_confirm_inscrit_Click);
            // 
            // adresse_cli
            // 
            this.adresse_cli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adresse_cli.DefaultText = "";
            this.adresse_cli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adresse_cli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adresse_cli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adresse_cli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adresse_cli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adresse_cli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adresse_cli.ForeColor = System.Drawing.Color.Black;
            this.adresse_cli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adresse_cli.Location = new System.Drawing.Point(217, 313);
            this.adresse_cli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adresse_cli.Name = "adresse_cli";
            this.adresse_cli.PasswordChar = '\0';
            this.adresse_cli.PlaceholderForeColor = System.Drawing.Color.Black;
            this.adresse_cli.PlaceholderText = "Adresse du client";
            this.adresse_cli.SelectedText = "";
            this.adresse_cli.Size = new System.Drawing.Size(474, 62);
            this.adresse_cli.TabIndex = 5;
            // 
            // cin_cli
            // 
            this.cin_cli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cin_cli.DefaultText = "";
            this.cin_cli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cin_cli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cin_cli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cin_cli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cin_cli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cin_cli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cin_cli.ForeColor = System.Drawing.Color.Black;
            this.cin_cli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cin_cli.Location = new System.Drawing.Point(741, 313);
            this.cin_cli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cin_cli.Name = "cin_cli";
            this.cin_cli.PasswordChar = '\0';
            this.cin_cli.PlaceholderForeColor = System.Drawing.Color.Black;
            this.cin_cli.PlaceholderText = "Numero CIN du client";
            this.cin_cli.SelectedText = "";
            this.cin_cli.Size = new System.Drawing.Size(498, 62);
            this.cin_cli.TabIndex = 7;
            // 
            // contact
            // 
            this.contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contact.DefaultText = "";
            this.contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contact.ForeColor = System.Drawing.Color.Black;
            this.contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contact.Location = new System.Drawing.Point(217, 407);
            this.contact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contact.Name = "contact";
            this.contact.PasswordChar = '\0';
            this.contact.PlaceholderForeColor = System.Drawing.Color.Black;
            this.contact.PlaceholderText = "Tel / email";
            this.contact.SelectedText = "";
            this.contact.Size = new System.Drawing.Size(474, 59);
            this.contact.TabIndex = 9;
            // 
            // solde
            // 
            this.solde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.solde.DefaultText = "";
            this.solde.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.solde.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.solde.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.solde.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.solde.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.solde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.solde.ForeColor = System.Drawing.Color.Black;
            this.solde.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.solde.Location = new System.Drawing.Point(741, 407);
            this.solde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.solde.Name = "solde";
            this.solde.PasswordChar = '\0';
            this.solde.PlaceholderForeColor = System.Drawing.Color.Black;
            this.solde.PlaceholderText = "Solde initial";
            this.solde.SelectedText = "";
            this.solde.Size = new System.Drawing.Size(498, 59);
            this.solde.TabIndex = 10;
            // 
            // sexe
            // 
            this.sexe.BackColor = System.Drawing.Color.Transparent;
            this.sexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sexe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sexe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sexe.ForeColor = System.Drawing.Color.Black;
            this.sexe.ItemHeight = 30;
            this.sexe.Location = new System.Drawing.Point(741, 229);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(498, 36);
            this.sexe.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(951, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sexe";
            // 
            // Numero_compte
            // 
            this.Numero_compte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Numero_compte.DefaultText = "";
            this.Numero_compte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Numero_compte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Numero_compte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Numero_compte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Numero_compte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Numero_compte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Numero_compte.ForeColor = System.Drawing.Color.Black;
            this.Numero_compte.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Numero_compte.Location = new System.Drawing.Point(217, 217);
            this.Numero_compte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Numero_compte.Name = "Numero_compte";
            this.Numero_compte.PasswordChar = '\0';
            this.Numero_compte.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Numero_compte.PlaceholderText = "Numero de compte";
            this.Numero_compte.SelectedText = "";
            this.Numero_compte.Size = new System.Drawing.Size(474, 63);
            this.Numero_compte.TabIndex = 14;
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1398, 635);
            this.Controls.Add(this.Numero_compte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.solde);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.cin_cli);
            this.Controls.Add(this.adresse_cli);
            this.Controls.Add(this.btn_confirm_inscrit);
            this.Controls.Add(this.prenom_cli);
            this.Controls.Add(this.nom_cli);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Inscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscription";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox nom_cli;
        private Guna.UI2.WinForms.Guna2TextBox prenom_cli;
        private Guna.UI2.WinForms.Guna2Button btn_confirm_inscrit;
        private Guna.UI2.WinForms.Guna2TextBox adresse_cli;
        private Guna.UI2.WinForms.Guna2TextBox cin_cli;
        private Guna.UI2.WinForms.Guna2TextBox contact;
        private Guna.UI2.WinForms.Guna2TextBox solde;
        private Guna.UI2.WinForms.Guna2ComboBox sexe;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Numero_compte;
    }
}