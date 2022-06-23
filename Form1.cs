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
                            item.OgrenciId,
                            item.OgrenciAd,
                            item.OgrenciSoyad
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
                            item.NotId,
                            item.tblOgrenci.OgrenciAd,
                            item.tblOgrenci.OgrenciSoyad,
                            item.tblDersler.DersAd,
                            item.Sınav1,
                            item.Sınav2,
                            item.Sınav3,
                            item.Ortalama,
                            item.Durum
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            tblOgrenci t1 = new tblOgrenci();
            t1.OgrenciAd = textBoxOgrAd.Text;
            t1.OgrenciSoyad = textBoxOgrSoyad.Text;
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
            dataGridView1.DataSource = db.tblOgrenci.Where(x => x.OgrenciAd == textBoxOgrAd.Text |
            x.OgrenciSoyad == textBoxOgrSoyad.Text)
                .ToList();
        }

        private void textBoxOgrAd_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tblOgrenci.Where(
                    x => x.OgrenciAd.StartsWith(textBoxOgrAd.Text)).ToList();
        }

        private void buttonLinq_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    List<tblOgrenci> list2 = db.tblOgrenci.OrderBy(y => y.OgrenciAd).Take(3).ToList();
                    dataGridView1.DataSource = list2;
                }
                else
                {
                    List<tblOgrenci> list1 = db.tblOgrenci.OrderBy(p => p.OgrenciAd).ToList();
                    dataGridView1.DataSource = list1;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    List<tblOgrenci> list2 = db.tblOgrenci.OrderByDescending(x => x.OgrenciAd).Take(3).ToList();
                    dataGridView1.DataSource = list2;
                }
                else
                {
                    List<tblOgrenci> list2 = db.tblOgrenci.OrderByDescending(x => x.OgrenciAd).ToList();
                    dataGridView1.DataSource = list2;
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    List<tblOgrenci> list1 = db.tblOgrenci.OrderBy(x => x.OgrenciId).Take(3).ToList();
                    dataGridView1.DataSource = list1;
                }
                else
                {
                    List<tblOgrenci> list1 = db.tblOgrenci.OrderBy(x => x.OgrenciId).ToList();
                    dataGridView1.DataSource = list1;
                }
            }
            else if (radioButton4.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    List<tblOgrenci> list1 = db.tblOgrenci.Where(x => x.OgrenciAd.StartsWith("a")).Take(3).ToList();
                    dataGridView1.DataSource = list1;
                }
                else
                {
                    List<tblOgrenci> list1 = db.tblOgrenci.Where(x => x.OgrenciAd.StartsWith("a")).ToList();
                    dataGridView1.DataSource = list1;
                }
            }
            else if (radioButton5.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    List<tblOgrenci> list1 = db.tblOgrenci.Where(x => x.OgrenciAd.EndsWith("a")).Take(3).ToList();
                    dataGridView1.DataSource = list1;
                }
                else
                {
                    List<tblOgrenci> list1 = db.tblOgrenci.Where(x => x.OgrenciAd.EndsWith("a")).ToList();
                    dataGridView1.DataSource = list1;
                }
            }
            else if (radioButton6.Checked == true)
            {
                int toplam = db.tblOgrenci.Count();
                MessageBox.Show($"Toplam Öğrenci Sayısı = {toplam}");
            }
            else if (radioButton7.Checked == true)
            {
                var notToplam = db.tblNotlar.Sum(t => t.Sınav1);
                MessageBox.Show($"1. Sınavdan Alınan Toplam Not = {notToplam}");
            }
            else if (radioButton8.Checked == true)
            {
                var ortalama = db.tblNotlar.Average(o => o.Sınav2);
                MessageBox.Show($"2. Sınav Sınıf Ortalaması = {ortalama}");
            }
            else if (radioButton9.Checked == true)

            {
                var ortalama = db.tblNotlar.Average(o => o.Sınav1);
                List<tblNotlar> list1 = db.tblNotlar.Where(x => x.Sınav1 > ortalama).ToList();
                dataGridView1.DataSource = list1;
            }
            else if (radioButton10.Checked == true)
            {
                var enDusuk = db.tblNotlar.Min(y => y.Sınav1);
                List<tblNotlar> list1 = db.tblNotlar.Where(x => x.Sınav1 == enDusuk).ToList();
                dataGridView1.DataSource = list1;
            }
        }

        private void buttonSınavNotuEkle_Click(object sender, EventArgs e)
        {
            tblNotlar not1 = new tblNotlar();
            decimal sinav1 = decimal.Parse(textBoxSinav1.Text);
            decimal sinav2 = decimal.Parse(textBoxSinav2.Text);
            decimal sinav3 = decimal.Parse(textBoxSinav3.Text);
            not1.Ogrenci = Convert.ToInt32(textBoxOgrId.Text);
            not1.Ders = Convert.ToInt32(textBoxDersId.Text);
            not1.Sınav1 = Convert.ToInt32(sinav1);
            not1.Sınav2 = Convert.ToInt32(sinav2);
            not1.Sınav3 = Convert.ToInt32(sinav3);
            not1.Ortalama = (sinav1 + sinav2 + sinav3) / 3;
            not1.Durum = sonuc(sinav1, sinav2, sinav3);
            db.tblNotlar.Add(not1);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı");
        }
        public bool sonuc(decimal sinav1, decimal sinav2, decimal sinav3)
        {
            if ((sinav1 + sinav2 + sinav3) / 3 > 50)
                return true;
            else
                return false;
        }

    }
}
