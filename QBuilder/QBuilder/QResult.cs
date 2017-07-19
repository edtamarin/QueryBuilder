using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QBuilder
{
    public partial class QResult : Form
    {
        public QResult()
        {
            InitializeComponent();
            queryData.AutoSize = true;
            // make table more SEEABLE
            // TODO: better table view
            ArrayList qResult = DataControl.QueryData;
            List<string> dbMD = DataControl.DbMetaData;
            foreach (string column in dbMD)
            { // populate the table with columns
                DataGridViewColumn col = new DataGridViewColumn();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                col.CellTemplate = cell;
                col.HeaderText = column;
                col.Name = column;
                col.Visible = true;
                queryData.Columns.Add(col);
            }
            foreach (string data in qResult)
            { // add data to the table
                string[] rowResult = data.Split(' ');
                queryData.Rows.Add(rowResult);
            }
            
        }

        private void queryData_SizeChanged(object sender, EventArgs e)
        { // scale the window according to the amount of data in the table
            Width = queryData.Width + 10;
        }
    }
}
