using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eReview01.CDControl
{
    [System.ComponentModel.ToolboxItem(true)]
  public class CDButton: DevExpress.XtraEditors.SimpleButton
    {
        public CommonUI.Enumeration.EnumBindingType BindingType { get; set; }
    }
}
