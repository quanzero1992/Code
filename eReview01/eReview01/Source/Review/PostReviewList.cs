using DevExpress.XtraPrinting;
using eReview01.BL;
using eReview01.CommonUI;
using eReview01.Source.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using System.Threading;
using DevExpress.XtraEditors;
using log4netDatabase;
using DevExpress.Utils;
using System.Linq;
using System.Drawing.Imaging;

namespace eReview01.Source.Review
{
    public partial class PostReviewList : eReview01.Source.Framework.FormMasterBase
    {
        #region Declaration
        private Logger logger = LogManager.GetLogger(typeof(frmMain));
        public Entities.DatasetReview dsCount = new Entities.DatasetReview();
        private BLTransaction transactionBLObject;
        private BLVehicleInfo vehBLObject = new BLVehicleInfo();
        private BLStandardVehicleInfo standardVehBLObject = new BLStandardVehicleInfo();
        private BLBase oBLDictionary = null;
        private string sFilterUserTicket = string.Empty;
        private LoggerDb logDb = LogDbManager.GetLogger(typeof(PostReviewList), (int)Enumeration.eReview_Monitor.hậu_kiểm);
        string OldVehNumber;
        private BLMonthVehicle MonthVeh = new BLMonthVehicle(); // here
        #endregion

        #region Contructor
        public PostReviewList()
        {
            InitializeComponent();
            transactionBLObject = new BLTransaction(dsReview);
            oBLDictionary = new BLBase(dsReview.vehicle_type.TableName, string.Empty, dsReview);
        }
        #endregion

        #region Properties

        #endregion

