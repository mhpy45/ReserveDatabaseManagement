using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Up;
using SuperMap.Desktop;

namespace Store.Up.AttributeDataManagement
{
    class AttributeExport : CtrlAction
    {
        override public void Run()
        {
            //To do your work.
            //Example:

            IBaseItem baseItem = this.Caller;
            if (baseItem != null)
            {
                String itemType = baseItem.GetType().ToString().Replace("SuperMap.Desktop.", "");
                Form attrImp = new Store.Up.Views.Forms.AttributeExport();
                attrImp.ShowDialog();
                MessageBox.Show("这是一个{0}", itemType);
            }

        }
    }
}
