using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            İlan_ekleme yeni = new İlan_ekleme();
            yeni.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıGiriş yeni = new KullanıcıGiriş();
            yeni.Show();
            this.Hide();
            

        }
    }
}
