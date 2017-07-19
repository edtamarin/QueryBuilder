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
{
    public partial class Form1 : Form
    {
        private MySqlConnection _conn;
        private ArrayList _qResult = new ArrayList();
        private List<string> _dbMD;
        public Form1()
        {
            InitializeComponent();
            queryGB.Enabled = false;
            EnableConnectionGb(true);
        }

        private void connectButton_Click(object sender, EventArgs e)
        { // connects to the database
            if (serverTB.Text.Equals("") || databaseTB.Text.Equals("") || userTB.Text.Equals("")
                || passTB.Text.Equals("")) // check if we have all the data needed
            { // if not show an error message
                MessageBox.Show(this, "Not all fields are filled in", "Content Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { // if yes try to open a connection
                try
                { // create the connection
                    _conn = new MySqlConnection(
                        $"Server={serverTB.Text};Database={databaseTB.Text};" +
                        $"Uid={userTB.Text};Pwd={passTB.Text}");
                    connLabel.Text = "Connection established";
                    passTB.Text = "";
                    _conn.Open();
                    queryGB.Enabled = true; // disable connection controls, enable query editor
                    EnableConnectionGb(false);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

        private void disconButton_Click(object sender, EventArgs e)
        { // disconnect from the DB
            _conn.Close();
            connLabel.Text = "Connection closed.";
            queryGB.Enabled = false;
            EnableConnectionGb(true);
        }

        private void saveLoadButton_Click(object sender, EventArgs e)
        { // load the saved DB logins
            DBStorage dbs = new DBStorage();
            dbs.FormClosed += DBStorage_Closed;
            dbs.Show();
        }

        private void DBStorage_Closed(object sender, FormClosedEventArgs e)
        { // passing selected data from selecting DBs
            databaseTB.Text = DataControl.BaseData;
            serverTB.Text = DataControl.HostData;
            userTB.Text = DataControl.UserData;
        }

        private void saveButton_Click(object sender, EventArgs e)
        { // save the DB login info
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
        { // execute the query
            if (selQueryTB.Text.Equals(""))
            { // check if there's anything in the textbox
                MessageBox.Show(this, "The query field is empty", "Content Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {// if yes try to execute it TODO: implement error handling
                _qResult.Clear();
                MySqlCommand selCommand = new MySqlCommand(selQueryTB.Text,_conn);
                MySqlDataReader myReader = selCommand.ExecuteReader();
                try
                { // execute command and see what comes back
                    if (myReader.HasRows)
                    { // pass the information on which columns there are to the data display
                        _dbMD = Enumerable.Range(0, myReader.FieldCount).Select(myReader.GetName).ToList();
                        while (myReader.Read())
                        { // read all data row by row into an arraylist
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
                    { // if nothing was returned show an error message
                        MessageBox.Show(this, "The table is empty or does not exist!", "No result",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {   // close the reader and pass the result and the metadata to the control class
                    myReader.Close();
                    DataControl.QueryData = _qResult;
                    DataControl.DbMetaData = _dbMD;
                    QResult qrf = new QResult();
                    qrf.Show();
                }
            }
        }

        private void EnableConnectionGb(bool state)
        { // enable/disable connection controls, clunky TODO:improve
                serverTB.Enabled = state;
                databaseTB.Enabled = state;
                userTB.Enabled = state;
                passTB.Enabled = state;
                saveButton.Enabled = state;
                loadButton.Enabled = state;
                connectButton.Enabled = state;
                disconButton.Enabled = !state;
        }
    }
}
