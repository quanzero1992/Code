using DevExpress.XtraPrinting.Preview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eReview01.Source.Report
{
    public partial class PreviewReportForm : Source.Framework.frmBase
    {
        #region Declaration 

        #endregion

        #region Contructor
        public PreviewReportForm()
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

        #endregion
    }
}
