namespace bancaire_system
{
    partial class Retirer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retirer));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirmRetrait = new Guna.UI2.WinForms.Guna2Button();
            this.solde = new Guna.UI2.WinForms.Guna2TextBox();
            this.numero_compte = new Guna.UI2.WinForms.Guna2TextBox();
            this.date_retrait = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(340, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "EFFECTUER UNE RETRAIT";
            // 
            // btn_confirmRetrait
            // 
            this.btn_confirmRetrait.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmRetrait.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmRetrait.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirmRetrait.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirmRetrait.FillColor = System.Drawing.Color.Blue;
            this.btn_confirmRetrait.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_confirmRetrait.ForeColor = System.Drawing.Color.White;
            this.btn_confirmRetrait.Location = new System.Drawing.Point(404, 423);
            this.btn_confirmRetrait.Name = "btn_confirmRetrait";
            this.btn_confirmRetrait.Size = new System.Drawing.Size(328, 56);
            this.btn_confirmRetrait.TabIndex = 6;
            this.btn_confirmRetrait.Text = "Confirmer";
            this.btn_confirmRetrait.Click += new System.EventHandler(this.btn_confirmRetrait_Click);
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
            this.solde.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.solde.Location = new System.Drawing.Point(234, 344);
            this.solde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.solde.Name = "solde";
            this.solde.PasswordChar = '\0';
            this.solde.PlaceholderText = "Solde a retirer";
            this.solde.SelectedText = "";
            this.solde.Size = new System.Drawing.Size(650, 48);
            this.solde.TabIndex = 5;
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
            this.numero_compte.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numero_compte.Location = new System.Drawing.Point(234, 171);
            this.numero_compte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numero_compte.Name = "numero_compte";
            this.numero_compte.PasswordChar = '\0';
            this.numero_compte.PlaceholderText = "Numero de compte";
            this.numero_compte.SelectedText = "";
            this.numero_compte.Size = new System.Drawing.Size(650, 48);
            this.numero_compte.TabIndex = 4;
            // 
            // date_retrait
            // 
            this.date_retrait.Checked = true;
            this.date_retrait.FillColor = System.Drawing.Color.White;
            this.date_retrait.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_retrait.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_retrait.Location = new System.Drawing.Point(234, 254);
            this.date_retrait.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_retrait.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_retrait.Name = "date_retrait";
            this.date_retrait.Size = new System.Drawing.Size(650, 52);
            this.date_retrait.TabIndex = 8;
            this.date_retrait.Value = new System.DateTime(2023, 8, 12, 12, 42, 10, 386);
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
            // Retirer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1143, 542);
            this.Controls.Add(this.date_retrait);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_confirmRetrait);
            this.Controls.Add(this.solde);
            this.Controls.Add(this.numero_compte);
            this.Name = "Retirer";
            this.Text = "Retirer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_confirmRetrait;
        private Guna.UI2.WinForms.Guna2TextBox solde;
        private Guna.UI2.WinForms.Guna2TextBox numero_compte;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_retrait;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}