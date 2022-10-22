using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Proje_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            
            var kategoriler = db.TBLKATEGORI.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();
            t.AD = TxtAd.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Ekleme İşlemi Tamamlandı.","Bilgi",MessageBoxButtons.OK ,MessageBoxIcon.Information);
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
              int x = Convert.ToInt32(TxtId.Text);
              var ktgr = db.TBLKATEGORI.Find(x);
              db.TBLKATEGORI.Remove(ktgr);
              db.SaveChanges();
              MessageBox.Show("Kategori Silme İşlemi Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var ktgr = db.TBLKATEGORI.Find(x);
            ktgr.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncelleme İşlemi Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
