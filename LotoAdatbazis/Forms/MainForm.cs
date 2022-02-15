using LotoAdatbazis.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoAdatbazis.Forms
{
    public partial class MainForm : MaterialForm
    {
        public int Jogosultsag { get; set; }
        public MainForm(int _jogsoultsag)
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            FontFamily privateFont = EmbeddedResources.LotoFont;

            foreach (Control c in splitContainer1.Panel1.Controls)
            {
                c.Font = new Font(privateFont, 12, FontStyle.Bold);
            }
            BackEnd.FormLoadV2(btnDelete, btnOpen, btnOpenPdf, btnJelek, label1, label2, label3, label4, pdfViewer, cbTerulet, cbGep, cbGepSzam, cbVerzio, pbDokuMegjelenes, pbNikkoLogo, btnAdmin, signCreatorMenu1);
            pbNikkoLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            //pbNikkoLogo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\nikko_gif.gif");
            //pbLogo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\loto_gif.gif");
            //pbDokuMegjelenes.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\megjelen_gif.gif");
            //panelBalMenu.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\hatter.JPG");

            pbNikkoLogo.Image = EmbeddedResources.NikkoGif;
            pbLogo.Image = EmbeddedResources.LotoGif;
            pbDokuMegjelenes.Image = EmbeddedResources.MegjelenGif;
            splitContainer1.Panel1.BackgroundImage = EmbeddedResources.Hatter;
            splitContainer1.BackColor = Color.FromArgb(18, 91, 180);
            splitContainer1.Panel2.BackColor = Color.White;

            //chbDeleteSigns.ForeColor = Color.White;
            //PanelInit();
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //panelBalMenu.Size = new Size(panelBalMenu.Width, this.Height - 64);
            pdfViewer.Size = new Size(this.Width - 325, this.Height - 64);
            pbDokuMegjelenes.Location = new Point((int)(410 * ((double)this.Width / 1000)), (int)(150 * ((double)this.Height / 800)));
            pbNikkoLogo.Location = new Point(this.Width - 201, this.Height - 61);
            btnAdmin.Location = new Point(this.Width - 200, 24);
            splitContainer1.Size = new Size(0, this.Height - 64);

            //signCreatorMenu1.dataGridView1.Columns[0].Width = this.Width - 325 - 50;
            //if (signCreatorMenu1.cbJelMod.Items.Count > 0)
            //{
            //    if (signCreatorMenu1.cbJelMod.SelectedIndex == 0)
            //    {
            //        signCreatorMenu1.Size = new Size(500, this.Height - 64);
            //    }
            //    else if (signCreatorMenu1.cbJelMod.SelectedIndex == 1)
            //    {
            //        signCreatorMenu1.Size = new Size(this.Width - 325, this.Height - 64);
            //    }
            //}
            //else
            //{
            //    signCreatorMenu1.Size = new Size(this.Width - 325, this.Height - 64);
            //}
        }

        private void btnOpenPdf_Click(object sender, EventArgs e)
        {
            BackEnd.OpenAPdf();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.lotohungary.hu/loto.html");
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin adminPage = new Admin();
            adminPage.Show();
        }
    }
}
