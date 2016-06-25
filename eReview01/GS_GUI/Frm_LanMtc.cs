using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Base;
using System.Threading;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraEditors.Controls;
using System.Collections;
using DevExpress.XtraGrid;
using System.Xml;
using System.IO;
using eReview01.CommonUI;
using log4netDatabase;
using System.Linq;
using DevExpress.Utils;
using System.Drawing.Imaging;
using System.Diagnostics;


namespace eMonitor01
{
    // Edit 14-12-2014
        
    public partial class Frm_LanMtc : DevExpress.XtraEditors.XtraForm
    {
        public Frm_LanMtc()
        {
            Thread t = new Thread(new ThreadStart(RunWaitingCursor));
            t.Start();
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();
            GridLocalizer.Active = new MyGridLocalizer();
            Localizer.Active = new MyXtraMessage();
            t.Abort();
            Cursor.Current = Cursors.Default;
         
        }

        DataTable dt;
        int SoBanGhiChuaXuLy;
        int timeRunSlideshow;      
        int TimeloadNewData;
        
        public virtual bool KeepFocusedRowOnUpdate { get; set; }
        private Logger logger = LogManager.GetLogger(typeof(Frm_LanMtc).Name);
        private LoggerDb logDb = LogDbManager.GetLogger(typeof(Frm_LanMtc), (int)eReview01.CommonUI.Enumeration.eReview_Monitor.giám_sát);
       
        string OldVehNumber;

        # region Phím tắt
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // shortcut 4 slideshow
        {       
            if (keyData == (System.Windows.Forms.Keys.Up) || keyData == (System.Windows.Forms.Keys.Down) || keyData == (System.Windows.Forms.Keys.Escape))
            {
                if (timer_autoloaddt.Enabled==true)
                {               
                    this.btn_run.Image = ((System.Drawing.Image)(Properties.Resources.play));
                    this.btn_run.Text = "Chạy";
                    timer_autoloaddt.Enabled = false;
                }               
            }

            if (keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S))
                btn_run.PerformClick();

            //if (keyData == (System.Windows.Forms.Keys.Add)) // Nút + bên phím numlock
            //    MessageBox.Show("+");

            if (keyData == (System.Windows.Forms.Keys.Left))
                grid_Mtc.FocusedRowHandle--;    

            if (keyData == (System.Windows.Forms.Keys.Right))
                grid_Mtc.FocusedRowHandle++;    

            if (keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z))
                btn_resize_image.PerformClick();

