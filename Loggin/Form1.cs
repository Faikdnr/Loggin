using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Loggin
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
            Class1 class1 = new Class1();
            class1.baglanti();

        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        void griddoldur()
        {
            con = new SqlConnection("Data Source = FAIK_ARDA\\MYSQLSERVER; Initial Catalog = Ornek; Integrated Security = True");
            da = new SqlDataAdapter("Select *From Kullanici_Bilgi", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kullanici_Bilgi");
            dataGridView1.DataSource = ds.Tables["Kullanici_Bilgi"];
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.baglanti();
            String kadi = txtkadi.Text;
            String sifre = txtsifre.Text;

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string sorgu = "Insert into Kullanici_Bilgi (kadi,sifre) values (@kadi,@sifre)";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@kadi", txtkadi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
            
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SifremiUnuttum frm = new SifremiUnuttum();
            frm.Show();
        }
    }
}
