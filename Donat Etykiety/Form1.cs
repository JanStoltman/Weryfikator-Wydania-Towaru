using Etykiety_Epl;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//0020727500156
namespace Donat_Etykiety
{
    public partial class MainMenu : Form
    {
        static public List<Dokument> daneDokumentu = new List<Dokument>();
        private List<Magazyn> magazynyLista = new List<Magazyn>();
        public int iloscWydruk = 0;
        private string wybranyWierszIdPoz = string.Empty;
        private string id_Nagl, numDok;

        public MainMenu()
        {
            InitializeComponent();
            pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, "1", "1", "DW");
            updateGridView(daneDokumentu);
            updateMagazynyCombo();

                DokumentyMagazynoweForm dokmag = new DokumentyMagazynoweForm();
                dokmag.activeMenu = this;
                dokmag.ShowDialog(this);
               
        }

        //public void Inicjalizuj()
        //{
        //    pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, "1", "1", "DW");
        //    updateGridView(daneDokumentu);

        //    updateMagazynyCombo();
        //}

        public void updateMagazynyCombo()
        {
            try
            {
                FbConnection fCon = new FbConnection(Settings.connectionString);
                fCon.Open();
                FbCommand fComm = new FbCommand(Settings.commandString6, fCon);
                FbDataReader fbreader = fComm.ExecuteReader();

                while (fbreader.Read())
                {
                    if (!magazynCombo.Items.Contains(fbreader.GetValue(1))) magazynCombo.Items.Add(fbreader.GetValue(1));

                    magazynyLista.Add(new Magazyn(fbreader.GetValue(0), fbreader.GetValue(1), fbreader.GetValue(2)));
                }

                fbreader.Close();
                fComm.Dispose();
                fCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateGridView(List<Dokument> _daneDokumentu,string nrDok)
        {
            if (_daneDokumentu.Count > 0)
            {
                Kartoteka_TxB.Text = "";
                Dokument_TxB.Text = "";

                Dokument_TxB.Text = nrDok;

                daneDokumentu = _daneDokumentu;
                MainGridView.Rows.Clear();
                foreach (var x in _daneDokumentu)
                {
                    MainGridView.Rows.Add(x.dane.ToArray());
                }
                MainGridView.Columns["Indeks_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                MainGridView.Columns["NazwaKartoteki_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                MainGridView.Columns["Magazyn_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                MainGridView.Update();
                wybranyWierszIdPoz = daneDokumentu[0].id;
            }
        }

        public void updateGridView(List<Dokument> _daneDokumentu)
        {
            if (_daneDokumentu.Count > 0)
            {
                Kartoteka_TxB.Text = "";
                Dokument_TxB.Text = "";

                daneDokumentu = _daneDokumentu;
                MainGridView.Rows.Clear();
                foreach (var x in _daneDokumentu)
                {
                    MainGridView.Rows.Add(x.dane.ToArray());
                }
                MainGridView.Columns["Indeks_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                MainGridView.Columns["NazwaKartoteki_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                MainGridView.Columns["Magazyn_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                MainGridView.Update();
                wybranyWierszIdPoz = daneDokumentu[0].id;
            }
        }

        public void updateGridView(string id_nagl,string nrDok, string modeString)
        {
            id_Nagl = id_nagl;
            numDok = nrDok;
            Kartoteka_TxB.Text = "";
            Dokument_TxB.Text = "";

            Dokument_TxB.Text = nrDok;

            daneDokumentu = pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, id_nagl, "1", modeString);

            MainGridView.Rows.Clear();
            foreach (var x in daneDokumentu)
            {
                MainGridView.Rows.Add(x.dane.ToArray());
            }

            if (MainGridView.Rows.Count > 0)
            {
                MainGridView.Columns["Indeks_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                MainGridView.Columns["NazwaKartoteki_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                MainGridView.Columns["Magazyn_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
               
                MainGridView.Update();
                wybranyWierszIdPoz = daneDokumentu[0].id;
            }
        }

        private void wybierzWiersz(object sender, DataGridViewCellEventArgs e)
        {
             if (MainGridView.CurrentRow != null)
            {
                foreach (var x in daneDokumentu)
                    if (x.dane[0] == MainGridView.CurrentRow.Cells[0].Value.ToString())
                    {
                        wybranyWierszIdPoz = x.id;
                        Kartoteka_TxB.Text = MainGridView.CurrentRow.Cells["NazwaKartoteki_Column"].Value.ToString();
                    }
            }
        }
       
        private void wybierzWiersz()
        {
            wybranyWierszIdPoz = "00000000";

            if (MainGridView.CurrentRow != null)
            {
                foreach (var x in daneDokumentu)
                    if (x.dane[0] == MainGridView.CurrentRow.Cells[0].Value.ToString())
                    {
                        wybranyWierszIdPoz = x.id;
                    }
                if (wybranyWierszIdPoz == "00000000")
                    Kartoteka_TxB.Text = "00000000";
                else Kartoteka_TxB.Text = MainGridView.CurrentRow.Cells["NazwaKartoteki_Column"].Value.ToString();
            }


        }

        private void innyDokument_Button_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                DokumentyMagazynoweForm dokmag = new DokumentyMagazynoweForm();
                dokmag.activeMenu = this;
                dokmag.ShowDialog(this);     
            }
        }

        private void koniec_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void skanuj_Button_Click(object sender, EventArgs e)
        {
            if (Skanuj_TxB.Text.Length < 13)
            {
                MessageBox.Show("Nie znaleziono dostawy " + Skanuj_TxB.Text);
                Skanuj_TxB.Text = "";
                return;
            }

            FbConnection fCon = new FbConnection(Settings.connectionString);
            fCon.Open();

            string cmdS = string.Format(Settings.commandString4, Skanuj_TxB.Text.Substring(0, 13));

            FbCommand fComm = new FbCommand(cmdS, fCon);

            
            FbDataReader fbreader = fComm.ExecuteReader();

            fbreader.Read();

            try
            {
                var temp = fbreader.GetInt32(0);
                wybranyWierszIdPoz = temp.ToString();
                dodrukuj();

               pobierzDane(MainGridView.ColumnCount, Settings.connectionString, string.Format(Settings.commandString5,fbreader.GetInt32(1).ToString(),fbreader.GetInt32(0).ToString(),"S"));
               updateGridView(daneDokumentu);

                foreach (var x in daneDokumentu)
                {
                    if (x.id == temp.ToString())
                    {
                        foreach (DataGridViewRow z in MainGridView.Rows)
                        {
                            if (z.Cells[0].Value.ToString() == x.dane[0].ToString() && z.Cells[1].Value.ToString() == x.dane[1].ToString())
                            {
                                z.Selected = true;
                                Dokument_TxB.Text = x.numerDokWew;
                                Kartoteka_TxB.Text = z.Cells["NazwaKartoteki_Column"].Value.ToString();
                                break;
                            }
                        }
                        break;
                    }
                }

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Nie znaleziono dostawy " + Skanuj_TxB.Text);
            }
            finally
            {
                Skanuj_TxB.Text = "";
            }
        }

        private void dodrukuj_Button_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                using (AskBox askB = new AskBox())
                {
                    askB.ShowDialog(this);
                    iloscWydruk = askB.wynik;
                }
            }

            wybierzWiersz();
            dodrukuj();
            iloscWydruk = 0;

            updateGridView(id_Nagl, numDok,"C");
        }

        private void dodrukuj()
        {
            prepareFile();
            Process.Start("cmd", "/C copy " + Settings.copyFilePath1 + " \\\\tsclient\\COM1");
            //Process.Start("cmd", "/C copy " + Settings.copyFilePath1 + " lpt1");
        }

        private void prepareFile()
        {

            using (StreamWriter strw = new StreamWriter(Settings.copyFilePath1, false))
            {
                FbConnection fCon = new FbConnection(Settings.connectionString);
                fCon.Open();

                //wybierzWiersz();
                string combinedString = string.Format(Settings.commandString3, (wybranyWierszIdPoz + ", " + iloscWydruk.ToString()));

                FbCommand fComm = new FbCommand(combinedString, fCon);
                FbDataReader fbreader = fComm.ExecuteReader();

                while (fbreader.Read())
                {
                    for (int i = 0; i < fbreader.FieldCount; i++)
                    {
                        strw.WriteLine(fbreader.GetString(i));
                    }
                }
                fbreader.Close();
                fComm.Dispose();
                fCon.Close();
            }


        }

        private void pobierzDane(int iloscKolumn, string connectionString, string commandString)
        {
            List<Dokument> tempListaDok = new List<Dokument>();

            FbConnection fCon = new FbConnection(connectionString);
            fCon.Open();
            FbCommand fComm = new FbCommand(commandString, fCon);
            FbDataReader fbreader = fComm.ExecuteReader();

            while (fbreader.Read())
            {
                Dokument temp = new Dokument();
                temp.id = fbreader.GetString(0);

                for (int i = 1; i <= iloscKolumn; i++)
                    temp.addValue(fbreader.GetString(i));
                tempListaDok.Add(temp);
            }

            if (daneDokumentu != null)
                daneDokumentu.Clear();

            daneDokumentu = tempListaDok;

            fbreader.Close();
            fComm.Dispose();
            fCon.Close();

        }

        private List<Dokument> pobierzDane(int iloscKolumn, string connectionString, string commandString, string id_nagl, string id_poz, string wartTrzy)
        {
            if (id_nagl == null || id_nagl == "") id_nagl = "1";
            if (id_poz == null || id_poz == "") id_poz = "1";

            List<Dokument> tempListaDok = new List<Dokument>();

            FbConnection fCon = new FbConnection(connectionString);
            fCon.Open();
            FbCommand fComm = new FbCommand(String.Format(commandString,id_nagl,id_poz,wartTrzy), fCon);
            FbDataReader fbreader = fComm.ExecuteReader();
            while (fbreader.Read())
            {
                Dokument temp = new Dokument();
                temp.id = fbreader.GetString(0);

                for (int i = 1; i <= iloscKolumn && i<fbreader.FieldCount; i++)
                    temp.addValue(fbreader.GetString(i));
                tempListaDok.Add(temp);
            }
            fbreader.Close();
            fComm.Dispose();
            fCon.Close();

            if (daneDokumentu != null)
                daneDokumentu.Clear();

            daneDokumentu = tempListaDok;

            return tempListaDok;
        }

        private void Skanuj_TxB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                skanuj_Button_Click(this, new EventArgs());
            }
        }

        private void Magazyn_Button_Click(object sender, EventArgs e)
        {
            wybierzWiersz();

            if (Magazyn_Button.Text == "Magazyn wszystkie")
            {
                    if (id_Nagl != null && id_Nagl != "" && wybranyWierszIdPoz != null && wybranyWierszIdPoz != "")
                        pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, id_Nagl, wybranyWierszIdPoz, "N");
                    else
                        pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, "1", getNumerMagazynu(), "MW");

                    updateGridView(daneDokumentu);

                    podswietlPrzycisk((Button)sender);

                    zmienTxtBelka(Magazyn_Button.Text);
                    Magazyn_Button.Text = "Magazyn niewydrukowane";
                    id_Nagl = "";
            }
            else if (Magazyn_Button.Text == "Magazyn niewydrukowane")
            {

                    if (id_Nagl != null && id_Nagl != "" && wybranyWierszIdPoz != null && wybranyWierszIdPoz != "")
                        pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, id_Nagl, wybranyWierszIdPoz, "N");
                    else
                        pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, "1", getNumerMagazynu(), "MN");

                    updateGridView(daneDokumentu);

                    podswietlPrzycisk((Button)sender);

                    zmienTxtBelka(Magazyn_Button.Text);
                    Magazyn_Button.Text = "Magazyn wszystkie";
                    id_Nagl = "";
            }
        }

        private void ZDnia_Button_Click(object sender, EventArgs e)
        {
            if (ZDnia_Button.Text == "Pokaż niewydrukowane z dnia")
            {

                    pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, "1", "1", "DN");
                    updateGridView(daneDokumentu);

                    podswietlPrzycisk((Button)sender);

                    zmienTxtBelka(ZDnia_Button.Text);
                    ZDnia_Button.Text = "Pokaż wszystkie z dnia";


                id_Nagl = "";
            }
            else if (ZDnia_Button.Text == "Pokaż wszystkie z dnia")
            {
                    pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, "1", "1", "DW");
                    updateGridView(daneDokumentu);

                    podswietlPrzycisk((Button)sender);

                    zmienTxtBelka(ZDnia_Button.Text);
                    ZDnia_Button.Text = "Pokaż niewydrukowane z dnia";


                id_Nagl = "";
            }
        }

        private void PokazNiewydrukowane_Button_Click(object sender, EventArgs e)
        {
            if (PokazNiewydrukowane_Button.Text == "Pokaż niewydrukowane")
            {
                if (MainGridView.Rows.Count > 0)
                {

                    if (id_Nagl != null && id_Nagl != "")
                        pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, id_Nagl, "1", "N");
                    else
                    pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, "1", "1", "N");
                    updateGridView(daneDokumentu);

                    podswietlPrzycisk((Button)sender);

                    zmienTxtBelka(PokazNiewydrukowane_Button.Text);
                    PokazNiewydrukowane_Button.Text = "Pokaż wszystkie";
                }
            }
            else if (PokazNiewydrukowane_Button.Text == "Pokaż wszystkie")
            {
                if (MainGridView.Rows.Count > 0)
                {
                    if(id_Nagl != null && id_Nagl != "")
                        pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, id_Nagl, "1", "C");
                       else
                    pobierzDane(MainGridView.Columns.Count, Settings.connectionString, Settings.commandString5, "1", "1", "C");


                    updateGridView(daneDokumentu);

                    podswietlPrzycisk((Button)sender);

                    zmienTxtBelka(PokazNiewydrukowane_Button.Text);
                    PokazNiewydrukowane_Button.Text = "Pokaż niewydrukowane";
                }
            }
        }

        private void zmienTxtBelka(string text)
        {
            if(text != null)
            {
                this.Text = "Etykiety - " + text;
                Magazyn_Button.Text = "Magazyn niewydrukowane";
                ZDnia_Button.Text = "Pokaż niewydrukowane z dnia";
                PokazNiewydrukowane_Button.Text = "Pokaż niewydrukowane";
            }
        }

        private void podswietlPrzycisk(Button butt)
        {
            foreach (Control b in this.Controls)
                if (b is Button && b.BackColor != Color.LightGray) b.BackColor = Color.LightGray;

            if (butt.BackColor == Color.LightGray)
                butt.BackColor = Color.LightBlue;
            else
                butt.BackColor = Color.LightGray;

        }

        public void resetButtons()
        {
            PokazNiewydrukowane_Button.Text = "Pokaż niewydrukowane";
            ZDnia_Button.Text = "Pokaż niewydrukowane z dnia";
            Magazyn_Button.Text = "Magazyn wszystkie";
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            DokumentyMagazynoweForm dokmag = new DokumentyMagazynoweForm();
            dokmag.Show();
        }

        private string getNumerMagazynu()
        {
            foreach(Magazyn x in magazynyLista)
            {
                if (x.nazwaMagazynu == magazynCombo.Text)
                    return x.p1;
            }
                return "1";
        }
    }
}
