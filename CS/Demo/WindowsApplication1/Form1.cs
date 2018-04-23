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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ProcessItems();
        }
        private void ProcessItems()
        {
            ArrayList items = MyFocusHelper.GetItemsInVisibleOrder(layoutControl1);
            for (int i = 0; i < items.Count; i++)
            {
                LayoutControlItem item = items[i] as LayoutControlItem;
                if (item != null)
                {
                    item.Text = String.Format("Order = <{0}>", i);
                    item.TextVisible = true;
                }
            }
        }
    }


}