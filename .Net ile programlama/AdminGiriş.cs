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

namespace WindowsFormsApp4
{
    public partial class AdminGiriş : Form
    {
        public AdminGiriş()
        {
            InitializeComponent();
        }
        private void ilangetir()
        {
            ilo.Open();
            SqlDataAdapter cod = new SqlDataAdapter("select * from İlan ", ilo);
            DataSet ds = new DataSet();
            cod.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            ilo.Close();
        }
        SqlConnection ilo = new SqlConnection(@"Data Source=DESKTOP-BU3BBCB\SQLEXPRESS;Initial Catalog=GALERİ;Integrated Security=True");
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (ilo.State == ConnectionState.Closed)
                    ilo.Open();
                
                string kayit = "insert into İlan(Marka,Model,Fiyat,Kilometre,Vites,Yakıt,AdSoyad,TelefonNo) values (@Marka,@Model,@Fiyat,@Kilometre,@Vites,@Yakıt,@AdSoyad,@TelefonNo)";
                
                SqlCommand komut = new SqlCommand(kayit, ilo);
                komut.Parameters.AddWithValue("@Marka", txt_Marka.Text);
                komut.Parameters.AddWithValue("@Model", txt_Model.Text);
                komut.Parameters.AddWithValue("@Fiyat", txt_Fiyat.Text);
                komut.Parameters.AddWithValue("@Kilometre", txt_Kilometre.Text);
                komut.Parameters.AddWithValue("@Vites", txt_Vites.Text);
                komut.Parameters.AddWithValue("@Yakıt", txt_Yakıt.Text);
                komut.Parameters.AddWithValue("@AdSoyad", txt_Ad_Soyad.Text);
                komut.Parameters.AddWithValue("@TelefonNo", txt_TelefonNo.Text);
                komut.ExecuteNonQuery();
                ilo.Close();
                MessageBox.Show("İlan Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
    

        private void textBox3_TextChanged(object sender, EventArgs e)

        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngun_Click(object sender, EventArgs e)
        {
            ilangetir();
        }

        private void AdminGiriş_Load(object sender, EventArgs e)
        {

        }
        SqlCommand kom;
        private void  button3_Click(object sender, EventArgs e)
        {
            ilo.Open();
            string sorgu = "UPDATE İlan SET Fiyat=@Fiyat WHERE Marka=@Marka";
             kom = new SqlCommand(sorgu, ilo);

            kom.Parameters.AddWithValue("@Marka", txt_Marka.Text);
            kom.Parameters.AddWithValue("@Fiyat", Convert.ToInt32(txt_Fiyat.Text));


            kom.ExecuteNonQuery();
            ilo.Close();
            ilangetir();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ilo.Open();
            SqlCommand komut = new SqlCommand("delete from İlan where Marka=@Marka", ilo);
            kom.Parameters.AddWithValue("@Marka", txt_sil.Text);
            kom.ExecuteNonQuery();
            ilangetir();
            ilo.Close();
        }
    }
}
    
