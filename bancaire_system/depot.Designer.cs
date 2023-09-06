namespace bancaire_system
{
    partial class depot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depot));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.date_depot = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirmSolde = new Guna.UI2.WinForms.Guna2Button();
            this.solde = new Guna.UI2.WinForms.Guna2TextBox();
            this.numero_compte = new Guna.UI2.WinForms.Guna2TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.guna2Panel1.Controls.Add(this.date_depot);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btn_confirmSolde);
            this.guna2Panel1.Controls.Add(this.solde);
            this.guna2Panel1.Controls.Add(this.numero_compte);
            this.guna2Panel1.Location = new System.Drawing.Point(-6, -3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1214, 546);
            this.guna2Panel1.TabIndex = 0;
            // 
            // date_depot
            // 
            this.date_depot.Checked = true;
            this.date_depot.FillColor = System.Drawing.Color.White;
            this.date_depot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_depot.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_depot.Location = new System.Drawing.Point(310, 240);
            this.date_depot.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_depot.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_depot.Name = "date_depot";
            this.date_depot.Size = new System.Drawing.Size(650, 50);
            this.date_depot.TabIndex = 5;
            this.date_depot.Value = new System.DateTime(2023, 8, 12, 11, 54, 38, 515);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(412, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "EFFECTUER UNE DEPOT";
            // 
            // btn_confirmSolde
            // 
            this.btn_confirmSolde.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmSolde.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmSolde.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirmSolde.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirmSolde.FillColor = System.Drawing.Color.Blue;
            this.btn_confirmSolde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_confirmSolde.ForeColor = System.Drawing.Color.White;
            this.btn_confirmSolde.Location = new System.Drawing.Point(449, 413);
            this.btn_confirmSolde.Name = "btn_confirmSolde";
            this.btn_confirmSolde.Size = new System.Drawing.Size(380, 56);
            this.btn_confirmSolde.TabIndex = 2;
            this.btn_confirmSolde.Text = "Confirmer";
            this.btn_confirmSolde.Click += new System.EventHandler(this.btn_confirmSolde_Click);
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
            this.solde.Location = new System.Drawing.Point(310, 331);
            this.solde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.solde.Name = "solde";
            this.solde.PasswordChar = '\0';
            this.solde.PlaceholderText = "Solde";
            this.solde.SelectedText = "";
            this.solde.Size = new System.Drawing.Size(650, 48);
            this.solde.TabIndex = 1;
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
            this.numero_compte.Location = new System.Drawing.Point(310, 152);
            this.numero_compte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numero_compte.Name = "numero_compte";
            this.numero_compte.PasswordChar = '\0';
            this.numero_compte.PlaceholderText = "Numero de compte";
            this.numero_compte.SelectedText = "";
            this.numero_compte.Size = new System.Drawing.Size(650, 48);
            this.numero_compte.TabIndex = 0;
            this.numero_compte.TextChanged += new System.EventHandler(this.numero_compte_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // depot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1204, 539);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "depot";
            this.Text = "depot";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_confirmSolde;
        private Guna.UI2.WinForms.Guna2TextBox solde;
        private Guna.UI2.WinForms.Guna2TextBox numero_compte;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_depot;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}