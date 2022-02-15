using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
//using System.Data.SqlClient;
//using System.Data;
using System.IO;
using System.Data.SqlServerCe;
using LotoAdatbazis.Services;

namespace LotoAdatbazis
{
    public partial class Bejelentkezes : MaterialSkin.Controls.MaterialForm
    {
        private DatabaseHandler _database;
        public Bejelentkezes()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue600, Accent.LightBlue400, TextShade.WHITE);
            _database = new DatabaseHandler();
        }

        private void btnBejelentkezes_Click(object sender, EventArgs e)
        {
            try
            {
                int jogosultsagiSzint = -1;
                if(cbBelepVagyReg.SelectedIndex == 0)
                {
                    jogosultsagiSzint = _database.Login(tbNev.Text,tbJelszo.Text);
                }
                else if(cbBelepVagyReg.SelectedIndex == 1)
                {
                    jogosultsagiSzint = _database.Registration(tbNev.Text, tbJelszo.Text);
                }
                if(jogosultsagiSzint != -1)
                {
                    Main mainPage = new Main(jogosultsagiSzint);
                    this.Hide();
                    mainPage.Show();
                }
                else
                {
                    MessageBox.Show("Belépés megtagadva!");
                }
            }
            catch
            {
                MessageBox.Show("Nem sikerült hozzáférni az adatbázishoz!");
            }
        }

        private void Bejelentkezes_Load(object sender, EventArgs e)
        {
            btnBejelentkezes.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnBejelentkezes.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            btnBejelentkezes.FlatStyle = FlatStyle.Flat;
            btnBejelentkezes.BackColor = Color.FromArgb(18, 91, 180);
            btnBejelentkezes.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnBejelentkezes.ForeColor = Color.White;
            tbNev.BorderStyle = BorderStyle.None;
            tbJelszo.BorderStyle = BorderStyle.None;
            label1.Parent = panelHatter;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(12, 60, 120);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label2.Parent = panelHatter;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(12, 60, 120);
            label2.TextAlign = ContentAlignment.MiddleCenter;
            tbNev.BackColor = Color.FromArgb(25, 118, 210);
            tbNev.ForeColor = Color.White;
            tbNev.TextAlign = HorizontalAlignment.Center;
            tbJelszo.BackColor = Color.FromArgb(25, 118, 210);
            tbJelszo.ForeColor = Color.White;
            tbJelszo.PasswordChar = '*';
            tbJelszo.TextAlign = HorizontalAlignment.Center;
            //panelHatter.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\hatter2.jpg");
            panelHatter.BackgroundImage = LotoAdatbazis.Properties.Resources.hatter2;
            cbBelepVagyReg.SelectedIndex = 0;
            cbBelepVagyReg.ForeColor = Color.FromArgb(12, 60, 120);
        }
    }
}
