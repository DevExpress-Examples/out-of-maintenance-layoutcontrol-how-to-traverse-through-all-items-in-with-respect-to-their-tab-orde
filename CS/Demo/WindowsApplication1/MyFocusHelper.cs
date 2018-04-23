using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using System.Collections;

namespace WindowsApplication1
{
    public class MyFocusHelper : FocusHelperBase
    {
        public MyFocusHelper(ILayoutControl control)
            : base(control)
        {

        }

        public ArrayList GetItemsInVisibleOrder()
        {
            return GetArrangedFocusList(false);
        }

        public static ArrayList GetItemsInVisibleOrder(ILayoutControl control)
        {
            return new MyFocusHelper(control).GetItemsInVisibleOrder();
        }
    }
}
