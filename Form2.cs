using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;
namespace SORU2
{
    public partial class Form2 : Form
    {
    
        public Form2()
        {
            
            InitializeComponent();
           
        }

        OleDbConnection baglan = new OleDbConnection(
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bilgiler3.accdb");
        void ekle()
        {
            DataTable tablo = new DataTable();

            OleDbDataAdapter adtr = new OleDbDataAdapter(
            "SELECT * FROM TABLO1 WHERE ADI='" + Form1.seciliAd + "' AND SOYADI='" + Form1.seciliSoyad + "'", baglan);

            adtr.Fill(tablo);

            ReportDataSource rds = new ReportDataSource("DataSet1", tablo);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        
        
        private void Form2_Load(object sender, EventArgs e)
        {
            ekle();
   
            
        }
    }
}
