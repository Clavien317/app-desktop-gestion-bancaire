namespace bancaire_system
{
    partial class Rembourse
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
            this.date_rembourse = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_confirmRembourse = new Guna.UI2.WinForms.Guna2Button();
            this.solde = new Guna.UI2.WinForms.Guna2TextBox();
            this.numero_compte = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_rembourse
            // 
            this.date_rembourse.Checked = true;
            this.date_rembourse.FillColor = System.Drawing.Color.White;
            this.date_rembourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_rembourse.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_rembourse.Location = new System.Drawing.Point(469, 282);
            this.date_rembourse.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_rembourse.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_rembourse.Name = "date_rembourse";
            this.date_rembourse.Size = new System.Drawing.Size(892, 75);
            this.date_rembourse.TabIndex = 15;
            this.date_rembourse.Value = new System.DateTime(2023, 8, 12, 11, 54, 38, 515);
            // 
            // btn_confirmRembourse
            // 
            this.btn_confirmRembourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmRembourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmRembourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirmRembourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirmRembourse.FillColor = System.Drawing.Color.Green;
            this.btn_confirmRembourse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmRembourse.ForeColor = System.Drawing.Color.White;
            this.btn_confirmRembourse.Location = new System.Drawing.Point(701, 531);
            this.btn_confirmRembourse.Name = "btn_confirmRembourse";
            this.btn_confirmRembourse.Size = new System.Drawing.Size(443, 66);
            this.btn_confirmRembourse.TabIndex = 14;
            this.btn_confirmRembourse.Text = "Confirmer";
            this.btn_confirmRembourse.Click += new System.EventHandler(this.btn_confirmRembourse_Click);
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
            this.solde.Location = new System.Drawing.Point(469, 397);
            this.solde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.solde.Name = "solde";
            this.solde.PasswordChar = '\0';
            this.solde.PlaceholderText = "Solde";
            this.solde.SelectedText = "";
            this.solde.Size = new System.Drawing.Size(892, 73);
            this.solde.TabIndex = 13;
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
            this.numero_compte.Location = new System.Drawing.Point(469, 166);
            this.numero_compte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numero_compte.Name = "numero_compte";
            this.numero_compte.PasswordChar = '\0';
            this.numero_compte.PlaceholderText = "Numero de compte";
            this.numero_compte.SelectedText = "";
            this.numero_compte.Size = new System.Drawing.Size(892, 73);
            this.numero_compte.TabIndex = 12;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Blue;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(114, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1480, 104);
            this.guna2Panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(524, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "EFFECTUER UN REMBOURSEMENT";
            // 
            // Rembourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1573, 637);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.date_rembourse);
            this.Controls.Add(this.btn_confirmRembourse);
            this.Controls.Add(this.solde);
            this.Controls.Add(this.numero_compte);
            this.Name = "Rembourse";
            this.Text = "Rembourse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker date_rembourse;
        private Guna.UI2.WinForms.Guna2Button btn_confirmRembourse;
        private Guna.UI2.WinForms.Guna2TextBox solde;
        private Guna.UI2.WinForms.Guna2TextBox numero_compte;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
    }
}