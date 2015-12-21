namespace Donat_Etykiety
{
    partial class MainMenu
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
            this.Skanuj_TxB = new System.Windows.Forms.TextBox();
            this.Skanuj_Button = new System.Windows.Forms.Button();
            this.Kartoteka_Label = new System.Windows.Forms.Label();
            this.Kartoteka_TxB = new System.Windows.Forms.TextBox();
            this.Dokument_Label = new System.Windows.Forms.Label();
            this.Dokument_TxB = new System.Windows.Forms.TextBox();
            this.InnyDokument_Button = new System.Windows.Forms.Button();
            this.PokazNiewydrukowane_Button = new System.Windows.Forms.Button();
            this.Dodrukuj_Button = new System.Windows.Forms.Button();
            this.Koniec_Button = new System.Windows.Forms.Button();
            this.MainGridView = new System.Windows.Forms.DataGridView();
            this.Lp_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Magazyn_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indeks_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaKartoteki_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IloscOpakowan_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IleWOpakowaniu_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodPartii_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodOpakowan_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S01_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S02_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzyWydrukowano_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodzinaDrukowania_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoazycjiWydrukwoano_Label = new System.Windows.Forms.Label();
            this.Magazyn_Button = new System.Windows.Forms.Button();
            this.ZDnia_Button = new System.Windows.Forms.Button();
            this.magazynCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Skanuj_TxB
            // 
            this.Skanuj_TxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Skanuj_TxB.Location = new System.Drawing.Point(80, 13);
            this.Skanuj_TxB.MaxLength = 20;
            this.Skanuj_TxB.Name = "Skanuj_TxB";
            this.Skanuj_TxB.Size = new System.Drawing.Size(153, 20);
            this.Skanuj_TxB.TabIndex = 0;
            this.Skanuj_TxB.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Skanuj_TxB_PreviewKeyDown);
            // 
            // Skanuj_Button
            // 
            this.Skanuj_Button.BackColor = System.Drawing.Color.LightGray;
            this.Skanuj_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Skanuj_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Skanuj_Button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.Skanuj_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skanuj_Button.Location = new System.Drawing.Point(239, 10);
            this.Skanuj_Button.Name = "Skanuj_Button";
            this.Skanuj_Button.Size = new System.Drawing.Size(94, 23);
            this.Skanuj_Button.TabIndex = 1;
            this.Skanuj_Button.Text = "Skanuj";
            this.Skanuj_Button.UseVisualStyleBackColor = false;
            this.Skanuj_Button.Click += new System.EventHandler(this.skanuj_Button_Click);
            // 
            // Kartoteka_Label
            // 
            this.Kartoteka_Label.AutoSize = true;
            this.Kartoteka_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kartoteka_Label.Location = new System.Drawing.Point(4, 44);
            this.Kartoteka_Label.Name = "Kartoteka_Label";
            this.Kartoteka_Label.Size = new System.Drawing.Size(67, 17);
            this.Kartoteka_Label.TabIndex = 2;
            this.Kartoteka_Label.Text = "Kartoteka:";
            // 
            // Kartoteka_TxB
            // 
            this.Kartoteka_TxB.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Kartoteka_TxB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Kartoteka_TxB.Enabled = false;
            this.Kartoteka_TxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kartoteka_TxB.Location = new System.Drawing.Point(80, 44);
            this.Kartoteka_TxB.Name = "Kartoteka_TxB";
            this.Kartoteka_TxB.ReadOnly = true;
            this.Kartoteka_TxB.Size = new System.Drawing.Size(253, 20);
            this.Kartoteka_TxB.TabIndex = 3;
            // 
            // Dokument_Label
            // 
            this.Dokument_Label.AutoSize = true;
            this.Dokument_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dokument_Label.Location = new System.Drawing.Point(4, 79);
            this.Dokument_Label.Name = "Dokument_Label";
            this.Dokument_Label.Size = new System.Drawing.Size(70, 17);
            this.Dokument_Label.TabIndex = 4;
            this.Dokument_Label.Text = "Dokument:";
            // 
            // Dokument_TxB
            // 
            this.Dokument_TxB.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Dokument_TxB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Dokument_TxB.Enabled = false;
            this.Dokument_TxB.Location = new System.Drawing.Point(80, 75);
            this.Dokument_TxB.Name = "Dokument_TxB";
            this.Dokument_TxB.ReadOnly = true;
            this.Dokument_TxB.Size = new System.Drawing.Size(153, 20);
            this.Dokument_TxB.TabIndex = 5;
            // 
            // InnyDokument_Button
            // 
            this.InnyDokument_Button.BackColor = System.Drawing.Color.LightGray;
            this.InnyDokument_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.InnyDokument_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.InnyDokument_Button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.InnyDokument_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InnyDokument_Button.Location = new System.Drawing.Point(239, 73);
            this.InnyDokument_Button.Name = "InnyDokument_Button";
            this.InnyDokument_Button.Size = new System.Drawing.Size(94, 23);
            this.InnyDokument_Button.TabIndex = 6;
            this.InnyDokument_Button.Text = "Inny dokument";
            this.InnyDokument_Button.UseVisualStyleBackColor = false;
            this.InnyDokument_Button.Click += new System.EventHandler(this.innyDokument_Button_Click);
            // 
            // PokazNiewydrukowane_Button
            // 
            this.PokazNiewydrukowane_Button.BackColor = System.Drawing.Color.LightGray;
            this.PokazNiewydrukowane_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PokazNiewydrukowane_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.PokazNiewydrukowane_Button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.PokazNiewydrukowane_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PokazNiewydrukowane_Button.Location = new System.Drawing.Point(1119, 73);
            this.PokazNiewydrukowane_Button.Name = "PokazNiewydrukowane_Button";
            this.PokazNiewydrukowane_Button.Size = new System.Drawing.Size(162, 23);
            this.PokazNiewydrukowane_Button.TabIndex = 7;
            this.PokazNiewydrukowane_Button.Text = "Pokaż niewydrukowane";
            this.PokazNiewydrukowane_Button.UseVisualStyleBackColor = false;
            this.PokazNiewydrukowane_Button.Click += new System.EventHandler(this.PokazNiewydrukowane_Button_Click);
            // 
            // Dodrukuj_Button
            // 
            this.Dodrukuj_Button.BackColor = System.Drawing.Color.LightGray;
            this.Dodrukuj_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Dodrukuj_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Dodrukuj_Button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.Dodrukuj_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dodrukuj_Button.Location = new System.Drawing.Point(1178, 772);
            this.Dodrukuj_Button.Name = "Dodrukuj_Button";
            this.Dodrukuj_Button.Size = new System.Drawing.Size(94, 23);
            this.Dodrukuj_Button.TabIndex = 8;
            this.Dodrukuj_Button.Text = "Dodrukuj";
            this.Dodrukuj_Button.UseVisualStyleBackColor = false;
            this.Dodrukuj_Button.Click += new System.EventHandler(this.dodrukuj_Button_Click);
            // 
            // Koniec_Button
            // 
            this.Koniec_Button.BackColor = System.Drawing.Color.LightGray;
            this.Koniec_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Koniec_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Koniec_Button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.Koniec_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Koniec_Button.Location = new System.Drawing.Point(12, 772);
            this.Koniec_Button.Name = "Koniec_Button";
            this.Koniec_Button.Size = new System.Drawing.Size(94, 23);
            this.Koniec_Button.TabIndex = 9;
            this.Koniec_Button.Text = "Koniec";
            this.Koniec_Button.UseVisualStyleBackColor = false;
            this.Koniec_Button.Click += new System.EventHandler(this.koniec_Button_Click);
            // 
            // MainGridView
            // 
            this.MainGridView.AllowUserToAddRows = false;
            this.MainGridView.AllowUserToDeleteRows = false;
            this.MainGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lp_Column,
            this.Magazyn_Column,
            this.Indeks_Column,
            this.NazwaKartoteki_Column,
            this.IloscOpakowan_Column,
            this.IleWOpakowaniu_Column,
            this.KodPartii_Column,
            this.KodOpakowan_Column,
            this.S01_Column,
            this.S02_Column,
            this.CzyWydrukowano_Column,
            this.GodzinaDrukowania_Column,
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.MainGridView.Location = new System.Drawing.Point(12, 102);
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.ReadOnly = true;
            this.MainGridView.Size = new System.Drawing.Size(1269, 652);
            this.MainGridView.TabIndex = 10;
            this.MainGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wybierzWiersz);
            this.MainGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wybierzWiersz);
            this.MainGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wybierzWiersz);
            this.MainGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wybierzWiersz);
            // 
            // Lp_Column
            // 
            this.Lp_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lp_Column.HeaderText = "Lp.";
            this.Lp_Column.Name = "Lp_Column";
            this.Lp_Column.ReadOnly = true;
            this.Lp_Column.Width = 47;
            // 
            // Magazyn_Column
            // 
            this.Magazyn_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Magazyn_Column.HeaderText = "Magazyn";
            this.Magazyn_Column.Name = "Magazyn_Column";
            this.Magazyn_Column.ReadOnly = true;
            this.Magazyn_Column.Width = 65;
            // 
            // Indeks_Column
            // 
            this.Indeks_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Indeks_Column.HeaderText = "Indeks";
            this.Indeks_Column.Name = "Indeks_Column";
            this.Indeks_Column.ReadOnly = true;
            this.Indeks_Column.Width = 64;
            // 
            // NazwaKartoteki_Column
            // 
            this.NazwaKartoteki_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NazwaKartoteki_Column.HeaderText = "Nazwa";
            this.NazwaKartoteki_Column.Name = "NazwaKartoteki_Column";
            this.NazwaKartoteki_Column.ReadOnly = true;
            this.NazwaKartoteki_Column.Width = 65;
            // 
            // IloscOpakowan_Column
            // 
            this.IloscOpakowan_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IloscOpakowan_Column.HeaderText = "Ilość opak zb.";
            this.IloscOpakowan_Column.Name = "IloscOpakowan_Column";
            this.IloscOpakowan_Column.ReadOnly = true;
            this.IloscOpakowan_Column.Width = 60;
            // 
            // IleWOpakowaniu_Column
            // 
            this.IleWOpakowaniu_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IleWOpakowaniu_Column.HeaderText = "Ile w opak zb.";
            this.IleWOpakowaniu_Column.Name = "IleWOpakowaniu_Column";
            this.IleWOpakowaniu_Column.ReadOnly = true;
            this.IleWOpakowaniu_Column.Width = 60;
            // 
            // KodPartii_Column
            // 
            this.KodPartii_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KodPartii_Column.HeaderText = "Kod partii";
            this.KodPartii_Column.Name = "KodPartii_Column";
            this.KodPartii_Column.ReadOnly = true;
            this.KodPartii_Column.Width = 76;
            // 
            // KodOpakowan_Column
            // 
            this.KodOpakowan_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KodOpakowan_Column.HeaderText = "Kod opak.";
            this.KodOpakowan_Column.Name = "KodOpakowan_Column";
            this.KodOpakowan_Column.ReadOnly = true;
            this.KodOpakowan_Column.Width = 60;
            // 
            // S01_Column
            // 
            this.S01_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.S01_Column.HeaderText = "S01";
            this.S01_Column.Name = "S01_Column";
            this.S01_Column.ReadOnly = true;
            this.S01_Column.Width = 51;
            // 
            // S02_Column
            // 
            this.S02_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.S02_Column.HeaderText = "S02";
            this.S02_Column.Name = "S02_Column";
            this.S02_Column.ReadOnly = true;
            this.S02_Column.Width = 51;
            // 
            // CzyWydrukowano_Column
            // 
            this.CzyWydrukowano_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CzyWydrukowano_Column.HeaderText = "Czy wydrukowano";
            this.CzyWydrukowano_Column.Name = "CzyWydrukowano_Column";
            this.CzyWydrukowano_Column.ReadOnly = true;
            this.CzyWydrukowano_Column.Width = 118;
            // 
            // GodzinaDrukowania_Column
            // 
            this.GodzinaDrukowania_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GodzinaDrukowania_Column.HeaderText = "Godzina drukowania";
            this.GodzinaDrukowania_Column.Name = "GodzinaDrukowania_Column";
            this.GodzinaDrukowania_Column.ReadOnly = true;
            this.GodzinaDrukowania_Column.Width = 60;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 73;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 73;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 73;
            // 
            // PoazycjiWydrukwoano_Label
            // 
            this.PoazycjiWydrukwoano_Label.AutoSize = true;
            this.PoazycjiWydrukwoano_Label.Location = new System.Drawing.Point(160, 374);
            this.PoazycjiWydrukwoano_Label.Name = "PoazycjiWydrukwoano_Label";
            this.PoazycjiWydrukwoano_Label.Size = new System.Drawing.Size(0, 13);
            this.PoazycjiWydrukwoano_Label.TabIndex = 11;
            // 
            // Magazyn_Button
            // 
            this.Magazyn_Button.BackColor = System.Drawing.Color.LightGray;
            this.Magazyn_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Magazyn_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Magazyn_Button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.Magazyn_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Magazyn_Button.Location = new System.Drawing.Point(951, 72);
            this.Magazyn_Button.Name = "Magazyn_Button";
            this.Magazyn_Button.Size = new System.Drawing.Size(162, 23);
            this.Magazyn_Button.TabIndex = 13;
            this.Magazyn_Button.Text = "Magazyn niewydrukowane";
            this.Magazyn_Button.UseVisualStyleBackColor = false;
            this.Magazyn_Button.Click += new System.EventHandler(this.Magazyn_Button_Click);
            // 
            // ZDnia_Button
            // 
            this.ZDnia_Button.BackColor = System.Drawing.Color.LightGray;
            this.ZDnia_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ZDnia_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ZDnia_Button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.ZDnia_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZDnia_Button.Location = new System.Drawing.Point(782, 72);
            this.ZDnia_Button.Name = "ZDnia_Button";
            this.ZDnia_Button.Size = new System.Drawing.Size(163, 23);
            this.ZDnia_Button.TabIndex = 14;
            this.ZDnia_Button.Text = "Pokaż niewydrukowane z dnia";
            this.ZDnia_Button.UseVisualStyleBackColor = false;
            this.ZDnia_Button.Click += new System.EventHandler(this.ZDnia_Button_Click);
            // 
            // magazynCombo
            // 
            this.magazynCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.magazynCombo.FormattingEnabled = true;
            this.magazynCombo.Location = new System.Drawing.Point(951, 43);
            this.magazynCombo.Name = "magazynCombo";
            this.magazynCombo.Size = new System.Drawing.Size(162, 21);
            this.magazynCombo.TabIndex = 15;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 802);
            this.Controls.Add(this.magazynCombo);
            this.Controls.Add(this.ZDnia_Button);
            this.Controls.Add(this.Magazyn_Button);
            this.Controls.Add(this.PoazycjiWydrukwoano_Label);
            this.Controls.Add(this.MainGridView);
            this.Controls.Add(this.Koniec_Button);
            this.Controls.Add(this.Dodrukuj_Button);
            this.Controls.Add(this.PokazNiewydrukowane_Button);
            this.Controls.Add(this.InnyDokument_Button);
            this.Controls.Add(this.Dokument_TxB);
            this.Controls.Add(this.Dokument_Label);
            this.Controls.Add(this.Kartoteka_TxB);
            this.Controls.Add(this.Kartoteka_Label);
            this.Controls.Add(this.Skanuj_Button);
            this.Controls.Add(this.Skanuj_TxB);
            this.Name = "MainMenu";
            this.Text = "Etykiety";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Skanuj_TxB;
        private System.Windows.Forms.Button Skanuj_Button;
        private System.Windows.Forms.Label Kartoteka_Label;
        private System.Windows.Forms.TextBox Kartoteka_TxB;
        private System.Windows.Forms.Label Dokument_Label;
        private System.Windows.Forms.TextBox Dokument_TxB;
        private System.Windows.Forms.Button InnyDokument_Button;
        private System.Windows.Forms.Button PokazNiewydrukowane_Button;
        private System.Windows.Forms.Button Dodrukuj_Button;
        private System.Windows.Forms.Button Koniec_Button;
        private System.Windows.Forms.DataGridView MainGridView;
        private System.Windows.Forms.Label PoazycjiWydrukwoano_Label;
        private System.Windows.Forms.Button Magazyn_Button;
        private System.Windows.Forms.Button ZDnia_Button;
        private System.Windows.Forms.ComboBox magazynCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lp_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Magazyn_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indeks_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaKartoteki_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IloscOpakowan_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IleWOpakowaniu_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodPartii_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodOpakowan_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn S01_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn S02_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzyWydrukowano_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodzinaDrukowania_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

