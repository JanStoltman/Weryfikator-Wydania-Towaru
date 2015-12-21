using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donat_Etykiety
{
    class Settings
    {
        static public string connectionString = "User=SYSDBA;Password=masterkey;Database=C:\\STREAM soft\\STREAM soft SQL\\BAZA\\Gebala.FB;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";     
       // static public string connectionString = "User=SYSDBA;Password=masterkey;Database=C:\\Stream\\Firma1\\PCB\\baza\\Premium.fb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";

        //static public readonly string commandString1 = "select  n.ID_NAGL, n.NRDOKWEW, substr(n.DATADOK,1,10), count(p.ID_POZ), n.SUMAOG, dd.OPISDEFDOK, dd.SKROTDEFDOK from nagl n join poz p on p.ID_NAGL=n.ID_NAGL join kartoteka k on k.ID_KARTOTEKA=p.ID_KARTOTEKA join defdok dd on dd.ID_DEFDOK=n.ID_DEFDOK where k.ID_RODZAJKART=1 and n.id_defdok in (10008, 10003) and n.DATADOK>current_date-30 group by n.ID_NAGL, n.NRDOKWEW, substr(n.DATADOK,1,10), n.SUMAOG, dd.OPISDEFDOK, dd.SKROTDEFDOK";
        static public readonly string commandString1 = "select p1, p2, p3, p4, p5, p6, p7, p8 from XXX_EKT_NAGL";
        static public readonly string commandString2 = "select p.ID_POZ, p.lp,m.nrMag, k.INDEKS, k.NAZWASKR, p.ILOSC, p.CENANETTO, p.WARTBRUTTO, wcp.WARTOSC, cast(wo.ILOSCWOPAK as integer) from poz p join kartoteka k on k.id_kartoteka=p.ID_KARTOTEKA join magazyn m on m.ID_MAGAZYN=p.ID_MAGAZYN left join WYSTCECHPOZ wcp on wcp.ID_POZ=p.ID_POZ and wcp.ID_CECHADOKK=10013 left JOIN WYSTOPAK Wo ON  (WO.ID_DEFOPAK = K.ID_DEFOPAKDEF) AND (WO.ID_KARTOTEKA = K.ID_KARTOTEKA) where p.id_nagl=";
        static public readonly string commandString3 = "select x.wiersz from XXX_EKT_ETYKIETY_PRN ({0}) x";
        static public readonly string commandString4 = "select first 1 wcp.id_poz, p.id_nagl from wystcechpoz wcp join poz p on p.id_poz=wcp.id_poz where wcp.id_cechadokk=10001 and wcp.wartosc ='{0}'";
        //static public string commandString5 = "select p.id_poz, p.lp, M.NRMAG, substr(k.indeks,1,30), Substr(k.NAZWASKR,1,35), wcp4.wartosc, cast(wo.ILOSCWOPAK as integer), substr(wcp6.WARTOSC,1,8),  wck1.WARTOSC, wcp1.WARTOSC, wcp2.WARTOSC, wcp7.wartosc from POZ p join kartoteka k on p.ID_KARTOTEKA=k.ID_KARTOTEKA INNER JOIN WYSTOPAK Wo ON  (WO.ID_DEFOPAK = K.ID_DEFOPAKDEF) AND (WO.ID_KARTOTEKA = K.ID_KARTOTEKA) join magazyn m on m.ID_MAGAZYN=p.ID_MAGAZYN join dostawa d on d.ID_POZ=p.ID_POZ join nagl n on n.ID_NAGL=p.ID_NAGL left join WYSTCECHPOZ wcp1 on wcp1.ID_POZ=p.ID_POZ and wcp1.ID_CECHADOKK=10017 left join WYSTCECHPOZ wcp2 on wcp2.ID_POZ=p.ID_POZ and wcp2.ID_CECHADOKK=10018 left join WYSTCECHPOZ wcp3 on wcp3.ID_POZ=p.ID_POZ and wcp3.ID_CECHADOKK=10019 left join WYSTCECHPOZ wcp4 on wcp4.ID_POZ=p.ID_POZ and wcp4.ID_CECHADOKK=10013 left join WYSTCECHPOZ wcp5 on wcp5.ID_POZ=p.ID_POZ and wcp5.ID_CECHADOKK=10001 left join WYSTCECHPOZ wcp6 on wcp6.ID_POZ=p.ID_POZ and wcp6.ID_CECHADOKK=10002 left join WYSTCECHPOZ wcp7 on wcp7.ID_POZ=p.ID_POZ and wcp7.ID_CECHADOKK=10012 left join WYSTCECHKART wck1 on wck1.ID_KARTOTEKA=p.ID_KARTOTEKA and wck1.ID_CECHADOKK=10006 where p.id_nagl=";
        static public readonly string commandString5 = "select x.p, x.p1, x.p2, x.p3, x.p4, x.p5, x.p6, x.p7, x.p8, x.p9, x.p10, x.p11, x.p12, x.p13, x.p14, x.p15 from XXX_EKT_ETYKIETY  ({0}, {1}, '{2}') x";
        static public readonly string commandString6 = "select p1, p2, p3 from XXX_EKT_MAGAZYNY"; // dodac i wyswietlic p2

        static public readonly string copyFilePath1 = "Etykiety.prn";

        static public readonly string testCommandString1 = "select id_kartoteka from kartoteka";
        static public readonly string testCommandString2 = "select id_jm from jm where id_jm < 10005";


        //public static MainMenu openMain;
        //public static DokumentyMagazynoweForm openDokumentyMagazynowe;

        //public static void closeMenu()
        //{
        //    if (openMain != null)
        //    {
        //        openMain.Close();
        //        openMain = null;
        //    }
        //}

        //public static void closeDokumentyMagazynoweForm()
        //{
        //    if (openDokumentyMagazynowe != null)
        //    {
        //        openDokumentyMagazynowe.Close();
        //        openDokumentyMagazynowe = null;
        //    }
        }
    }

//TODO: podswietlenie aktywnego przycisku
//Zapytanie z comboboxem