using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace HMS
{
    /// <summary>
    /// Summary description for Common
    /// </summary>
    public class Common
    {
   
        public Common()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static string GetMonthName(int month, bool abbrev)
        {
            DateTime date = new DateTime(1900, month, 1);
            if (abbrev) return date.ToString("MMM");
            return date.ToString("MMMM");
        }

        public static bool IsDate(string sdate)
        {
            DateTime dt;
            bool isDate = true;
            try
            {
                dt = DateTime.Parse(sdate);
            }
            catch
            {
                isDate = false;
            }
            return isDate;
        }

        public static string GetFreeSearchExpress(DataTable tableClone, string freeSearchExpression, string otherSearchExpression)
        {
            string ReturnValue = "";

            foreach (DataColumn dc in tableClone.Columns)
            {
                if (dc.DataType.ToString() == "System.String")
                    ReturnValue += dc.ColumnName + " like '%" + freeSearchExpression + "%' or ";
            }

            if (ReturnValue != "")
                ReturnValue = ReturnValue.Substring(0, ReturnValue.Length - 3);

            if (otherSearchExpression.Trim() != "")
                ReturnValue = otherSearchExpression + " And(" + ReturnValue + ")";


            return ReturnValue;
        }

        public static int cInt(string expression)
        {
            int val = 0;
        
            try
            {
                if (expression.Trim() != "")
                    val = int.Parse(expression);
            }
            catch
            {
                val = 0;
            }
            return val;
        }

        public static decimal cDecimal(string expression)
        {
            decimal val = 0;

            try
            {
                if (expression.Trim() != "")
                    val = decimal.Parse(expression);
            }
            catch
            {
                val = 0;
            }
            return val;
        }

        public static void CreateCSVFile(DataTable dt, string strFilePath)
        {


            #region Export Grid to CSV

            // Create the CSV file to which grid data will be exported.

            StreamWriter sw = new StreamWriter(strFilePath, false);
            // First we will write the headers.
            //DataTable dt = m_dsProducts.Tables[0];

            int iColCount = dt.Columns.Count;

            for (int i = 0; i < iColCount; i++)
            {
                sw.Write(dt.Columns[i]);
                if (i < iColCount - 1)
                {
                    sw.Write(",");
                }
            }

            sw.Write(sw.NewLine);

            // Now write all the rows.

            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < iColCount; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        sw.Write(dr[i].ToString());
                    }

                    if (i < iColCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }

            sw.Close();

            #endregion


        }

        public static void ClearForm(KryptonPanel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c.GetType() == typeof(KryptonPanel))
                {
                    ClearForm((KryptonPanel)c);
                }
                if (c.GetType() == typeof(KryptonTextBox))
                {
                    KryptonTextBox t = (KryptonTextBox)c;
                    t.Text = "";
                }
                if (c.GetType() == typeof(KryptonRichTextBox))
                {
                    KryptonRichTextBox t = (KryptonRichTextBox)c;
                    t.Text = "";
                }
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox t = (PictureBox)c;
                    if (t.Image!=null)
                    {
                        t.Image.Dispose();
                        t.Image = null;
                        t.InitialImage = null;
                    }
                }
                if (c.GetType() == typeof(KryptonComboBox))
                {
                    KryptonComboBox t = (KryptonComboBox)c;
                    t.SelectedIndex = 0;
                }
                if (c.GetType() == typeof(KryptonCheckBox))
                {
                    KryptonCheckBox t = (KryptonCheckBox)c;
                    t.Checked = false;
                }
                if (c.GetType() == typeof(KryptonNumericUpDown))
                {
                    KryptonNumericUpDown t = (KryptonNumericUpDown)c;
                    t.Value = t.Minimum;
                }
                if (c.GetType() == typeof(KryptonLabel))
                {
                    KryptonLabel t = (KryptonLabel)c;
                    t.Values.ExtraText = "";
                }
                if (c.GetType() == typeof(KryptonGroupBox))
                {
                    ClearForm(((KryptonGroupBox)c).Panel);
                }
                if (c.GetType() == typeof(KryptonDataGridView))
                {
                    var t = ((KryptonDataGridView)c);
                    t.Rows.Clear();
                    t.DataSource = null;

                }
                if (c.GetType() == typeof(CheckedListBox))
                {
                    CheckedListBox t = ((CheckedListBox)c);
                    for (int index = 0; index < t.Items.Count; index++)
                    {
                        t.SetItemChecked(index, false);
                    }
                }
                if (c.GetType() == typeof(KryptonDateTimePicker))
                {
                    var t = c as KryptonDateTimePicker;
                    t.Value = DateTime.Now;
                }
            }
        }


        public static void ClearFormWithoutGrid(KryptonPanel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c.GetType() == typeof(KryptonPanel))
                {
                    ClearForm((KryptonPanel)c);
                }
                if (c.GetType() == typeof(KryptonTextBox))
                {
                    KryptonTextBox t = (KryptonTextBox)c;
                    t.Text = "";
                }
                if (c.GetType() == typeof(KryptonRichTextBox))
                {
                    KryptonRichTextBox t = (KryptonRichTextBox)c;
                    t.Text = "";
                }
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox t = (PictureBox)c;
                    if (t.Image != null)
                    {
                        t.Image.Dispose();
                        t.Image = null;
                        t.InitialImage = null;
                    }
                }
                if (c.GetType() == typeof(KryptonComboBox))
                {
                    KryptonComboBox t = (KryptonComboBox)c;
                    t.SelectedIndex = 0;
                }
                if (c.GetType() == typeof(KryptonCheckBox))
                {
                    KryptonCheckBox t = (KryptonCheckBox)c;
                    t.Checked = false;
                }
                if (c.GetType() == typeof(KryptonNumericUpDown))
                {
                    KryptonNumericUpDown t = (KryptonNumericUpDown)c;
                    t.Value = t.Minimum;
                }
                if (c.GetType() == typeof(KryptonLabel))
                {
                    KryptonLabel t = (KryptonLabel)c;
                    t.Values.ExtraText = "";
                }
                if (c.GetType() == typeof(KryptonGroupBox))
                {
                    ClearForm(((KryptonGroupBox)c).Panel);
                }
                if (c.GetType() == typeof(CheckedListBox))
                {
                    CheckedListBox t = ((CheckedListBox)c);
                    for (int index = 0; index < t.Items.Count; index++)
                    {
                        t.SetItemChecked(index, false);
                    }
                }
                if (c.GetType() == typeof(KryptonDateTimePicker))
                {
                    var t = c as KryptonDateTimePicker;
                    t.Value = DateTime.Now;
                }
            }
        }


        public static void LoadSerial(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                grid.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 25;
            }
        }

    }
}