            if (keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0) || keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad0))
                btn_Loi0.PerformClick();

            if (keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1) || keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad1))
                btn_Loi1.PerformClick();

            if (keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2) || keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad2))
                btn_Loi2.PerformClick();

            if (keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3) || keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad3))
                btn_Loi3.PerformClick();

            if (keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4) || keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad4))
                btn_Loi4.PerformClick();

            if (keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5) || keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad5))
                btn_Loi5.PerformClick();

            if (keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6) || keyData == (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad6))
                btn_Loi6.PerformClick();

            if (keyData == (System.Windows.Forms.Keys.F5))
            // refresh Data
            {
                
                if (radioButton1.Checked == true && radioButton2.Checked == false)
                {
                    XuLyBanGhiDaXem();
                    GetDataOldError();
                }
                if (radioButton2.Checked == true && radioButton1.Checked == false)
                {
                    XuLyBanGhiDaXem();
                    GetDataNewError();
                }
                OptionGoiYLoi();
                if (grid_Mtc.RowCount < 1)
                {
                    //lbl_CaptionGoiYLoi.Visible = false;
                    lbl_GoiYLoi.Visible = false;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
      
        # endregion


        private void RunWaitingCursor()
        {
            Cursor.Current = Cursors.WaitCursor;
        }

        private void CheckConnectionDb()
        {
            ConnectDb con = new ConnectDb();
            MySqlConnection mycon = con.GetCon();
            try
            {
                mycon.Open();
            }
            catch
            {
                logger.Error(Properties.Resources.DisconnectDb);
            }
            finally
            {
                if (mycon.State == ConnectionState.Open)
                {
                    mycon.Close();
                    mycon.Dispose();                
                }
            }
        }
        //object Gridview_SelectIndex;
        #region slideshow
        public void showbtn()
        {
            btn_run.Visible = true;
            //btn_suspect.Visible = true;
            //btn_error.Visible = true;          
            btn_next.Visible = true;
            btn_previous.Visible = true;
            //lbl_setslideshow.Visible = true;
            //cbo_settimerun.Visible = true;         
            //btn_test.Visible = true;
        }
        private void hidebtn()
        {
            btn_run.Visible = false;
            //btn_suspect.Visible = false;
            //btn_error.Visible = false;           
            btn_next.Visible = false;
            btn_previous.Visible = false;
            //lbl_setslideshow.Visible = false;
            //cbo_settimerun.Visible = false;         
           // btn_test.Visible = false;
        }  
   
#endregion

        private void frm_lanmtc_Load(object sender, EventArgs e)
        {
           
            Data_soatveMTC.EmbeddedNavigator.TextStringFormat = "Bản ghi {0} / {1}";
            try
            {
                toolStripStatusLabel1.Text = string.Format("Thời gian đăng nhập: {0:dd/MM/yyyy HH:mm:ss}", eReview01.Person.Timelogin);
                //CheckConnectionDb();
                Data_soatveMTC.Refresh();
                btn_previous.Parent = Pic_Mtc;
                btn_next.Parent = Pic_Mtc;
               // btn_run.Parent = Pic_Mtc;
                //lbl_setslideshow.Parent = Pic_Mtc;
                btn_next.BackColor = Color.Transparent;
                btn_previous.BackColor = Color.Transparent;                

                // đầu tiên kiểm tra xem có bản ghi nào chưa được xử lý 
                SoBanGhiChuaXuLy = CheckDbOld();
                if (SoBanGhiChuaXuLy > 0)
                {
                    DialogResult dr = XtraMessageBox.Show("Hiện có " + SoBanGhiChuaXuLy + " lượt soát vé ở các phiên trước chưa xử lý \r\n Bạn có muốn xử lý các thông tin này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        CheckDb();
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                        // lấy dữ liệu vào grid
                        GetDataOldError();
                        GridView view = grid_Mtc;
                        //view.Appearance.FocusedRow.BackColor = Color.Transparent;                        
                       // btn_Data.Enabled = false;
                    }
                    else
                    {
                        CheckDb();
                        radioButton1.Checked = false;
                        radioButton2.Checked = true;
                        grp_SettingFillData.Enabled = true;              
                        // thiết lập timer chạy tự động cập nhật các bản ghi tính từ thời điểm hiện tại trở đi
                        GetDataNewError();
                        GridView view = grid_Mtc;
                        //view.Appearance.FocusedRow.BackColor = Color.PaleTurquoise;
                    }
                }
                else            
                {
                    CheckDb();
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    GetDataNewError();
                    GridView view = grid_Mtc;
                    //view.Appearance.FocusedRow.BackColor = Color.PaleTurquoise;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            grid_Mtc.FocusedRowHandle = 0;
        } 
 
        private void CheckDb()
        {
            int tong = grid_Mtc.RowCount;
            if (tong==0)
            {
                EnableButtonLoi(false);
            }
        }

        private void GetDataOldError() // lấy những bản ghi cũ chưa được xử lý lỗi
        {           
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //CheckConnectionDb();
                ConnectDb cn = new ConnectDb();
                bool a = true;
                dt = new DataTable();
                dt = cn.DuLieuChuaXuLy(User_Login.LoginDateTime, a,MonitorSetting.ChooseLane);
                Data_soatveMTC.Refresh();
                
                int indexrow = grid_Mtc.FocusedRowHandle;
                
                grid_Mtc.BeginDataUpdate();
                //bindingSource1.DataSource = dt;
                Data_soatveMTC.DataSource = dt;
                grid_Mtc.EndDataUpdate();

                if (indexrow == grid_Mtc.RowCount)                
                grid_Mtc.FocusedRowHandle = indexrow - 1;
                else
                    grid_Mtc.FocusedRowHandle = indexrow;
                //bindingNavigator1.BindingSource = bindingSource1; 
                //NotChangeRowAfterReLoadDb();
                if (indexrow == 0)
                    grid_Mtc.RefreshRow(0);
                Cursor.Current = Cursors.Default;
                // XtraMessageBox.Show("Vui lòng xem lại kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {                
                logger.Error(ex);
            }
        }

        private void GetDataTest()
        {
             ConnectDb cn = new ConnectDb();
            try
            {
                bool a = false;
                dt = new DataTable();
                dt = cn.DuLieuChuaXuLy(User_Login.LoginDateTime, a, MonitorSetting.ChooseLane);
                Data_soatveMTC.DataSource = dt;
                Data_soatveMTC.RefreshDataSource();
                //Hoanglm add new to check the verhical standar data [12/10/2014]
                //Moi transaction se duoc kiem tra de lam lay thong tin dua vao bang data chuan
                // 2 transaction gan nhat trong vonng 1 thang se duoc lay tu bang tc_ transaction
                //Tuy nhien khi bang tc_transaction co hang trieu record thi viec query de lay 2 transaction gan nhat se mat khoang 1s
                //Can cai thien them

                // Quan edit 07-11- 2015
                // hiện tại cứ loại xe được đánh không lỗi gần nhất để làm xe chuẩn
                //string verNum = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "BienSo").ToString();
                //VehicleStandardProcess(verNum);
    
                //Hoanglm end [12/10/2014]
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra kết nối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //logger.Error(ex.ToString());
            }
            
        }

        private void GetDataNewError() // lấy những bản ghi mới chưa được xử lý lỗi từ thời điểm hiện tại trở đi
        {
            try
            {              
                //CheckConnectionDb();                
                GridView view = (GridView)Data_soatveMTC.MainView;
                int index = view.FocusedRowHandle;
                //int topVisibleIndex = view.TopRowIndex;
                Data_soatveMTC.BeginUpdate();

                ConnectDb cn = new ConnectDb();
                bool a = false;
                dt = new DataTable();
                dt = cn.DuLieuChuaXuLy(User_Login.LoginDateTime, a, MonitorSetting.ChooseLane);                                                
                Data_soatveMTC.DataSource = dt;
                if (view != null)
                {
                    view.FocusedRowHandle = index;
                    //view.TopRowIndex = topVisibleIndex;
                }
                Data_soatveMTC.EndUpdate();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
       /// <summary>
       /// Kiểm tra số bản ghi chưa xử lý
       /// </summary>
       /// <returns></returns>
        public int CheckDbOld() 
        {
            try
            {
                ConnectDb con = new ConnectDb();
                SoBanGhiChuaXuLy= con.BanGhiChuaXuLyTheoLan(MonitorSetting.ChooseLane);           
            }
            catch (Exception)
            {
                logger.Info("So Ban ghi chua xu ly " + SoBanGhiChuaXuLy);
            }
            return SoBanGhiChuaXuLy;
        }               
       
        private void timer_autoloaddt_Tick(object sender, EventArgs e)
        {
            timeRunSlideshow = MonitorSetting.TimeRunSlideshow;
            //if (File.Exists(SettingAppPath))
            //{
            //    XmlDocument xmlDoc2 = new XmlDocument();
            //    xmlDoc2.LoadXml(eReview01.CommonUI.Utils.DecryptString(File.ReadAllText(SettingAppPath)));
            //    timeRunSlideshow = int.Parse(xmlDoc2.GetElementsByTagName("TimeRunSlideshow")[0].InnerText.Trim()) * 1000;
            //}
            //else
            //{ timeRunSlideshow = 1000; }
             //   lbl_time.Text = time.ToString();
                btn_run.Enabled = true;
                timer_autoloaddt.Interval = timeRunSlideshow * 1000;
                grid_Mtc.FocusedRowHandle++;
              
        }
  
        private void btn_previous_Click(object sender, EventArgs e)
        {
            grid_Mtc.FocusedRowHandle--;            
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            grid_Mtc.FocusedRowHandle++;
        }


        private void Pic_Mtc_MouseLeave(object sender, EventArgs e)
        {
            if (!Pic_Mtc.RectangleToScreen(Pic_Mtc.ClientRectangle).Contains(Cursor.Position))
            {
                hidebtn();
            }
        }

        private void Pic_Mtc_MouseMove(object sender, MouseEventArgs e)
        {
            showbtn();
        }

        private void btn_previous_MouseUp(object sender, MouseEventArgs e)
        {
            btn_previous.Image = ((System.Drawing.Image)(Properties.Resources.Previous));
        }

        private void btn_next_MouseUp(object sender, MouseEventArgs e)
        {
            btn_next.Image = ((System.Drawing.Image)(Properties.Resources.Next));
        }

        private void btn_next_MouseDown(object sender, MouseEventArgs e)
        {
            btn_next.Image = ((System.Drawing.Image)(Properties.Resources.Next2));
        }

        private void btn_previous_MouseDown(object sender, MouseEventArgs e)
        {
            btn_previous.Image = ((System.Drawing.Image)(Properties.Resources.previous2));
        }
        
        private void grid_Mtc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            if (e.FocusedRowHandle < 0) return;
            int dong = grid_Mtc.FocusedRowHandle;
            int tong = grid_Mtc.RowCount;
            
            //OptionGoiYLoi();
            GridView view = grid_Mtc;
            try
            {
                OptionGoiYLoi(); //  edit 10-08-2015
                // khi thay đổi row những label.text sẽ thay đổi phù hợp    
                if (grid_Mtc.FocusedRowHandle < 0 || grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MaLuotThongXe") == null) return;
                string MaGs = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MaLuotThongXe").ToString();
                NapBanGhiDaXem(MaGs);
                //listBox1.SelectedIndex = (listBox1.Items.Count - 1);
                //MessageBox.Show(MaGs);           
                lbl_biensoxe.Text = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle,"BienSo").ToString();
                lbl_giatien.Text = (String.Format("{0:0,0 VNĐ}", grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "Phi" )));
                lbl_LoaiThuPhi.Text = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "LoaiThuPhi").ToString();

                //XtraMessageBox.Show(grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "LoaiVe").ToString());                        
                lbl_LoaiVe.Text = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "LoaiVe").ToString();

                //lbl_loaixe.Text = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MoTaLoaiXe").ToString();
                lbl_loaixe.Text = dictionaryVehType(grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MoTaLoaiXe").ToString().ConvertToInt());
                var imgPath = grid_Mtc.GetRowCellValue(dong, "HinhAnh").ToString();
                //Pic_Mtc.Properties.ZoomPercent = 85;
                if (!string.IsNullOrEmpty(imgPath))
                {
                    //Pic_Mtc.Properties.SizeMode = PictureSizeMode.Zoom;
                    Pic_Mtc.LoadAsync(@imgPath);
                }
                else
                {
                    //Pic_Mtc.Properties.SizeMode = PictureSizeMode.Clip;
                    Pic_Mtc.Image = (Image)Properties.Resources.ImageEmpty;
                }
               
                if (grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "GoiYLoi") == null || (int)grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "GoiYLoi") == 0)
                {
                    //lbl_CaptionGoiYLoi.ForeColor = Color.Green;
                    lbl_GoiYLoi.ForeColor = Color.Green;
                    lbl_GoiYLoi.Text = "Lượt thông xe không có lỗi";
                }
                else if ((int)grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "GoiYLoi") == 1)
                {
                    //lbl_CaptionGoiYLoi.ForeColor = Color.OrangeRed;
                    lbl_GoiYLoi.ForeColor = Color.OrangeRed;
                    lbl_GoiYLoi.Text = "Lượt thông xe nghi ngờ";
                }
                else
                {
                    //lbl_CaptionGoiYLoi.ForeColor = Color.Red;
                    lbl_GoiYLoi.ForeColor = Color.Red;
                    lbl_GoiYLoi.Text = "Lượt thông xe có lỗi";
                }
                int LuotThangQuy = string.IsNullOrEmpty(grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "LuotThangQuy").ToString()) ? 0 : grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "LuotThangQuy").ConvertToInt();
                LoadStandardVehicle(grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "BienSo").ToString(), grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "Phi").ConvertToInt(), LuotThangQuy);
                Pic_Mtc.Properties.ZoomPercent = 85;
                //XuLyBanGhiDaXem();
            }
            catch (Exception ex)
            {
               // XtraMessageBox.Show("Vui lòng kiểm tra kết nối");
                logger.Error("Error grid_Mtc_FocusedRowChanged with error " + ex);
            }
            if (dong+1==tong) // tự động dừng slideshow khi đến bản ghi cuối
            {
                this.btn_run.Image = ((System.Drawing.Image)(Properties.Resources.play));
                    this.btn_run.Text = "Chạy";
                    timer_autoloaddt.Enabled = false;        
            }        
        } 

        private void btn_resize_image_Click(object sender, EventArgs e)
        {
            if (panel_grid.Visible == true)
            {
                this.btn_resize_image.Image =((System.Drawing.Image)(Properties.Resources.up4));
                panel_grid.Visible = false;                
                btn_resize_image.ToolTip = "Hiện bảng";   
            }
            else  
            {
                panel_grid.Visible = true;    
                this.btn_resize_image.Image = ((System.Drawing.Image)(Properties.Resources.down4));
                btn_resize_image.ToolTip = "Dấu bảng";
            }
        }

        //Quan Fix 29-09-2015
        private void btn_Loi0_Click(object sender, EventArgs e)
        {
            //Hoanglm add new 
            var verNum = lbl_biensoxe.Text;
            var verType = lbl_loaixe.Text;
            //End
            string id = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MaLuotThongXe").ToString();
            
            try
            {                
                ConnectDb cn = new ConnectDb();
                
                //Quanedit 07-11
                // xe được đánh không lỗi thì cập nhật lại vào Db standard
                string verNumCurrent = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "BienSo").ToString();
                if (!string.IsNullOrEmpty(verNumCurrent) && !string.IsNullOrWhiteSpace(verNumCurrent))
                {
                    cn.UpdateError(id, 0);
                    VehicleStandardProcess(verNumCurrent);
                    grid_Mtc.DeleteRow(grid_Mtc.FocusedRowHandle);
                    LoadInfo();
                }
                else
                    XtraMessageBox.Show("Đây là trường hợp hệ thống không trả về biển số (Lỗi loại 3) bạn không thể tick không lỗi","Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {               
                XtraMessageBox.Show(Properties.Resources.CheckConnection,"Thất bại!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                logger.Error("User: " + User_Login.Name + " try tick 'Khong loi' for record '" + id + "' and Failure! by error " + ex);
            }                         
        }  

        private void btn_Loi1_Click(object sender, EventArgs e)
        { 
            int currentIndex = grid_Mtc.FocusedRowHandle;
            string id = grid_Mtc.GetRowCellValue(currentIndex, "MaLuotThongXe").ToString();
            try
            {               
                ConnectDb cn = new ConnectDb();
                cn.UpdateError(id, 1);
                XoaBanGhiDaXem(id);
                int LoaiXe = -1;
                string BienSo = grid_Mtc.GetRowCellValue(currentIndex, "BienSo").ToString();
                string LinkAnh = grid_Mtc.GetRowCellValue(currentIndex, "HinhAnh").ToString();
                string ThuPhiVien = grid_Mtc.GetRowCellDisplayText(currentIndex, "ThuPhiVien").ToString();
                logDb.Save(string.Format("User {0} tick lỗi loại 1 lượt xe có mã {1} \n Biển số: {2} \n Link ảnh: {3} \n Thu phí viên: {4}", User_Login.Name, id, BienSo, LinkAnh, ThuPhiVien),(int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                int.TryParse(grid_Mtc.GetRowCellValue(currentIndex, "MoTaLoaiXe").ToString().Trim(), out LoaiXe);
                
                if (!string.IsNullOrEmpty(BienSo) && LoaiXe > 0)
                    RemoveVehicleStandard(BienSo, LoaiXe);
                
                grid_Mtc.DeleteRow(currentIndex);
                LoadInfo();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 1' for record '" + id + "' and Failure! by error " + ex);
            }          
        }

        private void btn_Loi2_Click(object sender, EventArgs e)
        {
            string id = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MaLuotThongXe").ToString();
            try
            {
                
                ConnectDb cn = new ConnectDb();
                cn.UpdateError(id, 2);
                XoaBanGhiDaXem(id);
                
                //if (radioButton2.Checked == true) // nếu đang ở trạng thái xem lại                  
                //        GetDataNewError();
                  
                //if (radioButton1.Checked == true)                 
                //        GetDataOldError();
                string BienSo = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "BienSo").ToString();
                string LinkAnh = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "HinhAnh").ToString();
                string ThuPhiVien = grid_Mtc.GetRowCellDisplayText(grid_Mtc.FocusedRowHandle, "ThuPhiVien").ToString();
                
                logDb.Save(string.Format("User {0} tick lỗi loại 2 lượt xe có mã {1} \n Biển số: {2} \n Link ảnh: {3} \n Thu phí viên: {4}", User_Login.Name, id, BienSo, LinkAnh, ThuPhiVien),(int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                

                grid_Mtc.DeleteRow(grid_Mtc.FocusedRowHandle);
                    LoadInfo();
                     
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 2' for record '" + id + "' and Failure! by error " + ex);
            }                                  
        }               

        private void btn_Loi3_Click(object sender, EventArgs e)
        {
            string id = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MaLuotThongXe").ToString();
            try
            {                
                ConnectDb cn = new ConnectDb();
                cn.UpdateError(id, 3);
                XoaBanGhiDaXem(id);
                //if (radioButton2.Checked == true) // nếu đang ở trạng thái xem lại                              
                //    GetDataNewError();
           
                //if (radioButton1.Checked == true)              
                //    // giải quyết dữ liệu cũ                 
                //    GetDataOldError();        
                //string BienSo = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "BienSo").ToString();
                //string LinkAnh = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "HinhAnh").ToString();
                //string ThuPhiVien = grid_Mtc.GetRowCellDisplayText(grid_Mtc.FocusedRowHandle, "ThuPhiVien").ToString();
                //logDb.Save(string.Format("User {0} tick lỗi loại 3 lượt xe có mã {1} \n Biển số: {2} \n Link ảnh: {3} \n Thu phí viên: {4}", User_Login.Name, id, BienSo, LinkAnh, ThuPhiVien), (int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                

                grid_Mtc.DeleteRow(grid_Mtc.FocusedRowHandle);
                    LoadInfo();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 3' for record '" + id + "' and Failure! by error " + ex);
            }                              
        }

        private void btn_Loi4_Click(object sender, EventArgs e)
        {   
            string id = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MaLuotThongXe").ToString();
            try
            {
               
                ConnectDb cn = new ConnectDb();
                cn.UpdateError(id, 4);
                XoaBanGhiDaXem(id);
                //if (radioButton2.Checked == true) // nếu đang ở trạng thái xem lại                                        
                //        GetDataNewError();
                    
                //if (radioButton1.Checked == true)
                //        // giải quyết dữ liệu cũ                      
                //        GetDataOldError(); 
                //string BienSo = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "BienSo").ToString();
                //string LinkAnh = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "HinhAnh").ToString();
                //string ThuPhiVien = grid_Mtc.GetRowCellDisplayText(grid_Mtc.FocusedRowHandle, "ThuPhiVien").ToString();
                //logDb.Save(string.Format("User {0} tick lỗi loại 4 lượt xe có mã {1} \n Biển số: {2} \n Link ảnh: {3} \n Thu phí viên: {4}", User_Login.Name, id, BienSo, LinkAnh, ThuPhiVien), (int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                
                       
                grid_Mtc.DeleteRow(grid_Mtc.FocusedRowHandle);
                    LoadInfo();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 4' for record '" + id + "' and Failure! by error " + ex);
            }
        }

        private void btn_Loi5_Click(object sender, EventArgs e)
        {
            string id = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MaLuotThongXe").ToString();
            try
            {              
                    ConnectDb cn = new ConnectDb();
                    cn.UpdateError(id, 5);
                    XoaBanGhiDaXem(id);
                //if (radioButton2.Checked == true) // nếu đang ở trạng thái xem lại                   
                //        GetDataNewError();
                  
                //if (radioButton1.Checked == true) 
                //        GetDataOldError();                 
                    //string BienSo = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "BienSo").ToString();
                    //string LinkAnh = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "HinhAnh").ToString();
                    //string ThuPhiVien = grid_Mtc.GetRowCellDisplayText(grid_Mtc.FocusedRowHandle, "ThuPhiVien").ToString();
                    //logDb.Save(string.Format("User {0} tick lỗi loại 5 lượt xe có mã {1} \n Biển số: {2} \n Link ảnh: {3} \n Thu phí viên: {4}", User_Login.Name, id, BienSo, LinkAnh, ThuPhiVien), (int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                

                    grid_Mtc.DeleteRow(grid_Mtc.FocusedRowHandle);
                        LoadInfo();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 5' for record '" + id + "' and Failure! by error " + ex);
            }    
        }

        private void btn_Loi6_Click(object sender, EventArgs e)
        {
            string id = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MaLuotThongXe").ToString();
            try
            {
                // giải quyết dữ liệu cũ                
                ConnectDb cn = new ConnectDb();                
                cn.UpdateError(id, 6);
                XoaBanGhiDaXem(id);
                //if (radioButton2.Checked == true) // nếu đang ở trạng thái xem lại                    
                //        GetDataNewError();
                   
                //if (radioButton1.Checked == true)                                         
                //        GetDataOldError();              
                string BienSo = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "BienSo").ToString();
                string LinkAnh = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "HinhAnh").ToString();
                string ThuPhiVien = grid_Mtc.GetRowCellDisplayText(grid_Mtc.FocusedRowHandle, "ThuPhiVien").ToString();
                logDb.Save(string.Format("User {0} tick lỗi loại 6 lượt xe có mã {1} \n Biển số: {2} \n Link ảnh: {3} \n Thu phí viên: {4}", User_Login.Name, id, BienSo, LinkAnh, ThuPhiVien), (int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                
         
                grid_Mtc.DeleteRow(grid_Mtc.FocusedRowHandle);
                    LoadInfo();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 6' for record '"+ id+"' and Failure! by error " + ex);
            }            
        }

        private void EnableButtonLoi(bool tag)
        {
            if (tag == true)
            {
                btn_Loi0.Enabled = true;
                btn_Loi1.Enabled = true;
                btn_Loi2.Enabled = true;
                btn_Loi3.Enabled = true;
                btn_Loi4.Enabled = true;
                btn_Loi5.Enabled = true;
                btn_Loi6.Enabled = true;
            }
            if (tag == false)
            {
                btn_Loi0.Enabled = false;
                btn_Loi1.Enabled = false;
                btn_Loi2.Enabled = false;
                btn_Loi3.Enabled = false;
                btn_Loi4.Enabled = false;
                btn_Loi5.Enabled = false;
                btn_Loi6.Enabled = false;
                //lbl_CaptionGoiYLoi.Visible = false;
                lbl_GoiYLoi.Visible = false;

            }
        }

        private void grid_Mtc_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                GridView gridview = ((GridView)sender);
                if (!gridview.GridControl.IsHandleCreated) return;
                Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
                SizeF size = gr.MeasureString(gridview.RowCount.ToString(),gridview.PaintAppearance.Row.GetFont());
                gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 10;
                // nếu không có bản ghi nào trong grid view thì enable các button đánh lỗi đi 
                if (grid_Mtc.RowCount == 0)
                {
                    ResetInfo();
                    EnableButtonLoi(false);
                    grp_SettingFillData.Enabled = true;
                    lbl_GoiYLoi.Visible = false;
                    //lbl_CaptionGoiYLoi.Visible = false;
                    // btn_Data.Enabled = false;                
                }
                else
                    EnableButtonLoi(true);
            }
            catch (Exception ex)
            {
                logger.Error("error grid_Mtc_RowCountChanged by error " + ex);
            }            
        }

        private void ResetInfo()
        {
            lbl_biensoxe.Text = "";
            lbl_giatien.Text = "";
            lbl_LoaiThuPhi.Text = "";
            lbl_loaixe.Text = "";
            Pic_Mtc.LoadAsync("");
            lbl_LoaiVe.Text = "";
        }

        bool indicatorIcon = true;
        private void grid_Mtc_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
                if (!indicatorIcon)
                    e.Info.ImageIndex = -1;

                if (e.RowHandle == GridControl.InvalidRowHandle)
                {
                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = "STT";
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ConnectDb con = new ConnectDb();
                if (con.CheckConnectDb() == true)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (radioButton2.Checked == true)
                    {
                        XuLyBanGhiDaXem();
                        RunLoadDbAuto(true);
                        GetDataNewError();
                    }
                    else RunLoadDbAuto(false);
                    if (grid_Mtc.RowCount > 0)
                    {
                        grid_Mtc.FocusedRowHandle = 0;
                    }
                    else
                    {
                        //lbl_CaptionGoiYLoi.Visible = false;
                        lbl_GoiYLoi.Visible = false;
                    }
                    LoadInfo();
                    Cursor.Current = Cursors.Default;
                }
                else
                    XtraMessageBox.Show(Properties.Resources.CheckConnection,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //AllowSortColumns(false);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void timer_loaddb_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.IsDisposed) return;
                TimeloadNewData = MonitorSetting.TimeAutoLoadDb;
                timer_loaddb.Interval = TimeloadNewData * 1000;
                // ______________________________________________________________________ //
                GridView view = (GridView)Data_soatveMTC.MainView;
                int index = view.FocusedRowHandle;
                int topVisibleIndex = view.TopRowIndex;
                grid_Mtc.BeginDataUpdate();

                GetDataTest();

                if (view != null)
                {
                    view.FocusedRowHandle = index;
                    view.TopRowIndex = topVisibleIndex;
                }
                grid_Mtc.EndDataUpdate();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                ConnectDb con = new ConnectDb();
                if (con.CheckConnectDb() == true)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (radioButton1.Checked == true)
                    {
                        XuLyBanGhiDaXem();
                        RunLoadDbAuto(false);
                        GetDataOldError();
                      
                    }
                    if (grid_Mtc.RowCount > 0)
                        grid_Mtc.FocusedRowHandle = 0;
                    else
                    {
                        lbl_GoiYLoi.Visible = false;
                        //lbl_CaptionGoiYLoi.Visible = false;
                    }
                    LoadInfo();
                    Cursor.Current = Cursors.Default;
                }
                else
                    XtraMessageBox.Show(Properties.Resources.CheckConnection,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //AllowSortColumns(true);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        // Quan edit 29/09/2015
        /// <summary>
        /// Hàm khóa chức năng Sort 1 số columns
        /// </summary>
        /// <param name="key"></param>
        private void AllowSortColumns(bool key)
        {
            if (key)
                gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            else
                gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False; 
        }

        // end edit

        private void RunLoadDbAuto(bool turn) // hàm tắt bật chạy load db tự động
        {
            TimeloadNewData = MonitorSetting.TimeAutoLoadDb;
            if (turn == true)
            {               
                timer_loaddb.Enabled = true;
                timer_loaddb.Interval = TimeloadNewData * 1000;
              //  timer_LoadOldDb.Enabled = false;                                
            }
            else
            {
                timer_loaddb.Enabled = false;
              //  timer_LoadOldDb.Enabled = true;
            }
        }

        private void NotChangeRowAfterReLoadDb()
        {            
            int[] index = grid_Mtc.GetSelectedRows(); // lay index cua dong dang select
            //MessageBox.Show(a[0].ToString());   
            int dong = grid_Mtc.FocusedRowHandle;
            int tong = grid_Mtc.RowCount;
            if (index[0]+1 == tong)
            {
                grid_Mtc.FocusedRowHandle--;
                grid_Mtc.FocusedRowHandle++;
            }
            else
            {
                grid_Mtc.FocusedRowHandle++;
                grid_Mtc.FocusedRowHandle--;
            }
        }

        private void timer_LoadOldDb_Tick(object sender, EventArgs e)
        {
            timer_LoadOldDb.Interval = TimeloadNewData * 1000;     // hiện tại không dùng timer này       
            GetDataOldError();           
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            try
            {
                timeRunSlideshow = MonitorSetting.TimeRunSlideshow;
                if (timer_autoloaddt.Enabled == false)
                {
                    this.btn_run.Image = ((System.Drawing.Image)(Properties.Resources.stop));
                    this.btn_run.Text = "Dừng";
                    timer_autoloaddt.Enabled = true;
                }
                else
                {
                    this.btn_run.Image = ((System.Drawing.Image)(Properties.Resources.play));
                    this.btn_run.Text = "Chạy";
                    timer_autoloaddt.Enabled = false;
                }
                logger.Info("Run SlideShow with speed: " + timer_autoloaddt.Interval + " s");
            }
            catch (Exception ex)
            {
                logger.Error("Can't run SlideShow by error: " + ex);
            }
        }
     
        /* Chức năng tự động đánh không lỗi khi người dùng đã xem nhưng ko đánh lỗi bản ghi*/
        ArrayList DaXem = new ArrayList(); // khai báo mảng chứa mã của những bản ghi đã xem
        
        private void NapBanGhiDaXem(string MaGs) // sẽ được gọi lúc focusrow
        {
            if (!DaXem.Contains(MaGs))
            {
                DaXem.Add(MaGs);
                listBox1.Items.Add(MaGs);
            }
        }

        private void XoaBanGhiDaXem(string MaGs) // được gọi lúc đánh lỗi , trong các button lỗi
        {
            if (DaXem.Contains(MaGs))
            {
                DaXem.Remove(MaGs);
                listBox1.Items.Remove(MaGs);              
            }
        }

        public void XuLyBanGhiDaXem() // cài đặt để thực thi tự động hóa đánh lỗi những bản ghi đã xem, dữ liệu sẽ được load lại sau khi thực thi XuLy
        {
            try
            { 
                bool key = true;
               
                key = MonitorSetting.TuDongXuLyBanGhiDaXem;
                if (key==true)
                {      
                    if (radioButton2.Checked == true) // nếu đang ở trạng thái xem lại 
                    {                  
                        while (DaXem.Count > 0)
                        {
                            ConnectDb cn = new ConnectDb();
                            cn.UpdateError(DaXem[0].ToString(), 0);
                            XoaBanGhiDaXem(DaXem[0].ToString());                        
                        }                                                
                    }

                    if (radioButton1.Checked == true)
                    {                  
                        while (DaXem.Count > 0)
                        {
                            ConnectDb cn = new ConnectDb();
                            cn.UpdateError(DaXem[0].ToString(), 0);
                            XoaBanGhiDaXem(DaXem[0].ToString());
                        }                                  
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }   
        }       
        //string SettingAppPath = Path.Combine(Application.StartupPath, "SettingApp");


        private void grid_Mtc_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string Mags = View.GetRowCellValue(e.RowHandle, "MaLuotThongXe").ToString();
               // listBox1.Items.Clear();
                for (int i = 0; i < DaXem.Count ; i++)
                {                                 
                    if (DaXem[i].ToString()== Mags)
                    {
                            e.Appearance.BackColor =Color.FromArgb(MonitorSetting.ColorDaXem1);
                            e.Appearance.BackColor2 = Color.FromArgb(MonitorSetting.ColorDaXem2);
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (DaXem.Count>=5)
            {
                XuLyBanGhiDaXem();              
                DaXem.Clear();
            }
            listBox1.Items.Clear();
        }

        private void Frm_LanMtc_FormClosing(object sender, FormClosingEventArgs e)
        {
            // khi đóng form những bản ghi đã xem sẽ được tự động đánh là không lỗi
            XuLyBanGhiDaXem();
        }

        private void grid_Mtc_RowCellClick(object sender, RowCellClickEventArgs e)
        {          
            try
            {
                if (grid_Mtc.RowCount > 0)
                {
                    string MaGs = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MaLuotThongXe").ToString();
                    NapBanGhiDaXem(MaGs);
                    GridView view = (GridView)Data_soatveMTC.MainView;
                    
                        view.Appearance.FocusedRow.BackColor = Color.FromArgb(MonitorSetting.ColorDaXem1);
                        view.Appearance.FocusedRow.BackColor2 = Color.FromArgb(MonitorSetting.ColorDaXem2);
                    //}
                    //else
                    //{
                    //    view.Appearance.FocusedRow.BackColor = Color.LightGreen;
                    //    view.Appearance.FocusedRow.BackColor2 = Color.GreenYellow;
                    //}
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }              
        }

        private void grid_Mtc_FocusedRowLoaded(object sender, RowEventArgs e)
        {
            LoadInfo();
        }

        public void LoadInfo()
        {
            try
            {
                if (grid_Mtc.FocusedRowHandle >= 0)
                {
                    lbl_biensoxe.Text = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "BienSo").ToString();
                    lbl_giatien.Text = (String.Format("{0:0,0 VNĐ}", grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "Phi")));
                    lbl_LoaiThuPhi.Text = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "LoaiThuPhi").ToString();
                    lbl_LoaiVe.Text = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "LoaiVe").ToString();

                    lbl_loaixe.Text = dictionaryVehType(grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "MoTaLoaiXe").ConvertToInt());
                    var imgPath = grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "HinhAnh").ToString();
                    if (!string.IsNullOrEmpty(imgPath))
                    {
                        //Pic_Mtc.Properties.SizeMode = PictureSizeMode.Zoom;
                        Pic_Mtc.LoadAsync(@imgPath);
                    }
                    else
                    {
                        //Pic_Mtc.Properties.SizeMode = PictureSizeMode.Clip;
                        Pic_Mtc.Image = (Image)Properties.Resources.ImageEmpty;
                    }
                    Pic_Mtc.Properties.ZoomPercent = 85;
                    if (grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "GoiYLoi") == null || (int)grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "GoiYLoi") == 0)
                    {
                        lbl_GoiYLoi.ForeColor = Color.Green;
                        lbl_GoiYLoi.Text = "Lượt thông xe không có lỗi";
                    }
                    else if ((int)grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "GoiYLoi") == 1)
                    {
                        lbl_GoiYLoi.ForeColor = Color.OrangeRed;
                        lbl_GoiYLoi.Text = "Lượt thông xe nghi ngờ";
                    }
                    else
                    {
                        lbl_GoiYLoi.ForeColor = Color.Red;
                        lbl_GoiYLoi.Text = "Lượt thông xe có lỗi";
                    }

                    int LuotThangQuy = string.IsNullOrEmpty(grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "LuotThangQuy").ToString()) ? 0 : grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "LuotThangQuy").ConvertToInt();
                    LoadStandardVehicle(grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "BienSo").ToString(), grid_Mtc.GetRowCellValue(grid_Mtc.FocusedRowHandle, "Phi").ConvertToInt(), LuotThangQuy);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }
             
        public void OptionGoiYLoi() 
        {
            bool key = true;
            key = MonitorSetting.TuDongPhatHienNghiNgo;
            if (key == false)
            {
                //lbl_CaptionGoiYLoi.Visible = false;
                lbl_GoiYLoi.Visible = false;
                gridColumn9.Visible = false;
            }
            else
            {
                //lbl_CaptionGoiYLoi.Visible = true;
                lbl_GoiYLoi.Visible = true;
                gridColumn9.Visible = true;
            }
        }
        /// <summary>
        /// Hàm lấy chuỗi số làn được lấy dữ liệu
        /// </summary>
        

        Queue<VehicleStandard> Vs = new Queue<VehicleStandard>();
        /// <summary>
        /// hàm thêm vào queue những bản ghi được select
        /// </summary>
        /// <param name="vs"></param>
        public void AddVehicleStandard(VehicleStandard SelectVehicle)
        {
            lock (SelectVehicle)
            {
                if (!Vs.Contains(SelectVehicle))
                {
                    Vs.Enqueue(SelectVehicle);
                } 
            }           
        }

        private void Frm_LanMtc_Shown(object sender, EventArgs e)
        {
            try
            {
                logDb.iread = false;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }


        /// <summary>
        /// Hàm xử lý xe chuẩn (Thêm + Update)
        /// </summary>
        /// <param name="verNum"></param>
        public void VehicleStandardProcess(string verNum)
        {
            ConnectDb cn = new ConnectDb();
            try
            {
                if (grid_Mtc.RowCount == 0)
                    return;
                if (string.IsNullOrEmpty(verNum))
                    return;
                int typeId = -1;
                if (cn.CheckVerhicleNunberInTransaction(verNum, out typeId))
                {
                    if (typeId != -1)
                        cn.CheckStandardVerhicleInfo(verNum, typeId);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                cn.CloseConnection();
            }
        }

        /// <summary>
        /// Hàm remove xe khỏi danh sách dữ liệu chuẩn
        /// So sánh loại xe có khớp vs xe trong dữ liệu chuẩn không, nếu khớp mới remove
        /// </summary>
        /// <param name="verNum"></param>
        public void RemoveVehicleStandard(string vehNum, int Vehtype)
        {
            ConnectDb cn = new ConnectDb();
            try
            {
                if (Vehtype == cn.SelectStandardVehicleInfo(vehNum))
                {
                    cn.DeleteStandardVehicleInfo(vehNum);
                }
            }
            catch (Exception ex)
            {
                logDb.Error(ex);
            }
            finally
            {
                cn.CloseConnection();
            }
        }

        /// <summary>
        /// Trả về mô tả loại xe khi đã biết loại xe
        /// </summary>
        /// <returns></returns>
        public string dictionaryVehType(int VehNum)
        {
            if (CommonDictionary4Monitor.DataSource.vehicle_type == null)
                CommonDictionary4Monitor.LoadAllDictionary();

            string result = "";
            if (CommonDictionary4Monitor.DataSource != null)
                result = CommonDictionary4Monitor.DataSource.vehicle_type.FirstOrDefault(x => x.VEH_TYPE_ID == VehNum).VEH_TYPE_DESC.ToString();
            else result = VehNum.ToString();
            return result;
        }

        private void btnVideoPlayback_Click(object sender, EventArgs e)
        {
            Frm_VideoPlaybackForm frm = new Frm_VideoPlaybackForm();
            int index = grid_Mtc.FocusedRowHandle;
            int Lane_id = grid_Mtc.GetRowCellValue(index, "SoHieuLan").ConvertToInt();
            frm.IPCamera = CommonDictionary4Monitor.DataSource.cf_lane.FirstOrDefault(x => x.LANE_ID == Lane_id).LANE_CAMERA_IP.ToString();
            frm.TransBegin = grid_Mtc.GetRowCellValue(index, "ThoiDiemXeVao").ConvertToDateTime();
            frm.TransEnd = grid_Mtc.GetRowCellValue(index, "ThoiDiemXeQua").ConvertToDateTime();

            frm.ShowDialog();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Test");
        }

        private void LoadStandardVehicle(string VehNum, int Price, int LuotThangQuy)
        {
            try
            {
                resetStandardVehicle();
                if (string.IsNullOrEmpty(VehNum)) return;
                lblWarmning.Visible = false;
                ConnectDb cn = new ConnectDb();
                DataTable dt = cn.GetStandardVerhicleInfo(VehNum);
              
                if ( dt.Rows.Count >0)
                {
                    if (dt.Rows[0]["Type"].ConvertToInt() < 1) return;
                    lblWarmning.Visible = true;
                    lblStandard_VehNum.Text = VehNum;
                    lblStandard_VehType.Text = dt.Rows[0]["Type"].ToString();
                    lblStandard_UpdateDate.Text = dt.Rows[0]["DateUpdate"].ToString();
                    string UserUpdate = dt.Rows[0]["UserUpdate"].ToString();
                    int searchUser = CommonDictionary4Monitor.DataSource.user_info.Where(x => x.USER_INFO_ID == UserUpdate).Count().ConvertToInt(); // để đảm bảo UserUpdate có trong danh sách nhân viên hiện tại
                    lblStandard_UpdatePerson.Text = searchUser < 1 ? UserUpdate : CommonDictionary4Monitor.DataSource.user_info.FirstOrDefault(x => x.USER_INFO_ID.Equals(UserUpdate)).USER_INFO_FULL;
                    var aa = (from table in CommonDictionary4Monitor.DataSource.ticket_type.AsEnumerable()
                             where table.VEH_TYPE_ID == dt.Rows[0]["Type"].ConvertToInt() && table.TYPE == LuotThangQuy
                             select table.TICK_TYPE_FEE).ToList();
                    int StandardPrice = aa[0].ConvertToInt();

                    lblStandard_Price.Text =String.Format("{0} VNĐ", StandardPrice.ToString("0,0"));
                    if (StandardPrice != Price)
                    {
                        lblWarmning.ForeColor = Color.OrangeRed;
                        lblWarmning.Text = "Lượt soát vé không khớp với thông tin xe chuẩn";
                    }
                    else
                    {
                        lblWarmning.ForeColor = Color.Green;
                        lblWarmning.Text = "Lượt soát vé khớp với thông tin xe chuẩn";
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void resetStandardVehicle()
        {
            lblStandard_Price.Text = "";
            lblStandard_UpdateDate.Text = "";
            lblStandard_UpdatePerson.Text = "";
            lblStandard_VehNum.Text = "";
            lblStandard_VehType.Text = "";
            lblWarmning.Text = "";
        }
                
        private void mc_Image_Opening(object sender, CancelEventArgs e)
        {

        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {                
                using (Bitmap currentImage = (Bitmap)Pic_Mtc.EditValue)
                {
                    using (Bitmap saveImage = new Bitmap(currentImage, Pic_Mtc.ClientSize.Width, Pic_Mtc.ClientSize.Height))
                    {
                        saveImage.Save("M_Image.png");
                    }
                }

                var p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\M_Image.png";

                p.StartInfo.Verb = "Print";
                p.Start();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra lại địa chỉ máy in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error(ex);
            }
            
        }               

        private void inMànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width,
                          Screen.PrimaryScreen.WorkingArea.Height,
                          PixelFormat.Format32bppArgb))
                {

                    Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);


                    gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.WorkingArea.X,
                                                Screen.PrimaryScreen.WorkingArea.Y,
                                                0,
                                                0,
                                                Screen.PrimaryScreen.WorkingArea.Size,
                                                CopyPixelOperation.SourceCopy);

                    bmpScreenshot.Save("M_Screenshot.png", ImageFormat.Png);
                }

                var p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\M_Screenshot.png";
                
                p.StartInfo.Verb = "Print";
                p.Start();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra lại địa chỉ máy in","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error(ex);
            }
        }             

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Bitmap currentImage = (Bitmap)Pic_Mtc.EditValue)
            {
                using (Bitmap saveImage = new Bitmap(currentImage, Pic_Mtc.ClientSize.Width, Pic_Mtc.ClientSize.Height))
                {
                    try
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                        ImageFormat format = ImageFormat.Png;
                        if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            string ext = System.IO.Path.GetExtension(sfd.FileName);
                            switch (ext)
                            {
                                case ".jpg":
                                    format = ImageFormat.Jpeg;
                                    break;
                                case ".bmp":
                                    format = ImageFormat.Bmp;
                                    break;
                            }
                            saveImage.Save(sfd.FileName, format);
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex);
                    }
                }
            }
        }

        #region Zoom Image
     

        private void Pic_Mtc_Properties_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                Console.WriteLine(e.Delta);
                if (e.Delta > 0 && Pic_Mtc.Properties.ZoomPercent < 500)
                {
                    Pic_Mtc.Properties.ZoomPercent += 50;
                    DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
                else if (e.Delta < 0 && Pic_Mtc.Properties.ZoomPercent >= 135)
                {
                    Pic_Mtc.Properties.ZoomPercent -= 50;
                    DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion
    }

    public class VehicleStandard
    {
        public string VehicleNumber { get; set; }
        public DateTime TimeBegin { get; set; }
    }
}