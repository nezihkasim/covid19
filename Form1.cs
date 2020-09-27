using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Country");                               // 0
            dataTable.Columns.Add("Confirmed", typeof(int));                // 1
            dataTable.Columns.Add("Deaths", typeof(int));                   // 2
            dataTable.Columns.Add("Recovered", typeof(int));                // 3
            dataTable.Columns.Add("Active", typeof(int));                   // 4
            dataTable.Columns.Add("New Cases", typeof(int));                // 5
            dataTable.Columns.Add("New Deaths", typeof(int));               // 6
            dataTable.Columns.Add("New Recovered", typeof(int));            // 7
            dataTable.Columns.Add("Deaths/100 cases");                      // 8   Tried to define as double, but couldn't parse the data due to its style (different culture)
            dataTable.Columns.Add("Recovered/100 cases");                   // 9   Tried to define as double, but couldn't parse the data due to its style (different culture)
            dataTable.Columns.Add("Deaths/100 Recovered");                  // 10  Tried to define as double, but couldn't parse the data due to its style (different culture)
            dataTable.Columns.Add("Confirmed Last Week", typeof(int));      // 11
            dataTable.Columns.Add("1 Week Change", typeof(int));            // 12
            dataTable.Columns.Add("1 Week % Increase");                     // 13  Tried to define as double, but couldn't parse the data due to its style (different culture)
            dataTable.Columns.Add("WHO Region");

            string filePath = @"covid19.csv";
            StreamReader streamReader = new StreamReader(filePath);

            string[] totalData = new string[File.ReadAllLines(filePath).Length];
            totalData = streamReader.ReadLine().Split(',');

            while (!streamReader.EndOfStream)
            {
                totalData = streamReader.ReadLine().Split(',');
                dataTable.Rows.Add(totalData[0], totalData[1], totalData[2], totalData[3], totalData[4], totalData[5], totalData[6], totalData[7], totalData[8], totalData[9], totalData[10], totalData[11], totalData[12], totalData[13], totalData[14]);
            }

            DataView dv = new DataView(dataTable);

            //dv.RowFilter = string.Format("Country like '%{0}*%'", textBox_country.Text);

            //dv.RowFilter = "CONVERT(Confirmed, 'System.Int32') > 10000";
            //dv.RowFilter = "Confirmed <= {0}", Convert.ToInt32(textBox_maxConfirmed.Text);
            //dv.RowFilter = "Confirmed >= {Convert.ToInt32(textBox_minConfirmed.Text)}";
            dataGridView1.DataSource = dv;

        }

        private void button_show_Click(object sender, EventArgs e)
        {
            #region DATATABLE CREATING AGAIN :(

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Country");                               // 0
            dataTable.Columns.Add("Confirmed", typeof(int));                // 1
            dataTable.Columns.Add("Deaths", typeof(int));                   // 2
            dataTable.Columns.Add("Recovered", typeof(int));                // 3
            dataTable.Columns.Add("Active", typeof(int));                   // 4
            dataTable.Columns.Add("New Cases", typeof(int));                // 5
            dataTable.Columns.Add("New Deaths", typeof(int));               // 6
            dataTable.Columns.Add("New Recovered", typeof(int));            // 7
            dataTable.Columns.Add("Deaths/100 cases");                      // 8   Tried to define as double, but couldn't parse the data due to its style (different culture)
            dataTable.Columns.Add("Recovered/100 cases");                   // 9   Tried to define as double, but couldn't parse the data due to its style (different culture)
            dataTable.Columns.Add("Deaths/100 Recovered");                  // 10  Tried to define as double, but couldn't parse the data due to its style (different culture)
            dataTable.Columns.Add("Confirmed Last Week", typeof(int));      // 11
            dataTable.Columns.Add("1 Week Change", typeof(int));            // 12
            dataTable.Columns.Add("1 Week % Increase");                     // 13  Tried to define as double, but couldn't parse the data due to its style (different culture)
            dataTable.Columns.Add("WHO Region");                            // 14

            string filePath = @"covid19.csv";
            StreamReader streamReader = new StreamReader(filePath);

            string[] totalData = new string[File.ReadAllLines(filePath).Length];
            totalData = streamReader.ReadLine().Split(',');

            while (!streamReader.EndOfStream)
            {
                totalData = streamReader.ReadLine().Split(',');
                if ( (Convert.ToInt32(totalData[1]) >= Convert.ToInt32(textBox_minConfirmed.Text)) && (Convert.ToInt32(totalData[1]) <= Convert.ToInt32(textBox_maxConfirmed.Text)) && (Convert.ToInt32(totalData[2]) <= Convert.ToInt32(textBox_maxDeaths.Text)) && (Convert.ToInt32(totalData[2]) >= Convert.ToInt32(textBox_minDeaths.Text)) && (Convert.ToInt32(totalData[3]) <= Convert.ToInt32(textBox_maxRecovered.Text)) && (Convert.ToInt32(totalData[3]) >= Convert.ToInt32(textBox_minRecovered.Text)))
                {
                    dataTable.Rows.Add(totalData[0], totalData[1], totalData[2], totalData[3], totalData[4], totalData[5], totalData[6], totalData[7], totalData[8], totalData[9], totalData[10], totalData[11], totalData[12], totalData[13], totalData[14]);
                }
            }

            #endregion

            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("Country Like '{0}%'", textBox_country.Text);  // % operator was utilized for partial searching
            //dv.RowFilter = "Confirmed < 1";  // % operator was utilized for partial searching
            dataGridView1.DataSource = dv;




        }

        private void textBox_maxConfirmed_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
