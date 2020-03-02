using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;

namespace Store.Up.PlotAnalysis
{
    class MyCtrlActionColorButton : CtrlAction
    {
        override public void Run()
        {
            //To do your work.
            //Example:

            IColorButton colorButton = this.Caller as IColorButton;
            System.Drawing.Color color = colorButton.Color;
            MessageBox.Show(String.Format("This Color is: {0},{1},{2}", color.R, color.G, color.B));
        }
    }
}
