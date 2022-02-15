using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using MaterialSkin.Controls;
using System.Drawing.Text;
using SautinSoft;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace LotoAdatbazis
{
    class BackEnd
    {
        public static string path = "";
        public static string terulet = "";
        public static string gep = "";
        public static string gepszama = "";
        public static string verzio = "";
        public static string file = ""; //Az aktuálisan kiválasztott fiel neve eléréssel
        public static string alapKeresoMappa = "";
        public static string hibaString = "";
        public static string hibasFileok = "";

        public static Button btnDelete;
        public static Button btnOpen;
        public static Button btnOpenPdf;
        public static Button btnJelek;
        public static Button btnVissza;
        public static Label labelTerulet;
        public static Label labelGep;
        public static Label labelGepSzam;
        public static Label labelVerzio;
        public static AxAcroPDFLib.AxAcroPDF pdfViewer;
        public static ComboBox cbTerulet;
        public static ComboBox cbGep;
        public static ComboBox cbGepSzam;
        public static ComboBox cbVerzio;
        public static PictureBox dokuMegjel;
        public static PictureBox nikkoSoft;
        public static Panel panelJelMenu;
        public static ComboBox cbJelMod2;
        public static int cbJelMod2_SelectedIndex;


        public static void FormLoad(Button _btnDelete, Button _btnOpen, Button _btnOpenPdf, Button _btnJelek, Label _labelTerulet, Label _labelGep, Label _labelGepSzam, Label _labelVerzio, AxAcroPDFLib.AxAcroPDF _pdfViewer, ComboBox _cbTerulet, ComboBox _cbGep, ComboBox _cbGepSzam, ComboBox _cbVerzio, PictureBox _dokuMegjel, PictureBox _nikkoSoft, Panel _panelJelMenu, Button _btnVissza, ComboBox _cbJelMod2)
        {
            btnDelete = _btnDelete;
            btnOpen = _btnOpen;
            btnOpenPdf = _btnOpenPdf;
            btnJelek = _btnJelek;
            btnVissza = _btnVissza;
            labelTerulet = _labelTerulet;
            labelGep = _labelGep;
            labelGepSzam = _labelGepSzam;
            labelVerzio = _labelVerzio;
            pdfViewer = _pdfViewer;
            cbTerulet = _cbTerulet;
            cbGep = _cbGep;
            cbGepSzam = _cbGepSzam;
            cbVerzio = _cbVerzio;
            dokuMegjel = _dokuMegjel;
            nikkoSoft = _nikkoSoft;
            panelJelMenu = _panelJelMenu;
            cbJelMod2 = _cbJelMod2;

            cbJelMod2.SelectedIndexChanged += CbJelMod2_SelectedIndexChanged;
            cbJelMod2_SelectedIndex = 0;

            btnOpenPdf.AutoSize = false;
            btnOpenPdf.Size = new Size(315, 65);
            btnOpenPdf.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnOpenPdf.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            //btnOpenPdf.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 136, 229);
            btnOpenPdf.FlatStyle = FlatStyle.Flat;
            btnOpenPdf.BackColor = Color.FromArgb(21, 101, 192);
            btnOpenPdf.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnOpenPdf.ForeColor = Color.White;
            btnOpenPdf.EnabledChanged += Button_EnabledChanged;

            btnOpen.AutoSize = false;
            btnOpen.Size = new Size(315, 65);
            btnOpen.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnOpen.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.BackColor = Color.FromArgb(21, 101, 192);
            btnOpen.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnOpen.ForeColor = Color.White;
            btnOpen.EnabledChanged += Button_EnabledChanged;

            btnDelete.AutoSize = false;
            btnDelete.Size = new Size(315, 65);
            btnDelete.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.BackColor = Color.FromArgb(21, 101, 192);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnDelete.ForeColor = Color.White;
            btnDelete.EnabledChanged += Button_EnabledChanged;

            btnJelek.AutoSize = false;
            btnJelek.Size = new Size(315, 65);
            btnJelek.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnJelek.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            btnJelek.FlatStyle = FlatStyle.Flat;
            btnJelek.BackColor = Color.FromArgb(21, 101, 192);
            btnJelek.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnJelek.ForeColor = Color.White;
            btnJelek.EnabledChanged += Button_EnabledChanged;

            btnVissza.AutoSize = false;
            btnVissza.Size = new Size(100, 50);
            btnVissza.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnVissza.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            btnVissza.FlatStyle = FlatStyle.Flat;
            btnVissza.BackColor = Color.FromArgb(18, 91, 180);
            btnVissza.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnVissza.ForeColor = Color.White;

            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis");
            }

            try
            {
                btnDelete.Enabled = false;
                btnOpen.Enabled = false;
                btnJelek.Enabled = false;
                labelTerulet.BackColor = Color.Transparent;
                labelGep.BackColor = Color.Transparent;
                labelGepSzam.BackColor = Color.Transparent;
                labelVerzio.BackColor = Color.Transparent;
                pdfViewer.Visible = false;
                if(File.Exists(Directory.GetCurrentDirectory() + "\\Adat\\config.txt"))
                {
                    try
                    {
                        string[] sorok = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Adat\\config.txt");
                        alapKeresoMappa = sorok[0];
                    }
                    catch
                    {

                    }
                }

                string[] paths = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis");
                Array.Sort(paths, (x, y) => String.Compare(x, y));
                for (int i = 0; i < paths.Length; i++)
                {
                    cbTerulet.Items.Add(CsereldAPertVissza(paths[i].Split('\\').Last()));
                }
            }
            catch
            {

            }
        }

        private static void CbJelMod2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbJelMod2_SelectedIndex = cbJelMod2.SelectedIndex;
        }

        private static void Button_EnabledChanged(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
            {
                btn.BackColor = Color.FromArgb(21, 101, 192);
                btn.FlatAppearance.BorderColor = Color.FromArgb(25, 118, 210);
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.FromArgb(13, 71, 161);
                btn.FlatAppearance.BorderColor = Color.FromArgb(8, 65, 150);
                btn.ForeColor = Color.FromArgb(30,136,229);
            }
        }

        public static void OpenAPdf()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "pdf files (*.pdf)|*.pdf";
                dialog.Multiselect = true;
                if (alapKeresoMappa != "")
                {
                    dialog.InitialDirectory = alapKeresoMappa;
                }
                else
                {
                    dialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\";
                }
                dialog.Title = "Kérlek válaszd ki a PDF-fileokat!";

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    dialog.ShowHelp = true;
                    string[] files = dialog.FileNames;
                    List<string> fileNameElements = new List<string>();


                    try
                    {
                        //path = dialog.FileName;
                        for (int i = 0; i < files.Count(); i++)
                        {
                            bool hibasFile = false;


                            try
                            {

                                path = files[i];
                                fileNameElements = path.Split('\\').ToList();

                                StringBuilder text = new StringBuilder();
                                using (PdfReader reader = new PdfReader(path))
                                {
                                    for (int j = 1; j <= reader.NumberOfPages; j++)
                                    {
                                        text.Append(PdfTextExtractor.GetTextFromPage(reader, j));
                                    }
                                }

                                File.WriteAllText(Directory.GetCurrentDirectory() + "\\Adat\\text.txt", text.ToString());
                                string teruletGep = getBetween(text.ToString(), "GÉP MEGNEVEZÉSE: ", "\n");

                                string[] teruletGepReszek = teruletGep.Split('/');

                                terulet = getBetween(teruletGep, "", "/");

                                if (terulet[0] == ' ') //2020.10.26
                                {
                                    terulet.Remove(0);
                                }
                                if (terulet[terulet.Length - 1] == ' ')
                                {
                                    terulet.Remove(terulet.Length - 1);
                                }

                                string gepIdeiglenes = teruletGepReszek[1];
                                gep = gepIdeiglenes.Substring(1, gepIdeiglenes.Length - 2);

                                if (gep == "")
                                {
                                    //MessageBox.Show("A géppel van a gond!");
                                }
                                gepszama = getBetween(text.ToString(), "GÉP SZÁMA: ", " TERÜLET");

                                if (gepszama == "")
                                {
                                    //MessageBox.Show("A gépszámmal van a gond!");
                                }
                                string verzioValtozat = getBetween(text.ToString(), "Változat: ", ".");
                                string verzioValtozat2 = getBetween(text.ToString(), "Változat: ", "ENERGIA");
                                string[] verzioValtozatReszek = verzioValtozat.Split('/');
                                verzio = verzioValtozatReszek.Last(); //utolsó a verzió
                                Regex.IsMatch(verzioValtozat2, @"^[a-zA-Z]+$");
                                var VerzioResult = new string(verzioValtozat2.Where(c => Char.IsLetter(c) || Char.IsNumber(c)).ToArray());
                                //******************************************************

                                string fileNameShort = fileNameElements.Last().Split('.')[0];
                                if (VerzioResult.Length > 0)
                                {
                                    if (Char.IsLetter(VerzioResult[0]) && Char.IsDigit(VerzioResult[1]) && VerzioResult.Length < 4)
                                    {
                                        verzio = VerzioResult;
                                    }
                                    else
                                    {
                                        verzio = VerzioName(verzio, fileNameShort);
                                    }
                                }
                                else
                                {
                                    verzio = VerzioName(verzio, fileNameShort);
                                }



                                string fileMappa = "";
                                for (int j = 0; j < fileNameElements.Count() - 1; j++)
                                {
                                    fileMappa = fileMappa + fileNameElements[j] + "\\";
                                }
                                alapKeresoMappa = fileMappa;
                                File.WriteAllText(Directory.GetCurrentDirectory() + "\\Adat\\config.txt", alapKeresoMappa);

                                terulet = CsereldAPert(terulet);
                                gep = CsereldAPert(gep);
                                gepszama = CsereldAPert(gepszama);
                                verzio = CsereldAPert(verzio);

                                //richTextBox1.Text = String.Format("{0}\n{1}\n{2}\n{3}", terulet, gep, gepszama, verzio);
                                //richTextBox1.Text = text.ToString();
                                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis"))
                                {
                                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis");
                                }
                                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + @terulet))
                                {
                                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + @terulet);
                                }
                                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + @terulet + "\\" + @gep))
                                {
                                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + @terulet + "\\" + @gep);
                                }
                                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + @terulet + "\\" + @gep + "\\" + @gepszama))
                                {
                                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + @terulet + "\\" + @gep + "\\" + @gepszama);
                                }
                                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + @terulet + "\\" + @gep + "\\" + @gepszama + "\\" + @verzio))
                                {
                                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + @terulet + "\\" + @gep + "\\" + @gepszama + "\\" + @verzio);
                                }

                                try
                                {
                                    if (Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + @terulet + "\\" + @gep + "\\" + @gepszama + "\\" + @verzio + "\\").Length < 1)
                                    {
                                        File.Copy(dialog.FileNames[i], Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + @terulet + "\\" + @gep + "\\" + @gepszama + "\\" + @verzio + "\\" + @fileNameElements.Last());
                                    }
                                    else
                                    {
                                        //MessageBox.Show("Az adatbázis már tartalmaz elemet ezen a néven!");
                                        hibaString += "Az adatbázis már tartalmaz elemet ezekkel a tulajdonságokkal:" + @terulet + "\\" + @gep + "\\" + @gepszama + "\\" + @verzio + " - a hibás file(" + fileNameElements.Last() + ")\n";
                                        hibasFile = true;
                                    }
                                }
                                catch
                                {
                                    hibaString += "Az adatbázis már tartalmazza a " + fileNameElements.Last() + "-filet!\n";
                                    hibasFile = true;
                                }


                            }

                            catch (Exception e)
                            {

                                //MessageBox.Show("A PDF nem tartalmazza az alábbi kulcsszavak valamelyikét: (GÉP MEGNEVEZÉSE:) , (GÉP SZÁMA:), ( TERÜLET), (Változat: ), vagy ezek formátuma nem megfelelő!");
                                hibaString += "Hiba a " + fileNameElements.Last() + "-fileban. A gépmegnevezés, gépszám, a terület, vagy a verzió elnevezésével van a gond!\n";
                                //System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\text.txt");
                                hibasFile = true;
                            }
                            if (hibasFile)
                            {
                                hibasFileok += fileNameElements.Last() + "\n";
                            }
                        }



                    }
                    catch
                    {
                        //MessageBox.Show("A PDF nem tartalmazza az alábbi kulcsszavak valamelyikét: (GÉP MEGNEVEZÉSE:) , (GÉP SZÁMA:), ( TERÜLET), (Változat: ), vagy ezek formátuma nem megfelelő!");
                        //hibaString += "Hiba a " + fileNameElements.Last()  + "-fileban. A gépmegnevezés, gépszám, a terület, vagy a verzió elnevezésével van a gond!\n";
                        //hibaString = "";
                        //System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\text.txt");
                    }
                }
                try
                {
                    cbTerulet.Items.Clear();
                    string[] paths = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis");
                    for (int i = 0; i < paths.Length; i++)
                    {
                        cbTerulet.Items.Add(paths[i].Split('\\').Last());
                    }
                }
                catch
                {

                }
                if (hibaString != "")
                {
                    MessageBox.Show(hibaString + "\n\nHibás fileok:\n" + hibasFileok);
                    hibaString = "";
                    hibasFileok = "";
                }
            }
        }
        public static bool VanAzElsoOldalon(string _file)
        {
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(_file))
            {
                for (int j = 1; j <= reader.NumberOfPages; j++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, j));
                }
            }
            string elsoOldalSzovege = getBetween(text.ToString(), "ENERGIA", "F I G Y E L M E Z T E T É S !");
            if(elsoOldalSzovege.Contains("ENERGIA LEZÁRÁS SORRENDJE"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                if(End == -1)
                {
                    End = strSource.Length;
                }
                return strSource.Substring(Start, End - Start);
            }
            return "";
        }
        public static string VerzioName(string verzio, string fileNameShort)
        {
            if (verzio.Length > 0) //Ha nem volt üres a verzió, valamit talált, ezt tesztelem
            {
                if (verzio[0] != 'v' && verzio[0] != 'V')
                {
                    try
                    {
                        int vIndex = fileNameShort.LastIndexOf('v');
                        List<int> verzioSzam = new List<int>();
                        for (int j = vIndex + 1; j < fileNameShort.Length; j++)
                        {
                            try
                            {
                                verzioSzam.Add(Int32.Parse(fileNameShort[j].ToString()));
                            }
                            catch
                            {

                            }
                        }
                        if (verzioSzam.Count > 0)
                        {
                            verzio = "v";
                            for (int j = 0; j < verzioSzam.Count(); j++)
                            {
                                verzio = verzio + verzioSzam[j];
                            }
                        }
                    }
                    catch
                    {
                        verzio = "v0";
                    }
                }
            }
            else //Ha sehol nem talál a doksiban verziót
            {
                try
                {
                    int vIndex = fileNameShort.LastIndexOf('v');
                    List<int> verzioSzam = new List<int>();
                    if (vIndex != -1)
                    {
                        for (int j = vIndex + 1; j < fileNameShort.Length; j++)
                        {
                            try
                            {
                                verzioSzam.Add(Int32.Parse(fileNameShort[j].ToString()));
                            }
                            catch
                            {

                            }
                        }
                        if (verzioSzam.Count > 0)
                        {
                            verzio = "v";
                            for (int j = 0; j < verzioSzam.Count(); j++)
                            {
                                verzio = verzio + verzioSzam[j];
                            }
                        }
                    }
                    else
                    {
                        verzio = "v0";
                    }

                }
                catch
                {
                    verzio = "v0";
                }
            }
            return verzio;
        }
        public static string CsereldAPert(string input) //És vágd le a szóközöket is
        {
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(input);
            if (input.IndexOf('/') != -1)
            {
                strBuilder[input.IndexOf('/')] = '¤';
                input = strBuilder.ToString();
            }
            for (int i = 0; i < input.Length; i++) //Előről törüljük a szóközöket
            {
                if(input[i] == ' ')
                {
                    input = input.Remove(0, 1);
                }
                else
                {
                    break;
                }
            }
            for (int i = input.Length; i > 0; i--) //Hátulról törüljük a szóközöket
            {
                if (input[i-1] == ' ')
                {
                    input = input.Remove(i-1, 1);
                }
                else
                {
                    break;
                }
            }
            return input;
        }
        public static string CsereldAPertVissza(string input)
        {
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(input);
            if (input.IndexOf('¤') != -1)
            {
                strBuilder[input.IndexOf('¤')] = '/';
                input = strBuilder.ToString();
            }
            return input;
        }


        //Innen az eventek vannak
        public static void cbTeruletSelectedIndexChanged()
        {
            file = "";
            cbGep.SelectedIndex = -1;
            cbGepSzam.SelectedIndex = -1;
            cbVerzio.SelectedIndex = -1;
            cbGep.Items.Clear();
            cbGepSzam.Items.Clear();
            cbVerzio.Items.Clear();
            if (cbTerulet.SelectedIndex == -1)
            {
                cbTerulet.Items.Clear();
                string[] paths = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis");
                Array.Sort(paths, (x, y) => String.Compare(x, y));
                for (int i = 0; i < paths.Length; i++)
                {
                    cbTerulet.Items.Add(CsereldAPertVissza(paths[i].Split('\\').Last()));
                }
            }
            if (cbTerulet.SelectedIndex != -1 && cbTerulet.SelectedIndex < cbTerulet.Items.Count)
            {
                string[] paths2 = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + CsereldAPert(cbTerulet.SelectedItem.ToString()));
                Array.Sort(paths2, (x, y) => String.Compare(x, y));
                for (int i = 0; i < paths2.Length; i++)
                {
                    cbGep.Items.Add(CsereldAPertVissza(paths2[i].Split('\\').Last()));
                }
            }
        }
        public static void cbGepSelectedIndexChanged()
        {
            cbGepSzam.SelectedIndex = -1;
            cbVerzio.SelectedIndex = -1;
            cbGepSzam.Items.Clear();
            cbVerzio.Items.Clear();
            if (cbGep.SelectedIndex != -1)
            {
                cbGepSzam.Items.Clear();
                cbVerzio.Items.Clear();
                string[] paths = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + CsereldAPert(cbTerulet.SelectedItem.ToString()) + "\\" + CsereldAPert(cbGep.SelectedItem.ToString()));
                Array.Sort(paths, (x, y) => String.Compare(x, y));
                for (int i = 0; i < paths.Length; i++)
                {
                    cbGepSzam.Items.Add(CsereldAPertVissza(paths[i].Split('\\').Last()));
                }
            }
        }
        public static void cbGepSzemSelectedIndexChanged()
        {
            cbVerzio.SelectedIndex = -1;
            cbVerzio.Items.Clear();
            if (cbGepSzam.SelectedIndex != -1)
            {
                cbVerzio.Items.Clear();
                string[] paths = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + CsereldAPert(cbTerulet.SelectedItem.ToString()) + "\\" + CsereldAPert(cbGep.SelectedItem.ToString()) + "\\" + CsereldAPert(cbGepSzam.SelectedItem.ToString()));
                Array.Sort(paths, (x, y) => String.Compare(x, y));
                for (int i = 0; i < paths.Length; i++)
                {
                    cbVerzio.Items.Add(CsereldAPertVissza(paths[i].Split('\\').Last()));
                }
            }
        }
        public static void cbVerzioSelectedIndexChanged()
        {
            panelJelMenu.Visible = false;
            if (cbVerzio.SelectedIndex != -1)
            {
                btnDelete.Enabled = true;
                btnOpen.Enabled = true;
                btnJelek.Enabled = true;
                try
                {
                    string pathForOpen = Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + CsereldAPert(cbTerulet.SelectedItem.ToString()) + "\\" + CsereldAPert(cbGep.SelectedItem.ToString()) + "\\" + CsereldAPert(cbGepSzam.SelectedItem.ToString()) + "\\" + CsereldAPert(cbVerzio.SelectedItem.ToString());
                    List<string> files = Directory.EnumerateFiles(pathForOpen, "*.pdf").ToList();
                    pdfViewer.src = files[0];
                    file = files[0];
                    dokuMegjel.Visible = false;
                    pdfViewer.Visible = true;
                    nikkoSoft.Visible = false;
                }
                catch
                {
                    MessageBox.Show("File nem található!");
                }
            }
            else
            {
                btnDelete.Enabled = false;
                btnOpen.Enabled = false;
                btnJelek.Enabled = false;
                pdfViewer.Visible = false;
                dokuMegjel.Visible = true;
                nikkoSoft.Visible = true;
            }
        }
        public static void btnOpenClick()
        {
            try
            {
                System.Diagnostics.Process.Start(file);
            
            }
            catch
            {
                MessageBox.Show("Nincs file kiválasztva!");
            }
        }
        public static void btnDeleteClick()
        {
            if (cbVerzio.SelectedIndex != -1)
            {
                if (MessageBox.Show("Biztosan törli a kiválasztott PDF-et az adatbázisból?", "PDF törlése", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string verzioMappa = System.IO.Path.GetDirectoryName(file);
                    string gepSZamaMappa = System.IO.Path.GetDirectoryName(verzioMappa);
                    string gepMappa = System.IO.Path.GetDirectoryName(gepSZamaMappa);
                    string teruletMappa = System.IO.Path.GetDirectoryName(gepMappa);

                    File.Delete(file);
                    //Directory.Delete(verzioMappa);
                    DeleteDirectory(verzioMappa);

                    string[] gepSzamaMappak = Directory.GetDirectories(gepSZamaMappa);
                    if (gepSzamaMappak.Count() == 0)
                    {
                        Directory.Delete(gepSZamaMappa);
                    }
                    string[] gepMappak = Directory.GetDirectories(gepMappa);
                    if (gepMappak.Count() == 0)
                    {
                        Directory.Delete(gepMappa);
                    }
                    string[] teruletMappak = Directory.GetDirectories(teruletMappa);
                    if (teruletMappak.Count() == 0)
                    {
                        Directory.Delete(teruletMappa);
                    }
                    pdfViewer.LoadFile("none");
                    cbTerulet.SelectedIndex = -1;
                }
            }
        }
        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
            //DeleteEmptyDirs(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis");
        
        }
        static void DeleteEmptyDirs(string dir)
        {
            if (String.IsNullOrEmpty(dir))
                throw new ArgumentException(
                    "Starting directory is a null reference or an empty string",
                    "dir");

            try
            {
                foreach (var d in Directory.EnumerateDirectories(dir))
                {
                    DeleteEmptyDirs(d);
                }

                var entries = Directory.EnumerateFileSystemEntries(dir);

                if (!entries.Any())
                {
                    try
                    {
                        Directory.Delete(dir);
                    }
                    catch (UnauthorizedAccessException) { }
                    catch (DirectoryNotFoundException) { }
                }
            }
            catch (UnauthorizedAccessException) { }
        }
        public static void btnVisszaClick()
        {
            panelJelMenu.Visible = false;
        }
        public static bool btnJelekBusy = false;
        public static void btnJelekClick()
        {
            panelJelMenu.Visible = !panelJelMenu.Visible;
        }
        public static async void JelekKigyujtese()
        {
            if (!btnJelekBusy)
            {
                btnJelekBusy = true;
                if (Directory.Exists(System.IO.Path.GetDirectoryName(file) + "\\Jelek"))
                {
                    Process.Start(System.IO.Path.GetDirectoryName(file) + "\\Jelek");
                }
                else
                {
                    btnJelek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    btnJelek.Image = System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\loading.gif");
                    btnJelek.BackColor = Color.FromArgb(13, 71, 161);
                    btnJelek.FlatAppearance.BorderColor = Color.FromArgb(8, 65, 150);
                    btnJelek.ForeColor = Color.Black;
                    await Task.Run(() => SpireConvert.Convert(file));
                    btnJelek.Image = null;
                    Process.Start(System.IO.Path.GetDirectoryName(file) + "\\Jelek");
                    btnJelek.BackColor = Color.FromArgb(21, 101, 192);
                    btnJelek.FlatAppearance.BorderColor = Color.FromArgb(25, 118, 210);
                    btnJelek.ForeColor = Color.White;
                }
                btnJelekBusy = false;
            }
        }
        

    }
}
