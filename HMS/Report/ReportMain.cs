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
    public partial class ReportMain : KryptonForm
    {
        public ReportMain()
        {
            InitializeComponent();
        }

        int ClubId;
        string UserName;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tvReport.ExpandAll();
        }

        public ReportMain(int _ClubID, string _UserName):this()
        {
            
            ClubId = _ClubID;
            UserName = _UserName;
        }

        void ShowForm(KryptonForm frm)
        {
            frm.TopLevel = false;
            pnlContainer.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();
        }

        private void tvReport_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (tvReport.SelectedNode.Text == "Handicap Query")
            //{
            //    Report.HandicapQuery frm = new Report.HandicapQuery(ClubId, UserName);
            //    ShowForm(frm);
            //}
            //else if (tvReport.SelectedNode.Text == "Handicap Conversion")
            //{
            //    Report.HandicapConversion frm = new Report.HandicapConversion(ClubId, UserName);
            //    ShowForm(frm);
            //}
            //else if (tvReport.SelectedNode.Text == "Club Info")
            //{
            //    Report.ClubInfo frm = new Report.ClubInfo(ClubId, UserName);
            //    ShowForm(frm);
            //}
            //else if (tvReport.SelectedNode.Text == "Hole Avg Score")
            //{
            //    Report.HoleAvgScore frm = new Report.HoleAvgScore(ClubId, UserName);
            //    ShowForm(frm);
            //}
            //else if (tvReport.SelectedNode.Text == "Member Report")
            //{
            //    Report.MemberReport frm = new Report.MemberReport(ClubId, UserName);
            //    ShowForm(frm);
            //}
            //else if(tvReport.SelectedNode.Text == "Handicap Publish")
            //{
            //    Report.HandicapControl frm = new HandicapControl(ClubId, UserName);
            //    ShowForm(frm);
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
