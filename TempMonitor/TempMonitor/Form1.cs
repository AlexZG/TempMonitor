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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rdbCelsius.Checked = true;
            crtTemp.ChartAreas.Add("TempArea");
            crtTemp.ChartAreas["TempArea"].AxisX.Interval = 48;
            crtTemp.Series.Add("temp");
            crtTemp.Series["temp"].Color = Color.LawnGreen;
            crtTemp.Series["temp"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            crtTemp.Series["temp"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            crtTemp.Series["temp"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            crtTemp.Series["temp"].XValueMember = "DateTime";
            crtTemp.Series["temp"].YValueMembers = "Celsius";
            crtTemp.DataBind();
        }
        public DataTable fillTable()
        {
   
            DataTable tbl = new DataTable();
            string sqlQuery = "SELECT * FROM view_log";
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
            setup();
        }
        private void setup()
        {
            crtTemp.DataSource = getView(true);
            crtTemp.DataBind();
        }
        private DataTable getView(bool unit)
        {
            var filter = new DataView(table);
            string unitType = "";
            
            if (unit)
            {
                unitType = "Celsius";
            }
            else if(!unit)
            {
                unitType = "Farenheit";
            }

            return filter.ToTable(false, "DateTime", unitType);
        }

      
    }
    
}
