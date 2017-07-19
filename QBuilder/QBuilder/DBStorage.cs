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
        { // initialize the form and put items into the listbox
            InitializeComponent();
            var settings = new CustomSettings((int)OpType.Read);
            for (int i = 0; i < settings.GetSize(); i++)
            {
                dbListBox.Items.Add(settings.GetDatabaseName(i));
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        { // loads the selected DB data into the main form TODO: error handling
            var settings = new CustomSettings((int)OpType.Read);
            DataControl.HostData = settings.GetDatabaseHost(dbListBox.SelectedIndex);
            DataControl.BaseData = dbListBox.SelectedItem.ToString();
            DataControl.UserData = settings.GetUsername(dbListBox.SelectedIndex);
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        { // closes  the form, duh.
            this.Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        { // deletes the entry from the list
            var settings = new CustomSettings((int)OpType.Read);
            settings.Delete(dbListBox.SelectedIndex);
            dbListBox.Items.RemoveAt(dbListBox.SelectedIndex);
        }
    }
}
