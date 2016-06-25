using DevExpress.XtraEditors;
using eReview01.BL;
using eReview01.CommonUI;
using eReview01.Source.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using log4netDatabase;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace eReview01.Source.Review
{
    public partial class PostReviewDetail : eReview01.Source.Framework.FormDetailBase
    {
        #region Declaration
        private Logger logger = LogManager.GetLogger(typeof(PostReviewDetail));
        private BLVehicleInfo vehBLObject = new BLVehicleInfo();
        private Entities.DatasetReview tempSource = new Entities.DatasetReview();
        private LoggerDb logDb = LogDbManager.GetLogger(typeof(PostReviewDetail), (int)Enumeration.eReview_Monitor.hậu_kiểm);
        string OldVehNumber;
        #endregion

        #region Contructor
        public PostReviewDetail()
        {
            InitializeComponent();
            vehBLObject.DataSource = dsReview;
        }
        #endregion

        #region Properties
        
        #endregion

        #region Method
        protected override void InitCombo()
        {
            var oBL = new BL.BLBase(dsReview.vehicle_type.TableName, string.Empty, dsReview);
            oBL.GetAllData();
        }
        protected override void RefineDataObject()
        {
            base.RefineDataObject();
            bsLaneInfo.DataSource = DatasetBusiness;
            bsTCType.DataSource = DatasetBusiness;
            rileTC_Type.DataSource = bsTCType;
        }

        /// <summary>
        /// Nạp giá trị cho các control trên form khi chuyển bản ghi
        /// </summary>
        private void LoadFormValue()
        {
            var drCurrent = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
            SetEventKeypress(this);
            // Load lịch sử xe qua trạm trong ngày
            dsReview.tc_transaction.Clear();
            var thrCarPass = new System.Threading.Thread(LoadHistoryCarPass);
            thrCarPass.Start();
            bsTransaction.PositionChanged -= bsTransaction_PositionChanged;
            ResetVehicleInfo();
            //var oBL = new Bussiness.BLTransaction(dsReview);
            //dsReview.tc_transaction.Clear();
            //oBL.GetTransactionByCarNumberAndTime(drCurrent.TRANS_BEGIN.Date, drCurrent.TRANS_BEGIN.Date.AddDays(1).AddMilliseconds(-1),
            //    drCurrent[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName].ToString());
            //bsTransaction.PositionChanged -= bsTransaction_PositionChanged;
            //gcHistory.Text = string.Format(gcHistory.Tag.ToString(), dsReview.tc_transaction.Count);
            //var iPosition = 0;
            //for (int i = 0; i < dsReview.tc_transaction.Count; i++)
            //{
            //    if (drCurrent.TRANS_ID.Equals(dsReview.tc_transaction[i].TRANS_ID))
            //    {
            //        iPosition = i;
            //        break;
            //    }
            //}
            //bsTransaction.PositionChanged += bsTransaction_PositionChanged;
            //var oldPos = bsTransaction.Position;
            //bsTransaction.Position = iPosition;
            //if (oldPos == iPosition)
            //{
            //    LoadHistoryValue();
            //}
            // tmcuong 11/8/2015 rem lai
            //LoadHistoryValue((Entities.DatasetReview.tc_transactionRow)GetCurrentRow());
            var thrVehicleInfo = new System.Threading.Thread(GetVehicleInfo);
            thrVehicleInfo.Start();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void LoadHistoryCarPass()
        {
            try
            {
                tempSource = (Entities.DatasetReview)dsReview.Copy();
                tempSource.tc_transaction.Clear();
                var oBL = new BL.BLTransaction(tempSource);
                var drReview = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
                oBL.GetTransactionByCarNumberAndTime(drReview.TRANS_BEGIN.Date, drReview.TRANS_BEGIN.Date.AddDays(1).AddMilliseconds(-1),
                    drReview[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName].ToString(),drReview.TRANS_ID);
                SetPassCount();
            }
            catch (Exception ex)
            {
                logger.Error(ex, false);
            }
        }

        delegate void SetPassCountCallback();
        private void SetPassCount()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (lblVehRegDate.InvokeRequired)
            {
                SetPassCountCallback d = new SetPassCountCallback(SetPassCount);
                this.Invoke(d, new object[] {  });
            }
            else
            {
                dsReview = (Entities.DatasetReview)tempSource.Copy();
                bsTransaction.DataSource = dsReview;
                bsTransaction.PositionChanged -= bsTransaction_PositionChanged;
                gcHistory.Text = string.Format(gcHistory.Tag.ToString(), dsReview.tc_transaction.Count);
                var iPosition = 0;
                var drCurrent = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
                for (int i = 0; i < dsReview.tc_transaction.Count; i++)
                {
                    if (drCurrent.TRANS_ID.Equals(dsReview.tc_transaction[i].TRANS_ID))
                    {
                        iPosition = bsTransaction.Find(dsReview.tc_transaction.TRANS_IDColumn.ColumnName, dsReview.tc_transaction[i].TRANS_ID);
                        break;
                    }
                }
                bsTransaction.Position = iPosition;
                bsTransaction.PositionChanged += bsTransaction_PositionChanged;
                LoadHistoryValue((Entities.DatasetReview.tc_transactionRow)GetCurrentRow());
                //var oldPos = bsTransaction.Position;
                //bsTransaction.Position = iPosition;
                //if (oldPos == iPosition)
                //{
                //    LoadHistoryValue();
                //}
            }
        }
        private void ResetVehicleInfo()
        {
            lblVehRegDate.Text = string.Empty;
            lblVehRegSeat.Text = string.Empty;
            lblVehRegAddress.Text = string.Empty;
            lblVehRegOwn.Text = string.Empty;
            lblVehRegType.Text = string.Empty;
            lblVehRegLoad.Text = string.Empty;
        }
        private void GetVehicleInfo(string vehNumber = "")
        {
            if (string.IsNullOrEmpty(vehNumber))
            {
                var drCurrent = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
                if (drCurrent != null)
                {
                    vehNumber = drCurrent[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName].ToString();
                }
            }
            vehBLObject.GetVehicleInfoByNumber(vehNumber);
            var dtVehInfo = dsReview.vehicle_info;
            if (dtVehInfo != null && dtVehInfo.Count > 0)
            {
                lblVehRegDate.Text = string.Format("{0:dd/MM/yyyy}", dtVehInfo[0][dsReview.vehicle_info.VEH_INF_REG_DATEColumn.ColumnName].ToString());
                lblVehRegSeat.Text = dtVehInfo[0][dsReview.vehicle_info.VEH_INF_SEATColumn.ColumnName].ToString();
                lblVehRegAddress.Text = dtVehInfo[0][dsReview.vehicle_info.VEH_INF_ADDRColumn.ColumnName].ToString();
                lblVehRegOwn.Text = dtVehInfo[0][dsReview.vehicle_info.VEH_INF_OWNColumn.ColumnName].ToString();
                var drRegVehType = ((Entities.DatasetReview)DatasetBusiness).vehicle_type.FindByVEH_TYPE_ID(dtVehInfo[0][dsReview.vehicle_info.VEH_INF_TYPE_IDColumn.ColumnName].ConvertToInt());
                lblVehRegType.Text = drRegVehType != null ? drRegVehType.VEH_TYPE_NAME : string.Empty;
                lblVehRegLoad.Text = string.Format("{0:00.##} tấn", dtVehInfo[0][dsReview.vehicle_info.VEH_INF_LOADColumn.ColumnName].ConvertToDecimal());
            }
            else
            {
                ResetVehicleInfo();
            }
        }

        
        private void LoadHistoryValue(Entities.DatasetReview.tc_transactionRow drTrans = null)
        {
            if (drTrans == null)
            {
                drTrans = (Entities.DatasetReview.tc_transactionRow)((DataRowView)bsTransaction.Current).Row;
            }
            var dsSource = (Entities.DatasetReview)DatasetBusiness;
            lblBarCode.Text = drTrans[dsReview.tc_transaction.TRANS_BARCODEColumn.ColumnName].ToString();
            var iMNR = drTrans[dsReview.tc_transaction.ERR_TYPE_IDColumn.ColumnName].Equals
                (DBNull.Value) ? -9999 : drTrans[dsReview.tc_transaction.ERR_TYPE_IDColumn.ColumnName].ConvertToInt();
            var drError = dsSource.error_type.FindByERR_TYPE_ID(iMNR);
            lblError.Text = drError != null ? drError.ERR_TYPE_NAME + (string.IsNullOrEmpty(drError[dsReview.error_type.ERR_TYPE_DESCColumn.ColumnName].ToString())
                ? string.Empty : (" - " + drError[dsReview.error_type.ERR_TYPE_DESCColumn.ColumnName].ToString())) : Properties.Resources.MNR_NotInfo;
            var drLane = dsSource.lane_info.FindByLANE_INFO_ID(drTrans[dsReview.tc_transaction.LANE_INFO_IDColumn.ColumnName].ConvertToInt());
            lblLane.Text = drLane != null ? drLane.LANE_INFO_NUMBER.ToString() : string.Empty;
            var drMonitor = dsSource.user_info.FindByUSER_INFO_ID(drTrans[dsReview.tc_transaction.MNR_USER_IDColumn.ColumnName].ToString());
            lblMonitor.Text = drMonitor != null ? drMonitor.USER_INFO_FULL : string.Empty;
            var drTcType = dsSource.tc_type.FindByTC_TYPE_ID(drTrans[dsReview.tc_transaction.TRANS_TC_TYPEColumn.ColumnName].ConvertToInt());
            lblTc_Type.Text = drTcType != null ? drTcType[dsReview.tc_type.TC_TYPE_NAMEColumn.ColumnName].ToString() : string.Empty;
            var drTicketType = dsSource.ticket_type.FindByTICK_TYPE_ID(drTrans[dsReview.tc_transaction.TICK_TYPE_IDColumn.ColumnName].ConvertToInt());
            lblTicketType.Text = drTicketType != null ? drTicketType.TICK_TYPE_NAME : string.Empty;
            lblTransBegin.Text = string.Format("{0:dd/MM/yyyy HH:mm:ss}", drTrans.TRANS_BEGIN);
            lblTransFee.Text = string.Format("{0:#,#}", drTrans.TRANS_FEE);
            var drUser = dsSource.user_info.FindByUSER_INFO_ID(drTrans[dsReview.tc_transaction.USER_INFO_IDColumn.ColumnName].ToString());
            lblUser.Text = drUser != null ? drUser.USER_INFO_FULL : string.Empty;
            lblVehNumber.Text = drTrans.TRANS_VEH_NUMBER;
            var drVehType = dsSource.vehicle_type.FindByVEH_TYPE_ID(drTrans[dsReview.tc_transaction.TRANS_VEH_TYPEColumn.ColumnName].ConvertToInt());
            lblVehType.Text = drVehType != null ? drVehType.VEH_TYPE_NAME : string.Empty;
            pictureEdit1.LoadAsync(drTrans[dsReview.tc_transaction.TRANS_MIX_IMG_LINKColumn.ColumnName].ToString());
            txtVehNumberUpdate.Text = drTrans.TRANS_VEH_NUMBER;
        }

        protected override void MoveNext()
        {
            base.MoveNext();
            LoadFormValue();
        }

        protected override void MovePrevious()
        {
            base.MovePrevious();
            LoadFormValue();
        }

        #endregion

        #region Events

        private void SetEventKeypress(Control control)
        {
            control.KeyDown += item_KeyDown;
            foreach (Control item in control.Controls)
            {
                SetEventKeypress(item);
            }
        }
        private void PostReviewDetail_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblVehNumber.Text.Trim()))
                    OldVehNumber = "";
                else
                OldVehNumber = lblVehNumber.Text;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        void item_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void btnUpdateVehNumber_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var oBL = new BL.BLTransaction(dsReview);
                oBL.MasterRow = ((DataRowView)bsTransaction.Current).Row;
                if (oBL.MasterRow == null)
                {
                    return;
                }
                ((DataRowView)bsTransaction.Current).Row[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName] = txtVehNumberUpdate.Text;
                
                bsTransaction.EndEdit();
                if (oBL.Update())
                {
                    CommonFunction.ShowInfomationMessage(Properties.Resources.UpdateSuccess);
                    string MaLuotXe = ((DataRowView)bsTransaction.Current).Row[dsReview.tc_transaction.TRANS_IDColumn.ColumnName].ToString();
                    string LinkAnh = ((DataRowView)bsTransaction.Current).Row[dsReview.tc_transaction.TRANS_MIX_IMG_LINKColumn.ColumnName].ToString();
                    logDb.Info(String.Format("User {0} sửa biển số {1} thành {2} trong lượt xe có mã {3}\nLink ảnh: {4}", Person.UserName, OldVehNumber,txtVehNumberUpdate.Text, MaLuotXe, LinkAnh));
                    lblVehNumber.Text = txtVehNumberUpdate.Text;
                    GetVehicleInfo(txtVehNumberUpdate.Text);
                    // Cập nhật xong thì cập nhật vào dataset source từ form list
                    var drTrans = ((Entities.DatasetReview)DatasetBusiness).tc_transaction.FindByTRANS_ID(oBL.MasterRow[dsReview.tc_transaction.TRANS_IDColumn.ColumnName].ToString());
                    if (drTrans != null)
                    {
                        drTrans.TRANS_VEH_NUMBER = txtVehNumberUpdate.Text;
                    }


                }
                else
                {
                    CommonFunction.ShowInfomationMessage(Properties.Resources.UpdateFail);
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                // --- Quân Edit 08-10 ---
                //if (ex is MySql.Data.MySqlClient.MySqlException)
                //{
                //    XtraMessageBox.Show("Vui lòng kiểm tra kết nối tới cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                logger.Error(ex);
                // end edit
            }
        }

        private void bsTransaction_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                if (bsTransaction.Current == null) return;
                LoadHistoryValue((Entities.DatasetReview.tc_transactionRow)((DataRowView)bsTransaction.Current).Row);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (dsReview.tc_transaction[e.RowHandle].TRANS_ID.Equals(GetCurrentRow()[dsReview.tc_transaction.TRANS_IDColumn.ColumnName].ToString()))
                {
                    e.Appearance.ForeColor = Color.Maroon;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            try
            {
                var drTrans = (Entities.DatasetReview.tc_transactionRow)((DataRowView)bsTransaction.Current).Row;
                if (drTrans != null)
                {
                    var frm = new VideoPlaybackForm();
                    frm.TransactionRow = drTrans;
                    var drLane = ((Entities.DatasetReview)DatasetBusiness).cf_lane.FindByLANE_ID(drTrans[dsReview.tc_transaction.LANE_INFO_IDColumn.ColumnName].ConvertToInt());
                    if (drLane != null)
                    {
                        frm.IPCamera = drLane[dsReview.cf_lane.LANE_CAMERA_IPColumn.ColumnName].ToString();
                        frm.PortCamera = drLane[dsReview.cf_lane.LANE_CAMERA_PORTColumn.ColumnName].ConvertToInt();
                    }
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void PostReviewDetail_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadFormValue();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void txtVehNumberUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == 22 || (int)e.KeyChar == 24) return;
                if (!Regex.IsMatch(e.KeyChar.ToString(), @"^[\b A-Za-z0-9]$"))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        #endregion

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void GetVehicleInfo()
        {
            try
            {
                var drReview = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
                string strErrorNotice = Properties.Resources.VehicleHistoryVerifyValid;
                vehBLObject.DataSource = dsReview;
                vehBLObject.GetVehicleInfoByNumber(drReview[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName].ToString());
                if (dsReview.vehicle_info.Count > 0)
                {
                    SetVehicleInfo(dsReview.vehicle_info[0]);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, false);
            }
        }
        delegate void GetVehicleCallback(Entities.DatasetReview.vehicle_infoRow row);
        private void SetVehicleInfo(Entities.DatasetReview.vehicle_infoRow row)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.gcHistory.InvokeRequired)
            {
                GetVehicleCallback d = new GetVehicleCallback(SetVehicleInfo);
                this.Invoke(d, new object[] { row });
            }
            else
            {
                LoadVehicleInfo(row);
            }
        }
        private void LoadVehicleInfo(Entities.DatasetReview.vehicle_infoRow drVeh)
        {
            if (drVeh != null)
            {
                lblVehRegDate.Text = string.Format("{0:dd/MM/yyyy}", drVeh[dsReview.vehicle_info.VEH_INF_REG_DATEColumn.ColumnName].ToString());
                lblVehRegSeat.Text = drVeh[dsReview.vehicle_info.VEH_INF_SEATColumn.ColumnName].ToString();
                lblVehRegAddress.Text = drVeh[dsReview.vehicle_info.VEH_INF_ADDRColumn.ColumnName].ToString();
                lblVehRegOwn.Text = drVeh[dsReview.vehicle_info.VEH_INF_OWNColumn.ColumnName].ToString();
                var drRegVehType = dsReview.vehicle_type.FindByVEH_TYPE_ID(drVeh[dsReview.vehicle_info.VEH_INF_TYPE_IDColumn.ColumnName].ConvertToInt());
                lblVehRegType.Text = drRegVehType != null ? drRegVehType.VEH_TYPE_NAME : string.Empty;
                lblVehRegLoad.Text = string.Format("{0:00.##} tấn", drVeh[dsReview.vehicle_info.VEH_INF_LOADColumn.ColumnName].ConvertToDecimal());
                
            }
            else
            {
                ResetVehicleInfo();
            }
        }

        private void lblVehNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblVehNumber.Text.Trim())) OldVehNumber = "";
            else OldVehNumber = lblVehNumber.Text;
        }

        protected override void RefreshToolbar()
        {
            //base.RefreshToolbar();
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Bitmap currentImage = (Bitmap)pictureEdit1.EditValue)
            {
                using (Bitmap saveImage = new Bitmap(currentImage, pictureEdit1.ClientSize.Width, pictureEdit1.ClientSize.Height))
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

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Bitmap currentImage = (Bitmap)pictureEdit1.EditValue)
                {
                    using (Bitmap saveImage = new Bitmap(currentImage, pictureEdit1.ClientSize.Width, pictureEdit1.ClientSize.Height))
                    {
                        saveImage.Save("HK_Image.png");
                    }
                }

                var p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\HK_Image.png";

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

                    bmpScreenshot.Save("HK_Screenshot.png", ImageFormat.Png);
                }

                var p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\HK_Screenshot.png";

                p.StartInfo.Verb = "Print";
                p.Start();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra lại địa chỉ máy in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error(ex);
            }
        }
    }
}