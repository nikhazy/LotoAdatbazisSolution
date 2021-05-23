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
using System.Xml;
using System.IO;
using System.Data.SqlServerCe;

namespace LotoAdatbazis
{
    public partial class Admin : MaterialSkin.Controls.MaterialForm
    {
        public Admin()
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
        }
        /*
        SqlConnection sql;
        SqlDataAdapter sda;
        DataTable dtb;
        SqlDataReader reader;
        SqlCommand cmd;*/

        private void Admin_Load(object sender, EventArgs e)
        {
            //sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() + "\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            Frissites();
            cbAccessLevel.SelectedIndex = 0;

            Init();
        }
        public void Init()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 118, 210);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            /*
            btnAdd.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.BackColor = Color.FromArgb(18, 91, 180);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnAdd.ForeColor = Color.White;
            btnAdd.Font = new Font("Arial", 10, FontStyle.Bold);
            */
            btnDelete.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.BackColor = Color.FromArgb(18, 91, 180);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnDelete.ForeColor = Color.White;
            btnDelete.Font = new Font("Arial", 10, FontStyle.Bold);

            btnEdit.FlatAppearance.CheckedBackColor = Color.FromArgb(25, 118, 210);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 107, 192);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.BackColor = Color.FromArgb(18, 91, 180);
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(18, 90, 180);
            btnEdit.ForeColor = Color.White;
            btnEdit.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //CreateDatabase();
        }
        public void Frissites()
        {
            /*
            string query = "Select * from [Table]";
            sda = new SqlDataAdapter(query, sql);
            dtb = new DataTable();
            sda.Fill(dtb);
            dataGridView1.DataSource = dtb;
            sql.Close();
            */

            _con = new SqlCeConnection(_c);
            _con.Open();
            _cmd = new SqlCeCommand("Select * from Accounts", _con);// 
            _da = new SqlCeDataAdapter(_cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            dataGridView1.DataSource = _dt;
            _cmd.ExecuteReader();

            dataGridView1.Columns[0].HeaderText = "Sorszám";
            dataGridView1.Columns[1].HeaderText = "Felhasználónév";
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].HeaderText = "Jelszó";
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Jogosultság";

            
        }
        public void textBoxBehivas()
        {
            try
            {
                /*
                string query = "Select * from [Table] where Id = '" + label1.Text + "'";
                cmd = new SqlCommand(query, sql);
                sql.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tbLoginName.Text = reader[1].ToString();
                    tbPassword.Text = reader[2].ToString();
                    cbAccessLevel.SelectedIndex = Int32.Parse(reader[3].ToString()) - 1;
                }
                sql.Close();
                */
                _con = new SqlCeConnection(_c);
                _con.Open();
                _cmd = new SqlCeCommand("Select * from Accounts where ID = '" + label1.Text + "'", _con);// 
                _da = new SqlCeDataAdapter(_cmd);
                _dt = new DataTable();
                _da.Fill(_dt);
                SqlCeDataReader reader = _cmd.ExecuteReader();
                while (reader.Read())
                {
                    tbLoginName.Text = reader[1].ToString();
                    //tbPassword.Text = reader[2].ToString();
                    cbAccessLevel.SelectedIndex = Int32.Parse(reader[3].ToString()) - 1;
                }
            }
            catch
            {
                MessageBox.Show("Nem sikerült hozzáférni az adatbázishoz!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string id = dataGridView1.SelectedCells[0].Value.ToString();
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            label1.Text = id;
            textBoxBehivas();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                string query = "Update [Table] SET username = '" + tbLoginName.Text + "', password = '" + tbPassword.Text + "', level = '" + (cbAccessLevel.SelectedIndex + 1).ToString() + "' where Id='" + label1.Text + "'";
                cmd = new SqlCommand(query, sql);
                sql.Open();
                reader = cmd.ExecuteReader();
                sql.Close();
                Frissites();
                */
                _con = new SqlCeConnection(_c);
                _con.Open();
                _cmd = new SqlCeCommand(@"Update Accounts SET username = '" + tbLoginName.Text + "', level = '" + (cbAccessLevel.SelectedIndex + 1).ToString() + "' where ID='" + label1.Text + "'", _con);
                _cmd.ExecuteNonQuery();
                Frissites();
            }
            catch
            {
                MessageBox.Show("Nem sikerült hozzáférni az adatbázishoz!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                string query = "Delete from [Table] where Id = '" + label1.Text + "'";
                cmd = new SqlCommand(query, sql);
                sql.Open();
                reader = cmd.ExecuteReader();
                sql.Close();
                Frissites();
                */
                _con = new SqlCeConnection(_c);
                _con.Open();
                _cmd = new SqlCeCommand(@"Delete from Accounts where ID = '" + label1.Text + "'", _con);
                _cmd.ExecuteNonQuery();
                Frissites();
            }
            catch
            {
                MessageBox.Show("Nem sikerült hozzáférni az adatbázishoz!");
            }
        }

        /*
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert into [Table](username,password,level) VALUES('" + tbLoginName.Text + "','" + tbPassword.Text + "','" + (cbAccessLevel.SelectedIndex + 1).ToString() + "')";
                cmd = new SqlCommand(query, sql);
                sql.Open();
                reader = cmd.ExecuteReader();
                sql.Close();
                Frissites();

                _con = new SqlCeConnection(_c);
                _con.Open();
                _cmd = new SqlCeCommand(@"Insert into Accounts(username,password,level) VALUES('" + tbLoginName.Text + "','" + PasswordHash.Hash(tbPassword.Text) + "','" + (cbAccessLevel.SelectedIndex + 1).ToString() + "')", _con);
                _cmd.ExecuteNonQuery();
                Frissites();
            }
            catch
            {
                MessageBox.Show("Nem sikerlt hozzáférni az adatbázishoz!");
            }
        }*/

        //**************************************************SQL CE*******************************

        private SqlCeCommand _cmd;
        private SqlCeConnection _con;
        private SqlCeDataAdapter _da;
        private DataTable _dt;
        private string _c = "DataSource=\"Adat\\data.sdf\"; Password=\"lthun1921\"";
    }
}
