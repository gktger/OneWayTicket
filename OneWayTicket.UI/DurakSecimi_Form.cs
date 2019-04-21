﻿using OneWayTicket.BLL;
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
    }
}