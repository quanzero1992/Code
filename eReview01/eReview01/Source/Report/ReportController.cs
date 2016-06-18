using eReview01.CommonUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eReview01.Source.Report
{
   public class ReportController
    {
       public static void ShowReport(Enumeration.EnumReportName reportName)
       {
           ParameterForm.ParameterForm frm = null;
           switch (reportName)
           {
               case Enumeration.EnumReportName.BC9:
                   frm = new Report.ParameterForm.CountVehicleInYearParameter();
                   frm.ReportName = Enumeration.EnumReportName.BC9;
                   break;
               case Enumeration.EnumReportName.BC3:
                   frm = new ParameterForm.ChangeShiftSummaryParameterForm();
                   frm.ReportName = Enumeration.EnumReportName.BC3;
                   break;
               case Enumeration.EnumReportName.BC1:
                   frm = new ParameterForm.ChangeShiftParameterForm();
                   frm.ReportName = Enumeration.EnumReportName.BC1;
                   break;
               case Enumeration.EnumReportName.BC2:
                   frm = new ParameterForm.ChangeShiftParameterForm();
                   frm.ReportName = Enumeration.EnumReportName.BC2;
                   break;
               case Enumeration.EnumReportName.BC4:
                   frm = new ParameterForm.BC4Parameter();
                   frm.ReportName = Enumeration.EnumReportName.BC4;
                   break;
               case Enumeration.EnumReportName.BC7:
                   frm = new ParameterForm.MonthParameter();
                   frm.ReportName = Enumeration.EnumReportName.BC7;
                   break;
               case Enumeration.EnumReportName.BC5:
                   frm = new ParameterForm.MonthParameter();
                   frm.ReportName = Enumeration.EnumReportName.BC5;
                   break;
               case Enumeration.EnumReportName.BC6:
                   frm = new ParameterForm.BC5BC6Parameter();
                   frm.ReportName = Enumeration.EnumReportName.BC6;
                   break;
               case Enumeration.EnumReportName.BC8:
                   frm = new ParameterForm.CountVehicleInYearParameter();
                   frm.ReportName = Enumeration.EnumReportName.BC8;
                   break;
               case Enumeration.EnumReportName.BC10:
                   frm = new ParameterForm.BC10Parameter();
                   frm.ReportName = Enumeration.EnumReportName.BC10;
                   break;
               case Enumeration.EnumReportName.VehicleCount:
                   frm = new ParameterForm.CountVehicleInYearParameter();
                   frm.ReportName = Enumeration.EnumReportName.VehicleCount;
                   break;
               case Enumeration.EnumReportName.BC2c:
                   frm = new ParameterForm.CountVehicleInYearParameter();
                   frm.ReportName = Enumeration.EnumReportName.BC2c;
                   break;

               default:
                   break;
           }
           if (frm != null)
           {
               frm.ShowDialog();
           }
       }
    }
}
