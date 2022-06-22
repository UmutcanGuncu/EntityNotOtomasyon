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
namespace EntityNotOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dbSınavOgrenciEntities db = new dbSınavOgrenciEntities();
        
        private void buttonDersListele_Click(object sender, EventArgs e)
        {
            dersListele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           ogrenciListele();
        }

        private void buttonOgrListe_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = db.tblOgrenci.ToList();
            /*Göüntülenmesini istemediğim Fotoğraflar ve Notlar sütnlarının görünürlüğünü
            false yapıyoruz */
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }
        public void dersListele()
        {
            //Entity Framework kullanmadan listeleme
            SqlConnection conn = new SqlConnection("Data Source=GUNCU;Initial Catalog=dbSınavOgrenci;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from tblDersler", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        public void ogrenciListele()
        {
            var sorgu = from item in db.tblOgrenci
                        select new
                        {
                            item.OgrenciId,item.OgrenciAd,item.OgrenciSoyad
                        };
            dataGridView1.DataSource = sorgu.ToList();
            textBoxOgrId.Clear();
            textBoxOgrAd.Clear();
            textBoxOgrSoyad.Clear();
            textBoxOgrFotograf.Clear();
        }

        private void buttonNotListele_Click(object sender, EventArgs e)
        {
            //Listelenmesini isteiğimiz Sütünları seçtiğimiz diğer bir yöntem
            var sorgu = from item in db.tblNotlar
                        select new
                        {
                            item.NotId,item.Ogrenci,item.Ders,item.Sınav1,item.Sınav2
                            ,item.Sınav3,item.Ortalama,item.Durum
                         };
            dataGridView1.DataSource=sorgu.ToList();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            tblOgrenci t1 = new tblOgrenci();
            t1.OgrenciAd = textBoxOgrAd.Text;
            t1.OgrenciSoyad =textBoxOgrSoyad.Text;
            db.tblOgrenci.Add(t1);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı");
            ogrenciListele();
        }

        private void buttonDersEkle_Click(object sender, EventArgs e)
        {
            tblDersler d1 = new tblDersler();
            d1.DersAd = textBoxDersAd.Text;
            db.tblDersler.Add(d1);
            db.SaveChanges();
            MessageBox.Show("Ders Ekleme Başarılı");
            dersListele();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {

            int id = int.Parse(textBoxOgrId.Text);
            var x = db.tblOgrenci.Find(id);
            db.tblOgrenci.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");
            ogrenciListele();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxOgrId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxOgrId.Text);
            var x = db.tblOgrenci.Find(id);
            x.OgrenciAd = textBoxOgrAd.Text;
            x.OgrenciSoyad = textBoxOgrSoyad.Text;
            x.OgrenciFotograf = textBoxOgrFotograf.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Tamamlandı");
            ogrenciListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NotListesi();
        }

        private void buttonBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tblOgrenci.Where(x => x.OgrenciAd == textBoxOgrAd.Text | x.OgrenciSoyad==textBoxOgrSoyad.Text)
                .ToList();
        }

        private void textBoxOgrAd_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tblOgrenci.Where(
                    x => x.OgrenciAd.StartsWith(textBoxOgrAd.Text)).ToList();
        }

        private void buttonLinq_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                List<tblOgrenci> list1 = db.tblOgrenci.OrderBy(p=>p.OgrenciAd).ToList();
                dataGridView1.DataSource = list1;
            }
        }
    }
}
