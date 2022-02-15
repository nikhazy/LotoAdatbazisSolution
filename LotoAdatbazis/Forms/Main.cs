using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using iTextSharp.text.pdf;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;

namespace LotoAdatbazis
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        public int Jogosultsag { get; set; }
        public Main(int _jogsoultsag)
        {
            InitializeComponent(); 
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //DirectoryInfo parentDirectoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            //ClearReadOnly(parentDirectoryInfo);

            // Configure color schema
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue400, Accent.LightBlue200,TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue600, Accent.LightBlue400, TextShade.WHITE);
            Jogosultsag = _jogsoultsag;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Directory.GetCurrentDirectory() + "\\Adat\\GEInspRg.TTF");
            foreach(Control c in panelBalMenu.Controls)
            {
                c.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
            }
            BackEnd.FormLoad(btnDelete, btnOpen, btnOpenPdf,btnJelek, label1, label2, label3, label4, pdfViewer, cbTerulet, cbGep, cbGepSzam, cbVerzio, pbDokuMegjelenes, pbNikkoLogo, panelPDFMenu, buttonHide, cbJelMod2);
            pbNikkoLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNikkoLogo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\nikko_gif.gif");
            pbLogo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\loto_gif.gif");
            pbDokuMegjelenes.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\megjelen_gif.gif");
            panelBalMenu.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\hatter.JPG");
            chbDeleteSigns.ForeColor = Color.White;
            PanelInit();
            if (Jogosultsag == 2)
            {
                btnAdmin.Visible = false;
            }
            if (Jogosultsag == 3)
            {
                btnOpenPdf.Visible = false;
                btnDelete.Visible = false;
                btnAdmin.Visible = false;
            }
        }
        private void ClearReadOnly(DirectoryInfo parentDirectory)
        {
            if (parentDirectory != null)
            {
                parentDirectory.Attributes = FileAttributes.Normal;
                foreach (FileInfo fi in parentDirectory.GetFiles())
                {
                    fi.Attributes = FileAttributes.Normal;
                }
                foreach (DirectoryInfo di in parentDirectory.GetDirectories())
                {
                    ClearReadOnly(di);
                }
            }
        }

        private void cbTerulet_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackEnd.cbTeruletSelectedIndexChanged();
        }

        private void cbGep_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackEnd.cbGepSelectedIndexChanged();
        }

        private void cbGepSzam_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackEnd.cbGepSzemSelectedIndexChanged();
        }

        private void cbVerzio_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackEnd.cbVerzioSelectedIndexChanged();
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            panelBalMenu.Size = new Size(panelBalMenu.Width,this.Height - 64);
            pdfViewer.Size = new Size(this.Width - 325, this.Height - 64);
            pbDokuMegjelenes.Location = new Point((int)(410 * ((double)this.Width/1000)), (int)(150 * ((double)this.Height / 800)));
            pbNikkoLogo.Location = new Point(this.Width - 201, this.Height - 61);
            dataGridView1.Columns[0].Width = this.Width - 325-50;
            btnAdmin.Location = new Point(this.Width - 200, 24);
            if(cbJelMod.Items.Count > 0)
            {
                if(cbJelMod.SelectedIndex == 0)
                {
                    panelPDFMenu.Size = new Size(500, this.Height - 64);
                }
                else if(cbJelMod.SelectedIndex == 1)
                {
                    panelPDFMenu.Size = new Size(this.Width - 325, this.Height - 64);
                }
            }
            else
            {
                panelPDFMenu.Size = new Size(this.Width - 325, this.Height - 64);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.lotohungary.hu/loto.html");
        }

        private void btnOpenPdf_Click(object sender, EventArgs e)
        {
            BackEnd.OpenAPdf();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            BackEnd.btnOpenClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BackEnd.btnDeleteClick();
        }

        private void btnJelek_Click(object sender, EventArgs e)
        {
            BackEnd.btnJelekClick();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            BackEnd.btnVisszaClick();
        }

        private void PanelInit()
        {
            panelPDFMenu.Visible = false;
            panelPDFMenu.BackColor = Color.FromArgb(21, 101, 192);
            panelPdfFejlec.BackColor = Color.FromArgb(18, 91, 180);

            cbJelMeret.SelectedIndex = 0;
            cbJelMod.SelectedIndex = 0;
            cbJelMod2.SelectedIndex = 0;

            btnJelekDokuKeszites.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnJelekDokuKeszites.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            btnJelekDokuKeszites.FlatStyle = FlatStyle.Flat;
            btnJelekDokuKeszites.BackColor = Color.FromArgb(18, 91, 180);
            btnJelekDokuKeszites.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnJelekDokuKeszites.ForeColor = Color.White;

            btnJelMindenKijeloles.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnJelMindenKijeloles.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            btnJelMindenKijeloles.FlatStyle = FlatStyle.Flat;
            btnJelMindenKijeloles.BackColor = Color.FromArgb(18, 91, 180);
            btnJelMindenKijeloles.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnJelMindenKijeloles.ForeColor = Color.White;

            btnAdmin.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.BackColor = Color.FromArgb(18, 91, 180);
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnAdmin.ForeColor = Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 118, 210);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AllowUserToAddRows = false;
            JelDokuKeszitesEllenorzes();
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            JelDokuKeszitesEllenorzes();
        }

        private void cbJelMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbJelMod.SelectedIndex == 1)
            {
                dataGridView1.Visible = true;
                btnJelMindenKijeloles.Visible = true;
                panelPDFMenu.Size = new Size(this.Width - 325, this.Height - 64);
                ListaKesziteseFileokbol();
            }
            else
            {
                dataGridView1.Visible = false;
                btnJelMindenKijeloles.Visible = false;
                panelPDFMenu.Size = new Size(500, this.Height - 64);
            }
            JelDokuKeszitesEllenorzes();
        }

        private void ListaKesziteseFileokbol()
        {
            dataGridView1.Rows.Clear();
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\", "*.pdf", SearchOption.AllDirectories);
            for (int i = 0; i < files.Length; i++)
            {
                string[] segedValtozo = files[i].Split('\\');
                string fileNameWithFolders = segedValtozo[segedValtozo.Length - 5] + "\\" + segedValtozo[segedValtozo.Length - 4] + "\\" +segedValtozo[segedValtozo.Length - 3] + "\\" +segedValtozo[segedValtozo.Length-2] + "\\" + segedValtozo[segedValtozo.Length - 1].Split('.').First();
                dataGridView1.Rows.Add(fileNameWithFolders,false);
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(188,218,248);
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.FromArgb(188, 218, 248);
                }
            }
        }
        public bool mindenKijelolve = false;
        private void btnJelMindenKijeloles_Click(object sender, EventArgs e)
        {
            mindenKijelolve = !mindenKijelolve;
            if(mindenKijelolve)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1[1, i].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1[1, i].Value = false;
                }
            }
        }
        private void JelDokuKeszitesEllenorzes()
        {
            bool mehet = false;
            if (cbJelMod.SelectedIndex == 0)
            {
                mehet = true;
            }
            else if (cbJelMod.SelectedIndex == 1)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (bool.Parse(dataGridView1[1, i].Value.ToString()) == true)
                    {
                        mehet = true;
                        break;
                    }
                }
            }
            if (mehet)
            {
                btnJelekDokuKeszites.Enabled = true;
            }
            else
            {
                btnJelekDokuKeszites.Enabled = false;
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        public bool SaveBusy = false;
        private async void btnJelekDokuKeszites_Click(object sender, EventArgs e)
        {
            if(!SaveBusy)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "nevtelen.pdf";
                // set filters - this can be done in properties as well
                savefile.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Enabled = false;
                    cbJelMeret.Enabled = false;
                    cbJelMod.Enabled = false;
                    cbJelMod2.Enabled = false;
                    chbDeleteSigns.Enabled = false;
                    btnJelMindenKijeloles.Enabled = false;
                    SaveBusy = true;
                    btnJelekDokuKeszites.Image = System.Drawing.Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\loading.gif");
                    btnJelekDokuKeszites.BackColor = Color.FromArgb(0, 129, 188);
                    btnJelekDokuKeszites.Text = "Dokumentum elkészítése folyamatban, kérlek várj!";
                    string PDFName = savefile.FileName;

                    if (cbJelMod.SelectedIndex == 0)
                    {
                            List<JelekPDFre> Jelek = new List<JelekPDFre>();
                            await Task.Run(() => EgyJelKigyujtesHaMegNincs(BackEnd.file));
                            Jelek.Add(new JelekPDFre(BackEnd.file));
                            string[] jelek = Directory.GetFiles(Path.GetDirectoryName(BackEnd.file) + "\\Jelek");
                            for (int j = 0; j < jelek.Length; j++)
                            {
                                Jelek.Last().Jelek.Add(jelek[j]);
                            }
                            JelekPdfreMasolasa(Jelek, PDFName);

                        try
                        {
                        }
                        catch
                        {
                            MessageBox.Show("Nem található jel a dokumentumban!");
                        }
                    }
                    else if (cbJelMod.SelectedIndex == 1)
                    {
                        List<JelekPDFre> Jelek = new List<JelekPDFre>();
                        JelekPDFre.Meret = cbJelMeret.SelectedIndex + 1;
                            for (int i = 0; i < dataGridView1.Rows.Count; i++) //Kigyűjtöm az összes jelet ami még nincs
                            {
                                if (bool.Parse(dataGridView1[1, i].Value.ToString()) == true)
                                {
                                    string tempFile = Directory.GetCurrentDirectory() + "\\Adat\\Adatbázis\\" + dataGridView1[0, i].Value.ToString() + ".pdf";
                                    await Task.Run(() => EgyJelKigyujtesHaMegNincs(tempFile));

                                    Jelek.Add(new JelekPDFre(tempFile));

                                    string[] jelek = Directory.GetFiles(Path.GetDirectoryName(tempFile) + "\\Jelek");
                                    for (int j = 0; j < jelek.Length; j++)
                                    {
                                        Jelek.Last().Jelek.Add(jelek[j]);
                                    }
                                }
                            }

                        try //VIsszatenni
                        {

                        }
                        catch
                        {
                            MessageBox.Show("Nem található jel a dokumentumban!");
                        }
                        JelekPdfreMasolasa(Jelek, PDFName);
                    }
                }

                dataGridView1.Enabled = true;
                cbJelMeret.Enabled = true;
                cbJelMod.Enabled = true;
                cbJelMod2.Enabled = true;
                chbDeleteSigns.Enabled = true;
                btnJelMindenKijeloles.Enabled = true;
                btnJelekDokuKeszites.Text = "Dokumentum készítése";
                btnJelekDokuKeszites.BackColor = Color.FromArgb(18, 91, 180);
                btnJelekDokuKeszites.Image = null;
                SaveBusy = false;
            }
        }
        public void JelekPdfreMasolasa(List<JelekPDFre> jelek, string PdfName)
        {
            PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument();
            document.Info.Title = PdfName;

            List<string> jelekElerese = new List<string>();
            for (int i = 0; i < jelek.Count; i++)
            {
                for (int j = 0; j < jelek[i].Jelek.Count; j++)
                {
                    jelekElerese.Add(jelek[i].Jelek[j]);
                }
            }
            int sorokSzama = (int)Math.Ceiling((double)jelekElerese.Count() / JelekPDFre.EgysegPerSor);

            int sorPerOldal = JelekPDFre.SorPerOldalMethod();
            int oldlakSzama = (int)Math.Ceiling((double)sorokSzama / sorPerOldal);

            List<PdfSharp.Pdf.PdfPage> pages = new List<PdfSharp.Pdf.PdfPage>();
            List<XGraphics> gfxList = new List<XGraphics>();
            for (int i = 0; i < oldlakSzama; i++)
            {
                pages.Add(document.AddPage());

                gfxList.Add(XGraphics.FromPdfPage(pages.Last()));
            }

            //ideiglenes cuccok
            double szelesseg = pages[0].Width.Point;
            double magassag = pages[0].Height.Point;


            int aktualisSor = 0;
            int aktualisOldal = 0;
            int hanyadikASotban = 0;

            double kezdoPixelX = 0;
            if(JelekPDFre.Meret == 3 )
            {
                kezdoPixelX = 595.0 / 2100 * 150;
            }
            else
            {
                kezdoPixelX = 595.0 / 2100 * 50;
            }

            double kezdoPixelY = 0;
            if (JelekPDFre.Meret == 1 && JelekPDFre.Meret == 5)
            {
                kezdoPixelY = 842.0 / 2970 * 235; //235 volt
            }
            else
            {
                kezdoPixelY = 842.0 / 2970 * 285; // 285 volt
            }

            XPen pen = new XPen(XColors.Black, 1);
            for (int i = 0; i < jelekElerese.Count; i++)
            {
                if (aktualisSor >= sorPerOldal)
                {
                    aktualisSor = 0;
                    hanyadikASotban = 0;
                    aktualisOldal++;
                }
                XRect mezo = new XRect((int)kezdoPixelX + hanyadikASotban * (int)((595.0 / 2100) * JelekPDFre.Meret * 100), (int)kezdoPixelY + aktualisSor * (int)((595.0 / 2100) * JelekPDFre.Meret * 100), (int)((595.0 / 2100) * JelekPDFre.Meret * 100), (int)((595.0 / 2100) * JelekPDFre.Meret * 100));
                XRect mezoKep = new XRect((int)kezdoPixelX + hanyadikASotban * (int)((595.0 / 2100) * JelekPDFre.Meret * 100)+1, (int)kezdoPixelY + aktualisSor * (int)((595.0 / 2100) * JelekPDFre.Meret * 100)+1, (int)((595.0 / 2100) * JelekPDFre.Meret * 100)-2, (int)((595.0 / 2100) * JelekPDFre.Meret * 100)-2);
                using (XImage image = XImage.FromFile(jelekElerese[i]))
                {
                    gfxList[aktualisOldal].DrawRectangle(pen, mezo);
                    gfxList[aktualisOldal].DrawImage(image, mezoKep);
                }

                hanyadikASotban++;
                if((i+1)%JelekPDFre.EgysegPerSor == 0)
                {
                    aktualisSor++;
                    hanyadikASotban = 0;
                }
            }

            
            document.Save(PdfName);
            document.Dispose();
            Process.Start(PdfName);
        }
        //public List<string> kijeloltFileok = new List<string>();
        public void EgyJelKigyujtesHaMegNincs(string file)
        {
            if(chbDeleteSigns.Checked && Directory.Exists(System.IO.Path.GetDirectoryName(file) + "\\Jelek"))
            {
                string[] files = Directory.GetFiles(System.IO.Path.GetDirectoryName(file) + "\\Jelek");
                for (int i = 0; i < files.Length; i++)
                {
                    File.Delete(files[i]);
                }
                Directory.Delete(System.IO.Path.GetDirectoryName(file) + "\\Jelek");
            }
            if (!Directory.Exists(System.IO.Path.GetDirectoryName(file) + "\\Jelek"))
            {
                SpireConvert.file = file;
                SpireConvert.Convert(file);
            }
        }

        private void cbJelMeret_SelectedIndexChanged(object sender, EventArgs e)
        {
            JelekPDFre.Meret = cbJelMeret.SelectedIndex + 1;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin adminPage = new Admin();
            adminPage.Show();
        }
    }
}
