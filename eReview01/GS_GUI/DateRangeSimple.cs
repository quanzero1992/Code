using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMonitor01
{
    public partial class DateRangeSimple : UserControl
    {
        #region Declaration
        public event EventHandler EditValueChanged;
        private Font _font;
        #endregion

        #region Contructor

        public DateRangeSimple()
        {
            InitializeComponent();
            FontDateRange = this.FontDateRange;
        }
        #endregion

        #region Properties
        public Font FontDateRange
        {
            get
            {
                return _font;
            }
            set
            {
                _font = value;
                //lblFromDate.Font = value;
               // lblToDate.Font = value;
                teFromTime.Font = value;
                deFromDate.Font = value;
                teToTime.Font = value;
                deToDate.Font = value;
            }
        }

        public DateTime FromDate
        {
            get
            {
                int timeFromSecond = teFromTime.Time.Hour * 3600 + teFromTime.Time.Minute * 60 + teFromTime.Time.Second;
                return deFromDate.DateTime.Date.AddSeconds(timeFromSecond);
            }
            set
            {
                teFromTime.EditValue = value;
                deFromDate.EditValue = value;
            }
        }

        public DateTime ToDate
        {
            get
            {
                int timeToSecond = teToTime.Time.Hour * 3600 + teToTime.Time.Minute * 60 + teToTime.Time.Second;
                return deToDate.DateTime.Date.AddSeconds(timeToSecond);
            }
            set
            {
                teToTime.EditValue = value;
                deToDate.EditValue = value;
            }
        }
        #endregion

        #region Method
        protected virtual void OnEditedValueChanged(EventArgs e)
        {
            EventHandler handler = EditValueChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        #endregion

        #region Events  

        
        private void deFromDate_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!this.DesignMode)
                {
                    OnEditedValueChanged(new EventArgs());
                }
            }
            catch 
            {
                throw;
            }
        }
        #endregion
    }
}