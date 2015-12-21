namespace Donat_Etykiety
{
    partial class DokumentyMagazynoweForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumerDok_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IlePoz_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontrahent_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozycje_Label = new System.Windows.Forms.Label();
            this.Wybierz_Button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Lp_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerMag_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indeks_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kartoteka_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaNetto_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WartoscBrutto_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IloscZB_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IlOpZbior_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista dokumentów zakupu:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumerDok_Column,
            this.Data_Column,
            this.IlePoz_Column,
            this.Suma_Column,
            this.Kontrahent_Column,
            this.Nazwa_Column,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1135, 257);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pobierzDaneDokumentow);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pobierzDaneDokumentow);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wybierz);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wybierz);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dataGridView1_PreviewKeyDown);
            // 
            // NumerDok_Column
            // 
            this.NumerDok_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumerDok_Column.HeaderText = "Numer Dokumentu ";
            this.NumerDok_Column.Name = "NumerDok_Column";
            this.NumerDok_Column.ReadOnly = true;
            this.NumerDok_Column.Width = 114;
            // 
            // Data_Column
            // 
            this.Data_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data_Column.HeaderText = "Data";
            this.Data_Column.Name = "Data_Column";
            this.Data_Column.ReadOnly = true;
            // 
            // IlePoz_Column
            // 
            this.IlePoz_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IlePoz_Column.HeaderText = "Ile pozycji";
            this.IlePoz_Column.Name = "IlePoz_Column";
            this.IlePoz_Column.ReadOnly = true;
            this.IlePoz_Column.Width = 72;
            // 
            // Suma_Column
            // 
            this.Suma_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Suma_Column.HeaderText = "Suma";
            this.Suma_Column.Name = "Suma_Column";
            this.Suma_Column.ReadOnly = true;
            this.Suma_Column.Width = 59;
            // 
            // Kontrahent_Column
            // 
            this.Kontrahent_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kontrahent_Column.HeaderText = "Kontrahent";
            this.Kontrahent_Column.Name = "Kontrahent_Column";
            this.Kontrahent_Column.ReadOnly = true;
            // 
            // Nazwa_Column
            // 
            this.Nazwa_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nazwa_Column.HeaderText = "Nazwa Dokumentu";
            this.Nazwa_Column.Name = "Nazwa_Column";
            this.Nazwa_Column.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Pozycje_Label
            // 
            this.Pozycje_Label.AutoSize = true;
            this.Pozycje_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pozycje_Label.Location = new System.Drawing.Point(9, 334);
            this.Pozycje_Label.Name = "Pozycje_Label";
            this.Pozycje_Label.Size = new System.Drawing.Size(59, 16);
            this.Pozycje_Label.TabIndex = 4;
            this.Pozycje_Label.Text = "Pozycje:";
            // 
            // Wybierz_Button
            // 
            this.Wybierz_Button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Wybierz_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Wybierz_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Wybierz_Button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.Wybierz_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wybierz_Button.Location = new System.Drawing.Point(503, 315);
            this.Wybierz_Button.Name = "Wybierz_Button";
            this.Wybierz_Button.Size = new System.Drawing.Size(117, 32);
            this.Wybierz_Button.TabIndex = 5;
            this.Wybierz_Button.Text = "Wybierz";
            this.Wybierz_Button.UseVisualStyleBackColor = false;
            this.Wybierz_Button.Click += new System.EventHandler(this.Wybierz_Button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lp_Column,
            this.numerMag_Column,
            this.Indeks_Column,
            this.Kartoteka_Column,
            this.Ilosc_Column,
            this.CenaNetto_Column,
            this.WartoscBrutto_Column,
            this.IloscZB_Column,
            this.IlOpZbior_Column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(12, 353);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1135, 273);
            this.dataGridView2.TabIndex = 6;
            // 
            // Lp_Column
            // 
            this.Lp_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lp_Column.HeaderText = "Lp.";
            this.Lp_Column.Name = "Lp_Column";
            this.Lp_Column.ReadOnly = true;
            this.Lp_Column.Width = 47;
            // 
            // numerMag_Column
            // 
            this.numerMag_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numerMag_Column.HeaderText = "Nr Mag";
            this.numerMag_Column.Name = "numerMag_Column";
            this.numerMag_Column.ReadOnly = true;
            this.numerMag_Column.Width = 62;
            // 
            // Indeks_Column
            // 
            this.Indeks_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indeks_Column.HeaderText = "Indeks";
            this.Indeks_Column.Name = "Indeks_Column";
            this.Indeks_Column.ReadOnly = true;
            // 
            // Kartoteka_Column
            // 
            this.Kartoteka_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kartoteka_Column.HeaderText = "Kartoteka";
            this.Kartoteka_Column.Name = "Kartoteka_Column";
            this.Kartoteka_Column.ReadOnly = true;
            // 
            // Ilosc_Column
            // 
            this.Ilosc_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ilosc_Column.HeaderText = "Ilość";
            this.Ilosc_Column.Name = "Ilosc_Column";
            this.Ilosc_Column.ReadOnly = true;
            this.Ilosc_Column.Width = 54;
            // 
            // CenaNetto_Column
            // 
            this.CenaNetto_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CenaNetto_Column.HeaderText = "Cena Netto";
            this.CenaNetto_Column.Name = "CenaNetto_Column";
            this.CenaNetto_Column.ReadOnly = true;
            this.CenaNetto_Column.Width = 79;
            // 
            // WartoscBrutto_Column
            // 
            this.WartoscBrutto_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WartoscBrutto_Column.HeaderText = "Wartość Brutto";
            this.WartoscBrutto_Column.Name = "WartoscBrutto_Column";
            this.WartoscBrutto_Column.ReadOnly = true;
            this.WartoscBrutto_Column.Width = 95;
            // 
            // IloscZB_Column
            // 
            this.IloscZB_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IloscZB_Column.HeaderText = "Ilosc Zbiorcza";
            this.IloscZB_Column.Name = "IloscZB_Column";
            this.IloscZB_Column.ReadOnly = true;
            this.IloscZB_Column.Width = 90;
            // 
            // IlOpZbior_Column
            // 
            this.IlOpZbior_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IlOpZbior_Column.HeaderText = "Ile w Opak Zbior";
            this.IlOpZbior_Column.Name = "IlOpZbior_Column";
            this.IlOpZbior_Column.ReadOnly = true;
            this.IlOpZbior_Column.Width = 101;
            // 
            // DokumentyMagazynoweForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 874);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Wybierz_Button);
            this.Controls.Add(this.Pozycje_Label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DokumentyMagazynoweForm";
            this.Text = "Dokumenty Zakupu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Pozycje_Label;
        private System.Windows.Forms.Button Wybierz_Button;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lp_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerMag_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indeks_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kartoteka_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaNetto_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn WartoscBrutto_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IloscZB_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IlOpZbior_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerDok_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IlePoz_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontrahent_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}