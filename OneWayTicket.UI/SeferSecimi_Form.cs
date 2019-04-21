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

        private void dgw_seferListesi_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            YolcuBilgiFormu_Form frm = new YolcuBilgiFormu_Form();
            frm.ShowDialog();
        }

        private void SeferSecimi_Form_Load(object sender, EventArgs e)
        {
            dgw_seferListesi.DataSource=SeferlerBLL.GetSeferlers();

      
            
          
        }
    }
}
