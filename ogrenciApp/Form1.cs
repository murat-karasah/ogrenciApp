using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenci> olist = new List<Ogrenci>();
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o1 = new Ogrenci();
            
            o1.ad = textBox1.Text;
            o1.soyad = textBox2.Text;
            o1.bolum = comboBox1.SelectedItem.ToString();
            o1.sinif = Convert.ToInt32(comboBox2.SelectedItem);


            
            o1.no = rnd.Next(1000, 5000).ToString();
            olist.Add(o1);
            temizle();

           
        }

        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Ogrenci> o = new List<Ogrenci>();
            foreach (var item in olist)
            {
                Ogrenci ogrnci = new Ogrenci();
                ogrnci.no = item.no;
                ogrnci.ad = item.ad;
                ogrnci.soyad = item.soyad;
                ogrnci.bolum = item.bolum;
                ogrnci.sinif = item.sinif;

                o.Add(ogrnci);
            }

            dataGridView1.DataSource = o;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Ogrenci secilen =(Ogrenci)dataGridView1.CurrentRow.DataBoundItem;
            textBox1.Text = secilen.ad;
            textBox2.Text = secilen.soyad;
            comboBox1.SelectedItem = secilen.bolum;
            comboBox2.SelectedItem =secilen.sinif.ToString();

        }
    }
}
