using System;
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
    public partial class DBStorage : Form
    {
        public DBStorage()
        {
            InitializeComponent();
            var settings = new CustomSettings((int)OpType.Read);
            for (int i = 0; i < settings.GetSize(); i++)
            {
                dbListBox.Items.Add(settings.GetDatabaseName(i));
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var settings = new CustomSettings((int)OpType.Read);
            DataControl.HostData = settings.GetDatabaseHost(dbListBox.SelectedIndex);
            DataControl.BaseData = dbListBox.SelectedItem.ToString();
            DataControl.UserData = settings.GetUsername(dbListBox.SelectedIndex);
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DBStorage_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
