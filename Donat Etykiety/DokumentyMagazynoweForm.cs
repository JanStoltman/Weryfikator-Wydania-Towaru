using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.Client;
using FirebirdSql.Data.Common;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Server;


namespace Donat_Etykiety
{
    public partial class DokumentyMagazynoweForm : Form
    {
        private List<Dokument> listaDokumentow, listaDanychDokument;
        string activeIdPoz = string.Empty;
        string numDok = "0000";
        public MainMenu activeMenu;

        public DokumentyMagazynoweForm()
        {
            InitializeComponent();
            Inicjalizuj();
           
        }

        public void Inicjalizuj()
        {
            listaDokumentow = pobierzDane(dataGridView1.ColumnCount, Settings.connectionString, Settings.commandString1);
            //listaDokumentow = pobierzDane();//testowe

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dataGridView1.Columns["Kontrahent_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Nazwa_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            foreach (Dokument x in listaDokumentow)
            {
                dataGridView1.Rows.Add(x.dane.ToArray());
            }

            if (dataGridView1.Rows.Count > 0 && listaDokumentow.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.Update();

                if (listaDanychDokument != null)
                    listaDanychDokument.Clear();

                listaDanychDokument = pobierzDane(dataGridView2.ColumnCount, Settings.connectionString, Settings.commandString2 + listaDokumentow[0].id);//TODO:Zapytanie o dany dokument

                dataGridView2.Rows.Clear();
                foreach (Dokument x in listaDanychDokument)
                {
                    dataGridView2.Rows.Add(x.dane.ToArray());
                }

                dataGridView2.Columns["Indeks_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView2.Columns["Kartoteka_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView2.Columns["Lp_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.Columns["numerMag_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.Refresh();
            }
        }

        private List<Dokument> pobierzDane()
        {
            List<Dokument> tempListaDok = new List<Dokument>();

            FbConnection fCon = new FbConnection(Settings.connectionString);
            fCon.Open();
            FbCommand fComm = new FbCommand(Settings.testCommandString1, fCon);
            FbDataReader fbreader = fComm.ExecuteReader();


            while (fbreader.Read())
            {
                Dokument temp = new Dokument();
                temp.id = fbreader.GetString(0);

                for (int i = 1; i <= 5; i++)
                    temp.addValue(fbreader.GetString(i));
                tempListaDok.Add(temp);
            }
            fbreader.Close();
            fComm.Dispose();
            fCon.Close();
            return tempListaDok;
        }//Testowe

        private List<Dokument> pobierzDane(int iloscKolumn, string connectionString, string commandString)
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
                temp.numerDokWew = fbreader.GetString(1);

                for (int i = 1; i <= iloscKolumn && i < fbreader.FieldCount; i++)
                    temp.addValue(fbreader.GetString(i));
                tempListaDok.Add(temp);
            }
            fbreader.Close();
            fComm.Dispose();
            fCon.Close();
            return tempListaDok;
        }

        private void pobierzDaneDokumentow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < (dataGridView1.Rows.Count - 1) && e.RowIndex >= 0)
            {
                numDok = dataGridView1.Rows[e.RowIndex].Cells["NumerDok_Column"].Value.ToString();

                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.Update();

                activeIdPoz = listaDokumentow.Find(item => (item.dane[0] == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())).id;

                if (listaDanychDokument != null)
                    listaDanychDokument.Clear();
                listaDanychDokument = pobierzDane(dataGridView2.ColumnCount, Settings.connectionString, Settings.commandString2 + activeIdPoz);//TODO:Zapytanie o dany dokument


                dataGridView2.Rows.Clear();
                foreach (Dokument x in listaDanychDokument)
                {
                    dataGridView2.Rows.Add(x.dane.ToArray());
                }

                dataGridView2.Columns["Indeks_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView2.Columns["Kartoteka_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView2.Columns["Lp_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.Columns["numerMag_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.Refresh();
            }
        }

        private void Wybierz_Button_Click(object sender, EventArgs e)
        {

            if (activeIdPoz != string.Empty)
            {
                int temp = new int();
                Int32.TryParse(activeIdPoz, out temp);
                activeMenu.updateGridView(activeIdPoz, numDok, "C");
                activeMenu.resetButtons();
                activeMenu.Show();
                this.Close();
            }

        }

        /*private void Wszystkie_Button_Click(object sender, EventArgs e)
        {
            if (listaDokumentow != null)
                listaDokumentow.Clear();
            listaDokumentow = pobierzDane(dataGridView1.ColumnCount, Settings.connectionString, Settings.commandString1);
            dataGridView1.Rows.Clear();

            foreach (Dokument x in listaDokumentow)
            {
                dataGridView1.Rows.Add(x.dane.ToArray());
            }

            dataGridView1.Columns["Kontrahent_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Nazwa_Column"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Refresh();
        }*/

        private void wybierz(object sender, DataGridViewCellEventArgs e)
        {
            if (activeIdPoz != string.Empty)
            {
                int temp = new int();
                Int32.TryParse(activeIdPoz, out temp);

                activeMenu.updateGridView(activeIdPoz, numDok, "C");
                activeMenu.resetButtons();
            }

            this.Close();
        }

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int i = dataGridView1.CurrentRow.Index;

                if (listaDanychDokument != null)
                    listaDanychDokument.Clear();

                listaDanychDokument = pobierzDane(dataGridView2.ColumnCount, Settings.connectionString, Settings.commandString2 + listaDokumentow[i].id);

                activeMenu.updateGridView(listaDanychDokument, numDok);
                this.Close();
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Automatic;
            if (dataGridView2.Rows != null)
                dataGridView2.Rows.Clear();

            activeIdPoz = string.Empty;
            numDok = "0000";
        }
    }
}
