using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms.Design;

namespace HMS.Forms.BaseForms
{
    [Designer(typeof(ControlDesigner))]
    public partial class OpenDataGridView : KryptonDataGridView
    {
        public OpenDataGridView()
        {
            InitializeComponent();
        }

        public OpenDataGridView(IContainer container)
        {
            container.Add(this);
        }
    }
}

