using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace eBaySearchApplication
{

    public class Tabs
    {
        public static List<Tab> TabList = new List<Tab>();


        [Serializable()]
        public class Tab
        {
            public string Name { get; set; }
            public int Index { get; set; }
            public string DisplayName { get; set; }

            public bool ExcludeKeywords { get; set; }
            public bool ExcludeSellers { get; set; }
            public bool ExcludeFromAutoSearch { get; set; }

            public override string ToString()
            {
                return this.DisplayName;
            }
        }


        public static void SaveTabs()
        {
         

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(Application.StartupPath + @"\tabs.bin", FileMode.OpenOrCreate);
            bf.Serialize(fs,TabList);
            fs.Close();


        }

        public static List<Tab> LoadTabList()
        {

            string file = Application.StartupPath + @"\tabs.bin";
            if (!File.Exists(file))
                return null;

            List<Tab> tabs = new List<Tab>();

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(file, FileMode.Open);
            tabs = (List<Tab>) bf.Deserialize(fs);
            fs.Close();

            TabList = tabs;

            //tabs.OrderBy<Tabs.Tab, 

            return tabs;

        }

    }


   
}
