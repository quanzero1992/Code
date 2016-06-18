using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace eMonitor01
{
    public partial class Frm_Detail : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Detail()
        {
            InitializeComponent();
        }
        public string path_1 { set; get; }
        public string path_2 { set; get; }
        public string tenlan { set; get; }
        public string sohieulan { set; get; }
        public string nhanvienthuphi { set; get; }
        public string ngaygio { set; get; }
        public string bienso { set; get; }
        public string giatien { set; get; }
        public string loaive { set; get; }
        public string sotien { set; get; }
        public string loaixe { set; get; }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
           // Pic_detail.Image = Image.FromFile(@);

        }

        private void frm_detail_Load(object sender, EventArgs e)
        {
            txtngaygio.Text = ngaygio;
            txttenlan.Text = tenlan;
            txttentpv.Text = nhanvienthuphi;
            txtbienso.Text = bienso;
            txtgiatien.Text = giatien;
            txtloaive.Text = loaive;
            txtloaixe.Text = loaixe;
            
            pic_bienso.Image = Image.FromFile(path_2);
            Pic_detail.Image = Image.FromFile(path_1);
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
           
        }

    }
}