using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEmber
{
    public class JsonReader
    {
        private string _jsonString { get; set; } = string.Empty;
        public JsonReader(string jsonString) 
        {
            _jsonString = jsonString;
        }
        public Dictionary<string, string> GetDeserializeJson() 
        {
            Dictionary<string, string> keyValue = new Dictionary<string, string>();
            bool isWrite = false;
            List<string> strings = new List<string>();
            string currentWord = "";
            for (int i = 0; i < _jsonString.Length; i++) 
            {
                
                if (_jsonString[i] == '"') 
                {
                    if (isWrite) 
                    {
                        isWrite = false;
                        strings.Add(currentWord);
                        currentWord = "";
                        continue;
                    }
                    isWrite = true;
                    continue;
                }
                if (isWrite == true) 
                {
                    currentWord += _jsonString[i];
                }
            }
            for(int i = 0; i < strings.Count - 1; i += 2) {
                keyValue.Add(strings[i], strings[i + 1]);
            }
            return keyValue;

        }
    }
}
