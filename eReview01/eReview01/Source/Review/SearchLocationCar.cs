using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using eReview01.DL;
using System.Data.Linq.SqlClient;
namespace eReview01.Source.Review
{
    public partial class SearchLocationCar : eReview01.Source.Framework.frmBase
    {
        List<SearchCarLocal> _listLocalCar = null;
        public SearchLocationCar()
        {
            InitializeComponent();
        }
        // view infor car_local have search
        public List<SearchCarLocal> SearchCarLocalMethod(string PlateNumber)
        {
            try
            {
                var Carlocal = _listLocalCar.Where(c => c.PlateNumber.Contains(PlateNumber));
                var x = Carlocal.ToList();
                return x;
            }
            catch (Exception)
            {
                return null;
            }
        }
        List<SearchCarLocal> ObjectCar = null;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ObjectCar = SearchCarLocalMethod(txtSearchText.Text.Trim());
            if (string.IsNullOrEmpty(txtSearchText.Text))
            {
                lblWanning.Text = "Bạn chưa nhập biển số";
                lblWanning.ForeColor = Color.Red;
            }
            else
            {
                if (ObjectCar.Count != 0)
                {
                    gridControl1.DataSource = ObjectCar;
                    //bindData(0);
                    Binding(0);
                }
                else
                {
                    XtraMessageBox.Show("không tìm thấy xe có biển số " + txtSearchText.Text + " trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void SearchLocationCar_Load(object sender, EventArgs e)
        {
            try
            {
                gridView1.OptionsBehavior.ReadOnly = true;
                var objectCarlocal = BL.BLBase.ListCarLocal();
                _listLocalCar = objectCarlocal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            Binding(e.RowHandle);
        }
        public void Binding(int RowHandle)
        {
            try
            {
                string strBeginDate = null;
                string strEndDate = null;
                string TICK_SOLD_TYPE = null;
                lblbillID.Text = ObjectCar[RowHandle].BillID.ToString().TrimStart();
                lblPlateNumber.Text = ObjectCar[RowHandle].PlateNumber.ToString().TrimStart();
                lblVehType.Text = ObjectCar[RowHandle].VehType.ToString().TrimStart();
                if (ObjectCar[RowHandle].DateSign != null)
                {
                    lblDateSign.Text = Convert.ToDateTime(ObjectCar[RowHandle].DateSign.ToString()).ToString("dd/MM/yyyy").TrimStart();
                }
                else
                {
                    lblDateSign.Text = string.Empty;
                }
                lblOwnerCarName.Text = ObjectCar[RowHandle].OwnerCarName.ToString().TrimStart();
                lblCMT.Text = ObjectCar[RowHandle].CMT.ToString().TrimStart();
                lblAddress.Text = ObjectCar[RowHandle].Address.ToString().TrimStart();
                lblPhoneNumber.Text = ObjectCar[RowHandle].PhoneNumber.ToString().TrimStart();
                lblUserInput.Text = ObjectCar[RowHandle].UserInput.ToString().TrimStart();
                if (!string.IsNullOrEmpty(ObjectCar[RowHandle].TICK_SOLD_BEGIN_DATE.ToString().Trim()))
                {
                    strBeginDate = Convert.ToDateTime(ObjectCar[RowHandle].TICK_SOLD_BEGIN_DATE.ToString()).ToString("dd/MM/yyyy").TrimStart();
                }
                else
                {
                    strBeginDate = string.Empty;
                }
                if (!string.IsNullOrEmpty(ObjectCar[RowHandle].TICK_SOLD_END_DATE.ToString()))
                {
                    strEndDate = Convert.ToDateTime(ObjectCar[RowHandle].TICK_SOLD_END_DATE.ToString()).ToString("dd/MM/yyyy").TrimStart();
                }
                else
                {
                    strEndDate = string.Empty;
                }
                if (!string.IsNullOrEmpty(ObjectCar[RowHandle].TICK_SOLD_TYPE.ToString()))
                {
                    TICK_SOLD_TYPE = ObjectCar[RowHandle].TICK_SOLD_TYPE.ToString().TrimStart();
                }
                else
                {
                    TICK_SOLD_TYPE = string.Empty;
                }
                switch (TICK_SOLD_TYPE)
                {
                    case "1":
                        lbltypeveh.Text = "Vé tháng (" + strBeginDate + " - " + strEndDate + ")";
                        lbltypeveh.ForeColor = Color.Blue;
                        break;
                    case "2":
                        lbltypeveh.Text = "Vé Quý (" + strBeginDate + " - " + strEndDate + ")";
                        lbltypeveh.ForeColor = Color.Blue;
                        break;
                    default:
                        lbltypeveh.Text = "Xe chưa mua vé ";
                        lbltypeveh.ForeColor = Color.Green;
                        break;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("SearchLocationCar " + ex.Message);
            }
        }
        private void txtSearchText_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                sender.GetType().GetProperty("EditValue").SetValue(sender, null, null);
            lblWanning.Text = string.Empty;
            SearchLocationCar_Load(sender, e);
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
        {
            lblWanning.Text = string.Empty;
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
    }
}
