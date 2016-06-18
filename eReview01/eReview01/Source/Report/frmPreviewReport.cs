using DevExpress.XtraPrinting.Preview;
using eReview01.CommonUI;
using eReview01.Source.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eReview01.Source.Report
{
    public partial class frmPreviewReport : Source.Framework.frmBase
    {
        #region Declaration 
        Logger logger = LogManager.GetLogger(typeof(frmPreviewReport));
        #endregion

        #region Contructor
        public frmPreviewReport()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public DocumentViewer ReportDocument
        {
            get
            {
                return docReviewReport;
            }
        }
        #endregion

        #region Method

        #endregion

        #region Events
        private void docReviewReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        #endregion
    }
}
