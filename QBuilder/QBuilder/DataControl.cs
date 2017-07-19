using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * This is a data control class. It handles passing data between different classes.
 */
namespace QBuilder
{
    public static class DataControl
    {
        public static string HostData { get; set; }
        public static string BaseData { get; set; }
        public static string UserData { get; set; }
        public static ArrayList QueryData { get; set; }
        public static List<string> DbMetaData { get; set; }
    }
}
