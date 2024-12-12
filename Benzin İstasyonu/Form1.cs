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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Benzin_İstasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=LAPTOP-34D9I3MG\\SQLEXPRESS;Initial Catalog = Pompa_Takip; Integrated Security = True; TrustServerCertificate=True";
        DataTable tablo = new DataTable();
        SqlConnection Baglanti_1 = new SqlConnection(constring);

        private void listele()
        {
            Baglanti_1.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select *From Bilgi ", Baglanti_1);
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Baglanti_1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pompa_TakipDataSet1.yakit_Stok' table. You can move, or remove it, as needed.
            this.yakit_StokTableAdapter.Fill(this.pompa_TakipDataSet1.yakit_Stok);

        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (Baglanti_1.State == ConnectionState.Closed)
                    Baglanti_1.Open();
                string kayit = "insert into yakit_Stok(Yakıt,Miktar) values(@Yakıt,@Miktar)";
                SqlCommand komut = new SqlCommand(kayit, Baglanti_1);
                komut.Parameters.AddWithValue("@Yakıt", textBox_yakitisim.Text);
                komut.Parameters.AddWithValue("@Miktar", textBox_yakitmiktar.Text);
                komut.ExecuteNonQuery();
                Baglanti_1.Close();

                MessageBox.Show("Kayıt Eklendi!");

                tablo.Clear();
                listele();

            }
            catch (Exception hata) {
                MessageBox.Show("Hata Meydana Geldi: " + hata.Message);
            }
        }
    }
}
