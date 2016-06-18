using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using eReview01.CommonUI;

namespace eReview01.Source.Report.ReportFile
{
    public partial class BC2cReport : XtraReport
    {
        public BC2cReport()
        {
            InitializeComponent();
        }

        private string TransactType(int VehTypeID)
        {
            if (VehTypeID < 8)
                return "Loại vé lượt";
            else if (VehTypeID < 15)
                return "Loại vé tháng";
            else
                return "Loại vé quý";
        }

        private void lblTransType_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblTransType.Text = TransactType(GetCurrentColumnValue("LoaiVe").ConvertToInt()).ToString();
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }


    }
}
