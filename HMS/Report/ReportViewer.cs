using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace HMS.Report
{
    public partial class ReportViewer : KryptonForm
    {
        public ReportViewer()
        {
            KryptonManager.ApplyToolstrips = false;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            KryptonManager.ApplyToolstrips = true;
        }
    }
}
