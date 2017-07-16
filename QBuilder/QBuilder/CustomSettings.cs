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
        Write,
        Read
    }
    public  class CustomSettings
    {
        private List<SettingsModel> _settings;
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
            {
                _settings = new List<SettingsModel>();
            }
            if (rwType == 0)
            {
                _settings.Add(new SettingsModel());
                _index = _settings.Count - 1;
                SetIndex();
            }
        }

        public int GetSize()
        {
            return _settings.Count;
        }

        public void SetIndex()
        {
            _settings[_index].Index = _settings.Count-1;
        }

        public string GetDatabaseName(int index)
        {
            return _settings[index].DatabaseName;
        }

        public void SetDatabaseName(string dbName)
        {
            _settings[_index].DatabaseName = dbName;
        }

        public string GetDatabaseHost(int index)
        {
            return _settings[index].DatabaseHost;
        }

        public void SetDatabaseHost(string dbHost)
        {
            _settings[_index].DatabaseHost = dbHost;
        }

        public string GetUsername(int index)
        {
            return _settings[index].Username;
        }

        public void SetUsername(string uName)
        {
            _settings[_index].Username = uName;
        }

        public void Save()
        {
            File.WriteAllText(_path, JsonConvert.SerializeObject(_settings, Formatting.Indented)+"\n");
        }
    }

    public class SettingsModel
    {
        public int Index { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseHost { get; set; }
        public string Username { get; set; }
    }
}
