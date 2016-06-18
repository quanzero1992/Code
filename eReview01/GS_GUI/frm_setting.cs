using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using eReview01.CommonUI;


namespace eMonitor01
{
    public partial class Frm_Setting : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Setting()
        {
            InitializeComponent();
            
        }
        private Logger logger = LogManager.GetLogger(typeof(Frm_Setting).Name);

        RepositoryItemCheckEdit ritem;
        GridColumn col;
        private MyCache _Cache = new MyCache("SoHieuLan");
        bool indicatorIcon = true;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // shortcut 4 button
        {
            if (keyData == (System.Windows.Forms.Keys.Escape))
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }     
       
        private void Frm_Setting_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectDb con = new ConnectDb();
                DataTable dt = con.DoDuLieuProcedure("proc_Monitor_ConfigChooseLane");
                dt.Columns.Add("IsMonitor", typeof(bool));
                gridControl1.DataSource = dt;
                CreateUnboundColumn();
                ritem = new RepositoryItemCheckEdit();
                ritem.AllowGrayed = false;

                checkTuDongPhatHienNghiNgo.AutoSizeInLayoutControl = true;                

                // doc file setting.xml]
                set_TimeRunSlideShow.Value = 1;
                set_TimeLoadData.Value = 1;
                    GetInfoSetting();
                    
            }
            catch (Exception ex)
            {
                logger.Error("Error load setting by: " + ex);
            }           
        }       
///

        private void GetInfoSetting()
        {
            MonitorSetting.LoadFile();
            color0Loi1.Color = Color.FromArgb(MonitorSetting.Color0Loi1);
            color0Loi2.Color = Color.FromArgb(MonitorSetting.Color0Loi2);
            colorChuaXuLy1.Color = Color.FromArgb(MonitorSetting.ColorChuaXuLy1);
            colorChuaXuLy2.Color = Color.FromArgb(MonitorSetting.ColorChuaXuLy2);
            colorCoLoi1.Color = Color.FromArgb(MonitorSetting.ColorCoLoi1);
            colorCoLoi2.Color = Color.FromArgb(MonitorSetting.ColorCoLoi2);
            colorDaXem1.Color = Color.FromArgb(MonitorSetting.ColorDaXem1);
            colorDaXem2.Color = Color.FromArgb(MonitorSetting.ColorDaXem2);
            set_TimeLoadData.Value = MonitorSetting.TimeAutoLoadDb;
            set_TimeRunSlideShow.Value = MonitorSetting.TimeRunSlideshow;
            checkTuDongPhatHienNghiNgo.Checked = MonitorSetting.TuDongPhatHienNghiNgo;
            checkTuDongXuLyBanGhiDaXem.Checked = MonitorSetting.TuDongXuLyBanGhiDaXem;
            GetLane();
        }

        private void GetLane()
        {
            try
            {
                var lane = MonitorSetting.ChooseLane;
                string[] LaneString = lane.Split(',');
                if (LaneString.Length == 0 || (LaneString.Length == 1 && string.IsNullOrEmpty(LaneString[0])))
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        gridView1.SetRowCellValue(i, col, true);
                    }
                }
                else
                {
                    foreach (string item in LaneString)
                    {
                        if (string.IsNullOrEmpty(item)) continue;
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            if (gridView1.GetRowCellValue(i, "SoHieuLan").ToString() == item)
                            {
                                gridView1.SetRowCellValue(i, col, true);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Frm_Config frm = new Frm_Config();
            //frm.Show();
            Frm_Login.ToRestart = true;
            //RestartApp(0, "GS_GUI.exe");
        }

        void RestartApp(int pid, string applicationName)
        {
            // Wait for the process to terminate
            Process process = null;
            try
            {
                process = Process.GetProcessById(pid);
                process.WaitForExit(1000);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            Process.Start(applicationName, "");
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {           
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, col) != null && gridView1.GetRowCellValue(i, col).ToString().Equals("True"))
                    {
                        sb.Append(string.Format("{0},",gridView1.GetRowCellValue(i,"SoHieuLan")));
                    }
                }
                if (sb.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                MonitorSetting.TimeAutoLoadDb = Convert.ToInt32(set_TimeLoadData.Value);
                MonitorSetting.TimeRunSlideshow = Convert.ToInt32(set_TimeRunSlideShow.Value);
                MonitorSetting.Color0Loi1 = color0Loi1.Color.ToArgb();
                MonitorSetting.Color0Loi2 =  color0Loi2.Color.ToArgb();
                MonitorSetting.ColorCoLoi1 =  colorCoLoi1.Color.ToArgb();
                MonitorSetting.ColorCoLoi2 = colorCoLoi2.Color.ToArgb();
                MonitorSetting.ColorDaXem1 = colorDaXem1.Color.ToArgb();
                MonitorSetting.ColorDaXem2 =  colorDaXem2.Color.ToArgb();
                MonitorSetting.ColorChuaXuLy1 = colorChuaXuLy1.Color.ToArgb();
                MonitorSetting.ColorChuaXuLy2 = colorChuaXuLy2.Color.ToArgb();
                MonitorSetting.TuDongXuLyBanGhiDaXem = checkTuDongXuLyBanGhiDaXem.Checked;
                MonitorSetting.TuDongPhatHienNghiNgo = checkTuDongPhatHienNghiNgo.Checked;
                MonitorSetting.ChooseLane = sb.ToString();
                // viết các thông số cấu hình vào file Setting Xml
                MonitorSetting.WriteFile();
                logger.Info("Save Setting: ");
                logger.Info("TimeLoadData: " + set_TimeLoadData.Value.ToString());
                logger.Info("TimeRunSlideShow: " + set_TimeRunSlideShow.Value.ToString());
                logger.Info("BackColorRow Khong Loi: " + color0Loi1.Color.ToArgb().ToString() + " & " + color0Loi2.Color.ToArgb().ToString());
                logger.Info("BackColorRow Co Loi: " + colorCoLoi1.Color.ToArgb().ToString() + " & " + colorCoLoi2.Color.ToArgb().ToString());
                logger.Info("BackColorRow Da Xem: " + colorDaXem1.Color.ToArgb().ToString() + " & " + colorDaXem2.Color.ToArgb().ToString());
                logger.Info("BackColorRow Chua Xu Ly: " + colorChuaXuLy1.Color.ToArgb().ToString() + " & " + colorChuaXuLy2.Color.ToArgb().ToString());
                logger.Info("checkTuDongXuLyBanGhiDaXem: " + checkTuDongXuLyBanGhiDaXem.Checked.ToString());
                logger.Info("checkTuDongPhatHienNghiNgo: " + checkTuDongPhatHienNghiNgo.Checked.ToString());
                logger.Info("Chooselane: " + sb.ToString());
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }              
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = _Cache.GetValue(e.Row);
            if (e.IsSetData)
                _Cache.SetValue(e.Row, e.Value);   
        }

        private void CreateUnboundColumn()
        {
            col = gridView1.Columns.AddVisible("IsMonitor", "Giám sát");
            col.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            col.ColumnEdit = ritem;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 10;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_ConfigLane frm = new Frm_ConfigLane();
            frm.Show();
        }               
    }
}