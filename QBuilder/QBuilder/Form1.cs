using System;
using System.Collections;
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
        private MySqlConnection _conn;
        private ArrayList _qResult = new ArrayList();
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
                    _conn = new MySqlConnection(
                        $"Server={serverTB.Text};Database={databaseTB.Text};" +
                        $"Uid={userTB.Text};Pwd={passTB.Text}");
                    connLabel.Text = "Connection established";
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

        private void disconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveLoadButton_Click(object sender, EventArgs e)
        {
            DBStorage dbs = new DBStorage();
            dbs.FormClosed += DBStorage_Closed;
            dbs.Show();
        }

        private void DBStorage_Closed(object sender, FormClosedEventArgs e)
        {
            databaseTB.Text = DataControl.BaseData;
            serverTB.Text = DataControl.HostData;
            userTB.Text = DataControl.UserData;
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
                settings.SetUsername($"{userTB.Text}");
                settings.Save();
            }
            MessageBox.Show(this, "Saved successfully!", "Save operation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void selExecuteButton_Click(object sender, EventArgs e)
        {
            if (selQueryTB.Text.Equals(""))
            {
                MessageBox.Show(this, "The query field is empty", "Content Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _qResult.Clear();
                MySqlCommand selCommand = new MySqlCommand(selQueryTB.Text,_conn);
                selCommand.Connection.Open();
                MySqlDataReader myReader = selCommand.ExecuteReader();
                try
                {
                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            string row = "";
                            for (int i = 0; i < myReader.FieldCount; i++)
                            {
                                if (myReader.GetValue(i) != DBNull.Value)
                                {
                                    row = row + Convert.ToString(myReader.GetValue(i));
                                }
                                else
                                {
                                    row = row + "NULL";
                                }
                                row = row + " ";
                            }
                            _qResult.Add(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "The table is empty or does not exist!", "No result",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    myReader.Close();
                    DataControl.QueryData = _qResult;
                }
            }
        }
    }
}
