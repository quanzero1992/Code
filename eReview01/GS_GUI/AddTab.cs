using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.Layout;
using DevExpress.XtraEditors;
using System.Drawing;

namespace eMonitor01
{
    class AddTab
    {
        public static int tabadd(DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtratab, System.Windows.Forms.Form frm)
        {
            int t = 0;
            foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage tab in xtratab.Pages) // kiểm tra tab đã được bật chưa 
            {
                if (tab.Text.Equals(frm.Text))
                {
                    xtratab.SelectedPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {
                return  1;
            }
            else
            {
                return 0;
            }
        }       
    }
}
