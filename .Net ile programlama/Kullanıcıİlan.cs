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
    public partial class Kullanıcıİlan : Form
    {
        public Kullanıcıİlan()
        {
            InitializeComponent();
        }
        SqlConnection ilo = new SqlConnection(@"Data Source=DESKTOP-BU3BBCB\SQLEXPRESS;Initial Catalog=GALERİ;Integrated Security=True");

        private void ilangetir()
        {
            ilo.Open();
            SqlDataAdapter cod = new SqlDataAdapter("select * from İlan ", ilo);
            DataSet ds = new DataSet();
            cod.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            ilo.Close();
        }
        private void Kullanıcıİlan_Load(object sender, EventArgs e)
        {
            ilangetir();
        }
    }
}
