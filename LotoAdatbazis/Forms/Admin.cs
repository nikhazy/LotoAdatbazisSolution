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
using System.Xml;
using System.IO;
using System.Data.SqlServerCe;
using LotoAdatbazis.Services;

namespace LotoAdatbazis
{
    public partial class Admin : MaterialSkin.Controls.MaterialForm
    {
        private DatabaseHandler _database;
        public Admin()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue600, Accent.LightBlue400, TextShade.WHITE);
            _database = new DatabaseHandler();
        }

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
            dataGridView1.DataSource = _database.GetAllData();

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
            KeyValuePair<string, int> nameAndLevel = _database.GetDataById(label1.Text);
            if(nameAndLevel.Value != -1)
            {
                tbLoginName.Text = nameAndLevel.Key;
                cbAccessLevel.SelectedIndex = nameAndLevel.Value;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            label1.Text = id;
            textBoxBehivas();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _database.Update(label1.Text, tbLoginName.Text, cbAccessLevel.SelectedIndex.ToString());
            Frissites();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _database.Delete(label1.Text);
            Frissites();
        }
    }
}
