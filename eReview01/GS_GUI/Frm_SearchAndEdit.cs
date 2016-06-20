using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Base;
using MySql.Data.MySqlClient;
using System.Threading;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid;
using System.IO;
using eReview01.CommonUI;
using log4netDatabase;
using System.Linq;
using System.Drawing.Imaging;
using DevExpress.Utils;

namespace eMonitor01
{
    public partial class Frm_SearchAndEdit : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SearchAndEdit()
        {
            //Thread t = new Thread(new ThreadStart(Waitting));
            //t.Start();
            Cursor.Current = Cursors.AppStarting;
            InitializeComponent();
            //t.Abort();
            Cursor.Current = Cursors.Default;
            pic_ImgBs.MouseWheel += pic_ImgBs_MouseWheel;
        }

      
        ConnectDb con = new ConnectDb();
        DataTable dt ;
        int LocLoi = 101;
        DateTime dtfrom; // gán giá trị time xét vào đây
        DateTime dtto;
        private Logger logger = LogManager.GetLogger(typeof(Frm_SearchAndEdit).Name);
        private LoggerDb logDb = LogDbManager.GetLogger(typeof(Frm_SearchAndEdit), (int)eReview01.CommonUI.Enumeration.eReview_Monitor.giám_sát);
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // shortcut 4 button
        {
            if (keyData == (System.Windows.Forms.Keys.Up))
                //grd_HistoryGs.FocusedRowHandle--;

            if (keyData == (System.Windows.Forms.Keys.Down))
                //grd_HistoryGs.FocusedRowHandle++;

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
                LoadDb();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void KtraCheckLoi()
        {
            try
            {
                if (checkEdit_Loi.Checked == true && checkEdit_KhongLoi.Checked == true)
                    LocLoi = 101;
                else if (checkEdit_Loi.Checked == false && checkEdit_KhongLoi.Checked == true)
                    LocLoi = 0;
                else if (checkEdit_Loi.Checked == true && checkEdit_KhongLoi.Checked == false)
                    LocLoi = 100;
                else
                    LocLoi = 102;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }            
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
                XtraMessageBox.Show(Properties.Resources.DisconnectDb, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Khoa(bool key)
        {
            if (key==true)
            {
                Dt_loc.Enabled = false;
                //timeEdit1.EditValue=User_Login.LoginDateTime;
                //dateEdit1.EditValue = User_Login.LoginDateTime;
            }
        }

        public DateTime todate{set;get;}
        public void DatLaiTime(DateTime date)
        {
            Dt_loc.ToDate = date;
        }

        private void Frm_SearchAndEdit_Load(object sender, EventArgs e)
        {
            grid_SearchAndEdit.EmbeddedNavigator.TextStringFormat = "Bản ghi {0} / {1}";
            grid_SearchAndEdit.EmbeddedNavigator.Size = new Size(1000,10);
            //CheckConnectionDb();
            

            try
            {
                Dt_loc.FromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);                            
              //  Dt_loc.ToDate =new DateTime( DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,23,23,59);  
                DatLaiTime(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59));           
                dtfrom = Dt_loc.FromDate;
                dtto = Dt_loc.ToDate;             
                grid_SearchAndEdit.Refresh();
                LoadDb();
                if (grd_HistoryGs.RowCount == 0)
                    KhoaButtonLoi(true);

                if (grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi") != null)
                {
                     if (grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString().Equals("0"))
                    OldErr = "không lỗi";
                     else
                    OldErr = "lỗi loại " + grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString();
                }
                if (CommonDictionary4Monitor.DataSource.error_type != null)
                {
                    repError.DataSource = CommonDictionary4Monitor.DataSource.error_type;
                    repError.DisplayMember = CommonDictionary4Monitor.DataSource.error_type.ERR_TYPE_DESCColumn.ColumnName;
                    repError.ValueMember = CommonDictionary4Monitor.DataSource.error_type.ERR_TYPE_IDColumn.ColumnName;
                }
                else
                {
                    CommonDictionary4Monitor.LoadAllDictionary();
                }
                GridView view = grd_HistoryGs;
                view.Appearance.FocusedRow.BackColor = Color.Transparent;
                
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }           
        }

        public void LoadDb()
        {          
           // CheckConnectionDb();
            try
            {             
                ConnectDb con = new ConnectDb();
                if (con.CheckConnectDb() == true)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    GridView view = (GridView)grid_SearchAndEdit.MainView;
                    int index = view.FocusedRowHandle;
                    int topVisibleIndex = view.TopRowIndex;
                    KtraCheckLoi();
                    DataTable dt = new DataTable();
                    dt = con.SearchAndEdit(User_Login.Id, LocLoi, dtfrom, dtto, MonitorSetting.ChooseLane);
                    grd_HistoryGs.BeginDataUpdate();
                    grid_SearchAndEdit.DataSource = dt;
                    if (view != null)
                    {
                        view.FocusedRowHandle = index;
                        view.TopRowIndex = topVisibleIndex;
                    }
                    grd_HistoryGs.EndDataUpdate();
                    //NotChangeRowAfterReLoadDb();
                    LoadInfo();
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    XtraMessageBox.Show(Properties.Resources.CheckConnection, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Connect Db Failed");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }            
        }

        private void NotChangeRowAfterReLoadDb()
        {
            try
            {
                int[] index = grd_HistoryGs.GetSelectedRows(); // laays index cua dong dang select
                //MessageBox.Show(a[0].ToString());             
                int tong = grd_HistoryGs.RowCount;
                if (index[0] + 1 == tong)
                {
                    grd_HistoryGs.FocusedRowHandle--;
                    grd_HistoryGs.FocusedRowHandle++;
                }
                else
                {
                    grd_HistoryGs.FocusedRowHandle++;
                    grd_HistoryGs.FocusedRowHandle--;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }           
        }

        public void LoadLookupLan(DevExpress.XtraEditors.LookUpEdit cb, string tencot1, string tencot2, string tencot3, string tencot4, string truongcot1, string truongcot2,string truongcot3, string truongcot4, string proc, string DisplayMember, string ValueMember)
        {
            try
            {
                cb.Refresh();
                cb.Properties.Columns.Clear();
                cb.Properties.DataSource = con.DoDuLieuProcedure(proc);
                cb.Properties.DisplayMember = DisplayMember;
                cb.Properties.ValueMember = ValueMember;
                cb.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
                        {
                            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(truongcot1,tencot1),
                            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(truongcot2,tencot2),
                            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(truongcot3,tencot3),
                            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(truongcot4,tencot4),
                        });
                cb.Properties.Columns[truongcot1].Width = 100;
                cb.Properties.Columns[truongcot2].Width = 300;
                cb.Properties.Columns[truongcot3].Width = 300;
                cb.Properties.Columns[truongcot4].Width = 300;
                cb.ClosePopup();
                cb.ItemIndex = 1;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }       

        private void checkEdit_Loi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                grid_SearchAndEdit.Refresh();
                KtraCheckLoi();
                dt = new DataTable();
                dt = con.SearchAndEdit(User_Login.Id, LocLoi, dtfrom, dtto,MonitorSetting.ChooseLane);
                grid_SearchAndEdit.DataSource = dt;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }           
        }

        private void checkEdit_KhongLoi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                grid_SearchAndEdit.Refresh();
                KtraCheckLoi();
                dt = new DataTable();
                dt = con.SearchAndEdit(User_Login.Id, LocLoi, dtfrom, dtto, MonitorSetting.ChooseLane);
                grid_SearchAndEdit.DataSource = dt;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }          
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                if (grd_HistoryGs.RowCount == 0)
                    KhoaButtonLoi(true);
                else LoadInfo();
                GridView gridview = ((GridView)sender);
                if (!gridview.GridControl.IsHandleCreated) return;
                Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
                SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
                gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 10;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }           
        }

