namespace EvidencijaStudenata
{
    partial class GlavnaForma
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
            this.btnObrisiTim = new System.Windows.Forms.Button();
            this.btnIzmijeniTim = new System.Windows.Forms.Button();
            this.btnNoviTim = new System.Windows.Forms.Button();
            this.lblTimovi = new System.Windows.Forms.Label();
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.btnObrisiStudenta = new System.Windows.Forms.Button();
            this.btnIzmijeniStudenta = new System.Windows.Forms.Button();
            this.btnNoviStudent = new System.Windows.Forms.Button();
            this.lblStudenti = new System.Windows.Forms.Label();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiTim
            // 
            this.btnObrisiTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiTim.Location = new System.Drawing.Point(1069, 236);
            this.btnObrisiTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiTim.Name = "btnObrisiTim";
            this.btnObrisiTim.Size = new System.Drawing.Size(100, 28);
            this.btnObrisiTim.TabIndex = 9;
            this.btnObrisiTim.Text = "Obriši";
            this.btnObrisiTim.UseVisualStyleBackColor = true;
            this.btnObrisiTim.Click += new System.EventHandler(this.btnObrisiTim_Click);
            // 
            // btnIzmijeniTim
            // 
            this.btnIzmijeniTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmijeniTim.Location = new System.Drawing.Point(961, 236);
            this.btnIzmijeniTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmijeniTim.Name = "btnIzmijeniTim";
            this.btnIzmijeniTim.Size = new System.Drawing.Size(100, 28);
            this.btnIzmijeniTim.TabIndex = 8;
            this.btnIzmijeniTim.Text = "Izmijeni";
            this.btnIzmijeniTim.UseVisualStyleBackColor = true;
            this.btnIzmijeniTim.Click += new System.EventHandler(this.btnIzmijeniTim_Click);
            // 
            // btnNoviTim
            // 
            this.btnNoviTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoviTim.Location = new System.Drawing.Point(853, 236);
            this.btnNoviTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoviTim.Name = "btnNoviTim";
            this.btnNoviTim.Size = new System.Drawing.Size(100, 28);
            this.btnNoviTim.TabIndex = 7;
            this.btnNoviTim.Text = "Novi";
            this.btnNoviTim.UseVisualStyleBackColor = true;
            this.btnNoviTim.Click += new System.EventHandler(this.btnNoviTim_Click);
            // 
            // lblTimovi
            // 
            this.lblTimovi.AutoSize = true;
            this.lblTimovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimovi.Location = new System.Drawing.Point(13, 9);
            this.lblTimovi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimovi.Name = "lblTimovi";
            this.lblTimovi.Size = new System.Drawing.Size(60, 17);
            this.lblTimovi.TabIndex = 6;
            this.lblTimovi.Text = "Timovi:";
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.AllowUserToAddRows = false;
            this.dgvTimovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Location = new System.Drawing.Point(17, 29);
            this.dgvTimovi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTimovi.MultiSelect = false;
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.RowHeadersWidth = 51;
            this.dgvTimovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimovi.Size = new System.Drawing.Size(1149, 200);
            this.dgvTimovi.TabIndex = 5;
            this.dgvTimovi.SelectionChanged += new System.EventHandler(this.dgvTimovi_SelectionChanged);
            // 
            // btnObrisiStudenta
            // 
            this.btnObrisiStudenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiStudenta.Location = new System.Drawing.Point(1069, 543);
            this.btnObrisiStudenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiStudenta.Name = "btnObrisiStudenta";
            this.btnObrisiStudenta.Size = new System.Drawing.Size(100, 28);
            this.btnObrisiStudenta.TabIndex = 14;
            this.btnObrisiStudenta.Text = "Obriši";
            this.btnObrisiStudenta.UseVisualStyleBackColor = true;
            this.btnObrisiStudenta.Click += new System.EventHandler(this.btnObrisiStudenta_Click);
            // 
            // btnIzmijeniStudenta
            // 
            this.btnIzmijeniStudenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmijeniStudenta.Location = new System.Drawing.Point(961, 543);
            this.btnIzmijeniStudenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmijeniStudenta.Name = "btnIzmijeniStudenta";
            this.btnIzmijeniStudenta.Size = new System.Drawing.Size(100, 28);
            this.btnIzmijeniStudenta.TabIndex = 13;
            this.btnIzmijeniStudenta.Text = "Izmijeni";
            this.btnIzmijeniStudenta.UseVisualStyleBackColor = true;
            this.btnIzmijeniStudenta.Click += new System.EventHandler(this.btnIzmijeniStudenta_Click);
            // 
            // btnNoviStudent
            // 
            this.btnNoviStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoviStudent.Location = new System.Drawing.Point(853, 543);
            this.btnNoviStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoviStudent.Name = "btnNoviStudent";
            this.btnNoviStudent.Size = new System.Drawing.Size(100, 28);
            this.btnNoviStudent.TabIndex = 12;
            this.btnNoviStudent.Text = "Novi";
            this.btnNoviStudent.UseVisualStyleBackColor = true;
            this.btnNoviStudent.Click += new System.EventHandler(this.btnNoviStudent_Click);
            // 
            // lblStudenti
            // 
            this.lblStudenti.AutoSize = true;
            this.lblStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStudenti.Location = new System.Drawing.Point(13, 290);
            this.lblStudenti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudenti.Name = "lblStudenti";
            this.lblStudenti.Size = new System.Drawing.Size(73, 17);
            this.lblStudenti.TabIndex = 11;
            this.lblStudenti.Text = "Studenti:";
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(17, 310);
            this.dgvStudenti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudenti.MultiSelect = false;
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(1149, 225);
            this.dgvStudenti.TabIndex = 10;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 597);
            this.Controls.Add(this.btnObrisiStudenta);
            this.Controls.Add(this.btnIzmijeniStudenta);
            this.Controls.Add(this.btnNoviStudent);
            this.Controls.Add(this.lblStudenti);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btnObrisiTim);
            this.Controls.Add(this.btnIzmijeniTim);
            this.Controls.Add(this.btnNoviTim);
            this.Controls.Add(this.lblTimovi);
            this.Controls.Add(this.dgvTimovi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GlavnaForma";
            this.Text = " ";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiTim;
        private System.Windows.Forms.Button btnIzmijeniTim;
        private System.Windows.Forms.Button btnNoviTim;
        private System.Windows.Forms.Label lblTimovi;
        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.Button btnObrisiStudenta;
        private System.Windows.Forms.Button btnIzmijeniStudenta;
        private System.Windows.Forms.Button btnNoviStudent;
        private System.Windows.Forms.Label lblStudenti;
        private System.Windows.Forms.DataGridView dgvStudenti;
    }
}