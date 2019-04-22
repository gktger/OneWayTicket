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
    public partial class SeferSecimi_Form : Form
    {
        public SeferSecimi_Form()
        {
            InitializeComponent();
        }

        public int inisId;
        public int binisId;

        private void dgw_seferListesi_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            YolcuBilgiFormu_Form frm = new YolcuBilgiFormu_Form();
            frm.inisid = inisId;
            frm.binisid = binisId;
            frm.seferId = Convert.ToInt32(dgw_seferListesi.SelectedRows[0].Cells["SeferID"].Value);
            frm.ShowDialog();
        }

        private void SeferSecimi_Form_Load(object sender, EventArgs e)
        {

            List<GuzergahDuraklari> binis = DuraklarBLL.GetGuzergahDuraklari(binisId);
            List<GuzergahDuraklari> inis = DuraklarBLL.GetGuzergahDuraklari(inisId);

            foreach (var item in binis)
            {
                foreach (var item2 in inis)
                {
                    if (item.GuzergahID == item2.GuzergahID && item.Sira < item2.Sira)
                    {
                        dgw_seferListesi.DataSource = SeferlerBLL.GetSeferler(item.GuzergahID);
                    }
                }
            }


        }
    }
}
