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

namespace LotoAdatbazis
{
    public partial class Bejelentkezes : MaterialSkin.Controls.MaterialForm
    {
        public Bejelentkezes()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue600, Accent.LightBlue400, TextShade.WHITE);
        }

        private void btnBejelentkezes_Click(object sender, EventArgs e)
        {
                int jogosUltsasg = 3;
                bool login = false;
                _con = new SqlCeConnection(_c);
                _con.Open();
                if(cbBelepVagyReg.SelectedIndex == 0)
                {
                    
                    _cmd = new SqlCeCommand("SELECT * FROM Accounts where username = '" + tbNev.Text.Trim() + "'", _con);// 
                    _da = new SqlCeDataAdapter(_cmd);
                    _dt = new DataTable();
                    _da.Fill(_dt);
                    _cmd.ExecuteReader();
                    if(_dt.Rows.Count > 0)
                    {
                        var result = PasswordHash.Verify(tbJelszo.Text.Trim(), _dt.Rows[0][2].ToString());
                        if (result)
                        {
                            login = true;
                        }
                        jogosUltsasg = Int32.Parse(_dt.Rows[0][3].ToString().Trim());
                    }
                    else
                    {
                        login = false;
                    }
                }
                else if(cbBelepVagyReg.SelectedIndex == 1)
                {
                    _cmd = new SqlCeCommand("SELECT * FROM Accounts where username = '" + tbNev.Text.Trim() + "'", _con);// 
                    _da = new SqlCeDataAdapter(_cmd);
                    _dt = new DataTable();
                    _da.Fill(_dt);
                    _cmd.ExecuteReader();
                    if(_dt.Rows.Count == 0)
                    {
                        _cmd = new SqlCeCommand(@"Insert into Accounts(username,password,level) VALUES('" + tbNev.Text + "','" + PasswordHash.Hash(tbJelszo.Text) + "','3')", _con);
                        _cmd.ExecuteNonQuery();
                        jogosUltsasg = 3;
                        login = true;
                    }
                    else
                    {
                        MessageBox.Show("A felhasználónév már használatban van!");
                    }
                }
                if(login)
                {
                    Main mainPage = new Main(jogosUltsasg);
                    this.Hide();
                    mainPage.Show();
                }
                else
                {
                    MessageBox.Show("Belépés megtagadva!");
                }


            try
            {
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
            panelHatter.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Adat\\hatter2.jpg");
            cbBelepVagyReg.SelectedIndex = 0;
            cbBelepVagyReg.ForeColor = Color.FromArgb(12, 60, 120);
            CreateDatabase();
        }
        private SqlCeCommand _cmd;
        private SqlCeConnection _con;
        private SqlCeDataAdapter _da;
        private DataTable _dt;
        private string _c = "DataSource=\"Adat\\data.sdf\"; Password=\"lthun1921\"";
        private void CreateDatabase()
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\Adat\\data.sdf"))
            {
                SqlCeEngine en = new SqlCeEngine(_c);
                en.CreateDatabase();
                CreateTable();
            }
        }
        private void CreateTable()
        {
            _con = new SqlCeConnection(_c);
            _con.Open();
            _cmd = new SqlCeCommand(@"create table Accounts(ID int primary key identity(1,1), username nvarchar(100) not null, password nvarchar(100) not null, level int not null)", _con);
            _cmd.ExecuteNonQuery();
            InsertAdmin();
        }
        private void InsertAdmin()
        {
            _con = new SqlCeConnection(_c);
            _con.Open();
            _cmd = new SqlCeCommand(@"INSERT INTO ACCOUNTS (username,password,level) VALUES ('Admin', '" + PasswordHash.Hash("admin") + "', '1')", _con);
            _cmd.ExecuteNonQuery();
        }
    }
}
