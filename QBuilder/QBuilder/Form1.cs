using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using QBuilder.Properties;

namespace QBuilder
{ // TODO: query builder
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (serverTB.Text.Equals("") || databaseTB.Text.Equals("") || userTB.Text.Equals("")
                || passTB.Text.Equals(""))
            {
                MessageBox.Show(this, "Not all fields are filled in", "Content Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(
                        $"Server={serverTB.Text};Database={databaseTB.Text};" +
                        $"Uid={userTB.Text};Pwd={passTB.Text}");
                    connLabel.Text = "Connection established";
                    MySqlCommand command = new MySqlCommand("SELECT firstName FROM employees", conn);

                    command.Connection.Open();
                    MySqlDataReader myReader = command.ExecuteReader();
                    try
                    {
                        while (myReader.Read())
                        {
                            Debug.WriteLine(myReader.GetString(0));
                        }
                    }
                    finally
                    {
                        myReader.Close();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

        private void disconButton_Click(object sender, EventArgs e)
        {

        }

        private void saveLoadButton_Click(object sender, EventArgs e)
        {
            DBStorage dbs = new DBStorage();
            dbs.FormClosed += DBStorage_Closed;
            dbs.Show();
            Debug.Write("1");
        }

        private void DBStorage_Closed(object sender, FormClosedEventArgs e)
        {
            databaseTB.Text = DataControl.BaseData;
            serverTB.Text = DataControl.HostData;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (serverTB.Text.Equals("") || databaseTB.Text.Equals(""))
            {
                MessageBox.Show(this, "Fill in the database name and the server address", "Content Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var settings = new CustomSettings((int) OpType.Write);
                settings.SetDatabaseName($"{databaseTB.Text}");
                settings.SetDatabaseHost($"{serverTB.Text}");
                settings.Save();
            }
            MessageBox.Show(this, "Saved successfully!", "Save operation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