        #region Methods
        #region private function
        /// <summary>
        /// Chạy video
        /// </summary>
        private void ShowVideo()
        {
            var dr = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
            if (dr != null)
            {
                var frm = new VideoPlaybackForm();
                frm.TransactionRow = dr;
                var drLane = dsReview.cf_lane.FindByLANE_ID(dr[dsReview.tc_transaction.LANE_INFO_IDColumn.ColumnName].ConvertToInt());
                if (drLane != null)
                {
                    frm.IPCamera = drLane[dsReview.cf_lane.LANE_CAMERA_IPColumn.ColumnName].ToString();
                    frm.PortCamera = drLane[dsReview.cf_lane.LANE_CAMERA_PORTColumn.ColumnName].ConvertToInt();
                }
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// Nạp các giá trị mặc định cho các control trên form
        /// </summary>
        private void InitDefaultFormControlValue()
        {
            this.Cursor = Cursors.WaitCursor;
            // Lấy điều kiện tìm kiếm ngày tháng là ngày hôm trước
            dateRangeSimple1.FromDate = DateTime.Today;
            dateRangeSimple1.ToDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            // Load dboption
            // Thông tin cấu hình hệ thống_
            oBLDictionary.GetAllDataByTableName(dsReview.cf_station);
            oBLDictionary.TableMasterName = dsReview.cf_lane.TableName;
            oBLDictionary.GetAllData();
            if (dsReview.cf_station.Count > 0)
            {
                DBOption.NVRServerID = dsReview.cf_station[0].VIDEO_SERVER_IP;
                DBOption.NVRServerPort = dsReview.cf_station[0].VIDEO_SERVER_PORT;
                DBOption.StationName = dsReview.cf_station[0].STATION_NAME;
                DBOption.UnitName = dsReview.cf_station[0].COMPANY_NAME;
            }
            this.Cursor = Cursors.Default;
        }
        #endregion
        #region override

        /// <summary>
        /// Sự kiện bấm menu bar
        /// </summary>
        /// <param name="sKey"></param>
        protected override void ToolClick(string sKey)
        {
            base.ToolClick(sKey);
            // Đổi mật khẩu
            if (sKey.Equals("cteVideo"))
            {
                ShowVideo();
            }
        }

        /// <summary>
        /// Sự kiện thay đổi dòng dữ liệu binding
        /// </summary>
        protected override void MasterBindingSourcePositionChange()
        {
            try
            {
                base.MasterBindingSourcePositionChange();
                //Binding dữ liệu chi tiết
                LoadInfoCar();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void LoadInfoCar()
        {
            Entities.DatasetReview.tc_transactionRow drReview = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
            if (drReview == null) return;
            var drUser = dsReview.user_info.FindByUSER_INFO_ID(drReview[dsReview.tc_transaction.USER_INFO_IDColumn.ColumnName].ToString());
            lblUser.Text = drUser != null ? drUser.USER_INFO_FULL : string.Empty;
            lblTransBegin.Text = string.Format("{0:dd/MM/yyyy HH:mm:ss}", drReview.TRANS_BEGIN);
            var drTicketType = dsReview.ticket_type.FindByTICK_TYPE_ID(drReview[dsReview.tc_transaction.TICK_TYPE_IDColumn.ColumnName].ConvertToInt());
            lblTicketType.Text = drTicketType != null ? drTicketType.TICK_TYPE_NAME : string.Empty;
            var drVehType = dsReview.vehicle_type.FindByVEH_TYPE_ID(drReview.TRANS_VEH_TYPE);
            lblVehType.Text = drVehType != null ? drVehType.VEH_TYPE_NAME : string.Empty;
            lblTransFee.Text = string.Format("{0:###,###}", drReview.TRANS_FEE);
            lblPassCount.Text = string.Empty;

            lblVehNumber.Text = drReview[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName].ToString();
            // tìm thông tin đăng kiểm xe
            pePhoto.LoadAsync(drReview[dsReview.tc_transaction.TRANS_MIX_IMG_LINKColumn.ColumnName].ToString());
            ResetVehicleInfo();
            lblVehicleHistory.ForeColor = Color.Black;
            txtUpdateVehNumber.Text = drReview[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName].ToString();
            GetStandardVehicleInfo1(drReview); // Quanedit 22-2-2016 - lấy thông tin xe chuẩn lần xe qua
        }

        private void ResetVehicleInfo()
        {
            lblVehRegDate.Text = string.Empty;
            lblVehRegSeat.Text = string.Empty;
            lblVehRegAddress.Text = string.Empty;
            lblVehRegOwn.Text = string.Empty;
            lblVehRegType.Text = string.Empty;
            lblVehRegWeight.Text = string.Empty;
            lblVehicleHistory.Text = string.Empty;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void GetVehicleInfo()
        {
            try
            {
                var drReview = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
                string strErrorNotice = Properties.Resources.VehicleHistoryVerifyValid;
                vehBLObject.GetVehicleInfoByNumber(drReview[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName].ToString());
                if (dsReview.vehicle_info.Count > 0)
                {
                    GetVehicleInfo(dsReview.vehicle_info[0]);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        delegate void GetVehicleCallback(Entities.DatasetReview.vehicle_infoRow row);
        private void GetVehicleInfo(Entities.DatasetReview.vehicle_infoRow row)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblPassCount.InvokeRequired)
            {
                GetVehicleCallback d = new GetVehicleCallback(GetVehicleInfo);
                this.Invoke(d, new object[] { row });
            }
            else
            {
                LoadVehicleInfo(row);
            }
        }
        private void LoadVehicleInfo(Entities.DatasetReview.vehicle_infoRow drVeh)
        {
            try
            {
                string strErrorNotice = Properties.Resources.VehicleHistoryVerifyValid;
                if (drVeh != null)
                {
                    lblVehRegDate.Text = string.Format("{0:dd/MM/yyyy}", drVeh[dsReview.vehicle_info.VEH_INF_REG_DATEColumn.ColumnName].ToString());
                    lblVehRegSeat.Text = drVeh[dsReview.vehicle_info.VEH_INF_SEATColumn.ColumnName].ToString();
                    lblVehRegAddress.Text = drVeh[dsReview.vehicle_info.VEH_INF_ADDRColumn.ColumnName].ToString();
                    lblVehRegOwn.Text = drVeh[dsReview.vehicle_info.VEH_INF_OWNColumn.ColumnName].ToString();
                    var drRegVehType = dsReview.vehicle_type.FindByVEH_TYPE_ID(drVeh[dsReview.vehicle_info.VEH_INF_TYPE_IDColumn.ColumnName].ConvertToInt());
                    lblVehRegType.Text = drRegVehType != null ? drRegVehType.VEH_TYPE_NAME : string.Empty;
                    lblVehRegWeight.Text = string.Format("{0:00.##} tấn", drVeh[dsReview.vehicle_info.VEH_INF_LOADColumn.ColumnName].ConvertToDecimal());
                    var drReview = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
                    if (drReview.TRANS_VEH_TYPE != drRegVehType.VEH_TYPE_ID)
                    {
                        strErrorNotice = Properties.Resources.VehicleHistoryVerifyInvalid;
                        lblVehicleHistory.ForeColor = Color.Red;
                    }
                    else
                    {
                        strErrorNotice = Properties.Resources.VehicleHistoryVerifyValid;
                    }
                    lblVehicleHistory.Text = strErrorNotice;
                }
                else
                {
                    ResetVehicleInfo();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        // Linh NH begin - Lấy thông tin xe chuẩn
        [MethodImpl(MethodImplOptions.Synchronized)]
        private void GetStandardVehicleInfo()
        {
            try
            {
                var drReview = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
                string strErrorNotice = Properties.Resources.VehicleHistoryVerifyValid;
                standardVehBLObject.GetStandardVehicleInfoByNumber(drReview[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName].ToString());
                if (dsReview.standard_vehicle_infor.Count > 0)
                {
                    GetStandardVehicleInfo(dsReview.standard_vehicle_infor[0]);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void GetStandardVehicleInfo1(Entities.DatasetReview.tc_transactionRow Row)
        {
            try
            {
                var drReview = Row;
                string strErrorNotice = Properties.Resources.VehicleHistoryVerifyValid;
                standardVehBLObject.GetStandardVehicleInfoByNumber(drReview[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName].ToString());
                if (dsReview.standard_vehicle_infor.Count > 0)
                {
                    LoadStandardVehicleInfo(dsReview.standard_vehicle_infor[0]);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        delegate void GetStandardVehicleCallback(Entities.DatasetReview.standard_vehicle_inforRow row);
        private void GetStandardVehicleInfo(Entities.DatasetReview.standard_vehicle_inforRow row)
        {
            if (this.lblPassCount.InvokeRequired)
            {
                GetStandardVehicleCallback d = new GetStandardVehicleCallback(GetStandardVehicleInfo);
                this.Invoke(d, new object[] { row });
            }
            else
            {
                LoadStandardVehicleInfo(row);
            }
        }
        private void LoadStandardVehicleInfo(Entities.DatasetReview.standard_vehicle_inforRow drVeh)
        {
            try
            {
                string strErrorNotice = Properties.Resources.VehicleHistoryVerifyValid;
                if (drVeh != null)
                {
                    lblVehRegDate.Text = string.Format("{0:dd/MM/yyyy}", drVeh[dsReview.standard_vehicle_infor.VEH_INF_REG_DATEColumn.ColumnName].ToString());
                    lblVehRegSeat.Text = drVeh[dsReview.standard_vehicle_infor.VEH_INF_SEATColumn.ColumnName].ToString();
                    lblVehRegAddress.Text = drVeh[dsReview.standard_vehicle_infor.VEH_INF_ADDRColumn.ColumnName].ToString();
                    lblVehRegOwn.Text = drVeh[dsReview.standard_vehicle_infor.VEH_INF_OWNColumn.ColumnName].ToString();
                    var drRegVehType = dsReview.vehicle_type.FindByVEH_TYPE_ID(drVeh[dsReview.standard_vehicle_infor.VEH_INF_TYPE_IDColumn.ColumnName].ConvertToInt());
                    lblVehRegType.Text = drRegVehType != null ? drRegVehType.VEH_TYPE_NAME : string.Empty;
                    lblVehRegWeight.Text = string.Format("{0:00.##} tấn", drVeh[dsReview.standard_vehicle_infor.VEH_INF_LOADColumn.ColumnName].ConvertToDecimal());
                    var drReview = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
                    if (drReview.TRANS_VEH_TYPE != drRegVehType.VEH_TYPE_ID)
                    {
                        strErrorNotice = Properties.Resources.VehicleHistoryVerifyInvalid;
                        lblVehicleHistory.ForeColor = Color.Red;
                    }
                    else
                    {
                        strErrorNotice = Properties.Resources.VehicleHistoryVerifyValid;
                    }
                    lblVehicleHistory.Text = strErrorNotice;
                }
                else
                {
                    ResetVehicleInfo();
                }
            }
            catch(Exception e)
            {
                XtraMessageBox.Show("Lỗi ");
            }
        }
        // Linh NH end

        /// <summary>
        /// Định nghĩa các thành phần của base trên form desire
        /// </summary>
        protected override void RefineDataObject()
        {
            try
            {
                base.RefineDataObject();
                base.BusinessObject = transactionBLObject;
                MasterBindingSource = bsReview;
                GridMasterList = gcReview;
                DatasetBusiness = dsReview;
                vehBLObject.DataSource = dsReview;
                standardVehBLObject.DataSource = dsReview;
                MonthVeh.DataSource = dsReview;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        protected override void RefreshData()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dsReview.Clear();
                GetDictionaryData();
                base.RefreshData();
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        protected override void GetDictionaryData()
        {
            try
            {
                base.GetDictionaryData();
                oBLDictionary.TableMasterName = dsReview.cf_station.TableName;
                oBLDictionary.GetAllData();
                if (dsReview.cf_station.Count > 0)
                {
                    DBOption.NVRServerID = dsReview.cf_station[0].VIDEO_SERVER_IP;
                    DBOption.NVRServerPort = Convert.ToUInt16(dsReview.cf_station[0][dsReview.cf_station.VIDEO_SERVER_PORTColumn.ColumnName].ConvertToInt());
                }
                oBLDictionary.TableMasterName = dsReview.vehicle_type.TableName;
                oBLDictionary.GetAllData();
                oBLDictionary.TableMasterName = dsReview.tc_type.TableName;
                oBLDictionary.GetAllData();
                oBLDictionary.TableMasterName = dsReview.lane_info.TableName;
                oBLDictionary.GetAllData();
                oBLDictionary.TableMasterName = dsReview.error_type.TableName;
                oBLDictionary.GetAllData();
                oBLDictionary.TableMasterName = dsReview.shift_type.TableName;
                oBLDictionary.GetAllData();
                oBLDictionary.TableMasterName = dsReview.ticket_type.TableName;
                oBLDictionary.GetAllData();
                oBLDictionary.TableMasterName = dsReview.tc_role.TableName;
                oBLDictionary.GetAllData();
                oBLDictionary.TableMasterName = dsReview.membership.TableName;
                oBLDictionary.GetAllData();
                oBLDictionary.TableMasterName = dsReview.user_info.TableName;
                oBLDictionary.GetAllData();
                // Filter userinfo
                sFilterUserTicket = string.Empty;
                foreach (var item in dsReview.user_info)
                {
                    foreach (var mem in dsReview.membership)
                    {
                        if (mem.MEM_USER.Equals(item.USER_INFO_ID) && mem.MEM_ROLE == (int)CommonUI.Enumeration.TollCollectionRole.TicketStaff)
                        {
                            sFilterUserTicket += "'" + item.USER_INFO_ID + "',";
                            break;
                        }
                    }
                }
                if (sFilterUserTicket.Length > 0)
                {
                    sFilterUserTicket = sFilterUserTicket.Substring(0, sFilterUserTicket.Length - 1);
                }
                bsUserTicket.Filter = dsReview.user_info.USER_INFO_IDColumn.ColumnName + " IN (" + sFilterUserTicket + ")";
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Nạp dữ liệu cho grid theo điều kiện filter
        /// </summary>
        public override void GetAllData()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dsReview.tc_transaction.Clear();
                DateTime fromDate = dateRangeSimple1.FromDate;
                DateTime toDate = dateRangeSimple1.ToDate;
                int tcType = -1;
                if (lueTcType.EditValue != null && !string.IsNullOrEmpty(lueTcType.EditValue.ToString()))
                {
                    int.TryParse(lueTcType.EditValue.ToString(), out tcType);
                }
                int laneInfoID = -1;
                if (lueLane.EditValue != null && !string.IsNullOrEmpty(lueLane.EditValue.ToString()))
                {
                    int.TryParse(lueLane.EditValue.ToString(), out laneInfoID);
                }
                int ticketType = -1;
                if (lueTicketType.EditValue != null && !string.IsNullOrEmpty(lueTicketType.EditValue.ToString()))
                {
                    int.TryParse(lueTicketType.EditValue.ToString(), out ticketType);
                }

                int vehType = -1;
                if (lueVehType.EditValue != null && !string.IsNullOrEmpty(lueVehType.EditValue.ToString()))
                {
                    int.TryParse(lueVehType.EditValue.ToString(), out vehType);
                }
                //Nguyenlt bổ sung thêm điều kiện lọc theo lỗi
                int errorType = -1;
                if (errorTcType.EditValue != null && !string.IsNullOrEmpty(errorTcType.EditValue.ToString()))
                {
                    int.TryParse(errorTcType.EditValue.ToString(), out errorType);
                }
                int selectSuspect = -1;
                if (checkEditSuspect.Checked)
                {
                    selectSuspect = 1;
                }
                else
                {
                    selectSuspect = 0;
                }
                //End Nguyenlt bổ sung
                string userID = glueUser.EditValue != null ? glueUser.EditValue.ToString() : string.Empty;
                transactionBLObject.GetTransactionSearch(fromDate, toDate, tcType, laneInfoID, userID, ticketType, vehType, txtVehNumber.Text.Trim(), errorType, selectSuspect);


                // Nếu không tìm thấy giao dịch thì reset thông tin chi tiết
                if (dsReview.tc_transaction.Count == 0)
                {
                    ResetGeneralInfo();
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void ResetGeneralInfo()
        {
            lblPassCount.Text = string.Empty;
            lblTicketType.Text = string.Empty;
            lblTransBegin.Text = string.Empty;
            lblTransFee.Text = string.Empty;
            lblUser.Text = string.Empty;
            lblVehicleHistory.Text = string.Empty;
            lblVehNumber.Text = string.Empty;
            lblVehRegAddress.Text = string.Empty;
            lblVehRegDate.Text = string.Empty;
            lblVehRegOwn.Text = string.Empty;
            lblVehRegSeat.Text = string.Empty;
            lblVehRegType.Text = string.Empty;
            lblVehRegWeight.Text = string.Empty;
            lblVehType.Text = string.Empty;
            txtUpdateVehNumber.Text = string.Empty;
            pePhoto.Image = Properties.Resources.noImage;
        }

        protected override eReview01.Source.Framework.FormDetailBase GetFormDetail()
        {
            return new PostReviewDetail();
        }
        #endregion
        #endregion

        #region Events
        /// <summary>
        /// Sự kiện load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PostReviewList_Load(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stpw = new Stopwatch();
                stpw.Start();
                LoadInfoCar();
                InitDefaultFormControlValue();
                //stlUser.Text = string.Format(Properties.Resources.FormStatus_User, Person.FullName);
                //stlTimer.Text = string.Format("{0:dd/MM/yy HH:mm:ss}", DateTime.Now);
                timer1.Start();
                stpw.Stop();
                Console.WriteLine("Time FormLoad " + stpw.ElapsedMilliseconds);
                if (string.IsNullOrEmpty(lblVehNumber.Text.Trim()))
                    OldVehNumber = "";
                else
                    OldVehNumber = lblVehNumber.Text.Trim();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void PostReviewList_Shown(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stpw = new Stopwatch();
                stpw.Start();
                GetAllData();
                stpw.Stop();
                Console.WriteLine("Time FormShown " + stpw.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Search các giao dịch thu soát vé theo yêu cầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateRangeSimple1.FromDate >= dateRangeSimple1.ToDate)
                {
                    CommonFunction.ShowWarningMessage(Properties.Resources.FromDateMustLessThanToDate);
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                GetAllData();
                if (!string.IsNullOrEmpty(txtVehNumber.Text.Trim()))
                    LookupMonthTicket(txtVehNumber.Text.Trim());
                else LookupMonthTicket(gvReview.GetRowCellDisplayText(gvReview.FocusedRowHandle, "TRANS_VEH_NUMBER").ToString().Trim());

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void peZoomPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsReview.Position >= 0)
                    EditVoucher();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }


        /// <summary>
        /// Chạy video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pePlayVideo_Click(object sender, EventArgs e)
        {
            try
            {
                ShowVideo();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Cập nhật lại biển số xe vào transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateVehNumber_Click(object sender, EventArgs e)
        {
            try
            {
                transactionBLObject.MasterRow = GetCurrentRow();
                transactionBLObject.MasterRow[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName] = txtUpdateVehNumber.Text;
                if (transactionBLObject.MasterRow == null)
                {
                    return;
                }
                bsReview.EndEdit();
                if (transactionBLObject.Update())
                {
                    CommonFunction.ShowInfomationMessage(Properties.Resources.UpdateSuccess);
                    string MaLuotXe = transactionBLObject.MasterRow[dsReview.tc_transaction.TRANS_IDColumn.ColumnName].ToString();
                    string LinkAnh = transactionBLObject.MasterRow[dsReview.tc_transaction.TRANS_MIX_IMG_LINKColumn.ColumnName].ToString();
                    logDb.Info(String.Format("User {0} sửa biển số {1} thành {2} trong lượt xe có mã {3}\nLink ảnh: {4}", Person.UserName, OldVehNumber, txtUpdateVehNumber.Text, MaLuotXe, LinkAnh));

                    lblVehNumber.Text = txtUpdateVehNumber.Text;
                    GetVehicleInfo();
                }
                else
                {
                    CommonFunction.ShowInfomationMessage(Properties.Resources.UpdateFail);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Xuất khẩu dữ liệu ra excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Excel (2003)(.xls)|*.xls|Excel (2007) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                    sfd.FileName = string.Format("Từ ngày {0:dd-MM-yyyy} Đến ngày {1:dd-MM-yyyy}", dateRangeSimple1.FromDate, dateRangeSimple1.ToDate);
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string fileName = sfd.FileName;
                        string fileExtenstion = new FileInfo(fileName).Extension;

                        if (!string.IsNullOrEmpty(fileName))
                        {
                            switch (fileExtenstion)
                            {
                                case ".xls":
                                    gcReview.ExportToXls(fileName);
                                    break;
                                case ".xlsx":
                                    gcReview.ExportToXlsx(fileName);
                                    break;
                                case ".rtf":
                                    gcReview.ExportToRtf(fileName);
                                    break;
                                case ".pdf":
                                    gcReview.ExportToPdf(fileName);
                                    break;
                                case ".html":
                                    gcReview.ExportToHtml(fileName);
                                    break;
                                case ".mht":
                                    gcReview.ExportToMht(fileName);
                                    break;
                                default:
                                    break;
                            }
                            // edit
                            if (fileExtenstion.Equals(".xls") || fileExtenstion.Equals(".xlsx"))
                            {
                                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                                try
                                {
                                    excelApp.Workbooks.Open(fileName);
                                    Microsoft.Office.Interop.Excel.Range Line = (Microsoft.Office.Interop.Excel.Range)excelApp.Rows[1];
                                    // Insert tiêu đề
                                    Line.Insert();
                                    excelApp.Cells[1, 1] = string.Format("Danh sách tìm kiếm giao dịch từ ngày {0:dd-MM-yyyy} đến ngày {1:dd-MM-yyyy}", dateRangeSimple1.FromDate, dateRangeSimple1.ToDate);
                                    var range = ((Microsoft.Office.Interop.Excel.Worksheet)excelApp.ActiveSheet).get_Range("A1", char.ConvertFromUtf32(gvReview.VisibleColumns.Count + 64) + "1");
                                    range.Merge();
                                    range.Font.Bold = true;
                                    range.AutoFormat(Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting1);
                                    range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                    Line.Insert();
                                    foreach (var item in excelApp.Workbooks)
                                    {
                                        ((Microsoft.Office.Interop.Excel.Workbook)item).Save();
                                    }
                                    ((Microsoft.Office.Interop.Excel.Range)excelApp.Rows[1]).AutoFormat(Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormat3DEffects2);
                                }
                                finally
                                {
                                    foreach (var item in excelApp.Workbooks)
                                    {
                                        ((Microsoft.Office.Interop.Excel.Workbook)item).Close(false, fileName, null);
                                    }
                                    excelApp.Quit();
                                    Marshal.ReleaseComObject(excelApp);
                                }

                            }

                            // Open file
                            if (CommonFunction.ShowYesNoMessage(Properties.Resources.ExportSuccess) == System.Windows.Forms.DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start(sfd.FileName);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        stlTimer.Text = string.Format("{0:dd/MM/yy HH:mm:ss}", DateTime.Now);
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex);
        //    }
        //}
        /// <summary>
        /// Danh so thu tu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvReview_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //try
            //{
            //    if (e.Column.Equals(colIndex))
            //    {
            //        gvReview.SetRowCellValue(e.RowHandle, colIndex, e.RowHandle + 1);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex);
            //}
        }

        private void gvReview_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.Equals(colIndex))
                {
                    e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void txtUpdateVehNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar != 22 && (int)e.KeyChar != 3 && !Regex.IsMatch(e.KeyChar.ToString(), @"^[-\b A-Za-z0-9]$"))
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
        private void LoadHistoryCarPass()
        {
            try
            {
                dsCount.Clear();
                var oBL = new BL.BLTransaction(dsCount);
                var drReview = (Entities.DatasetReview.tc_transactionRow)GetCurrentRow();
                oBL.GetTransactionByCarNumberAndTime(drReview.TRANS_BEGIN.Date, drReview.TRANS_BEGIN.Date.AddDays(1).AddMilliseconds(-1),
                    drReview[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName].ToString(), drReview.TRANS_ID);
                SetPassCountText(dsCount.tc_transaction.Count.ToString("00"));
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void LoadHistoryCarPass1(Entities.DatasetReview.tc_transactionRow Row)
        {
            try
            {
                dsCount.Clear();
                var oBL = new BL.BLTransaction(dsCount);
                var drReview = Row;
                oBL.GetTransactionByCarNumberAndTime(drReview.TRANS_BEGIN.Date, drReview.TRANS_BEGIN.Date.AddDays(1).AddMilliseconds(-1),
                    drReview[dsReview.tc_transaction.TRANS_VEH_NUMBERColumn.ColumnName].ToString(), drReview.TRANS_ID);
                lblPassCount.Text = dsCount.tc_transaction.Count.ToString("00");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        delegate void SetTextCallback(string text);
        private void SetPassCountText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblVehRegDate.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetPassCountText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblPassCount.Text = text;
            }
        }

        private void lblVehNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblVehNumber.Text.Trim()))
                OldVehNumber = "";
            else
                OldVehNumber = lblVehNumber.Text.Trim();
        }

        /// <summary>
        /// Tra cứu vé tháng, quý
        /// </summary>
        /// <param name="vehNum"></param>
        private void LookupMonthTicket(string vehNum)
        {
            try
            {
                ToolTipController defaultTooltipController = DevExpress.Utils.ToolTipController.DefaultController;
                SuperToolTip sTooltip = new SuperToolTip();
                SuperToolTipSetupArgs args = new SuperToolTipSetupArgs();


                MonthVeh.getInfoMonthVehicle(vehNum);

                var ds = (eReview01.Entities.DatasetReview)dsReview;
                if (ds != null && ds.ticket_bill.Count > 0)
                {
                  for (int i = 0; i < ds.ticket_bill.Count; i++)
			        {
                        DataRow dr = ds.ticket_bill.Rows[i];
                        string NguoiBan="";
                        if(!string.IsNullOrEmpty(dr["BILL_USERSELL"].ToString()))
                        NguoiBan = CommonDictionary.DataSource.user_info.FirstOrDefault(x => x.USER_INFO_ID == dr["BILL_USERSELL"].ToString()).USER_INFO_FULL.ToString();
                        string NgayBatDauHieuLuc = dr["BEGIN_DATE"].ConvertToDateTime().ToString("dd/MM/yyyy");
                        string NgayKetThucHieuLuc = dr["END_DATE"].ConvertToDateTime().ToString("dd/MM/yyyy");
                        string GiaTien = dr["BILL_PRICE"].ConvertToDouble().ToString("#,#");
                        string LoaiXe = dr["VEH_TYPE_ID"].ToString();
                        string NgayBan = dr["BILL_DATE"].ConvertToDateTime().ToString("dd/MM/yyyy HH:mm:ss");

                        if (dr["TICK_IMP_TYPE"].ConvertToInt() == 1) // VÉ THÁNG
                        {
                            if (dr["BEGIN_DATE"].ConvertToDateTime().Month == DateTime.Now.Month)
                            {
                                lbl_Note.Text = string.Format("Xe {0} có vé tháng {1}", vehNum, dr["BEGIN_DATE"].ConvertToDateTime().Month);
                                lbl_Note.Visible = true;

                                args.Title.Text = vehNum; // title
                                args.Contents.Text = string.Format(" Xe loại {0} \n Ngày bán {1} \n Người bán {2} \n Giá tiền {3}", LoaiXe, NgayBan, NguoiBan, GiaTien); // nội dung
                                args.ShowFooterSeparator = true;
                                args.Footer.Text = string.Format("Thời hạn hiệu lực từ {0} đến hết {1}", NgayBatDauHieuLuc, NgayKetThucHieuLuc); // Nội dung footer thời hạn hiệu lực
                                sTooltip.Setup(args);
                                sTooltip.AllowHtmlText = DefaultBoolean.True;
                                lbl_Note.SuperTip = sTooltip;
                                break;
                            }
                            else
                            {
                                lbl_Note.Visible = false;
                            }
                        }
                        if (dr["TICK_IMP_TYPE"].ConvertToInt() == 2) // VÉ QUÝ
                        {
                            if (MonthOfQuater(dr["BEGIN_DATE"].ConvertToDateTime().Month) == MonthOfQuater(DateTime.Now.Month))
                            {
                               
                                lbl_Note.Text = string.Format("Xe {0} có vé quý {1}", vehNum, MonthOfQuater(dr["BEGIN_DATE"].ConvertToDateTime().Month));
                                lbl_Note.Visible = true;

                                args.Title.Text = vehNum; // title
                                args.Contents.Text = string.Format(" Xe loại {0} \n Ngày bán {1} \n Người bán {2} \n Giá tiền {3}", LoaiXe, NgayBan, NguoiBan, GiaTien); // nội dung
                                args.ShowFooterSeparator = true;
                                args.Footer.Text = string.Format("Thời hạn hiệu lực từ {0} đến hết {1}", NgayBatDauHieuLuc, NgayKetThucHieuLuc); // Nội dung footer thời hạn hiệu lực
                                sTooltip.Setup(args);
                                sTooltip.AllowHtmlText = DefaultBoolean.True;
                                lbl_Note.SuperTip = sTooltip;
                                break;
                            }
                            else
                                lbl_Note.Visible = false;
                        }
                    }
                }
                else
                    lbl_Note.Visible = false;
            }
            catch (Exception ex)
            {
                logDb.Error(string.Format("Lỗi tra cứu thông tin tháng quý của xe {0} \n{1}", vehNum, ex.ToString()));
            }
        }

        /// <summary>
        /// Hàm cho biết tháng thuộc quý nào
        /// </summary>
        /// <returns></returns>
        private int MonthOfQuater(int month)
        {
            if (month < 4) return 1;
            else if (month < 7) return 2;
            else if (month < 10) return 3;
            else return 4;
        }

        private void gvReview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                LookupMonthTicket(gvReview.GetRowCellValue(gvReview.FocusedRowHandle, "TRANS_VEH_NUMBER").ToString());
                LoadInfoCar();
            }
            catch (Exception ex)
            {
                logDb.Error(ex);
            }
        }

        private void gcReview_Click(object sender, EventArgs e)
        {

        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Bitmap currentImage = (Bitmap)pePhoto.EditValue)
            {
                using (Bitmap saveImage = new Bitmap(currentImage, pePhoto.ClientSize.Width, pePhoto.ClientSize.Height))
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
                using (Bitmap currentImage = (Bitmap)pePhoto.EditValue)
                {
                    using (Bitmap saveImage = new Bitmap(currentImage, pePhoto.ClientSize.Width, pePhoto.ClientSize.Height))
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