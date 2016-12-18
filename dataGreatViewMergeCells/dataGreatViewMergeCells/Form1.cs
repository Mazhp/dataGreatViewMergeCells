using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CancelButton = this.button1;
            DataTable dt = new DataTable();
            dt.Columns.Add("1");
            dt.Columns.Add("2");
            dt.Columns.Add("3");
            dt.Columns.Add("4");
            dt.Rows.Add("河南", "开封", "2000", "3000");
            dt.Rows.Add("河南", "郑州", "3000", "4000");
            dt.Rows.Add("江苏", "无锡", "3000", "4500");
            dt.Rows.Add("江苏", "苏州", "5000", "7000");
            dt.Rows.Add("浙江", "杭州", "5000", "7500");
            this.rowMergeView1.DataSource = dt;
            //this.rowMergeView1.Rows.Add("中国", "上海", "5000", "7000");
            //this.rowMergeView1.Rows.Add("中国", "上海", "5000", "7000");
            //this.rowMergeView1.Rows.Add("美国", "纽约", "6000", "8600");
            //this.rowMergeView1.Rows.Add("美国", "华劢顿", "8000", "9000");
            //this.rowMergeView1.Rows.Add("英国", "伦敦", "7000", "8800");
            this.rowMergeView1.ColumnHeadersHeight = 40;
            this.rowMergeView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rowMergeView1.MergeColumnNames.Add("Column1");
            this.rowMergeView1.MergeColumnNames.Add("Column3");
           // MessageBox.Show(rowMergeView1.Rows .Count.ToString ());
            //this.rowMergeView1.AddSpanHeader(2, 2, "XXXX");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}