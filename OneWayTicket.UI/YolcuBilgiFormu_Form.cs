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

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
