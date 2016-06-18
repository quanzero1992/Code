using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eReview01.Source.Util;
using DevExpress.XtraEditors;
using eReview01.CommonUI;

namespace eReview01.Source
{
    public partial class DateRangeSimple : UserControl
    {
        #region Declaration
        private Logger logger = LogManager.GetLogger(typeof(frmMain));
        public event EventHandler EditValueChanged;
        private string _dateFormat;
        private string _timeFormat;
        #endregion

        #region Contructor

        public DateRangeSimple()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public string DateFormat
        {
            get { return _dateFormat; }
            set
            {
                _dateFormat = value;
                deFromDate.Properties.DisplayFormat.FormatString = value;
                deFromDate.Properties.EditFormat.FormatString = value;
                deFromDate.Properties.EditMask = value;                
                deToDate.Properties.DisplayFormat.FormatString = value;
                deToDate.Properties.EditFormat.FormatString = value;
                deToDate.Properties.EditMask = value;
            }
        }
        public string TimeFormat
        {
            get { return _timeFormat; }
            set
            {
                _timeFormat = value;
                teFromTime.Properties.DisplayFormat.FormatString = value;
                teFromTime.Properties.EditFormat.FormatString = value;
                teFromTime.Properties.EditMask = value;
                teToTime.Properties.EditFormat.FormatString = value;
                teToTime.Properties.DisplayFormat.FormatString = value;
                teToTime.Properties.EditMask = value;
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

        private void DateRange_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void deFromDate_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!this.DesignMode)
                {
                    OnEditedValueChanged(new EventArgs());
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void deFromDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (this.DesignMode) return;
                if (sender.Equals(deFromDate))
                {
                    deToDate.Properties.MinValue = e.NewValue.ConvertToDateTime();
                    if (e.NewValue.ConvertToDateTime().Date == deToDate.DateTime.Date)
                    {
                        if (teFromTime.Time.TimeOfDay > teToTime.Time.TimeOfDay)
                        {
                            teFromTime.Time = deToDate.DateTime.Date;
                        }
                    }
                }
                else if (sender.Equals(deToDate))
                {
                    deFromDate.Properties.MaxValue = e.NewValue.ConvertToDateTime();
                    if (e.NewValue.ConvertToDateTime().Date == deFromDate.DateTime.Date)
                    {
                        if (teFromTime.Time.TimeOfDay > teToTime.Time.TimeOfDay)
                        {
                            teToTime.Time = deToDate.DateTime.Date.AddDays(1).AddMilliseconds(-1);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void teFromTime_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (this.DesignMode) return;
                if (((TimeEdit)sender).Focused || ((TimeEdit)sender).ContainsFocus)
                {

                    if (deToDate.DateTime.Date == deFromDate.DateTime.Date)
                    {
                        if (sender.Equals(teFromTime))
                        {
                            if (e.NewValue.ConvertToDateTime().TimeOfDay >= teToTime.Time.TimeOfDay)
                            {
                                e.Cancel = true;
                            }
                        }
                        else if (sender.Equals(teToTime))
                        {
                            if (e.NewValue.ConvertToDateTime().TimeOfDay < teFromTime.Time.TimeOfDay)
                            {
                                e.Cancel = true;
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
        #endregion
    }
}