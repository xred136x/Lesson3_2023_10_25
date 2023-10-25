using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SQLite;

namespace Lesson3_2023_10_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection();
            connection.ConnectionString = "Data Source = qqq.db3";
            connection.Open();
           
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "create table tmp(id int, tt varchar(20))";
            command.ExecuteNonQuery();
            connection.Close();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
