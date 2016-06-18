using eReview01.BL;
using eReview01.Source.Framework;
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
    public partial class FormLocateCarList : eReview01.Source.Framework.FormMasterBase
    {
        public FormLocateCarList()
        {
            InitializeComponent();
        }

        protected override void GetDictionaryData()
        {
            base.GetDictionaryData();
            BL.BLBase oBL = new BL.BLBase(dsAccounting.vehicle_type.TableName, string.Empty, dsAccounting);
            oBL.GetAllData();
        }
        protected override FormDetailBase GetFormDetail()
        {
            return new FormLocateCarDetail();
        }

        protected override void RefineDataObject()
        {
            base.RefineDataObject();
            GridMasterList = grdBill;
            DatasetBusiness = dsAccounting;
            MasterBindingSource = bsLocalCar;
            GridMasterList.DataSource = MasterBindingSource;
            bsVehType.DataSource = dsAccounting;
            GetAllData();
        }

        public override void GetAllData()
        {
            base.GetAllData();
            string VehType = lueVehType.Text.ToString().Equals("Tất cả") ? "-1" : lueVehType.EditValue.ToString();
            string Code = txtCode.Text.Trim();
            string VehNum = txtVehNum.Text.Trim();
            BL.BLLocalCar bl = new BL.BLLocalCar(dsAccounting);
            dsAccounting.local_car.Clear();
            bl.searchLocalCar(Code, VehNum, VehType);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllData();
        }
              
        private void lueVehType_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                sender.GetType().GetProperty("EditValue").SetValue(sender, null, null);
        }

        private void txtVehNum_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                sender.GetType().GetProperty("EditValue").SetValue(sender, null, null);
        }

        private void txtCode_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                sender.GetType().GetProperty("EditValue").SetValue(sender, null, null);
        }

        private void FormLocateCarList_Activated(object sender, EventArgs e)
        {
            //GetAllData();
        }
    }
}
