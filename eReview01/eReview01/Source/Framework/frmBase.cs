using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace eReview01.Source.Framework
{
    public partial class frmBase : DevExpress.XtraEditors.XtraForm
    {
        public frmBase()
        {
            InitializeComponent();
            DevExpress.XtraEditors.Controls.Localizer.Active = new MyLocalizer();
        }
    }
}
