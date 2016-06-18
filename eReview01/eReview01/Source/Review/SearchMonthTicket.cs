using eReview01.BL;
using eReview01.CommonUI;
using log4netDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace eReview01.Source.Review
{
    public partial class SearchMonthTicket : eReview01.Source.Framework.frmBase
    {
        private Logging.Logger logger = Logging.LogManager.GetLogger(typeof(SearchMonthTicket));
        private LoggerDb logDb = LogDbManager.GetLogger(typeof(PostReviewList), (int)Enumeration.eReview_Monitor.hậu_kiểm);
        public SearchMonthTicket()
        {
            InitializeComponent();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
               BLMonthVehicle MonthVeh = new BLMonthVehicle(); 
                Entities.DatasetReview  ds1 = new Entities.DatasetReview();
                MonthVeh.DataSource = dsReview;
                MonthVeh.getInfoMonthVehicleByPlateNumberOrBarcode(txtSearchText.Text);
                gridView1.RefreshData();
                if (dsReview.ticket_bill.Count > 0)
                {

                    if (dsReview.ticket_bill.Where(x => DateTime.Today >= x.BEGIN_DATE && DateTime.Today <= x.END_DATE).Count() > 0)
                    {
                        lblStatus.ForeColor = Color.Blue;
                        lblStatus.Text = "Xe vé tháng/quý còn hiệu lực sử dụng tại thời điểm hiện tại";
                    }
                    else
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "Xe vé tháng/quý không có hiệu lực tại thời điểm hiện tại";
                    }
                }
                else
                {
                    lblStatus.Text = "Trạng thái:";
                    lblStatus.ForeColor = Color.Blue;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void SearchMonthTicket_Load(object sender, EventArgs e)
        {
            try
            {
                var oBL = new BLBase(dsReview.user_info.TableName, string.Empty, dsReview);
                oBL.GetAllData();
                oBL.TableMasterName = dsReview.ticket_type.TableName;
                oBL.GetAllData();

                bsTicketType.DataSource = CreateTicketType();
                txtSearchText.Focus();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private DataTable CreateTicketType()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Name", typeof(string));

            dt.Rows.Add(1,"Vé tháng");
            dt.Rows.Add(2, "Vé quý");

            return dt;
        }
    }
}
