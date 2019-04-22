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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            
            SeferSecimi_Form frm = new SeferSecimi_Form();
            
            frm.Show();
            

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            cmb_Nereden.DataSource = DuraklarBLL.GetDuraklar();
            cmb_Nereden.DisplayMember = "DurakAdi";
            cmb_Nereden.ValueMember = "DurakID";

            cmb_Nereye.DataSource = DuraklarBLL.GetDuraklar();
            cmb_Nereye.DisplayMember = "DurakAdi";
            cmb_Nereye.ValueMember = "DurakID";
        }

        private void cmb_Nereden_TextChanged(object sender, EventArgs e)
        {
            switch (cmb_Nereden.Text)
            {
                 
                case "A":
                         SeferiEntities dataContextA = new SeferiEntities();

                    var a = dataContextA.GuzergahDuraklaris.Where(x => x.GuzergahID == 1);
                    var aaa = dataContextA.Duraklars.Where(aa => a.Any(x => x.DurakID == aa.DurakID)).ToList();


                    cmb_Nereye.DataSource = aaa;
                    cmb_Nereye.DisplayMember = "DurakAdi";
                    cmb_Nereye.ValueMember = "DurakID";
                    break;
                case "H":
            SeferiEntities dataContextH = new SeferiEntities();

                    var h = dataContextH.GuzergahDuraklaris.Where(x => x.GuzergahID == 2);
                    var hh = dataContextH.Duraklars.Where(ha => h.Any(x => x.DurakID == ha.DurakID)).ToList();


                    cmb_Nereye.DataSource = hh;
                    cmb_Nereye.DisplayMember = "DurakAdi";
                    cmb_Nereye.ValueMember = "DurakID";
                    break;
                case "K":
                    SeferiEntities dataContextK = new SeferiEntities();
                    var k = dataContextK.GuzergahDuraklaris.Where(x => x.GuzergahID == 3);
                    var kk = dataContextK.Duraklars.Where(ka => k.Any(x => x.DurakID == ka.DurakID)).ToList();
                    cmb_Nereye.DataSource = kk;
                    cmb_Nereye.DisplayMember = "DurakAdi";
                    cmb_Nereye.ValueMember = "DurakID";
                    break;
            }
        }
    }
}