        bool indicatorIcon = true;      
        private void gridView1_CustomDrawRowIndicator_1(object sender, RowIndicatorCustomDrawEventArgs e)
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
                logger.Error( ex);
            }          
        }

        private void btn_Loi0_Click(object sender, EventArgs e)
        {
            string id = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaGs").ToString();
            try
            {
                ConnectDb cn = new ConnectDb();
                string BienSo = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "BienSo").ToString();
                string LinkAnh = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "HinhAnh").ToString();
                string ThuPhiVien = grd_HistoryGs.GetRowCellDisplayText(grd_HistoryGs.FocusedRowHandle, "ThuPhiVien").ToString();
                if (!string.IsNullOrEmpty(BienSo) && !string.IsNullOrWhiteSpace(BienSo))
                {
                    cn.UpdateError(id, 0);
                    VehicleStandardProcess(BienSo);
                    if (!grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString().Trim().Equals("0"))
                        logDb.Save(string.Format("User {0} thay đổi {1} thành không lỗi lượt xe có mã {2} \n Biển số: {3} \n Link ảnh: {4} \n Thu phí viên: {5}", User_Login.Name, OldErr, id, BienSo, LinkAnh, ThuPhiVien), (int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);

                    LoadDb();
                }
                else
                    XtraMessageBox.Show("Đây là trường hợp hệ thống không trả về biển số (Lỗi loại 3) bạn không thể tick không lỗi", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!");
                logger.Error("User: " + User_Login.Name + " try tick 'Khong loi' for record '" + id + "' and Failure! by error " + ex, false);
            }
        }

        private void btn_Loi1_Click(object sender, EventArgs e)
        {
            string id = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle,"MaGs").ToString();
            try
            {
                ConnectDb cn = new ConnectDb();
                cn.UpdateError(id, 1);
                if (!grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString().Trim().Equals("1"))
                {
                    string BienSo = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "BienSo").ToString();
                    string LinkAnh = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "HinhAnh").ToString();
                    string ThuPhiVien = grd_HistoryGs.GetRowCellDisplayText(grd_HistoryGs.FocusedRowHandle, "ThuPhiVien").ToString();
                    logDb.Save(string.Format("User {0} thay đổi {1} thành lỗi loại 1 lượt xe có mã {2} \n Biển số: {3} \n Link ảnh: {4} \n Thu phí viên: {5}", User_Login.Name, OldErr, id, BienSo, LinkAnh, ThuPhiVien), (int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                    int VehType = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "LoaiXe").ConvertToInt();
                    if(!string.IsNullOrEmpty(BienSo) && VehType > 0)
                    RemoveVehicleStandard(BienSo, VehType);
                }
                LoadDb();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection,"Thất bại!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 1' for record '" + id + "' and Failure! by error " + ex, false);
            }
           
        }

        private void btn_Loi2_Click(object sender, EventArgs e)
        {
            string id = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaGs").ToString();
            try
            {
                ConnectDb cn = new ConnectDb();
                cn.UpdateError(id, 2);
                if (!grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString().Trim().Equals("2"))
                {
                    string BienSo = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "BienSo").ToString();
                    string LinkAnh = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "HinhAnh").ToString();
                    string ThuPhiVien = grd_HistoryGs.GetRowCellDisplayText(grd_HistoryGs.FocusedRowHandle, "ThuPhiVien").ToString();
                    logDb.Save(string.Format("User {0} thay đổi {1} thành lỗi loại 2 lượt xe có mã {2} \n Biển số: {3} \n Link ảnh: {4} \n Thu phí viên: {5}", User_Login.Name, OldErr, id, BienSo, LinkAnh, ThuPhiVien), (int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                }
                LoadDb();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!");
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 2' for record '" + id + "' and Failure! by error " + ex, false);
            }
            
        }

        private void btn_Loi3_Click(object sender, EventArgs e)
        {
            string id = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaGs").ToString();
            try
            {
                ConnectDb cn = new ConnectDb();
                cn.UpdateError(id, 3);
                if (!grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString().Trim().Equals("3"))
                {
                    string BienSo = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "BienSo").ToString();
                    string LinkAnh = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "HinhAnh").ToString();
                    string ThuPhiVien = grd_HistoryGs.GetRowCellDisplayText(grd_HistoryGs.FocusedRowHandle, "ThuPhiVien").ToString();
                    logDb.Save(string.Format("User {0} thay đổi {1} thành lỗi loại 3 lượt xe có mã {2} \n Biển số: {3} \n Link ảnh: {4} \n Thu phí viên: {5}", User_Login.Name, OldErr, id, BienSo, LinkAnh, ThuPhiVien), (int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                }
                LoadDb();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!");
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 3' for record '" + id + "' and Failure! by error " + ex, false);
            }           
        }

        private void btn_Loi4_Click(object sender, EventArgs e)
        {
            string id = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaGs").ToString();
            try
            {                
                ConnectDb cn = new ConnectDb();
                cn.UpdateError(id, 4);
                if (!grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString().Trim().Equals("4"))
                {
                    string BienSo = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "BienSo").ToString();
                    string LinkAnh = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "HinhAnh").ToString();
                    string ThuPhiVien = grd_HistoryGs.GetRowCellDisplayText(grd_HistoryGs.FocusedRowHandle, "ThuPhiVien").ToString();
                    logDb.Save(string.Format("User {0} thay đổi {1} thành lỗi loại 4 lượt xe có mã {2} \n Biển số: {3} \n Link ảnh: {4} \n Thu phí viên: {5}", User_Login.Name, OldErr, id, BienSo, LinkAnh, ThuPhiVien), (int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                }
                LoadDb();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!");
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 4' for record '" + id + "' and Failure! by error " + ex, false);
            }          
        }

        private void btn_Loi5_Click(object sender, EventArgs e)
        {
            string id = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaGs").ToString();
            try
            {                
                ConnectDb cn = new ConnectDb();
                cn.UpdateError(id, 5);
                if (!grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString().Trim().Equals("5"))
                {
                    string BienSo = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "BienSo").ToString();
                    string LinkAnh = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "HinhAnh").ToString();
                    string ThuPhiVien = grd_HistoryGs.GetRowCellDisplayText(grd_HistoryGs.FocusedRowHandle, "ThuPhiVien").ToString();
                    logDb.Save(string.Format("User {0} thay đổi {1} thành lỗi loại 5 lượt xe có mã {2} \n Biển số: {3} \n Link ảnh: {4} \n Thu phí viên: {5}", User_Login.Name, OldErr, id, BienSo, LinkAnh, ThuPhiVien), (int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                }
                LoadDb();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!");
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 5' for record '" + id + "' and Failure! by error " + ex, false);
            }            
        }

        // OldErr : Lỗi loại + ...
        private void btn_Loi6_Click(object sender, EventArgs e)
        {
            string id = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaGs").ToString();
            try
            {               
                ConnectDb cn = new ConnectDb();
                cn.UpdateError(id, 6);
                if (!grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString().Trim().Equals("6"))
                {
                    string BienSo = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "BienSo").ToString();
                    string LinkAnh = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "HinhAnh").ToString();
                    string ThuPhiVien = grd_HistoryGs.GetRowCellDisplayText(grd_HistoryGs.FocusedRowHandle, "ThuPhiVien").ToString();
                    logDb.Save(string.Format("User {0} thay đổi {1} thành lỗi loại 6 lượt xe có mã {2} \n Biển số: {3} \n Link ảnh: {4} \n Thu phí viên: {5}", User_Login.Name, OldErr, id, BienSo, LinkAnh, ThuPhiVien), (int)eReview01.CommonUI.Enumeration.FormAction.tích_lỗi);
                }
                LoadDb();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.CheckConnection, "Thất bại!");
                logger.Error("User: " + User_Login.Name + " try tick 'Loi loai 6' for record '" + id + "' and Failure! by error " + ex, false);
            }
            
        }
                
        string path;
        private void grd_HistoryGs_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {                
                LoadInfo();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void KhoaButtonLoi(bool key)
        {
            try
            {
                if (key == true)
                {
                    btn_Loi0.Enabled = false;
                    btn_Loi1.Enabled = false;
                    btn_Loi2.Enabled = false;
                    btn_Loi3.Enabled = false;
                    btn_Loi4.Enabled = false;
                    btn_Loi5.Enabled = false;
                    btn_Loi6.Enabled = false;
                }
                else
                {
                    btn_Loi0.Enabled = true;
                    btn_Loi1.Enabled = true;
                    btn_Loi2.Enabled = true;
                    btn_Loi3.Enabled = true;
                    btn_Loi4.Enabled = true;
                    btn_Loi5.Enabled = true;
                    btn_Loi6.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void Dt_loc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtfrom = Dt_loc.FromDate;
                dtto = Dt_loc.ToDate;              
                LoadDb();
                if (grd_HistoryGs.RowCount==0)
                {
                    path = "";
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }            
        }

      private void grd_HistoryGs_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            try
            {
                if (e.Column.Equals(colErrorType))
                {
                    if(Convert.ToInt32(e.Value) == 1)
                    ripeErrorType.InitialImage = Properties.Resources.error;
                    else
                        ripeErrorType.InitialImage = Properties.Resources.error1;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void grd_HistoryGs_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
        }
        
        private void grd_HistoryGs_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                // thay doi mau ca dong
                GridView view = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    string error = view.GetRowCellValue(e.RowHandle, view.Columns["MaLoi"]).ToString();
                    //   string errorId = view.GetRowCellDisplayText(e.RowHandle, view.Columns.fi["Mã lỗi"]);
                    if (error == "0") // set màu cho row không lỗi
                    {
                            e.Appearance.BackColor = Color.FromArgb(MonitorSetting.Color0Loi1);
                            e.Appearance.BackColor2 = Color.FromArgb(MonitorSetting.Color0Loi2);
                    }
                    else if (error == "99") // set màu bản ghi chưa xử lý
                    {
                            e.Appearance.BackColor = Color.FromArgb(MonitorSetting.ColorChuaXuLy1);
                            e.Appearance.BackColor2 = Color.FromArgb(MonitorSetting.ColorChuaXuLy2);
                   
                    }
                    else // còn lại bản ghi có lỗi
                    {
                            e.Appearance.BackColor = Color.FromArgb(MonitorSetting.ColorCoLoi1);
                            e.Appearance.BackColor2 = Color.FromArgb(MonitorSetting.ColorCoLoi2);
                    
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            
        }   

        private void pic_ImgBs_MouseMove(object sender, MouseEventArgs e)
        {
                     
        }
       
        private void pic_ImgBs_MouseLeave(object sender, EventArgs e)
        {
                pic_BsDetail.Visible = false;
        }

        private void pic_ImgBs_MouseHover(object sender, EventArgs e)
        {
            int chieurong, chieucao; // width, height screen
            chieurong = ClientRectangle.Width;
            chieucao = ClientRectangle.Height;

            pic_BsDetail.Visible = true;
            pic_BsDetail.Location = new Point((chieurong - 642 )/2, (chieucao - 522)/2 - 50);
            pic_BsDetail.Size = new Size(642, 522);          
            pic_BsDetail.LoadAsync(path);
        }

        private void Frm_SearchAndEdit_Activated(object sender, EventArgs e)
        {
            try
            {
                LoadDb();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void LoadInfo()
        {
            try
            {
                int dong = grd_HistoryGs.FocusedRowHandle;
                int tong = grd_HistoryGs.RowCount;
                if (tong != 0)
                {
                    try
                    {
                        if (grd_HistoryGs.FocusedRowHandle < 0 || grd_HistoryGs.FocusedRowHandle >= grd_HistoryGs.RowCount) return;
                        lbl_BienSo.Text = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle , "BienSo").ToString();
                        lbl_loaixe.Text = dictionaryVehType(grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "LoaiXe").ConvertToInt());
                        lbl_LoaiVe.Text = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "LoaiVe").ToString();
                        lbl_PhiThu.Text = (String.Format("{0:0,0 VNĐ}", grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "Phi"))).Replace(',', '.');
                        lbl_ThuPhiVien.Text = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "ThuPhiVien").ToString();
                        //Console.WriteLine("------->" + grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "ThoiDiemThongXe").ToString());
                        lbl_ThoiDiem.Text = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "ThoiDiemThongXe").ConvertToDateTime().ToString("HH:mm:ss - dd/MM/yyyy");
                        pic_ImgBs.LoadAsync(@grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "HinhAnh").ToString());
                        path = @grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "HinhAnh").ToString();
                        lbl_KqGs.Text = grd_HistoryGs.GetRowCellDisplayText(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString();
                        pic_BsDetail.LoadAsync(path);
                        if (LocLoi == 102)
                        {
                            lbl_MaNVGS.Text = "";
                            lbl_HoTenGS.Text = "";
                            lbl_ThoiDiemDanhLoi.Text = "";
                            lbl_KqGs.Text = "";
                        }
                        else
                        {
                            lbl_MaNVGS.Text = User_Login.Id;
                            lbl_HoTenGS.Text = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "GiamSatVien").ToString();                            
                            //lbl_ThoiDiemDanhLoi.Text = ((DateTime)grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "ThoiDiemDanhLoi")).ToString("HH:mm:ss - dd/MM/yyyy");
                            lbl_ThoiDiemDanhLoi.Text = grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "ThoiDiemDanhLoi").ConvertToDateTime().ToString("HH:mm:ss - dd/MM/yyyy");

                            DateTime a = Convert.ToDateTime(grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "ThoiDiemDanhLoi"));
                            DateTime SetTimeCheckError = new DateTime(User_Login.LoginDateTime.Year, User_Login.LoginDateTime.Month, User_Login.LoginDateTime.Day, 00, 00, 00);
                            if (a <= SetTimeCheckError)
                            {
                                KhoaButtonLoi(true);
                            }
                            else
                            {
                                KhoaButtonLoi(false);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        logger.Error(ex);
                    }
                }
                else
                {
                    lbl_BienSo.Text = "";
                    lbl_loaixe.Text = "";
                    lbl_LoaiVe.Text = "";
                    lbl_PhiThu.Text = "";
                    lbl_ThuPhiVien.Text = "";
                    lbl_HoTenGS.Text = "";
                    lbl_MaNVGS.Text = "";
                    lbl_ThoiDiem.Text = "";
                    lbl_ThoiDiemDanhLoi.Text = "";
                    lbl_KqGs.Text = "";
                    pic_ImgBs.LoadAsync("");
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        string OldErr;
        private void lbl_KqGs_TextChanged(object sender, EventArgs e)
        {
            if (grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi") != null)
            {
             if (grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString().Equals("0"))
                OldErr = "không lỗi";
            else
                OldErr = "lỗi loại " + grd_HistoryGs.GetRowCellValue(grd_HistoryGs.FocusedRowHandle, "MaLoi").ToString();
            }    
        }

        private void Frm_SearchAndEdit_Shown(object sender, EventArgs e)
        {
            try
            {
                logDb.iread = false;
            }
            catch (Exception ex)
            {
                logDb.Error(ex);
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
                if (grd_HistoryGs.RowCount == 0)
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
                logDb.Error(string.Format("Không thể xóa xe '{0}' khỏi dữ liệu xe chuẩn, lỗi \n{1}",vehNum,ex.ToString()));
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Frm_VideoPlaybackForm frm = new Frm_VideoPlaybackForm();
            int index = grd_HistoryGs.FocusedRowHandle;
            int Lane_id = grd_HistoryGs.GetRowCellValue(index, "Lan").ConvertToInt();
            frm.IPCamera = CommonDictionary4Monitor.DataSource.cf_lane.FirstOrDefault(x => x.LANE_ID == Lane_id).LANE_CAMERA_IP.ToString();
            frm.TransBegin = grd_HistoryGs.GetRowCellValue(index, "ThoiDiemXeVao").ConvertToDateTime();
            frm.TransEnd = grd_HistoryGs.GetRowCellValue(index, "ThoiDiemThongXe").ConvertToDateTime();

            frm.ShowDialog();
        }

        private void lbl_ThuPhiVien_Click(object sender, EventArgs e)
        {

        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap currentImage = (Bitmap)pic_BsDetail.EditValue;
            Bitmap saveImage = new Bitmap(currentImage, pic_BsDetail.ClientSize.Width, pic_BsDetail.ClientSize.Height);
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
            finally
            {
                currentImage.Dispose();
                saveImage.Dispose();
            }
        }

        private void inMànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument myPrintDocument2 = new System.Drawing.Printing.PrintDocument();
            PrintDialog myPrinDialog2 = new PrintDialog();
            myPrintDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument1_PrintPage);
            myPrinDialog2.Document = myPrintDocument2;

            if (myPrinDialog2.ShowDialog() == DialogResult.OK)
            {
                myPrintDocument2.Print();
            }
        }

        private void myPrintDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Bitmap myBitmap2 = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width,
                           Screen.PrimaryScreen.WorkingArea.Height,
                           PixelFormat.Format32bppArgb))
            {
                this.DrawToBitmap(myBitmap2, new Rectangle(0, 0, Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height));
                e.Graphics.DrawImage(myBitmap2, 0, 0);
                myBitmap2.Save("ScreenShoot.png",ImageFormat.Png);
            }
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintDialog myPrinDialog1 = new PrintDialog();
            myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
            myPrinDialog1.Document = myPrintDocument1;

            if (myPrinDialog1.ShowDialog() == DialogResult.OK)
            {
                myPrintDocument1.Print();
            }
        }

        private void myPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap currentImage = (Bitmap)pic_BsDetail.EditValue;
            using (Bitmap saveImage = new Bitmap(currentImage, pic_BsDetail.ClientSize.Width, pic_BsDetail.ClientSize.Height))
            {
                saveImage.Save("Image.png",ImageFormat.Png);
                e.Graphics.DrawImage(saveImage, 0, 0);
            }
            currentImage.Dispose();
        }

        float zoomSpeedFactor = 0.1f;
        private void pic_ImgBs_Properties_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && pic_ImgBs.Properties.ZoomPercent < 500)
            {
                pic_ImgBs.Properties.ZoomPercent += 50;
                pic_BsDetail.Properties.ZoomPercent += 50;
                DXMouseEventArgs.GetMouseArgs(e).Handled = true;
            }
            else if (e.Delta < 0 && pic_ImgBs.Properties.ZoomPercent >= 150)
            {
                pic_ImgBs.Properties.ZoomPercent -= 50;
                pic_BsDetail.Properties.ZoomPercent -= 50;
                DXMouseEventArgs.GetMouseArgs(e).Handled = true;
            }
            else
                return;
        }

        private void pic_ImgBs_MouseWheel(object sender, MouseEventArgs e)
        {
            
        }
        
    }

    public class MyFindControl : FindControl
    {
        public MyFindControl(ColumnView view, object findPanelProperties)
            : base(view, findPanelProperties)
        {
            lciFindButton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciFind.Text = "Biển số: ";
            
            lciFind.TextVisible = true;
            
            teFind.Font = new Font("Tahoma", 10);
            teFind.Properties.NullValuePrompt = "Nhập biển số để tìm kiếm";
            this.teFind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            this.teFind.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.teFind_ButtonClick);
           
            //UpdateDropDownButtonVisibility();
            //teFind.Properties.Items.CollectionChanged += new CollectionChangeEventHandler(Items_CollectionChanged);
        }

        private void teFind_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (teFind.Properties.Buttons[1].Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                teFind.Text = "";
        }
        //void Items_CollectionChanged(object sender, CollectionChangeEventArgs e) {
        //    UpdateDropDownButtonVisibility();
        //}
        //private void UpdateDropDownButtonVisibility() {
        //    teFind.Properties.Buttons[0].Visible = teFind.Properties.Items.Count != 0;
        //}

    }

    public class MyGridView : GridView
    {
        protected override FindControl CreateFindPanel(object findPanelProperties)
        {
            return new MyFindControl(this, findPanelProperties);
        }
        //public void FocusFindEdit() {
        //    if (FindPanel != null) {
        //        FindPanel.Focus();
        //        FindPanel.FocusFindEdit();
        //    }
        //}
    }
}