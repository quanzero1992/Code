using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Localization;

namespace eMonitor01
{
    public class MyXtraMessage : Localizer
    {
        public override string GetLocalizedString(StringId id)
        {
            if (id == StringId.XtraMessageBoxAbortButtonText) return "Hủy bỏ";
            if (id == StringId.XtraMessageBoxCancelButtonText) return "Hủy";
            if (id == StringId.XtraMessageBoxIgnoreButtonText) return "Bỏ qua";
            if (id == StringId.XtraMessageBoxNoButtonText) return "Không";
            if (id == StringId.XtraMessageBoxOkButtonText) return "Đồng ý";
            if (id == StringId.XtraMessageBoxRetryButtonText) return "Thử lại";
            if (id == StringId.XtraMessageBoxYesButtonText) return "Có";
            return base.GetLocalizedString(id);
        }
    }
}

