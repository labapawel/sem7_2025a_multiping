using IniFile;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem7_2025a_multiping
{
    public partial class Form1 : Form
    {
        private string mysqlConnection = "";
        private MySqlConnection mysqlConn = null;
        private MySqlDataAdapter mysqlDataAdapter = null;
        private MySqlCommandBuilder mysqlCommandBuilder = null;
        private DataTable dt = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ini ini = new Ini("ustawienia.ini");
            this.mysqlConnection = $"server={ini["DB"]["HOST"]};Port={ini["DB"]["PORT"]};uid={ini["DB"]["USER"]};pwd={ini["DB"]["PASSWORD"]};database={ini["DB"]["DATABASE"]}";
            mysqlConn = new MySqlConnection(mysqlConnection);
            loadData();

        }

        private void loadData()
        {
            mysqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `hosty`", mysqlConn);
            mysqlCommandBuilder = new MySqlCommandBuilder(mysqlDataAdapter);
            dt = new DataTable();
            mysqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            bindingSource1.DataSource = dt;
            //bindingNavigator1.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            mysqlDataAdapter.Update(dt);
            loadData();
        }
    }
}
