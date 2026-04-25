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
namespace SORU2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        public static string seciliAd;
        public static string seciliSoyad;
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=bilgiler3.accdb");
        void yukle()
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM TABLO1", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız");
                return;
            }
            DataTable tablo = new DataTable();
            OleDbDataAdapter ara = new OleDbDataAdapter
            ("SELECT * FROM TABLO1 WHERE ADI='" + textBox1.Text +
            "' AND SOYADI='" + textBox2.Text + "'", baglan);
            ara.Fill(tablo);
            if (tablo.Rows.Count == 0)
            {
                MessageBox.Show("Kayıt bulunamadı");
                return;

            }
            DialogResult cevap = MessageBox.Show(
    "Kayıt bulundu. Rapor açılsın mı?",
    "Soru",
    MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
                Form1.seciliAd = textBox1.Text;
                Form1.seciliSoyad = textBox2.Text;

                Form2 frm = new Form2();
                frm.Show();
            }
        }
    }
}
