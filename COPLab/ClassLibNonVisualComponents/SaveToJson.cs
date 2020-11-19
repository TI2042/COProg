using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibNonVisualComponents
{
    public partial class SaveToJson : Component
    {
        public SaveToJson()
        {
            InitializeComponent();
        }

        public SaveToJson(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Save<T>(List<T> obj, string fullPath)
        {
            if (typeof(T).GetCustomAttributes(typeof(Newtonsoft.Json.JsonObjectAttribute), true).Length > 0)
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

                using (StreamWriter fs = new StreamWriter($"{fullPath}/save/{typeof(T).Name}.json"))
                {
                    fs.Write(json);
                }

                ZipFile.CreateFromDirectory($"{fullPath}/save", $"{fullPath}/{typeof(T).Name}Save.zip");
            }
            else
            {
                throw new Exception("Object not have attribute");
            }
        }
    }
}
