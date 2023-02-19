using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class jsons
    {
        public string rec_name { get; set; }
        public string rec_desc { get; set; }
        public string rec_date { get; set; }
        public void Serialize(List<jsons> jsons)
        {
            string json = JsonConvert.SerializeObject(jsons);
            File.AppendAllText("C:\\Users\\миша\\Desktop\\Records.json", json);
            string text = File.ReadAllText("C:\\Users\\миша\\Desktop\\Records.json");
        }
    }
}
