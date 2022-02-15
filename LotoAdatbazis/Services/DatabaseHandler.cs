using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoAdatbazis.Services
{
    class DatabaseHandler
    {
        private SqlCeCommand _cmd;
        private SqlCeConnection _con;
        private SqlCeDataAdapter _da;
        private DataTable _dt;
        private string _c = "DataSource=\"Adat\\data.sdf\"; Password=\"lthun1921\"";

        public DatabaseHandler()
        {
            if (!CreateDatabase())
            {
                _con = new SqlCeConnection(_c);
                _con.Open();
            }
        }

        private bool CreateDatabase()
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\Adat\\data.sdf"))
            {
                SqlCeEngine en = new SqlCeEngine(_c);
                en.CreateDatabase();
                CreateTable();
                return true;
            }
            else
            {
                return false;
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
            //_con = new SqlCeConnection(_c);
            //_con.Open();
            _cmd = new SqlCeCommand(@"INSERT INTO ACCOUNTS (username,password,level) VALUES ('Admin', '" + PasswordHash.Hash("admin") + "', '1')", _con);
            _cmd.ExecuteNonQuery();
        }

        public int Login(string name, string password)
        {
            try
            {
                int jogosultsagiSzint = -1;
                _cmd = new SqlCeCommand("SELECT * FROM Accounts where username = '" + name.Trim() + "'", _con);
                _da = new SqlCeDataAdapter(_cmd);
                _dt = new DataTable();
                _da.Fill(_dt);
                _cmd.ExecuteReader();
                if (_dt.Rows.Count > 0)
                {
                    var result = PasswordHash.Verify(password.Trim(), _dt.Rows[0][2].ToString());
                    jogosultsagiSzint = Int32.Parse(_dt.Rows[0][3].ToString().Trim());
                }
                return jogosultsagiSzint;
            }
            catch
            {
                MessageBox.Show("Nem sikerült hozzáférni az adatbázishoz!");
                return -1;
            }
        }

        public int Registration(string name, string password)
        {
            try
            {
                int jogosultsagiSzint = -1;
                _cmd = new SqlCeCommand("SELECT * FROM Accounts where username = '" + name.Trim() + "'", _con);
                _da = new SqlCeDataAdapter(_cmd);
                _dt = new DataTable();
                _da.Fill(_dt);
                _cmd.ExecuteReader();
                if (_dt.Rows.Count == 0)
                {
                    _cmd = new SqlCeCommand(@"Insert into Accounts(username,password,level) VALUES('" + name + "','" + PasswordHash.Hash(password) + "','3')", _con);
                    _cmd.ExecuteNonQuery();
                    jogosultsagiSzint = 3;
                }
                else
                {
                    MessageBox.Show("A felhasználónév már használatban van!");
                }
                return jogosultsagiSzint;
            }
            catch
            {
                MessageBox.Show("Nem sikerült hozzáférni az adatbázishoz!");
                return -1;
            }
        }

        public void Delete(string id)
        {
            try
            {
                //_con = new SqlCeConnection(_c);
                //_con.Open();
                _cmd = new SqlCeCommand(@"Delete from Accounts where ID = '" + id + "'", _con);
                _cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Nem sikerült hozzáférni az adatbázishoz!");
            }
        }

        public void Update(string id, string name, string level)
        {
            try
            {
                //_con = new SqlCeConnection(_c);
                //_con.Open();
                _cmd = new SqlCeCommand(@"Update Accounts SET username = '" + name + "', level = '" + level + "' where ID='" + id + "'", _con);
                _cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Nem sikerült hozzáférni az adatbázishoz!");
            }
        }

        public DataTable GetAllData()
        {
            try
            {
                //_con = new SqlCeConnection(_c);
                //_con.Open();
                _cmd = new SqlCeCommand("Select * from Accounts", _con);// 
                _da = new SqlCeDataAdapter(_cmd);
                _dt = new DataTable();
                _da.Fill(_dt);
                //_cmd.ExecuteReader();

                return _dt;
            }
            catch
            {
                MessageBox.Show("Nem sikerült hozzáférni az adatbázishoz!");
                return new DataTable();
            }
        }

        public KeyValuePair<string, int> GetDataById(string id)
        {
            try
            {
                KeyValuePair<string, int> NameAndLevel = new KeyValuePair<string, int>("hiba",-1);
                //_con = new SqlCeConnection(_c);
                //_con.Open();
                _cmd = new SqlCeCommand("Select * from Accounts where ID = '" + id + "'", _con);// 
                _da = new SqlCeDataAdapter(_cmd);
                _dt = new DataTable();
                _da.Fill(_dt);
                SqlCeDataReader reader = _cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader[1].ToString();
                    int level = Int32.Parse(reader[3].ToString()) - 1;
                    NameAndLevel = new KeyValuePair<string, int>(name, level);
                }
                return NameAndLevel;
            }
            catch
            {
                MessageBox.Show("Nem sikerült hozzáférni az adatbázishoz!");
                return new KeyValuePair<string, int>("hiba",-1);
            }
        }
    }
}
