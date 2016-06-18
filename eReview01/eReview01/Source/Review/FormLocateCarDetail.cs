using DevExpress.XtraEditors;
using eReview01.BL;
using eReview01.CommonUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eReview01.Source.Review
{
    public partial class FormLocateCarDetail : eReview01.Source.Framework.FormDetailBase
    {
        BLLocalCar oBLcar;
        public FormLocateCarDetail()
        {
            InitializeComponent();
            oBLcar = new BLLocalCar(dsAccounting);
        }

        protected override void RefineDataObject()
        {
            try
            {
                if (DesignMode) return;
                base.RefineDataObject();
                dsAccounting = (eReview01.Entities.DatasetReview)DatasetBusiness;
                bsVehType.DataSource = dsAccounting;

            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        protected override void InitCombo()
        {
            try
            {
                base.InitCombo();
                using (BLBase oBL = new BLBase(dsAccounting.vehicle_type.TableName, string.Empty, dsAccounting))
                { oBL.GetAllData(); }
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        public override bool SaveData()
        {
            if (txtCode.Text == null || txtCode.Text.Trim() == "")
            {
                XtraMessageBox.Show(string.Format(Properties.Resources.txtEnter, "Mã biên bản"), Properties.Resources.AlertEnter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
                return false;
            }
            if (txtCode.Text.Trim().Length > 50)
            {
                XtraMessageBox.Show(string.Format(Properties.Resources.txtEnter, "Mã biên bản", "50"), Properties.Resources.AlertEnter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
                return false;
            }

            if (txtAddress.Text == null || txtAddress.Text.Trim() == "")
            {
                XtraMessageBox.Show(string.Format(Properties.Resources.txtEnter, "Số CMT"), Properties.Resources.AlertEnter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return false;
            }
            if (txtAddress.Text.Trim().Length > 20)
            {
                XtraMessageBox.Show(string.Format(Properties.Resources.txtEnter, "Số CMT", "20"), Properties.Resources.AlertEnter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return false;
            }

            if (dtBill_date.ToString().Trim() == "")
            {
                XtraMessageBox.Show(string.Format(Properties.Resources.txtEnter, "Ngày lập"), Properties.Resources.AlertEnter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtBill_date.Focus();
                return false;
            }


            if (cboVeh.EditValue == null)
            {
                XtraMessageBox.Show(string.Format(Properties.Resources.cboChose, "Loại xe"), Properties.Resources.AlertEnter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboVeh.Focus();
                return false;
            }

            if (txtVehCode.Text.Trim() == "")
            {
                XtraMessageBox.Show(string.Format(Properties.Resources.txtEnter, "Biển số"), Properties.Resources.AlertEnter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVehCode.Focus();
                return false;
            }

            if (txtVehCode.Text.Trim().Length < 6)
            {
                XtraMessageBox.Show("Biển số xe không được nhỏ hơn 6 ký tự", Properties.Resources.AlertEnter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVehCode.Focus();
                return false;
            }
            else
            {
                if (!(System.Text.RegularExpressions.Regex.IsMatch(txtVehCode.Text.ToUpper().Trim(), @"\d{2}[A-Z]{1,2}[0-9]{4,6}")
                 || System.Text.RegularExpressions.Regex.IsMatch(txtVehCode.Text.ToUpper().Trim(), @"^[A-Z]{1,3}[0-9]{4,6}$")))
                {
                    XtraMessageBox.Show("Biển số xe không hợp lệ", Properties.Resources.AlertEnter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVehCode.Focus();
                    return false;
                }
            }

            if (!(System.Text.RegularExpressions.Regex.IsMatch(txtVehCode.Text.ToUpper().Trim(), @"\d{2}[A-Z]{1,2}[0-9]{4,6}")
                || System.Text.RegularExpressions.Regex.IsMatch(txtVehCode.Text.ToUpper().Trim(), @"^[A-Z]{1,3}[0-9]{4,6}$")))
            {
                XtraMessageBox.Show("Biển số xe không hợp lệ");
                this.Focus();
                return false;
            }
            else
            {
                if (oBLcar.CheckPlateNumberExist(txtVehCode.Text.Trim()) && EditMode == Enumeration.EnumEditMode.AddNew)
                //if (oBLcar.CheckPlateNumberExist(txtVehCode.Text.Trim()))
                {
                    XtraMessageBox.Show("Biển số xe đã tồn tại trong hệ thống", Properties.Resources.AlertEnter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVehCode.Focus();
                    return false;
                }
            }

            if (cboVeh.EditValue == null || "<Chọn loại xe>".Equals(cboVeh.Text.Trim()))
            {
                XtraMessageBox.Show("Loại xe chưa được chọn", Properties.Resources.AlertEnter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboVeh.Focus();
                return false;
            }
            if (EditMode == Enumeration.EnumEditMode.Edit)
            {
                memoEdit2.Text = memoEdit2.Text + "; [" + DateTime.Now + "] User " + Person.UserID + " sửa xe địa phương";
            }

            return base.SaveData();
        }

        public override void AddNewRow()
        {
            try
            {
                base.AddNewRow();
                var dr = (Entities.DatasetReview.local_carRow)GetCurrentRow();
                dr.DateSign = DateTime.Now;
                dr.UserInput = Person.UserID;
                dr.Note = "[" + DateTime.Now + "] User " + Person.UserID + " thêm xe địa phương";
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        public override void AddNewRowDetail()
        {
            base.AddNewRowDetail();
            try
            {
                base.AddNewRow();
                var dr = (Entities.DatasetReview.local_carRow)GetCurrentRow();
                dr.DateSign = DateTime.Now;
                dr.UserInput = Person.UserID;
                dr.Note = "[" + DateTime.Now + "] User " + Person.UserID + " thêm xe địa phương";
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        private void FormLocateCarDetail_Load(object sender, EventArgs e)
        {
            //dtBill_date.EditValue = DateTime.Now;
        }
    }
}
