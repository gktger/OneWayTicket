using OneWayTicket.BLL;
using OneWayTicket.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWayTicket.UI
{
    public partial class YolcuBilgiFormu_Form : Form
    {
        public YolcuBilgiFormu_Form()
        {
            InitializeComponent();
        }

        public int inisid;
        public int binisid;
        public int seferId;

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Rezervasyonlar rezerve = new Rezervasyonlar();
            rezerve.MusteriAdiSoyadi = textBox2.Text + " " + textBox3.Text;
            rezerve.MusteriTCKN = textBox1.Text;
            rezerve.Aciklama = textBox4.Text;
            rezerve.BinisDurakID = binisid;
            rezerve.InisDurakID = inisid;
            rezerve.SeferID = seferId;
            RezervasyonBLL.AddRezervasyon(rezerve);
        }

        private void YolcuBilgiFormu_Form_Load(object sender, EventArgs e)
        {
            Duraklar binis = DuraklarBLL.GetDurak(binisid);
            txt_nereden.Text = binis.DurakAdi;
            Duraklar inis = DuraklarBLL.GetDurak(inisid);
            txt_nereye.Text = inis.DurakAdi;
            Seferler sefer = SeferlerBLL.GetSefer(seferId);
            txt_tarih.Text = sefer.TarihSaat.ToString();
           
        }
    }
}
