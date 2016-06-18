using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace eMonitor01
{
    public partial class Frm_LanMtc_Win : DevExpress.XtraEditors.XtraForm
    {
        public Frm_LanMtc_Win()
        {
            InitializeComponent();
        }
        public void showbtn()
        {
            btn_run.Visible = true;
            btn_suspect.Visible = true;
            btn_error.Visible = true;
            btn_first.Visible = true;
            btn_last.Visible = true;
            btn_next.Visible = true;
            btn_previous.Visible = true;
            checkloi.Visible = true;
            checknghingo.Visible = true;
            cbo_settimerun.Visible = true;
        }
        private void hidebtn()
        {
            btn_run.Visible = false;
            btn_suspect.Visible = false;
            btn_error.Visible = false;
            btn_first.Visible = false;
            btn_last.Visible = false;
            btn_next.Visible = false;
            btn_previous.Visible = false;
            checkloi.Visible = false;
            checknghingo.Visible = false;
            cbo_settimerun.Visible = false;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle).Contains(Cursor.Position))
            {
                hidebtn();
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            showbtn();
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("hello");
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            XtraMessageBox.Show("picture");
        }    
        
        private void btn_run_Click(object sender, EventArgs e)
        {           
            if (btn_run.Text=="Chạy")
            {
                this.btn_run.Image = ((System.Drawing.Image)(Properties.Resources.stop));                
                this.btn_run.Text = "Dừng";                
            }
            else
            {
                this.btn_run.Image = ((System.Drawing.Image)(Properties.Resources.play));
                this.btn_run.Text = "Chạy";                
            }
        }

        private void btn_error_Click(object sender, EventArgs e)
        {
            if (btn_error.Text == "Lỗi") // sau này đoạn này sẽ sửa là nếu ô cờ của bản ghi này đánh dấu là 1 or 2,3,4 (có lỗi) thì ... 
            {
             //   Frm_LoiNhanVien frm = new Frm_LoiNhanVien();
                //frm.Location = new System.Drawing.Point(78, 78);
                //frm.ShowDialog();
                // MessageBox.Show(frm.Location.X.ToString() + "  " + frm.Location.Y.ToString());
                btn_error.Text = "Bỏ lỗi";
                this.btn_error.Image = ((System.Drawing.Image)(Properties.Resources.OK_button_icon));
                btn_error.Width = this.btn_error.Width + 30;
                btn_suspect.Enabled = false;
            }
            else
            {
                btn_error.Text = "Lỗi";
                this.btn_error.Image = ((System.Drawing.Image)(Properties.Resources.loi));
                btn_error.Width = this.btn_error.Width - 30;
                btn_suspect.Enabled = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // kết nối CSDL 
            //string Constring ="Server=localhost;Database=test;Port=3306;User ID=root;Password=";
            //string query = "select * from tb_thuphi";
            //MySqlConnection conn = new MySqlConnection(Constring);
            //conn.Open();
            //MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "thu");
            //Data_soatveMTC.Refresh();
            //Data_soatveMTC.DataSource = ds.Tables["thu"];
            //conn.Close();
            
            // tạo source cho datagridview
            //DataTable dt = new DataTable();
            //dt.Columns.Add("STT");
            //dt.Columns.Add("Biển số xe");
            //dt.Columns.Add("Hình ảnh làn");
            //dt.Columns.Add("Hình ảnh biển số");

            //DataRow dr = dt.NewRow();

            //Data_soatveMTC.Refresh();
            //Data_soatveMTC.DataSource = dt;
        }

        private void Frm_lanmtc_win_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_suspect_Click(object sender, EventArgs e)
        {
            if (btn_suspect.Text == "Nghi ngờ") // sau này đoạn này sẽ sửa là nếu ô cờ của bản ghi này đánh dấu là 1 or 2,3,4 (có lỗi) thì ... 
            {
                btn_suspect.Text = "Bỏ nghi ngờ";
                this.btn_suspect.Image = ((System.Drawing.Image)(Properties.Resources.OK_button_icon));
                btn_suspect.Width = this.btn_suspect.Width + 30;
                btn_error.Enabled = false;
            }
            else
            {
                btn_suspect.Text = "Nghi ngờ";
                this.btn_suspect.Image = ((System.Drawing.Image)(Properties.Resources.warning));
                btn_suspect.Width = this.btn_suspect.Width - 30;
                btn_error.Enabled = true;
            }
        }
    }
}