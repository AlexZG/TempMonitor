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
using TempMonitor.Properties;


namespace TempMonitor
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
            setup();
        }
        public DataTable fillTable()
        {
   
            DataTable tbl = new DataTable();
            string sqlQuery = "SELECT * FROM view_data";
            try
            {
                using (SqlConnection con = new SqlConnection(Settings.Default.ConString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tbl);
                    }
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return tbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table = fillTable();
            dgvTemp.DataSource = table;
        }
        private void setup()
        {

        }
    }
    
}
