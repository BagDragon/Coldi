using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coldi
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();           
        }


        string vStrConnection = "Server= localhost; port= 5432; user id= postgres; password= 93538565; database= UserBD;";
        NpgsqlConnection vCon;
        NpgsqlCommand vCmd;


        private void connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vStrConnection;

            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }

        }

        public DataTable getdata(string sql)
        {
            DataTable dt = new DataTable();
            connection();

            vCmd = new NpgsqlCommand();
            vCmd.Connection = vCon;
            vCmd.CommandText = sql;

            NpgsqlDataReader dr = vCmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        private void Authorization_Load(object sender, EventArgs e)
        { 
           connection();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DataTable dtgetdata = new DataTable();
            dtgetdata = getdata("select * from users;");

            DataView dv = dtgetdata.DefaultView;
            dgData.DataSource = dtgetdata;
        }

    }
}
