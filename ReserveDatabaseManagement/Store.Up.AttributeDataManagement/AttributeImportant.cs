using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;

namespace Store.Up.AttributeDataManagement
{
    class AttrImpCtrlAction : CtrlAction
    {
        override public void Run()
        {
            //To do your work.
            //Example:

            IBaseItem baseItem = this.Caller;
            if (baseItem != null)
            {
                String itemType = baseItem.GetType().ToString().Replace("SuperMap.Desktop.", "");
                Form attrImp = new Store.Up.Views.Forms.Store_Up_AttributeImportant_Form();
                attrImp.ShowDialog();
            }

        }
    }
}
