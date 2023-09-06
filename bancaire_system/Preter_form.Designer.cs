namespace bancaire_system
{
    partial class Preter_form
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
            this.date_pret = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_confirmPret = new Guna.UI2.WinForms.Guna2Button();
            this.solde = new Guna.UI2.WinForms.Guna2TextBox();
            this.numero_compte = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_pret
            // 
            this.date_pret.Checked = true;
            this.date_pret.FillColor = System.Drawing.Color.White;
            this.date_pret.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_pret.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_pret.Location = new System.Drawing.Point(534, 270);
            this.date_pret.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_pret.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_pret.Name = "date_pret";
            this.date_pret.Size = new System.Drawing.Size(892, 75);
            this.date_pret.TabIndex = 10;
            this.date_pret.Value = new System.DateTime(2023, 8, 12, 11, 54, 38, 515);
            // 
            // btn_confirmPret
            // 
            this.btn_confirmPret.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmPret.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmPret.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirmPret.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirmPret.FillColor = System.Drawing.Color.Green;
            this.btn_confirmPret.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmPret.ForeColor = System.Drawing.Color.White;
            this.btn_confirmPret.Location = new System.Drawing.Point(766, 519);
            this.btn_confirmPret.Name = "btn_confirmPret";
            this.btn_confirmPret.Size = new System.Drawing.Size(443, 66);
            this.btn_confirmPret.TabIndex = 8;
            this.btn_confirmPret.Text = "Confirmer";
            this.btn_confirmPret.Click += new System.EventHandler(this.btn_confirmPret_Click);
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
            this.solde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.solde.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.solde.Location = new System.Drawing.Point(534, 385);
            this.solde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.solde.Name = "solde";
            this.solde.PasswordChar = '\0';
            this.solde.PlaceholderText = "Solde";
            this.solde.SelectedText = "";
            this.solde.Size = new System.Drawing.Size(892, 73);
            this.solde.TabIndex = 7;
            // 
            // numero_compte
            // 
            this.numero_compte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numero_compte.DefaultText = "";
            this.numero_compte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numero_compte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numero_compte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numero_compte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numero_compte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numero_compte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numero_compte.ForeColor = System.Drawing.Color.Black;
            this.numero_compte.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numero_compte.Location = new System.Drawing.Point(534, 154);
            this.numero_compte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numero_compte.Name = "numero_compte";
            this.numero_compte.PasswordChar = '\0';
            this.numero_compte.PlaceholderText = "Numero de compte";
            this.numero_compte.SelectedText = "";
            this.numero_compte.Size = new System.Drawing.Size(892, 73);
            this.numero_compte.TabIndex = 6;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Blue;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(143, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1618, 104);
            this.guna2Panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(699, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "EFFECTUER UN PRET";
            // 
            // Preter_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1630, 683);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.date_pret);
            this.Controls.Add(this.btn_confirmPret);
            this.Controls.Add(this.solde);
            this.Controls.Add(this.numero_compte);
            this.Name = "Preter_form";
            this.Text = "Preter_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Preter_form_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker date_pret;
        private Guna.UI2.WinForms.Guna2Button btn_confirmPret;
        private Guna.UI2.WinForms.Guna2TextBox solde;
        private Guna.UI2.WinForms.Guna2TextBox numero_compte;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
    }
}