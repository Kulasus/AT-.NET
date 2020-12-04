using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using TestATNET_KON0355.Models;

namespace TestATNET_KON0355.Services
{
    public class JsonService
    {
        public void SaveToJson(FormModel form)
        {
            string jsonString = JsonSerializer.Serialize(form);
            using (StreamWriter sw = new StreamWriter("data.json", true))
            {
                sw.WriteLine(jsonString);
            }
        }

        public List<FormModel> LoadFromJson()
        {
            List<FormModel> result = new List<FormModel>();
            using (StreamReader sr = new StreamReader("data.json"))
            {
                string line;
                while ((line = sr.ReadLine())!=null)
                {
                    result.Add(JsonSerializer.Deserialize<FormModel>(line));
                }

            }
            return result;
        }
    }
}
