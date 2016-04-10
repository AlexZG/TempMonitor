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
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable fillTable()
        {
            DataTable tbl = new DataTable();
            try
            {
                using (SqlConnection c = new SqlConnection(Settings.Default.ConString))
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return tbl;
        }
    }
    
}
