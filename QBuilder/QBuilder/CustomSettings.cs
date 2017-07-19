using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QBuilder
{
    enum OpType
    { 
        // actually has little purpose but to look cool.
        // I know. I just wanted to use an enum here. Excuse me.
        Write,
        Read
    }
    public  class CustomSettings
    { // stores user settings, namely the DB logins
        private List<SettingsModel> _settings; // couple properties
        private int _index;
        private string _path = Path.Combine(
            System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),"QBfiles/conf.json");

        public CustomSettings(int rwType)
        {
            if (!File.Exists(_path))
            { // create file if doesn't exist
                System.IO.Directory.CreateDirectory(
                    Path.Combine(
                        System.Environment.GetFolderPath(
                            Environment.SpecialFolder.CommonApplicationData), "QBfiles"));
                File.Create(_path);
            }
            _settings = JsonConvert.DeserializeObject<List<SettingsModel>>(File.ReadAllText(_path));
            if (_settings == null)
            { // initialize the object for the first time
                _settings = new List<SettingsModel>();
            }
            if (rwType == 0)
            { // if operation is write, create a new object.
                // side note: this causes the delete operation to be write
                // it just looks weird but works
                _settings.Add(new SettingsModel());
                _index = _settings.Count - 1;
                SetIndex();
            }
        }

        public int GetSize()
        { // get the size of the list
            return _settings.Count;
        }

        public void SetIndex()
        { // set the index of an item
            _settings[_index].Index = _settings.Count-1;
        }

        public string GetDatabaseName(int index)
        { // get DB name
            return _settings[index].DatabaseName;
        }

        public void SetDatabaseName(string dbName)
        { // set DB name
            _settings[_index].DatabaseName = dbName;
        }

        public string GetDatabaseHost(int index)
        { // get hostname
            return _settings[index].DatabaseHost;
        }

        public void SetDatabaseHost(string dbHost)
        { // set hostname
            _settings[_index].DatabaseHost = dbHost;
        }

        public string GetUsername(int index)
        { // get username
            return _settings[index].Username;
        }

        public void SetUsername(string uName)
        { // set username
            _settings[_index].Username = uName;
        }

        public void Save()
        { // saves the changes
            File.WriteAllText(_path, JsonConvert.SerializeObject(_settings, Formatting.Indented)+"\n");
        }

        public void Delete(int index)
        { // deletes an item with a given index
            _settings.RemoveAt(index);
            Save();
        }
    }

    public class SettingsModel
    {
        // model of the settings system
        public int Index { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseHost { get; set; }
        public string Username { get; set; }
    }
}
