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
using eReview01.CommonUI;

namespace eReview01.Source
{
    public partial class DateRange : UserControl
    {
        #region Declaration
        private Logger logger = LogManager.GetLogger(typeof(DateRange));
        public event EventHandler EditValueChanged;
        private string _dateFormat;
        private string _timeFormat;
        #endregion

        #region Contructor
        
        public DateRange()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public CommonUI.Enumeration.EnumReportPeriod ReportPeriod
        {
            get {
                return (CommonUI.Enumeration.EnumReportPeriod)lueOption.EditValue.ConvertToInt();
            }
            set {
                lueOption.EditValue = (int)value;
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
                teFromTime.Time = value;
                deFromDate.DateTime = value;
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
                teToTime.Time = value;
                deToDate.DateTime = value;
                teToTime.EditValue = value;
                deToDate.EditValue = value;
            }
        }

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
        #endregion

        #region Method
        /// <summary>
        /// Tự động thay đổi tùy chọn nhanh khi chọn từ ngày đến ngày
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        private void ChangeOption(DateTime fromDate, DateTime toDate)
        {
            lueOption.EditValueChanged -= lueOptionValue_EditValueChanged;
            // Tháng này
            if (fromDate.Year == DateTime.Now.Year && toDate.Year == DateTime.Now.Year)
            {
                if (fromDate.Month == DateTime.Now.Month && fromDate.Month == toDate.Month && fromDate.Day == 1 
                    && toDate.Day == DateTime.DaysInMonth(toDate.Year, toDate.Month))
                {
                    ReportPeriod = CommonUI.Enumeration.EnumReportPeriod.ThisMonth;
                }
                // Trường hợp in tháng
                else if (fromDate.Month == toDate.Month && fromDate.Day == 1 && toDate.Day == DateTime.DaysInMonth(toDate.Year, toDate.Month))
                {
                    ReportPeriod = (CommonUI.Enumeration.EnumReportPeriod)fromDate.Month;
                }
                // trường hợp in quý 
                else if (toDate.Month == fromDate.Month + 2 && fromDate.Month % 3 == 1
                    && fromDate.Day == 1 && toDate.Day == DateTime.DaysInMonth(toDate.Year, toDate.Month))
                {
                    ReportPeriod = (CommonUI.Enumeration.EnumReportPeriod)(100 + (toDate.Month - 1) / 3 + 1);
                }
                // In cả năm
                else if (fromDate.Month == 1 && fromDate.Day == 1 && toDate.Month == 12 && toDate.Month == 31)
                {
                    ReportPeriod = CommonUI.Enumeration.EnumReportPeriod.AllYear;
                }
                // Hôm nay
                else if ((toDate.Date - fromDate.Date).TotalMilliseconds == 0 && fromDate.Date == DateTime.Today)
                {
                    ReportPeriod = CommonUI.Enumeration.EnumReportPeriod.Today;
                }
                // Hôm qua
                else if ((toDate.Date - fromDate.Date).TotalMilliseconds == 0 && fromDate.Date == DateTime.Today.AddDays(-1))
                {
                    ReportPeriod = CommonUI.Enumeration.EnumReportPeriod.Yesterday;
                }
                // tuan nay
                else if ((toDate.Date - fromDate.Date).TotalDays == 6 && fromDate.DayOfWeek == DayOfWeek.Monday && toDate.Date >= DateTime.Today)
                {
                    ReportPeriod = CommonUI.Enumeration.EnumReportPeriod.ThisWeek;
                }
                // tuan truoc
                else if ((toDate.Date - fromDate.Date).TotalDays == 6 && fromDate.DayOfWeek == DayOfWeek.Monday && (toDate.Date - fromDate.Date).TotalDays <= 6)
                {
                    ReportPeriod = CommonUI.Enumeration.EnumReportPeriod.LastWeek;
                }
                else
                {
                    ReportPeriod = CommonUI.Enumeration.EnumReportPeriod.Option;
                }
            }
            else
            {
                ReportPeriod = CommonUI.Enumeration.EnumReportPeriod.Option;
            }
            lueOption.EditValueChanged += lueOptionValue_EditValueChanged;
        }

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
        private void lueOptionValue_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DesignMode) return;
                deFromDate.EditValueChanged -= deFromDate_EditValueChanged;
                deToDate.EditValueChanged -= deFromDate_EditValueChanged;
                teFromTime.EditValueChanged -= deFromDate_EditValueChanged;
                teToTime.EditValueChanged -= deFromDate_EditValueChanged;
                int periodType = lueOption.EditValue != null ? Convert.ToInt32(lueOption.EditValue.ToString()) : 0;
                int year = DateTime.Now.Year;
                DateTime fromDate = DateTime.Today;
                DateTime toDate = DateTime.Now;
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US", false);
                string formatFromDate = "{0}/1/{1}";
                string formatToDate = "{0}/{1}/{2}";
                switch (periodType)
                {
                    case (int)CommonUI.Enumeration.EnumReportPeriod.Today:
                        fromDate = DateTime.Today;
                        toDate = DateTime.Today.AddDays(1).AddMilliseconds(-1);
                        break;
                    case (int)CommonUI.Enumeration.EnumReportPeriod.January:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.February:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.March:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.April:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.May:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.June:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.July:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.August:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.September:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.October:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.November:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.December:
                        fromDate = Convert.ToDateTime(string.Format(formatFromDate, periodType.ToString(), year.ToString()), culture);
                        toDate = Convert.ToDateTime(string.Format(formatToDate,
                            periodType.ToString(), DateTime.DaysInMonth(year, periodType), year), culture).AddDays(1).AddMilliseconds(-1);
                        break;
                    case (int)CommonUI.Enumeration.EnumReportPeriod.ThisMonth:
                        fromDate = Convert.ToDateTime(string.Format(formatFromDate, DateTime.Now.Month, year.ToString()), culture);
                        toDate = Convert.ToDateTime(string.Format(formatToDate,
                            DateTime.Now.Month, DateTime.DaysInMonth(year, DateTime.Now.Month), year), culture).AddDays(1).AddMilliseconds(-1);
                        break;
                    case (int)CommonUI.Enumeration.EnumReportPeriod.QuarterOne:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.QuarterTwo:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.QuarterThree:
                    case (int)CommonUI.Enumeration.EnumReportPeriod.QuarterFour:
                        fromDate = Convert.ToDateTime(string.Format(formatFromDate, ((periodType - 101) * 3 + 1).ToString(), year.ToString()), culture);
                        toDate = Convert.ToDateTime(string.Format(formatToDate, ((periodType - 101) * 3 + 3).ToString()
                            , DateTime.DaysInMonth(year, (periodType - 101) * 3 + 3), year), culture).AddDays(1).AddMilliseconds(-1);
                        break;
                    case (int)CommonUI.Enumeration.EnumReportPeriod.AllYear:
                        fromDate = Convert.ToDateTime(string.Format(formatFromDate, "1", year.ToString()), culture);
                        toDate = Convert.ToDateTime(string.Format(formatToDate, "12", "31", year.ToString()), culture).AddDays(1).AddMilliseconds(-1);
                        break;
                    case (int)CommonUI.Enumeration.EnumReportPeriod.Yesterday:
                        fromDate = DateTime.Now.Date.AddDays(-1);
                        toDate = DateTime.Now.Date.AddMilliseconds(-1);
                        break;
                    case (int)CommonUI.Enumeration.EnumReportPeriod.LastWeek:
                        fromDate = DateTime.Now.Date.AddDays(-((int)DateTime.Now.DayOfWeek + 6));
                        toDate = fromDate.AddDays(7).AddMilliseconds(-1);
                        break;
                    case (int)CommonUI.Enumeration.EnumReportPeriod.LastMonth:
                        fromDate = Convert.ToDateTime(string.Format(formatFromDate, DateTime.Now.Month - 1, year), culture);
                        toDate = DateTime.Today.AddDays(-DateTime.Now.Day);
                        break;
                    case (int) CommonUI.Enumeration.EnumReportPeriod.ThisWeek:
                        fromDate = DateTime.Now.Date.AddDays(-((int)DateTime.Now.DayOfWeek) + 1);
                        toDate = fromDate.AddDays(7).AddMilliseconds(-1);
                        break;
                    default:
                        break;
                }
                if (periodType != (int)CommonUI.Enumeration.EnumReportPeriod.Option)
                {
                    deFromDate.EditValue = fromDate;
                    teFromTime.EditValue = fromDate;
                    deToDate.EditValue = toDate;
                    teToTime.EditValue = toDate;
                    OnEditedValueChanged(new EventArgs());
                }
                deFromDate.EditValueChanged += deFromDate_EditValueChanged;
                deToDate.EditValueChanged += deFromDate_EditValueChanged;
                teFromTime.EditValueChanged += deFromDate_EditValueChanged;
                teToTime.EditValueChanged += deFromDate_EditValueChanged;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

        }

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
                if (DesignMode) return;
                ChangeOption(deFromDate.EditValue.ConvertToDateTime(), deToDate.EditValue.ConvertToDateTime());
                if (!this.DesignMode)
                {
                    if ((sender.Equals(deFromDate) || sender.Equals(deToDate)) && (((DevExpress.XtraEditors.DateEdit)sender).Focused
                    || ((DevExpress.XtraEditors.DateEdit)sender).ContainsFocus))
                    {
                        OnEditedValueChanged(new EventArgs());
                    }
                    else if ((sender.Equals(teFromTime) || sender.Equals(teToTime)) && (((DevExpress.XtraEditors.TimeEdit)sender).Focused
                    || ((DevExpress.XtraEditors.TimeEdit)sender).ContainsFocus))
                    {
                        OnEditedValueChanged(new EventArgs());
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
                if (((DevExpress.XtraEditors.TimeEdit)sender).Focused || ((DevExpress.XtraEditors.TimeEdit)sender).ContainsFocus)
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
        #endregion
    }
}