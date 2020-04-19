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
    public partial class KullanıcıGiriş : Form
    {
        public KullanıcıGiriş()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "kullanıcı")
            {
                Kullanıcıİlan yeni = new Kullanıcıİlan();
                yeni.Show();
                this.Hide();
            }
        }
    }
}
