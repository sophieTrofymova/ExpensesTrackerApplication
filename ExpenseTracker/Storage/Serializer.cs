using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Storage
{
    public static class Serializer
    {
        public static void SaveData<DataType>(DataType instance, string filename)
        {
            File.WriteAllText(filename, JsonConvert.SerializeObject(instance, Formatting.Indented));
        }
        public static DataType? LoadData<DataType>(string filename)
        {
            if (File.Exists(filename))
            {
                var jsonContent = File.ReadAllText(filename);
                return JsonConvert.DeserializeObject<DataType>(jsonContent);
            }
            return default;
        }
    }
}